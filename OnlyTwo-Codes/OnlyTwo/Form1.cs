using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace OnlyTwo
{
    public partial class OnlyTwoForm : Form
    {
        //Crypte File Variable
        byte[] abc;
        byte[,] table;

        //InterNetwork = ipv4 ailesi için -- SocketType.Dgram= UDP için -- SocketType.Stream= TCP için -- ProtocolType.IP = TCP ve UDP
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public OnlyTwoForm()
        {
            InitializeComponent();
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

        //Text Counters
        private void PlainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            int PlainTextLenght = PlainRichTextBox.TextLength;
            CounterPlainLabel.Text = "Counter: " + PlainTextLenght.ToString();
        }
        private void CipherTextBox_TextChanged(object sender, EventArgs e)
        {
            int CipherTextBoxLenght = CipherTextBox.TextLength;
            CounterCipherLabel.Text = "Counter: " + CipherTextBoxLenght.ToString();
        }

        //Encryption Process / Button Click
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            KeygenTextBox.Text = StringReplace(KeygenTextBox.Text);
            PlainRichTextBox.Text = StringReplace(PlainRichTextBox.Text);
            
            if(PlainRichTextBox.TextLength > 150)
                MessageBox.Show("You've Reached The 150 character Limit! Please Try Again!");
            else
            {
                if (EncryptComboBox.SelectedIndex == 0) //SHA-256
                    CipherTextBox.Text = SHA256(PlainRichTextBox.Text);
                else if (EncryptComboBox.SelectedIndex == 1) //SPN-16
                {
                    if (KeygenTextBox.TextLength != 8 || PlainRichTextBox.TextLength < 8 || PlainRichTextBox.TextLength > 150)
                    {
                        if (KeygenTextBox.Text == "" || KeygenTextBox.TextLength != 8)
                            MessageBox.Show("Please specify your Password with 8 characters.");
                        else if (PlainRichTextBox.TextLength <= 8)
                            MessageBox.Show("Text To Be Encrypted Must Be Longer Than 8 Letters!");
                        else
                            MessageBox.Show("Text Not Longer 150 Chracter");
                    }
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
            if(PlainRichTextBox.TextLength > 1200)
                MessageBox.Show("You've Reached The 1200 character Limit! Please Try Again!");
            else
            {
                if (EncryptComboBox.SelectedIndex == 1) //SPN-16
                {
                    if (KeygenTextBox.TextLength != 8 || PlainRichTextBox.TextLength < 8)
                    {
                        if (KeygenTextBox.Text == "" || KeygenTextBox.TextLength != 8)
                            MessageBox.Show("Please specify your Password with 8 characters.");
                        else if(PlainRichTextBox.TextLength <= 8)
                            MessageBox.Show("Text To Be Encrypted Must Be Longer Than 8 Letters!");
                    }
                    else
                        CipherTextBox.Text = SPN16Solve(PlainRichTextBox.Text, KeygenTextBox.Text);
                }
                else
                    MessageBox.Show("Please Select Encryption Type Select SPN-16. SHA256 Encryption Undecryptable. Passwords Only.");
            }       
        }

        //Turkisch Char Convert English Char
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


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        byte[] receivedBuf = new byte[1024];
        private void ReceiveData(IAsyncResult ar)//Asenkron
        {
            int listede_yok = 0;
            try
            {
                Socket socket = (Socket)ar.AsyncState;//Asenkron Get Socket
                int received = socket.EndReceive(ar);//Data Lenght
                byte[] dataBuf = new byte[received];//Translate Byte
                Array.Copy(receivedBuf, dataBuf, received);//dataBuf=receivedBuf
                string gelen = Encoding.ASCII.GetString(dataBuf).ToString();//Message From Server
                if (gelen.Contains("sil*"))
                {
                    string parcala = gelen.Substring(4, (gelen.Length - 4));
                    Console.WriteLine("degerim " + parcala);
                    for (int j = 0; j < UsersListBox.Items.Count; j++)//Remove From List Box
                    {
                        if (UsersListBox.Items[j].Equals(parcala))
                            UsersListBox.Items.RemoveAt(j);
                    }
                }
                else if (gelen.Contains("@"))//If It Contains @, We Will Add The Client To The List
                {
                    for (int i = 0; i < UsersListBox.Items.Count; i++)
                    {
                        if (UsersListBox.Items[i].ToString().Equals(gelen))
                            listede_yok = 1;
                    }
                    if (listede_yok == 0)
                    {
                        string ben = "@" + UsernameTextBox.Text;
                        if (ben.Equals(gelen)){}
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

        private void LoopConnect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)//Server Not Work - Try Loop
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect("127.0.0.1", 100);//127.0.0.1=IPAddress.Loopback - Connect 100 Port Num.
                }
                catch (SocketException)
                {
                    Console.WriteLine("Links: " + attempts.ToString());
                }
            }
            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);//AsyncCallback
            byte[] buffer = Encoding.ASCII.GetBytes("@@" + UsernameTextBox.Text);
            _clientSocket.Send(buffer);//Send The Server
            ServerInfoLabel.Text = ("Connected To The Server!");
        }
        
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = StringReplace(UsernameTextBox.Text);
            Thread t1 = new Thread(LoopConnect);
            t1.Start();
        }

        //Send Operation
        private void SendFlatButton_Click(object sender, EventArgs e)
        {
            if (_clientSocket.Connected)
            {
                string tmpStr = "";
                foreach (var item in UsersListBox.SelectedItems)//Listbox Selected Item
                {
                    tmpStr = UsersListBox.GetItemText(item);
                    byte[] buffer = Encoding.ASCII.GetBytes(tmpStr +" :" + CipherTextBox.Text + "*" + UsernameTextBox.Text);//Byte Translate
                    _clientSocket.Send(buffer);//Send IP+Port > Socket
                    Thread.Sleep(20);
                }
                if (tmpStr.Equals(""))
                    MessageBox.Show("Please Click The Send Username");
                else
                    PlainRichTextBox.AppendText(UsernameTextBox.Text + ": " + CipherTextBox.Text + "\n");                        
            }
        }


        //Form Load Operation
        private void OnlyTwoForm_Load(object sender, EventArgs e)
        {
            UsernameTextBox.MaxLength = 20;
            KeygenTextBox.MaxLength = 8;
            FindTextBox.MaxLength = 20;
            PlainRichTextBox.MaxLength = 1200;
            CipherTextBox.MaxLength = 1200;
            CheckForIllegalCrossThreadCalls = false;//Add Dynamic Object To List

            EnRadioButton.Checked = true;
            //Init abc and table
            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                    table[i, j] = abc[(i + j) % 256];
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
                FilePathTextBox.Text = od.FileName;
        }

        private void EnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (EnRadioButton.Checked)
                DeRadioButton.Checked = false;
        }
        private void DeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DeRadioButton.Checked)
                EnRadioButton.Checked = false;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            //Check Input Value
            if (!File.Exists(FilePathTextBox.Text))
            {
                MessageBox.Show("File Does Not Exit");
                return;
            }
            if (String.IsNullOrEmpty(KeygenTextBox.Text))
            {
                MessageBox.Show("Password Empty! Please Enter Your Password");
                return;
            }

            //Get File Content And Key For Encryption/Decyription
            try
            {
                byte[] fileContent = File.ReadAllBytes(FilePathTextBox.Text);
                byte[] passwordTpm = Encoding.ASCII.GetBytes(KeygenTextBox.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = passwordTpm[i % passwordTpm.Length];

                
                byte[] result = new byte[fileContent.Length];
                if (EnRadioButton.Checked)//Encrypt
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i], key = keys[i];
                        int ValueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == value)
                            {
                                ValueIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        result[i] = table[keyIndex, ValueIndex];
                    }
                }
                else//Decrypt
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i], key = keys[i];
                        int ValueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                        {
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        }
                        for (int j = 0; j < 256; j++)
                        {
                            if (table[keyIndex, j] == value)
                            {
                                ValueIndex = j;
                                break;
                            }
                        }
                        result[i] = abc[ValueIndex];
                    }
                }

                //Save Resule To New File With The Same Extention
                String fileExt = Path.GetExtension(FilePathTextBox.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
                if (sd.ShowDialog() == DialogResult.OK)
                    File.WriteAllBytes(sd.FileName, result);
            }
            catch
            {
                MessageBox.Show("File Is In Use. Close Other Program Is Using This File And Try Again.");
                return;
            }
        }
    }
}