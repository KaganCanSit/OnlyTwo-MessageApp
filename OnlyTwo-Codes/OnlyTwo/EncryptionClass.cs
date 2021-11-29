using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OnlyTwo
{
    class EncryptionClass
    {
        //SHA256 - Crypting
        public string SHA256(string text)
        {
            StringBuilder sb = new StringBuilder();
            SHA256CryptoServiceProvider SHA256Encrypt = new SHA256CryptoServiceProvider();
            byte[] bt = Encoding.UTF8.GetBytes(text);
            bt = SHA256Encrypt.ComputeHash(bt);
            foreach (byte x in bt)
                sb.Append(x.ToString("X2"));
            return sb.ToString();
        }

        //SPN-16 - Text Crypting
        public string SPN16(string text, string keygen)
        {
            string keycrypto = Key(keygen), alltext = Key(text);    //Add Key Binary    -   8 Bit Text Binary
            alltext = XOROperation(alltext, keycrypto);             //XOR Operation          
            int[] CrossoverArray = { 5, 9, 0, 12, 7, 3, 11, 14, 1, 4, 13, 8, 2, 15, 6, 10 };
            alltext = Crossover(CrossoverArray, alltext);           //Crossover Operation
            return alltext;
        }

        //SPN-16 - Solve
        public string SPN16Solve(string text, string keygen)
        {
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
    }
}
