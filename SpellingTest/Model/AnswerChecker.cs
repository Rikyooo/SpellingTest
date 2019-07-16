using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingTest
{
    public class AnswerChecker
    {
        //the number to count your correct answer
        private int _correctCount = 0;
        private const string CORRECT_MESSAGE = "Correct!!";
        private const string WRONG_MESSAGE = "It should be ";
        private const int FULL_SCORE = 100;
        private double _score = 0;
        private List<string> _incorrectQuestion = new List<string>();
        private const string BLANK = " ";

        //Check if the word inputed correct
        public string GetResultsInFillMode(string inputText, string answer, string questionText)
        {
            if (inputText.Equals(answer))
            {
                _correctCount++;
                return CORRECT_MESSAGE;
            }
            else
            {
                _incorrectQuestion.Add(answer + BLANK + questionText);
                return WRONG_MESSAGE + answer;
            }     
        }

        //verify the answer in the multiple mode
        public string GetResultsInChoiceMode(bool[] isOptionChecked, int correctOptionOrdinalNumber, string questionText, string correctOptionText)
        {
            if (isOptionChecked[correctOptionOrdinalNumber - 1])
            {
                _correctCount++;
                return CORRECT_MESSAGE;
            }
            else
            {
                _incorrectQuestion.Add(questionText + BLANK + correctOptionText);
                return WRONG_MESSAGE + correctOptionText;
            }
        }     

        //get the number of correct answer
        public int GetCorrectNumber()
        {
            return _correctCount;
        }

        //set correct number for test
        public void SetCorrectNumber(int correctNumber)
        {
            _correctCount = correctNumber;
        }

        //reset the number of correct answer
        public void ClearTheResult()
        {
            _correctCount = 0;
        }

        //calculate the score
        public void CalculateScore(int clickTimes, int urgedTimes)
        {
            _score = ((double)_correctCount / (double)clickTimes) * FULL_SCORE - urgedTimes;
            if (_score < 0)
                _score = 0;
        }

        //get the score
        public double GetScore()
        {
            return _score;
        }

        //get incorrect question list
        public List<string> GetIncorrectQuestionList()
        {
            return _incorrectQuestion;
        }

        //clear incorrect question list
        public void ResetIncorrectQuestionList()
        {
            _incorrectQuestion.Clear();
        }
    }
}
