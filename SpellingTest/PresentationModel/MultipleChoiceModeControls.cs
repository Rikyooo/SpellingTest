using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingTest
{
    public class MultipleChoiceModeControls
    {
        private bool _isMultipleChoiceLayoutVisible = false;
        private string _outputEnglishBoxText = "";
        private const int OPTION_NUMBER = 4;
        private bool[] _isOptionChecked = new bool[OPTION_NUMBER] { false, false, false, false };
        private const int FIRST_OPTION = 1;
        private const int SECOND_OPTION = 2;
        private const int THIRD_OPTION = 3;
        private const int FOURTH_OPTION = 4;
        private string[] _optionList = new string[OPTION_NUMBER];

        //set multiple choice layout
        public void SetMultipleChoiceLayout(bool isVisible)
        {
            _isMultipleChoiceLayoutVisible = isVisible;
        }

        //if multiple choice layout visible
        public bool IsMultipleChoiceLayoutVisible()
        {
            return _isMultipleChoiceLayoutVisible;
        }

        //set englishOutput box's text
        public void SetOutputEnglishText(string englishText)
        {
            _outputEnglishBoxText = englishText;
        }

        //get englishOutput box's text
        public string GetOutputEnglishText()
        {
            return _outputEnglishBoxText;
        }

        //set option list
        public void SetOptionList(string[] optionList)
        {
            _optionList = optionList;
        }

        //get option list
        public string GetOption(int optionOrdinalNumber)
        {
            return _optionList[optionOrdinalNumber - 1];
        }

        //set status of options
        public void SetOptionStatus(bool[] isOptionChecked)
        {
            _isOptionChecked = isOptionChecked;
        }

        //if the option checked
        public bool IsOptionChecked(int optionOrdinalNumber)
        {
            return _isOptionChecked[optionOrdinalNumber - 1];
        }
    }
}
