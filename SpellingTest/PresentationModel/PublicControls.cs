using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingTest
{
    public class PublicControls
    {
        const int SIZE_FORMAT = 2;
        private int[] _formSize = new int[SIZE_FORMAT];
        private const int WIDTH = 0;
        private const int HEIGHT = 1;
        private bool _isStartButtonEnabled = true;
        private bool _isNextButtonEnabled = false;
        private bool _isStopButtonEnabled = false;
        private string _testWindowTitle = "";
        const int FILL_THE_BLANK_MODE = 1;
        const int MULTIPLE_CHOICE_MODE = 2;
        const string CUSTOMIZATION_TITLE = "Customize Your Examination";
        const string QUESTION = "Q";
        const string FILL_MODE_TITLE = " : Fill in the Blanks";
        const string CHOICE_MODE_TITLE = " : Multiple Choice Question";
        const string ELAPSED_TIME_LABEL = "{0:D2}:{1:D2}:{2:D2}";
        const int TIME_UNIT = 3;
        const int HOUR = 0;
        const int MINUTE = 1;
        const int SECOND = 2;
        private int[] _elapsedTime = new int[TIME_UNIT] { 0, 0, 0 };
        const int PROGRESS_BAR_MAXIMUM = 10;
        const int URGED_TIME = 10;
        private int _tickTimes = 0;
        private int _urgedTimes = 0;

        //set the form's size
        public void SetFormSize(int width, int height)
        {
            _formSize[WIDTH] = width;
            _formSize[HEIGHT] = height;
        }

        //get the form's size(width)
        public int GetFormSizeWidth()
        {
            return _formSize[WIDTH];
        }

        //get the form's size(height)
        public int GetFormSizeHeight()
        {
            return _formSize[HEIGHT];
        }

        //set start button
        public void SetStartButton(bool isEnabled)
        {
            _isStartButtonEnabled = isEnabled;
        }

        //if start button enabled
        public bool IsStartButtonEnabled()
        {
            return _isStartButtonEnabled;
        }

        //set next button
        public void SetNextButton(bool isEnabled)
        {
            _isNextButtonEnabled = isEnabled;
        }

        //if next button enabled
        public bool IsNextButtonEnabled()
        {
            return _isNextButtonEnabled;
        }

        //set stop button
        public void SetStopButton(bool isEnabled)
        {
            _isStopButtonEnabled = isEnabled;
        }

        //if stop button enabled
        public bool IsStopButtonEnabled()
        {
            return _isStopButtonEnabled;
        }

        //set the test window's text
        public void SetTestWindowTitle(int mode, int clickTime)
        {
            if (mode == FILL_THE_BLANK_MODE)
                _testWindowTitle = QUESTION + clickTime + FILL_MODE_TITLE;
            else if (mode == MULTIPLE_CHOICE_MODE)
                _testWindowTitle = QUESTION + clickTime + CHOICE_MODE_TITLE;
            else
                _testWindowTitle = CUSTOMIZATION_TITLE;
        }

        //get the test window's text
        public string GetTestWindowTitle()
        {
            return _testWindowTitle;
        }

        //set progress bar's value
        public int SetProgressBarValue(int value)
        {
            if (++_tickTimes == URGED_TIME)
            {
                _tickTimes = 0;
                _urgedTimes++;
            }
            if (value == PROGRESS_BAR_MAXIMUM)
                return 0;
            else
                return value;
        }

        //Set tick times
        public void SetTickTimes(int times)
        {
            _tickTimes = times;
        }

        //get tick times for test
        public int GetTickTimes()
        {
            return _tickTimes;
        }

        //Set urging times
        public void SetUrgedTimes(int times)
        {
            _urgedTimes = times;
        }

        //get urging times
        public int GetUrgedTimes()
        {
            return _urgedTimes;
        }

        //reset elapsed time
        public void SetElapsedTime(int hour, int minute, int second)
        {
            _elapsedTime[HOUR] = hour;
            _elapsedTime[MINUTE] = minute;
            _elapsedTime[SECOND] = second;
        }

        //update elapsed time
        public void UpdateElapsedTime()
        {
            const int SIXTY = 60;
            _elapsedTime[SECOND]++;
            if (_elapsedTime[SECOND] == SIXTY)
            {
                _elapsedTime[SECOND] = 0;
                _elapsedTime[MINUTE]++;
                if (_elapsedTime[MINUTE] == SIXTY)
                {
                    _elapsedTime[MINUTE] = 0;
                    _elapsedTime[HOUR]++;
                }
            }
        }

        //get elapsed time
        public string GetElapsedTime()
        {
            return string.Format(ELAPSED_TIME_LABEL, _elapsedTime[HOUR], _elapsedTime[MINUTE], _elapsedTime[SECOND]);
        }
    }
}
