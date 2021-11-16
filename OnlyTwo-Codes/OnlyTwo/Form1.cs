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

        //SHA256
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
        //SPN-16
        private static string Deneme(string text) 
        {
            if (String.IsNullOrEmpty(text))
                MessageBox.Show("File is empty!");

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];
                MessageBox.Show(text[i].ToString());
            }
            return text.ToString();
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

        //Key Must Be 8 Characters Control
        private void KeygenTextBox_TextChanged(object sender, EventArgs e)
        {
            int PasswordLenght = KeygenTextBox.TextLength;
            if (PasswordLenght == 8)
                MessageBox.Show("You've Reached The 8 Character Limit! Done!");
        }

        //Encryption Process / Buton Click
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (EncryptComboBox.SelectedIndex == 0) //SHA-256
                CipherTextBox.Text = SHA256(PlainRichTextBox.Text);
            else if (EncryptComboBox.SelectedIndex == 1) //SPN-16
            {
                if (KeygenTextBox.TextLength != 8)
                    MessageBox.Show("Please specify your Password with 8 characters.");
                else
                    Deneme(PlainRichTextBox.Text);
            }
            else
            {
                MessageBox.Show("Please Check The Encrypt Type");
            }
        }
    }
}
