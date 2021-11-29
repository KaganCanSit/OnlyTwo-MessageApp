using System;
using System.Drawing;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace OnlyTwo
{
    public partial class OnlyTwoForm : Form
    {
        //Crypte File Variable
        byte[] abc;
        byte[,] table;

        //InterNetwork = IPV4 Protocol -- SocketType.Dgram= UDP Protocol -- SocketType.Stream= TCP Protocol -- ProtocolType.IP = TCP ve UDP
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public OnlyTwoForm()
        {
            InitializeComponent();
        }

        //Encryption Operations 
        EncryptionClass EncryptionOp = new EncryptionClass();

        
        //Basic Form Operations

        string temptext;
        //Find The Keywords In The Main Text
        private void FindButton_Click(object sender, EventArgs e)
        {
            if (FindTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Search Value In The 'Find Keyword Search'");
                return;
            }
            else
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
        }

        //Restore Previous Text Click
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            DialogResult Result;
            Result = MessageBox.Show("Do you want to restore the message?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result == DialogResult.Yes)
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


        //Keygen Text Box Control
        private void KeygenTBControl()
        {
            if (KeygenTextBox.Text == "" || KeygenTextBox.TextLength != 8)
                MessageBox.Show("Please specify your Password with 8 characters.");
            else if (PlainRichTextBox.TextLength <= 8)
                MessageBox.Show("Text To Be Encrypted Must Be Longer Than 8 Letters!");
        }

        //Encryption Process / Button Click
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (PlainRichTextBox.Text == "")
            {
                MessageBox.Show("File is empty!");
                return;
            }

            KeygenTextBox.Text = EncryptionOp.StringReplace(KeygenTextBox.Text);
            PlainRichTextBox.Text = EncryptionOp.StringReplace(PlainRichTextBox.Text);

            if (PlainRichTextBox.TextLength > 150)
                MessageBox.Show("You've Reached The 150 character Limit! Please Try Again!");
            else
            {
                if (EncryptComboBox.SelectedIndex == 0) //SHA-256
                    CipherTextBox.Text = EncryptionOp.SHA256(PlainRichTextBox.Text);
                else if (EncryptComboBox.SelectedIndex == 1) //SPN-16
                {
                    if (KeygenTextBox.TextLength != 8 || PlainRichTextBox.TextLength < 8)
                        KeygenTBControl();
                    else
                        CipherTextBox.Text = EncryptionOp.SPN16(PlainRichTextBox.Text, KeygenTextBox.Text);
                }
                else
                    MessageBox.Show("Please Check The Encrypt Type");
            }
        }
        //Solve Process / Button Click
        private void SolveButton_Click(object sender, EventArgs e)
        {
            if (PlainRichTextBox.Text == "")
            {
                MessageBox.Show("File is empty!");
                return;
            }

            if (PlainRichTextBox.TextLength > 1200)
                MessageBox.Show("You've Reached The 1200 character Limit! Please Try Again!");
            else
            {
                if (EncryptComboBox.SelectedIndex == 1) //SPN-16
                {
                    if (KeygenTextBox.TextLength != 8 || PlainRichTextBox.TextLength < 8)
                        KeygenTBControl();
                    else if (Convert.ToChar(PlainRichTextBox.Text.Substring(0, 1)) != '0' && Convert.ToChar(PlainRichTextBox.Text.Substring(0, 1)) != '1' || Convert.ToChar(PlainRichTextBox.Text.Substring(PlainRichTextBox.TextLength - 1, 1)) != '0' && Convert.ToChar(PlainRichTextBox.Text.Substring(PlainRichTextBox.TextLength - 1, 1)) != '1')
                        MessageBox.Show("Enter the Binary Text Consisting of 0s and 1s of the Spn-16 Encryption.");
                    else
                        CipherTextBox.Text = EncryptionOp.SPN16Solve(PlainRichTextBox.Text, KeygenTextBox.Text);
                }
                else
                    MessageBox.Show("Please Select Encryption Type Select SPN-16. SHA256 Encryption Undecryptable. Passwords Only.");
            }
        }

        //Socket Programming Operations ------------------------------------------------------------------------------------------------------------------------------------
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
                        if (ben.Equals(gelen)) { }
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
        //Connect Loop Server Try
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

        //Connect Loop Start
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = EncryptionOp.StringReplace(UsernameTextBox.Text);
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
                    byte[] buffer = Encoding.ASCII.GetBytes(tmpStr + " :" + CipherTextBox.Text + "*" + UsernameTextBox.Text);//Byte Translate
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

        //Crypte File Operations -------------------------------------------------------------------------------------------------------------------------------------------
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


        //Zip File Operations -------------------------------------------------------------------------------------------------------------------------------------------
        private void ZipFileButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePathTextBox.Text))
            {
                MessageBox.Show("Please select your filename.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FilePathTextBox.Focus();
                return;
            }
            string fileName = FilePathTextBox.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    FileInfo fi = new FileInfo(fileName);
                    zip.AddFile(fileName);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(fileName);
                    zip.SaveProgress += Zip_SaveFileProgress;
                    zip.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, fi.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
        }
        //Zip File Save Progress And Progress Bar Counter
        private void Zip_SaveFileProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.MaximumValue = 100;
                    progressBar.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar.Update();
                    if (progressBar.Value == 100)
                        MessageBox.Show("Zip Progress Done!");
                }));
            }
        }
    }
}