using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace OnlyTwo
{
    class EncryptionFile
    {
        //Crypte File Variable
        byte[] abc;
        byte[,] table;

        public string BrowseFile(string FilePath)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                return od.FileName;
            }
            else
                return "";
        }

        public void ExecuteDescryption(string FilePath, string Keygen, Boolean RadioButton)
        {
            abc = new byte[256];
            for (int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                    table[i, j] = abc[(i + j) % 256];

            //Check Input Value
            if (!File.Exists(FilePath))
            {
                MessageBox.Show("File Does Not Exit");
                return;
            }
            if (String.IsNullOrEmpty(Keygen))
            {
                MessageBox.Show("Password Empty! Please Enter Your Password");
                return;
            }

            //Get File Content And Key For Encryption/Decyription
            try
            {
                byte[] fileContent = File.ReadAllBytes(FilePath);
                byte[] passwordTpm = Encoding.ASCII.GetBytes(Keygen);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = passwordTpm[i % passwordTpm.Length];


                byte[] result = new byte[fileContent.Length];
                if (RadioButton)//Encrypt
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
                String fileExt = Path.GetExtension(FilePath);
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
