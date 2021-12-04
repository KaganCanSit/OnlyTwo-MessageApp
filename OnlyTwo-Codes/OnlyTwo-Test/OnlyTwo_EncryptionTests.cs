using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlyTwo;

namespace OnlyTwo_Test
{
    [TestClass]
    public class OnlyTwo_EncryptionTests
    {
        //Convert To StringReplace
        void ReplaceSender(string testValue, string resultValue)
        {
            EncryptionClass EC = new EncryptionClass();
            string result = EC.StringReplace(testValue);
            Assert.AreEqual(result, resultValue);
        }
        [TestMethod]
        public void Replace_Test1()
        {
            ReplaceSender("Kağan Can Şit","Kagan Can Sit");
        }
        [TestMethod]
        public void Replace_Test2()
        {
            ReplaceSender("Her hayatın birbirinden farkı olmaksızın değerli olduğunu düşündünüz mü? Düşünün. Bir ressamın hayal dünyasında kuramadığını küçük bir çocuk sanki bir film izlercesine kafasında inşa edebilir. Bir askerin kararlı ve soğuk kanlı planlamasını sevdiklerini kaybetmiş her insan hayatında gösterebilir. Kimi zaman zorluklarla, kimi zaman sevdikleriyle beraber bir insan nice büyük farklılıklar yaratabilir.", "Her hayatin birbirinden farki olmaksizin degerli oldugunu dusundunuz mu? Dusunun. Bir ressamin hayal dunyasinda kuramadigini kucuk bir cocuk sanki bir film izlercesine kafasinda insa edebilir. Bir askerin kararli ve soguk kanli planlamasini sevdiklerini kaybetmis her insan hayatinda gosterebilir. Kimi zaman zorluklarla, kimi zaman sevdikleriyle beraber bir insan nice buyuk farkliliklar yaratabilir.");
        }
        [TestMethod]
        public void Replace_Test3()
        {
            ReplaceSender("Gün doğuyor şehrin üzerine", "Gun doguyor sehrin uzerine");
        }


        //SHA256 TestCase
        void SHA256Sender(string testValue, string resultValue)
        {
            EncryptionClass EC = new EncryptionClass();
            string result = EC.SHA256(EC.StringReplace(testValue));
            Assert.AreEqual(result, resultValue);
        }
        [TestMethod]
        public void SHA256_Test1()
        {
            SHA256Sender("kagancansit","1D9E45A05B7896009EB3377CA135419CCB4E45C7A0125F05A92098E789980819");
        }
        [TestMethod]
        public void SHA256_Test2()
        {
            SHA256Sender("Mustafa Kemal Atatürk","91E280C89FAF300C707918C3777D389F4DA1E64C1153C7CF15D7E9320E1B5B2A");
        }
        [TestMethod]
        public void SHA256_Test3()
        {
            SHA256Sender("Hi!I am Junior Software Developer","4576E9E469481B20C160562A77949AC60411C3330F7D679C535E0C3CB528F9FF");
        }


        //SPN16 TestCase
        void SPN16Sender(string testvalue, string keygen, string resultValue)
        {
            EncryptionClass EC = new EncryptionClass();
            string result= EC.SPN16(EC.StringReplace(testvalue), EC.StringReplace(keygen));
            Assert.AreEqual(result, resultValue);
        }
        [TestMethod]
        public void SPN16_Test1()
        {
            SPN16Sender("Mustafa Kemal ATATÜRK", "kagancan","100100001001000100010000101010010001000100110011001010100000000110000000000000010000000100010000000010100011000010100010100001001000000110110101100000101011110000100101");
        }
        [TestMethod]
        public void SPN16_Test2()
        {
            SPN16Sender("kagancasb", "kagancan","000000000000000000000000000000000000000000000000001000001010000100001001");
        }
        [TestMethod]
        public void SPN16_Test3()
        {
            SPN16Sender("Servet ve onun doğal sonucu olan rahat yaşamak ve mutluluk, yalnız ve ancak çalışanların hakkıdır. Yaşamak demek, çalışmak demektir.", "çalışmak","100000000000100100110011101110010011000010111000001000001110001100011000001100000000001000110011000100100011000000100010011000110001001100000001000100010010001100100010110110110001000100110001000100100001100000101001001010100001000100101000000000000010000100000010111100100001000100100010001000001011100000000010110000100000001010010000000100010000001100000010000110010010000011100011000110000011000000100000100000110001000000110010000100100010100100110010000110000010100001100000001000010001000100010001001000110010001110110000001100111110000100111000001110010000000000100001000000000000000000111000001100100010000000001001000100110000001000000000000010000000000000110001001000101011100100000001001000010010000001110010000100110000001000000001000010010001001000000010001010100010101100010001110001000010001010011001000000100000000100100010000100000011000101100001000100000001100000010000000000000001100101110010001100010001001000010001000110110000001000011001001000100001000000110001011000010001000000011000000100000000000000110000000110100001101100111001");
        }

        //SPN16 SolveTestCase
        void SPN16SolveSender(string testvalue, string keygen, string resultValue)
        {
            EncryptionClass EC = new EncryptionClass();
            string result = EC.SPN16Solve(EC.StringReplace(testvalue), EC.StringReplace(keygen));
            Assert.AreEqual(result, resultValue);
        }
        [TestMethod]
        public void SPN16Solve_Test1()
        {
            SPN16SolveSender("100100001001000100010000101010010001000100110011001010100000000110000000000000010000000100010000000010100011000010100010100001001000000110110101100000101011110000100101", "kagancan","Mustafa Kemal ATATURK");
        }
        [TestMethod]
        public void SPN16Solve_Test2()
        {
            SPN16SolveSender("000000000000000000000000000000000000000000000000001000001010000100001001", "kagancan","kagancasb");
        }
        [TestMethod]
        public void SPN16Solve_Test3()
        {
            SPN16SolveSender("100000000000100100110011101110010011000010111000001000001110001100011000001100000000001000110011000100100011000000100010011000110001001100000001000100010010001100100010110110110001000100110001000100100001100000101001001010100001000100101000000000000010000100000010111100100001000100100010001000001011100000000010110000100000001010010000000100010000001100000010000110010010000011100011000110000011000000100000100000110001000000110010000100100010100100110010000110000010100001100000001000010001000100010001001000110010001110110000001100111110000100111000001110010000000000100001000000000000000000111000001100100010000000001001000100110000001000000000000010000000000000110001001000101011100100000001001000010010000001110010000100110000001000000001000010010001001000000010001010100010101100010001110001000010001010011001000000100000000100100010000100000011000101100001000100000001100000010000000000000001100101110010001100010001001000010001000110110000001000011001001000100001000000110001011000010001000000011000000100000000000000110000000110100001101100111001", "çalışmak","Servet ve onun dogal sonucu olan rahat yasamak ve mutluluk, yalniz ve ancak calisanlarin hakkidir. Yasamak demek, calismak demektir.");
        }


        //Convert String Test
        void ConvertStringSender(string testvalue, string resultValue)
        {
            EncryptionClass EC = new EncryptionClass();
            string result = EC.ConvertString(testvalue);
            Assert.AreEqual(result, resultValue);
        }
        [TestMethod]
        public void ConvertString_Test1()
        {
            ConvertStringSender("010010000110100100100001001000000100110101111001001000000110111001100001011011010110010100100000011010010111001100100000010010110110000101100111011000010110111000101110", "Hi! My name is Kagan.");
        }
        [TestMethod]
        public void ConvertString_Test2()
        {
            ConvertStringSender("0101001101100101011001010010000001111001011011110111010100101110", "See you.");
        }
        [TestMethod]
        public void ConvertString_Test3()
        {
            ConvertStringSender("0100111101101110011011000111100101010100011101110110111101010100011001010111001101110100", "OnlyTwoTest");
        }

        //Convert Binary Test
        void ConvertBinarySender(string testValue, string resultValue)
        {
            EncryptionClass EC = new EncryptionClass();
            string result = EC.Key(testValue);
            Assert.AreEqual(result, resultValue);
        }
        [TestMethod]
        public void ConvertBinary_Test1()
        {
            ConvertBinarySender("Binary","010000100110100101101110011000010111001001111001");
        }
        [TestMethod]
        public void ConvertBinary_Test2()
        {
            ConvertBinarySender("Junior Software Developer", "01001010011101010110111001101001011011110111001000100000010100110110111101100110011101000111011101100001011100100110010100100000010001000110010101110110011001010110110001101111011100000110010101110010");
        }
        [TestMethod]
        public void ConvertBinary_Test3()
        {
            ConvertBinarySender("MCBU", "01001101010000110100001001010101");
        }
    }
}
