using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace SpellingTest
{
    public class Model
    {
        Dictionary _dictionary = new Dictionary();
        AnswerChecker _answerChecker = new AnswerChecker();

        private const string PATH = "..\\..\\Vocabulary.txt";
        private const int LENGTH_LIMITED = 2;
        private int _letterNumber = 0;
        private const char APOSTROPHE = '\'';
        private const char DOT = '.';
        private const char EMPTY_LINE = ' ';
        private const string UNDERLINE = "___";
        private const char OPEN_PAREN = '(';
        private const char CLOSE_PAREN = ')';
        //new a random number
        private Random _createRandomNumber = new Random();
        //store the mode currently
        private int _questionType;
        //two kinds of question
        private const int FILL_THE_BLANK_MODE = 1;
        private const int MULTIPLE_CHOICE_MODE = 2;
        //new a string array for 4 options
        private string[] _optionList = new string[OPTION_NUMBER];
        private int _randomNumberForOptions;
        //There are 4 option for each title
        private const int OPTION_NUMBER = 4;
        private const int FIRST_OPTION = 1;
        private const int SECOND_OPTION = 2;
        private const int THIRD_OPTION = 3;
        private const int FOURTH_OPTION = 4;
        private int _correctOptionOrdinalNumber;
        private string _questionText;
        private string _correctOptionText;

        //create a dictionary
        public void CreateDictionary()
        {
            _dictionary.FileReader(PATH);
        }

        //get vocabulary number
        public int GetVocabularyNumber()
        {
            return _dictionary.GetVocabularyNumber();
        }

        //copy dictionary
        public void CopyDictionary()
        {
            _dictionary.CopyDictionary();
        }

        //get a word and its Chinese meaning
        public void SelectWord()
        {
            _dictionary.ReadRandomLine();
            _dictionary.StringSeparator();
        }

        //select a question type randomly
        public void SelectQuestionType()
        {
            _questionType = _createRandomNumber.Next(FILL_THE_BLANK_MODE, MULTIPLE_CHOICE_MODE + 1);//[1,3)
        }

        //set question type
        public void SetQuestionType(int questionType)
        {
            _questionType = questionType;
        }

        //get question type currently
        public int GetQuestionType()
        {
            return _questionType;
        }

        //Show chinese meaning
        public string GetChineseInFillMode()
        {
            string englishText = _dictionary.GetEnglishText();
            string chineseText = _dictionary.GetChineseText();
            _questionText = chineseText;
            _letterNumber = 0;
            for (int i = 0; i < englishText.Length; i++)
            {
                if (englishText[i] == APOSTROPHE || englishText[i] == EMPTY_LINE || englishText[i] == DOT)
                    continue;
                _letterNumber++;
            }
            if (englishText.Length > LENGTH_LIMITED)
                //format:chinese first letter___last letter （letter's number）
                return chineseText + EMPTY_LINE + englishText[0] + UNDERLINE + englishText[englishText.Length - 1] + EMPTY_LINE + OPEN_PAREN + _letterNumber + CLOSE_PAREN;
            else
                return chineseText + OPEN_PAREN + _letterNumber + CLOSE_PAREN;
        }

        //output the english in multiple choice mode
        public string GetEnglishInChoiceMode()
        {
            return _dictionary.GetEnglishText();
        }

        //transmit option array
        public string[] GetOptionList()
        {
            int[] optionOrdinalNumber = new int[] { FIRST_OPTION, SECOND_OPTION, THIRD_OPTION, FOURTH_OPTION };
            for (int i = 0; i < OPTION_NUMBER; i++)
            {
                _randomNumberForOptions = _createRandomNumber.Next(OPTION_NUMBER - i);
                _optionList[optionOrdinalNumber[_randomNumberForOptions] - 1] = _dictionary.GetChineseText();
                optionOrdinalNumber[_randomNumberForOptions] = optionOrdinalNumber[OPTION_NUMBER - i - 1];
                if (i == 0)
                {
                    _correctOptionOrdinalNumber = _randomNumberForOptions + 1; //record the correct option's serial number
                    _correctOptionText = _dictionary.GetChineseText();
                    _questionText = _dictionary.GetEnglishText();
                }
                if (i == OPTION_NUMBER - 1)
                    break; //we don't need to read a new random line if the option list has been created
                SelectWord();
            }
            return _optionList;
        }

        //transmit the output text contents
        public string GetOutputText()
        {
            if (_questionType == FILL_THE_BLANK_MODE)
                return GetChineseInFillMode();
            else
                return GetEnglishInChoiceMode();
        }

        //set question text
        public void SetQuestionText(string questionText)
        {
            _questionText = questionText;
        }

        //get results in fill the blank mode
        public string GetResultsInFillMode(string inputText)
        {
            return _answerChecker.GetResultsInFillMode(inputText, _dictionary.GetEnglishText(), _questionText);
        }

        //set correct option ordinal number
        public void SetCorrectOptionOrdinalNumber(int number)
        {
            _correctOptionOrdinalNumber = number;
        }

        //set correct option text
        public void SetCorrectOptionText(string text)
        {
            _correctOptionText = text;
        }

        //get results in multiple choice mode
        public string GetResultsInChoiceMode(bool[] isOptionChecked)
        {
            return _answerChecker.GetResultsInChoiceMode(isOptionChecked, _correctOptionOrdinalNumber, _questionText, _correctOptionText);
        }

        //Notice the grade
        public void ClearTheResult()
        {
            //MessageBox.Show(string.Format(RESULT_NOTICE, _answerChecker.GetCorrectNumber(), clickTimes));
            _answerChecker.ClearTheResult();
        }

        //Get score
        public double GetScore(int clickTimes, int urgedTimes)
        {
            _answerChecker.CalculateScore(clickTimes, urgedTimes);
            return _answerChecker.GetScore();
        }

        //get incorrect question list
        public List<string> GetIncorrectQuestionList()
        {
            return _answerChecker.GetIncorrectQuestionList();
        }

        //clear incorrect question list
        public void ResetIncorrectQuestionList()
        {
            _answerChecker.ResetIncorrectQuestionList();
        }

        //get correct number
        public int GetCorrectNumber()
        {
            return _answerChecker.GetCorrectNumber();
        }

        //get dictionary for test
        public Dictionary GetDictionary()
        {
            return _dictionary;
        }

        //get answer checker for test
        public AnswerChecker GetAnswerChecker()
        {
            return _answerChecker;
        }
    }
}
