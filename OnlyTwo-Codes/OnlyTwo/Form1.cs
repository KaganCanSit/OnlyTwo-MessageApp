using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace OnlyTwo
{
    public partial class OnlyTwoForm : Form
    {
        public OnlyTwoForm()
        {
            InitializeComponent();
        }
       
        //SPN-16 - Solve
        private static string SPN16Solve(string text, string keygen)
        {
            if (String.IsNullOrEmpty(text))
                MessageBox.Show("File Is Empty!");

            string alltext, keycrypto = Key(keygen);
            int[] CrossoverArray = { 2, 8, 12, 5, 9, 0, 14, 4, 11, 1, 15, 6, 3, 10, 7, 13 };
            alltext = Crossover(CrossoverArray, text);
            alltext = XOROperation(alltext, keycrypto);
            alltext = ConvertString(alltext);
            return alltext;
        }
        //Spn16-Solve - Input Convert To String
        private static String ConvertString(string text)
        {
            List<byte> stringList = new List<byte>();

            for (int i = 0; i < text.Length; i += 8)
            {
                stringList.Add(Convert.ToByte(text.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(stringList.ToArray());
        }



        //SPN-16 - Text Crypting
        private static string SPN16(string text, string keygen)
        {
            if (String.IsNullOrEmpty(text))
                MessageBox.Show("File Is Empty!");
           
            string keycrypto = Key(keygen), alltext = Key(text);    //Add Key Binary    -   8 Bit Text Binary
            alltext = XOROperation(alltext, keycrypto);             //XOR Operation          
            int[] CrossoverArray = { 5, 9, 0, 12, 7, 3, 11, 14, 1, 4, 13, 8, 2, 15, 6, 10 };
            alltext = Crossover(CrossoverArray, alltext);           //Crossover Operation
            return alltext;
        }
        //SPN-16 Input Convert To Binary
        private static String Key(string text)
        {
            string temp, keycrypto = "";
            for (int a = 0; a < text.Length; a++)
            {
                temp = Convert.ToString(text[a], 2).PadLeft(8, '0');
                keycrypto += temp;
            }
            return keycrypto;
        }
        //SPN-16 XOR Operation
        private static String XOROperation(string alltext, string keycrypto)
        {
            int keygencounter = 0;
            for (int a = 0; a < alltext.Length; a++)
            {
                if (keygencounter == keycrypto.Length)   //Segmentation By Key length
                    keygencounter = 0;

                if (alltext[a] == '0' && keycrypto[keygencounter] == '0' || alltext[a] == '1' && keycrypto[keygencounter] == '1')       //(0 - 0->0 / 0 - 1->1 / 1 - 0->1 / 1 - 1->1)
                    alltext = alltext.Remove(a, 1).Insert(a, "0");
                else if (alltext[a] == '0' && keycrypto[keygencounter] == '1' || alltext[a] == '1' && keycrypto[keygencounter] == '0')
                    alltext = alltext.Remove(a, 1).Insert(a, "1");

                keygencounter++;
            }
            return alltext;
        }
        //SPN-16 Crossover Operation
        private static String Crossover(int[] CrossoverArray, string alltext)
        {
            string alltextEnd = alltext;
            int CrossoverCounter = 0, arraypoint = 0, counter = 0;
            int remaining = alltext.Length % 16;

            for (int j = 0; j < alltext.Length - remaining; j++)
            {
                if (j != 0 && CrossoverCounter % 16 == 0)
                {
                    CrossoverCounter = 0;
                    counter += 16;
                }

                arraypoint = CrossoverArray[CrossoverCounter];
                alltextEnd = alltextEnd.Remove(counter + arraypoint, 1).Insert(counter + arraypoint, Convert.ToString(alltext[j]));
                CrossoverCounter++;
            }
            return alltextEnd;
        }
        //SHA256 - Crypting
        private static string SHA256(string text)
        {
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrEmpty(text))
                MessageBox.Show("File is empty!");
            else
            {
                SHA256CryptoServiceProvider SHA256Encrypt = new SHA256CryptoServiceProvider();
                byte[] bt = Encoding.UTF8.GetBytes(text);
                bt = SHA256Encrypt.ComputeHash(bt);
                foreach (byte x in bt)
                    sb.Append(x.ToString("X2"));
            }
            return sb.ToString();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        string temptext;
        //Find The Keywords In The Main Text
        private void FindButton_Click(object sender, EventArgs e)
        {        
            temptext = PlainRichTextBox.Text;   //Restore Previous Text

            int index = 0;
            PlainRichTextBox.Text = PlainRichTextBox.Text.ToLower();
            FindTextBox.Text = FindTextBox.Text.ToLower();

            while (index < PlainRichTextBox.Text.LastIndexOf(FindTextBox.Text))
            {
                PlainRichTextBox.Find(FindTextBox.Text, index, PlainRichTextBox.TextLength, RichTextBoxFinds.None);
                PlainRichTextBox.SelectionBackColor = Color.Yellow;
                index = PlainRichTextBox.Text.IndexOf(FindTextBox.Text, index) + 1;
            }
        }

        //Restore Previous Text Click
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("Do you want to restore the message?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(Result == DialogResult.Yes)
                PlainRichTextBox.Text = temptext;
            else
                MessageBox.Show("Operation Cancelled.");
        }

        //Delete The Plain And Cipher Text Box
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("Are you sure all content will be deleted?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result == DialogResult.Yes)
            {
                PlainRichTextBox.Text = "";
                CipherTextBox.Text = "";
                KeygenTextBox.Text = "";
            }
            else
                MessageBox.Show("Operation Cancelled.");
        }

        //Text Counters - Limits Control
        private void PlainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            int PlainTextLenght = PlainRichTextBox.TextLength;
            CounterPlainLabel.Text = "Counter: " + PlainTextLenght.ToString();
        }
        //Key Must Be 8 Characters Control
        private void KeygenTextBox_TextChanged(object sender, EventArgs e)
        {         
            int PasswordLenght = KeygenTextBox.TextLength;
            if (PasswordLenght >= 8)
                MessageBox.Show("You've Reached The 8 Character Limit!");
        }

        //Encryption Process / Button Click
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            KeygenTextBox.Text = StringReplace(KeygenTextBox.Text);
            PlainRichTextBox.Text = StringReplace(PlainRichTextBox.Text);
            
            if(PlainRichTextBox.TextLength > 200)
                MessageBox.Show("You've Reached The 200 character Limit! Please Try Again!");
            else
            {
                if (EncryptComboBox.SelectedIndex == 0) //SHA-256
                    CipherTextBox.Text = SHA256(PlainRichTextBox.Text);
                else if (EncryptComboBox.SelectedIndex == 1) //SPN-16
                {
                    if (KeygenTextBox.TextLength != 8 || PlainRichTextBox.TextLength < 8)
                        MessageBox.Show("Please specify your Password with 8 characters.\nText To Be Encrypted Must Be Longer Than 8 Letters!");
                    else
                        CipherTextBox.Text = SPN16(PlainRichTextBox.Text, KeygenTextBox.Text);
                }
                else
                    MessageBox.Show("Please Check The Encrypt Type");
            }          
        }
        //Solve Process / Button Click
        private void SolveButton_Click(object sender, EventArgs e)
        {
            if(PlainRichTextBox.TextLength > 1600)
                MessageBox.Show("You've Reached The 1200 character Limit! Please Try Again!");
            else
            {
                if (EncryptComboBox.SelectedIndex == 1) //SPN-16
                {
                    if (KeygenTextBox.TextLength != 8 || PlainRichTextBox.TextLength < 8)
                        MessageBox.Show("Please specify your Password with 8 characters.\n Text To Be Encrypted Must Be Longer Than 8 Letters!");
                    else
                        CipherTextBox.Text = SPN16Solve(PlainRichTextBox.Text, KeygenTextBox.Text);
                }
                else
                    MessageBox.Show("Please Select Encryption Type Select SPN-16. SHA256 Encryption Undecryptable. Passwords Only.");
            }       
        }

        //Turkisch Convert Englisch
        public string StringReplace(string text)
        {
            text = text.Replace("İ", "I");
            text = text.Replace("ı", "i");
            text = text.Replace("Ğ", "G");
            text = text.Replace("ğ", "g");
            text = text.Replace("Ö", "O");
            text = text.Replace("ö", "o");
            text = text.Replace("Ü", "U");
            text = text.Replace("ü", "u");
            text = text.Replace("Ş", "S");
            text = text.Replace("ş", "s");
            text = text.Replace("Ç", "C");
            text = text.Replace("ç", "c");
            return text;
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------
        private void OnlyTwoForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;//dinamik nesne eklemek için listeye
        }

        //Send Operation
        private void SendFlatButton_Click(object sender, EventArgs e)
        {
            if (_clientSocket.Connected)//client servera bağlı ise
            {
                string tmpStr = "";
                foreach (var item in UsersListBox.SelectedItems)//listboxtaki seçili itemlere
                {
                    tmpStr = UsersListBox.GetItemText(item);
                    byte[] buffer = Encoding.ASCII.GetBytes(tmpStr +" :" + CipherTextBox.Text + "*" + UsernameTextBox.Text);//byte çevir
                    _clientSocket.Send(buffer);//ve gönder ip ve porta
                    Thread.Sleep(20);//yapmasanda olur(fakat 4 cliente bırden mesaj gonderınce dıgerlerine gıtmeyebılir)
                }
                if (tmpStr.Equals(""))
                    MessageBox.Show("Please Click The Send Username");
                else
                    PlainRichTextBox.AppendText(CipherTextBox.Text);
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(LoopConnect);
            t1.Start();
        }

        private void LoopConnect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)//server çalışmıyorsa(çalışısaya kadar döngü döner)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect("127.0.0.1", 100);//127.0.0.1=IPAddress.Loopback demek 100 portuna bağlan
                }
                catch (SocketException)
                {
                    Console.WriteLine("Links: " + attempts.ToString());
                }
            }
            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);//AsyncCallback thread gibi asenkron eş zamansız çalışıyor
            byte[] buffer = Encoding.ASCII.GetBytes("@@" + UsernameTextBox.Text);//ismimizin başına 2 tane @@ koydum belli olsun
            _clientSocket.Send(buffer);//veriyi gönderdim servera
            ServerInfoLabel.Text = ("Connected To The Server!");//servere bağlandı
        }

        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //InterNetwork = ipv4 ailesi için -- SocketType.Dgram= UDP için -- SocketType.Stream= TCP için -- ProtocolType.IP = TCP ve UDP

        byte[] receivedBuf = new byte[1024];//veri almak için yer ayırdık
        private void ReceiveData(IAsyncResult ar)//burası asenkron oldugu için hep çalışır thread gibi veriyi almak için
        {
            int listede_yok = 0;//yok
            try
            {
                Socket socket = (Socket)ar.AsyncState;//asenkron soketi alırız
                int received = socket.EndReceive(ar);//verinin toplam uzunlugu
                byte[] dataBuf = new byte[received];//verıyı byte cevırdık
                Array.Copy(receivedBuf, dataBuf, received);//dataBuf=receivedBuf ve received uzunluk
                string gelen = Encoding.ASCII.GetString(dataBuf).ToString();//serverdan gelen mesaj
                if (gelen.Contains("sil*"))
                {
                    string parcala = gelen.Substring(4, (gelen.Length - 4));
                    Console.WriteLine("degerim  " + parcala);
                    for (int j = 0; j < UsersListBox.Items.Count; j++)//list boxtanda kaldır
                    {
                        if (UsersListBox.Items[j].Equals(parcala))
                            UsersListBox.Items.RemoveAt(j);
                    }
                }
                else if (gelen.Contains("@"))//içerisinde @ içeriyorsa clienti listeye eklicez
                {
                    for (int i = 0; i < UsersListBox.Items.Count; i++)//listedeki itemler kadar dön
                    {
                        if (UsersListBox.Items[i].ToString().Equals(gelen))//listede varsa o client
                            listede_yok = 1;//var
                    }
                    if (listede_yok == 0)//yoksa  ekle clienti
                    {
                        string ben = "@" + UsernameTextBox.Text;
                        if (ben.Equals(gelen))//kendimi ekleme
                        {
                        }
                        else
                            UsersListBox.Items.Add(gelen);
                    }
                }
                else
                    PlainRichTextBox.AppendText(gelen + "\n");

                _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine("ReceiveData() Error In Method" + e.Message);
            }
        }
    }
}