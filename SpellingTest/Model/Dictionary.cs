using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace SpellingTest
{
    public class Dictionary
    {
        //new a list for dictionary
        private List<string> _vocabulary = new List<string>();
        //new a list for copy
        private List<string> _vocabularyCopy = new List<string>();
        //new a hash table for random number
        private Hashtable _hashForRandomNumber = new Hashtable();
        //new a random number
        private Random _createRandomNumber = new Random();
        private int _randomNumber;
        //the random line geted from dictionary
        private string _randomLine;
        //the english and chinese geted from dictionary
        private string _englishText;
        private string _chineseText;
        private const char DELIMITER = '>';

        //Read the dictionary
        public void FileReader(string path)
        {
            StreamReader dictionary = new StreamReader(@path, System.Text.Encoding.Default);//Read .txt file
            //read the file line by line
            while (dictionary.Peek() >= 0)
            {
                _vocabulary.Add(dictionary.ReadLine());
            }
        }

        //Copy the dictionary
        public void CopyDictionary()
        {
            _vocabularyCopy.Clear();
            _vocabulary.ForEach(i => _vocabularyCopy.Add(i));
        }

        //Read a line for test
        public string GetLine(int number)
        {
            return _vocabulary[number - 1];
        }

        //Set randomLine for test
        public void SetRandomLine(int number)
        {
            _randomLine = _vocabulary[number - 1];
        }

        //Read a random line
        public void ReadRandomLine()
        {
            _randomNumber = _createRandomNumber.Next(_vocabularyCopy.Count - 1);
            _randomLine = _vocabularyCopy[_randomNumber];
            _vocabularyCopy[_randomNumber] = _vocabularyCopy[_vocabularyCopy.Count - 1];
            _vocabularyCopy.RemoveAt(_vocabularyCopy.Count - 1);
        }

        //Get randomLine for test
        public string GetRandomLine()
        {
            return _randomLine;
        }

        //seperarate englsih and chinese
        public void StringSeparator()
        {
            string[] words;
            words = _randomLine.Split(DELIMITER);
            _englishText = words[0].Trim();
            _chineseText = words[words.Count() - 1].Trim();//The 4th part is chinese
        }

        //set english text for test
        public void SetEnglishText(string englishText)
        {
            _englishText = englishText;
        }

        //get english text
        public string GetEnglishText()
        {
            return _englishText;
        }

        //get chinese text
        public string GetChineseText()
        {
            return _chineseText;
        }

        //get vocabulary number
        public int GetVocabularyNumber()
        {
            return _vocabulary.Count;
        }
    }
}
