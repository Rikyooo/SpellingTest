using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpellingTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingTest.Tests
{
    [TestClass()]
    public class DictionaryTests
    {
        private Dictionary _dictionary = new Dictionary();

        //test file reader
        [TestMethod()]
        public void FileReaderTest()
        {
            _dictionary.FileReader("..\\..\\FileReaderTest.txt");
            Assert.AreEqual("1", _dictionary.GetLine(1));
            Assert.AreEqual("22", _dictionary.GetLine(2));
            Assert.AreEqual("333", _dictionary.GetLine(3));
            Assert.AreEqual("4444", _dictionary.GetLine(4));
            Assert.AreEqual(4, _dictionary.GetVocabularyNumber());
        }

        //test random line reader
        [TestMethod()]
        public void ReadRandomLineTest()
        {
            string[] randomline = new string[10];
            _dictionary.FileReader("..\\..\\ReadRandomLineTest.txt");
            _dictionary.CopyDictionary();
            for (int i = 0; i < 10; i++)
            {
                _dictionary.ReadRandomLine();
                randomline[i] = _dictionary.GetRandomLine();
            }
            for (int i = 1; i < 10; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    Assert.AreNotEqual(randomline[j], randomline[i]);
                }
            }
        }

        //test string separator
        [TestMethod()]
        public void StringSeparatorTest()
        {
            _dictionary.FileReader("..\\..\\StringSeparatorTest.txt");
            _dictionary.SetRandomLine(1);
            _dictionary.StringSeparator();
            Assert.AreEqual("english1", _dictionary.GetEnglishText());
            Assert.AreEqual("chinese1", _dictionary.GetChineseText());
            _dictionary.SetRandomLine(2);
            _dictionary.StringSeparator();
            Assert.AreEqual("english2", _dictionary.GetEnglishText());
            Assert.AreEqual("chinese2", _dictionary.GetChineseText());
            _dictionary.SetRandomLine(3);
            _dictionary.StringSeparator();
            Assert.AreEqual("english3", _dictionary.GetEnglishText());
            Assert.AreEqual("chinese3", _dictionary.GetChineseText());
        }
    }
}