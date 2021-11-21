using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace server
{

    public partial class ServerForm : Form
    {

        private byte[] _buffer = new byte[5120];//Data Size
        public List<SocketT2h> __ClientSockets { get; set; }
        List<string> _names = new List<string>();
        private Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public ServerForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            __ClientSockets = new List<SocketT2h>();
        }
        //AsyncCallback
        private void SetupServer()
        {
            InfoLabelUp.Text = "Server Started . . .";
            _serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 100));//127.0.0.1,100 Port Listen
            _serverSocket.Listen(1);//dinliyor

            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null); //Async Callback
            Console.WriteLine("Listen");
        }
        private void AppceptCallback(IAsyncResult ar)
        {
            Console.WriteLine("Here Again");
            Socket socket = _serverSocket.EndAccept(ar);//
            __ClientSockets.Add(new SocketT2h(socket));//SocketT2h Class At The Bottom -> List<SocketT2h> __ClientSockets = new List<SocketT2h>();
            ClintListBox.Items.Add(socket.RemoteEndPoint.ToString());
            Console.WriteLine("Connecting Socket = " + socket.RemoteEndPoint.ToString());
            InfoLabelUp.Text = "Client Connect. . .";
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);//AsyncCallback
            Console.WriteLine("ReceiveCallback Method Work");
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
            Console.WriteLine("AppceptCallback Method Is Recursive");
        }
       static string sonlanan_clien = "";
       
        private void ReceiveCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;//Socket To Return
            if (socket.Connected)
            {
                int received;
                try
                {
                    received = socket.EndReceive(ar);
                }
                catch (Exception)
                {
                    for (int i = 0; i < __ClientSockets.Count; i++)
                    {
                        if (__ClientSockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            sonlanan_clien = __ClientSockets[i]._Name.Substring(1, __ClientSockets[i]._Name.Length - 1);
                            Console.WriteLine("End Client " + sonlanan_clien);
                            __ClientSockets.RemoveAt(i);//Delete Socket List
                            for (int j = 0; j < ClintListBox.Items.Count; j++)//Delete ListBox
                            {
                                if (ClintListBox.Items[j].Equals(sonlanan_clien))
                                    ClintListBox.Items.RemoveAt(j);
                            }
                        }
                    }
                    clientlerden_sil(sonlanan_clien);
                    return;
                }
                if (received != 0)
                {
                    byte[] dataBuf = new byte[received];
                    Array.Copy(_buffer, dataBuf, received);
                    string text = Encoding.ASCII.GetString(dataBuf);
                    Console.WriteLine("Received Message " + text);
                    string reponse = string.Empty;

                    if (text.Contains("@@"))//If There Is @@ In The Text This Client Will Register New
                    {
                        for (int i = 0; i < ClintListBox.Items.Count; i++)
                        {
                            if (socket.RemoteEndPoint.ToString().Equals(__ClientSockets[i]._Socket.RemoteEndPoint.ToString())) //If Already In Listbox
                            {
                                ClintListBox.Items.RemoveAt(i);
                                ClintListBox.Items.Insert(i, text.Substring(1, text.Length - 1));
                                __ClientSockets[i]._Name = text;
                                socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);//BeginReceive=  Begin The Receiving rocess Recursive=ReceiveCallback
                                isimleri_gonder();
                                return;
                            }
                        }
                    }
                    int index = text.IndexOf(" ");
                    string cli = text.Substring(0, index);

                    string mesaj = "";
                    int uzunluk = (text.Length) - (index + 2);
                    index = index + 2;
                    mesaj = text.Substring(index, uzunluk);
                    gonder_gelen_mesaji(cli, text, mesaj);
                    for (int i = 0; i < __ClientSockets.Count; i++)
                    {
                        if (socket.RemoteEndPoint.ToString().Equals(__ClientSockets[i]._Socket.RemoteEndPoint.ToString()))//Socket Name == List Socket Name
                            MessageTextBox.AppendText("\n" + __ClientSockets[i]._Name + ": " + text);//Socket Name Write
                    }
                }
                else
                {
                    for (int i = 0; i < __ClientSockets.Count; i++)
                    {
                        if (__ClientSockets[i]._Socket.RemoteEndPoint.ToString().Equals(socket.RemoteEndPoint.ToString()))
                        {
                            __ClientSockets.RemoveAt(i);
                            Console.WriteLine("Output");
                        }
                    }
                }
            }
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
        }
        public void clientlerden_sil(string sonlanan_client)
        {
            string sil = "Delete*" + sonlanan_clien;
            for (int j = 0; j < __ClientSockets.Count; j++)
            {
                if (__ClientSockets[j]._Socket.Connected)
                {
                        Sendata(__ClientSockets[j]._Socket, sil);
                        Thread.Sleep(20);
                }
            }
        }
        public void gonder_gelen_mesaji(string cli, string text, string mesaj)
        {
            //gelen=@@aa
            //__ClientSockets[i]._Name=@@aa
            string parcc = text.Substring(2, 2);
            Console.WriteLine("I Was Looking For " + parcc);
            cli = "@" + cli;

            Console.WriteLine("Coming_cli = " + cli + "\n cli_name" + __ClientSockets[0]._Name + "\n text :" + text);
            if (cli.Equals(__ClientSockets[0]._Name))
                Console.WriteLine("Done");


            Console.WriteLine("Message " + mesaj);
            int ind__ = (mesaj.IndexOf("*") + 1);
            string parcalanm = mesaj.Substring(ind__, mesaj.Length - ind__);
            string mess = mesaj.Substring(0, (ind__ - 1));
            string gonder_ = parcalanm + ": " + mess;
            Console.WriteLine("Sender " + gonder_);
            try
            {
                for (int j = 0; j < __ClientSockets.Count; j++)
                {
                    if (__ClientSockets[j]._Socket.Connected)
                    {
                        if (__ClientSockets[j]._Name.Equals(cli))//Send The Message (a Client >B Client)
                        {
                            Sendata(__ClientSockets[j]._Socket, gonder_);
                            Thread.Sleep(20);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("gonder_gelen_mesaji() Error " + e.Message);
            }
        }
        void Sendata(Socket socket, string mesajj)//Come Socket And Message
        {
            byte[] data = Encoding.ASCII.GetBytes(mesajj);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);//Send The Socket
            _serverSocket.BeginAccept(new AsyncCallback(AppceptCallback), null);
        }
        private void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;//Dinamic Article
            SetupServer();
        }
        public void isimleri_gonder()
        {
            for (int j = 0; j < __ClientSockets.Count; j++)
            {
                if (__ClientSockets[j]._Socket.Connected)//Connected OK
                {
                    for (int i = 0; i < ClintListBox.Items.Count; i++)
                    {
                        Sendata(__ClientSockets[j]._Socket, ClintListBox.Items[i].ToString());//Client Names Send
                        Thread.Sleep(20);
                    }
                }
            }
        }
    }
    public class SocketT2h
    {
        public Socket _Socket { get; set; }
        public string _Name { get; set; }
        public SocketT2h(Socket socket)
        {
            this._Socket = socket;
        }
    }
}