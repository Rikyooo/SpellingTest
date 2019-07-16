using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingTest
{
    public class PresentationModel
    {
        public delegate void ModelChangedEventHandler();
        public event ModelChangedEventHandler _testCompleted;
        Model _model;
        Menu _menu = new Menu();
        PublicControls _publicControls = new PublicControls();
        CustomizationControls _customizationControls = new CustomizationControls();
        FillInBlankModeControls _fillInBlankModeControls = new FillInBlankModeControls();
        MultipleChoiceModeControls _multipleChoiceModeControls = new MultipleChoiceModeControls();
        const int DEFAULT_FORM_SIZE_WIDTH = 325;
        const int DEFAULT_FORM_SIZE_HEIGHT = 245;
        const int FILL_FORM_SIZE_WIDTH = 390;
        const int FILL_FORM_SIZE_HEIGHT = 245;
        const int CHOICE_FORM_SIZE_WIDTH = 340;
        const int CHOICE_FORM_SIZE_HEIGHT = 335;
        const int FILL_THE_BLANK_MODE = 1;
        const int MULTIPLE_CHOICE_MODE = 2;
        private int _questionType = 0;
        private const int OPTION_NUMBER = 4;
        private int _clickTime = 0;
        private int _questionNumber = 1;
        private int _testMode = 0;
        private const int ALL_FILL_IN_THE_BLANK_QUESTIONS = 1;
        private const int ALL_MULTIPLE_CHOICE_QUESTIONS = 2;
        private const int PICK_UP_QUESTIONS_RANDOMLY = 3;
        private const string ERROR = "Error!";
        protected bool[] _userControlDefault = new bool[] { false, false, false, false, true, true, true, true };
        protected bool[] _userControlsOnStart = new bool[] { true, true, true, true, false, false, false, false };

        public PresentationModel(Model model)
        {
            _model = model;
        }

        //get model
        public Model GetModel()
        {
            return _model;
        }

        //get menu's property
        public Menu GetMenu()
        {
            return _menu;
        }

        //get public controls' property
        public PublicControls GetPublicControls()
        {
            return _publicControls;
        }

        //get customization controls' property
        public CustomizationControls GetCustomizationControls()
        {
            return _customizationControls;
        }

        //get FillInBlankMode controls' property
        public FillInBlankModeControls GetFillInInBlankModeControls()
        {
            return _fillInBlankModeControls;
        }

        //get MultipleChoiceMode controls' property
        public MultipleChoiceModeControls GetMultipleChoiceModeControls()
        {
            return _multipleChoiceModeControls;
        }

        //create dictionary
        public int CreateDictionary()
        {
            _model.CreateDictionary();
            return _model.GetVocabularyNumber();
        }

        //verify the answer in fill in the blank mode
        public string GetResults(string inputText, bool[] isOptionChecked)
        {
            if (_questionType == FILL_THE_BLANK_MODE)
                return _model.GetResultsInFillMode(inputText);
            else if (_questionType == MULTIPLE_CHOICE_MODE)
            {
                _multipleChoiceModeControls.SetOptionStatus(isOptionChecked);
                return _model.GetResultsInChoiceMode(isOptionChecked);
            }
            else
                return ERROR;
        }

        //set test mode
        void SetTestMode()
        {
            if (_testMode == ALL_FILL_IN_THE_BLANK_QUESTIONS)
            {
                _questionType = FILL_THE_BLANK_MODE;
                _model.SetQuestionType(FILL_THE_BLANK_MODE);
            }
            else if (_testMode == ALL_MULTIPLE_CHOICE_QUESTIONS)
            {
                _questionType = MULTIPLE_CHOICE_MODE;
                _model.SetQuestionType(MULTIPLE_CHOICE_MODE);
            }
            else if (_testMode == PICK_UP_QUESTIONS_RANDOMLY)
            {
                _model.SelectQuestionType();
                _questionType = _model.GetQuestionType();
            }
        }

        //testing process
        void RunTestProcess()
        {
            SetTestMode();
            _model.SelectWord();
            if (_questionType == FILL_THE_BLANK_MODE) //go into a fill the blank type question
            {
                _publicControls.SetFormSize(FILL_FORM_SIZE_WIDTH, FILL_FORM_SIZE_HEIGHT);
                _multipleChoiceModeControls.SetMultipleChoiceLayout(false);
                _fillInBlankModeControls.SetFillTheBlankLayout(true);
                _fillInBlankModeControls.SetOutputChineseText(_model.GetOutputText());
            }
            else if (_questionType == MULTIPLE_CHOICE_MODE) //go into amultiple choice type question
            {
                _publicControls.SetFormSize(CHOICE_FORM_SIZE_WIDTH, CHOICE_FORM_SIZE_HEIGHT);
                _fillInBlankModeControls.SetFillTheBlankLayout(false);
                _multipleChoiceModeControls.SetMultipleChoiceLayout(true);
                _multipleChoiceModeControls.SetOutputEnglishText(_model.GetOutputText());
                _multipleChoiceModeControls.SetOptionList(_model.GetOptionList());
            }
        }

        //Start the test
        public void StartTest()
        {
            _clickTime = 1;
            _model.CopyDictionary();
            _questionNumber = _customizationControls.GetQuestionNumber();
            _testMode = _customizationControls.GetTestMode();
            _fillInBlankModeControls.SetEnglishInputBox(true);
            SetUserControls(_userControlsOnStart);//set controls to start status
            _customizationControls.SetCustomizationLayout(false);
            RunTestProcess();
            _publicControls.SetTestWindowTitle(_questionType, _clickTime);
        }

        //run next question
        public void RunNextQuestion()
        {
            _clickTime++;
            _fillInBlankModeControls.SetInputEnglishText("");
            _multipleChoiceModeControls.SetOptionStatus(new bool[OPTION_NUMBER] { false, false, false, false });//reset the radio button list
            RunTestProcess();
            _publicControls.SetTestWindowTitle(_questionType, _clickTime);
        }

        //set user controls
        void SetUserControls(bool[] userControls)
        {
            _publicControls.SetNextButton(userControls[0]);
            _menu.SetNextMenuItem(userControls[1]);
            _publicControls.SetStopButton(userControls[2]);
            _menu.SetStopMenuItem(userControls[3]);
            _publicControls.SetStartButton(userControls[4]);
            _menu.SetStartMenuItem(userControls[5]);
            _menu.SetNumberOfQuestionsMenuItem(userControls[6]);
            _menu.SetQuestionTypeMenuItem(userControls[7]);
        }

        //exit the test
        public void EndTest()
        {
            _fillInBlankModeControls.SetOutputChineseText("");
            _fillInBlankModeControls.SetInputEnglishText("");
            _multipleChoiceModeControls.SetOptionStatus(new bool[OPTION_NUMBER] { false, false, false, false });//reset the radio button list
            _publicControls.SetFormSize(DEFAULT_FORM_SIZE_WIDTH, DEFAULT_FORM_SIZE_HEIGHT);
            _publicControls.SetTestWindowTitle(0, 0);
            _multipleChoiceModeControls.SetMultipleChoiceLayout(false);
            _fillInBlankModeControls.SetFillTheBlankLayout(false);
            _customizationControls.SetCustomizationLayout(true);
            SetUserControls(_userControlDefault); //set controls to default
            NotifyObserver();
            _model.ClearTheResult();
        }

        //Get score
        public double GetScore()
        {
            return _model.GetScore(_clickTime, _publicControls.GetUrgedTimes());
        }

        //click the next button
        public void ClickNextButton()
        {
            if (_clickTime + 1 <= _questionNumber)
                RunNextQuestion();
            else
                EndTest();
        }

        //notify observer
        void NotifyObserver()
        {
            if (_testCompleted != null)
                _testCompleted();
        }

        //get click times
        public int GetClickTimes()
        {
            return _clickTime;
        }
    }
}