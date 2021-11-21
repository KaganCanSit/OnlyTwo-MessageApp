using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

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
            if (PlainTextLenght > 500)
                MessageBox.Show("You've Reached The 500 Character Limit! Done!");
            CounterPlainLabel.Text = "Counter: " + PlainTextLenght.ToString();
        }
        private void CipherTextBox_TextChanged(object sender, EventArgs e)
        {
            int CipherTextLenght = CipherTextBox.TextLength;
            if (CipherTextLenght > 500)
                MessageBox.Show("You've Reached The 500 Character Limit! Done!");
            CounterCipherLabel.Text = "Counter: " + CipherTextLenght.ToString();
        }

        //Key Must Be 8 Characters Control
        private void KeygenTextBox_TextChanged(object sender, EventArgs e)
        {
            int PasswordLenght = KeygenTextBox.TextLength;
            if (PasswordLenght >= 8)
                MessageBox.Show("You've Reached The 8 Character Limit! Done!");            
        }

        //Encryption Process / Button Click
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (EncryptComboBox.SelectedIndex == 0) //SHA-256
                CipherTextBox.Text = SHA256(PlainRichTextBox.Text);
            else if (EncryptComboBox.SelectedIndex == 1) //SPN-16
            {
                if (KeygenTextBox.TextLength != 8 || PlainRichTextBox.TextLength < 8)
                    MessageBox.Show("Please specify your Password with 8 characters.\n Text To Be Encrypted Must Be Longer Than 8 Letters!");
                else
                    CipherTextBox.Text=SPN16(PlainRichTextBox.Text, KeygenTextBox.Text);
            }
            else
                MessageBox.Show("Please Check The Encrypt Type");
        }

        //Solve Process / Button Click
        private void SolveButton_Click(object sender, EventArgs e)
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
}