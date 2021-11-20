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

            //Add Key Binary    -   8 Bit Text Binary
            string keycrypto = Key(keygen), alltext = Key(text);

            //XOR Operation
            int keygencounter=0;
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
            //return alltext;

            //Crossover Operation
            int[] CrossoverArray = { 5, 9, 0, 12, 7, 3, 11, 14, 1, 4, 13, 8, 2, 15, 6, 10 };
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
                alltextEnd = alltextEnd.Remove(counter+arraypoint,1).Insert(counter + arraypoint, Convert.ToString(alltext[j]));
                CrossoverCounter++;
            }

            //while (counter + 15 <= alltext.Length - 1)
            //{
            //    counter++;
            //    alltextEnd = alltextEnd.Insert(counter, Convert.ToString(alltext[counter]));
            //}
            return alltextEnd;
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
    }
}
