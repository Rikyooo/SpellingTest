using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingTest
{
    public class FillInBlankModeControls
    {
        private bool _isFillTheBlankLayoutVisible = false;
        private bool _isEnglishInputBoxEnabled = false;
        private string _inputEnglishBoxText = "";
        private string _outputChineseBoxText = "";

        //set fill the blank layout
        public void SetFillTheBlankLayout(bool isVisible)
        {
            _isFillTheBlankLayoutVisible = isVisible;
        }

        //if fill the blank layout visible
        public bool IsFillTheBlankLayoutVisible()
        {
            return _isFillTheBlankLayoutVisible;
        }

        //set english inputbox
        public void SetEnglishInputBox(bool isEnabled)
        {
            _isEnglishInputBoxEnabled = isEnabled;
        }

        //if english inputbox enabled
        public bool IsEnglishInputBoxEnabled()
        {
            return _isEnglishInputBoxEnabled;
        }

        //set chineseOutput box's text
        public void SetOutputChineseText(string chineseText)
        {
            _outputChineseBoxText = chineseText;
        }

        //get chineseOutput box's text
        public string GetOutputChineseText()
        {
            return _outputChineseBoxText;
        }

        //set englishInput box's text
        public void SetInputEnglishText(string englishText)
        {
            _inputEnglishBoxText = englishText;
        }

        //get englishInput box's text
        public string GetInputEnglishText()
        {
            return _inputEnglishBoxText;
        }
    }
}
