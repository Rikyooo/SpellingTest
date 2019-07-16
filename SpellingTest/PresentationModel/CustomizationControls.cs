using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingTest
{
    public class CustomizationControls
    {
        private bool _isCustomizationLayoutVisible = true;
        private int _questionNumber = 1;
        private const int ALL_FILL_IN_THE_BLANK_QUESTIONS_INTEGER = 1;
        private const int ALL_MULTIPLE_CHOICE_QUESTIONS_INTEGER = 2;
        private const int PICK_UP_QUESTIONS_RANDOMLY_INTEGER = 3;
        private const string ALL_FILL_IN_THE_BLANK_QUESTIONS_STRING = "All fill in the blank questions";
        private const string ALL_MULTIPLE_CHOICE_QUESTIONS_STRING = "All multiple-choice questions";
        private const string PICK_UP_QUESTIONS_RANDOMLY_STRING = "Pick up questions randomly";
        private int _testMode = 1;

        //set customization layout
        public void SetCustomizationLayout(bool isVisible)
        {
            _isCustomizationLayoutVisible = isVisible;
        }

        //if customization layout visible
        public bool IsCustomizationLayoutVisible()
        {
            return _isCustomizationLayoutVisible;
        }

        //set number of question
        public void SetQuestionNumber(int questionNumber)
        {
            _questionNumber = questionNumber;
        }

        //get number of question
        public int GetQuestionNumber()
        {
            return _questionNumber;
        }

        //set test mode
        public void SetTestMode(string testMode)
        {
            if (testMode.Equals(ALL_FILL_IN_THE_BLANK_QUESTIONS_STRING))
                _testMode = ALL_FILL_IN_THE_BLANK_QUESTIONS_INTEGER;
            else if (testMode.Equals(ALL_MULTIPLE_CHOICE_QUESTIONS_STRING))
                _testMode = ALL_MULTIPLE_CHOICE_QUESTIONS_INTEGER;
            else if (testMode.Equals(PICK_UP_QUESTIONS_RANDOMLY_STRING))
                _testMode = PICK_UP_QUESTIONS_RANDOMLY_INTEGER;
        }

        //get test mode
        public int GetTestMode()
        {
            return _testMode;
        }
    }
}
