using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingTest
{
    public class Menu
    {
        private bool _isStartMenuItemEnabled = true;
        private bool _isNextMenuItemEnabled = false;
        private bool _isStopMenuItemEnabled = false;
        private bool _isNumberOfQuestionsMenuItemEnabled = true;
        private bool _isQuestionTypeMenuItemEnabled = true;

        //set start menu item
        public void SetStartMenuItem(bool isEnabled)
        {
            _isStartMenuItemEnabled = isEnabled;
        }

        //if start menu item enabled
        public bool IsStartMenuItemEnabled()
        {
            return _isStartMenuItemEnabled;
        }

        //set next menu item
        public void SetNextMenuItem(bool isEnabled)
        {
            _isNextMenuItemEnabled = isEnabled;
        }

        //if next menu item enabled
        public bool IsNextMenuItemEnabled()
        {
            return _isNextMenuItemEnabled;
        }

        //set stop menu item
        public void SetStopMenuItem(bool isEnabled)
        {
            _isStopMenuItemEnabled = isEnabled;
        }

        //if stop menu item enabled
        public bool IsStopMenuItemEnabled()
        {
            return _isStopMenuItemEnabled;
        }

        //set number of questions menu item
        public void SetNumberOfQuestionsMenuItem(bool isEnabled)
        {
            _isNumberOfQuestionsMenuItemEnabled = isEnabled;
        }

        //if number of questions menu item enabled
        public bool IsNumberOfQuestionsMenuItemEnabled()
        {
            return _isNumberOfQuestionsMenuItemEnabled;
        }

        //set question type menu item
        public void SetQuestionTypeMenuItem(bool isEnabled)
        {
            _isQuestionTypeMenuItemEnabled = isEnabled;
        }

        //if question type menu item enabled
        public bool IsQuestionTypeMenuItemEnabled()
        {
            return _isQuestionTypeMenuItemEnabled;
        }
    }
}
