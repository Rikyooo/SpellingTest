using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellingTest
{
    public partial class TestForm : Form
    {
        PresentationModel _presentationModel;
        Menu _menu;
        PublicControls _publicControls;
        CustomizationControls _customizationControls;
        FillInBlankModeControls _fillInBlankModeControls;
        MultipleChoiceModeControls _multipleChoiceModeControls;
        private const int FIRST_DEFAULT_QUESTION_NUMBER = 10;
        private const int SECOND_DEFAULT_QUESTION_NUMBER = 20;
        private const int THIRD_DEFAULT_QUESTION_NUMBER = 50;
        private const int ALL_FILL_THE_BLANK_QUESTIONS_INDEX = 0;
        private const int ALL_MULTIPLE_CHOICE_QUESTIONS_INDEX = 1;
        private const int PICK_UP_QUESTION_RANDOMLY_INDEX = 2;
        private const int FILL_THE_BLANK_MODE = 1;
        private const int MULTIPLE_CHOICE_MODE = 2;
        private const int FIRST_OPTION = 1;
        private const int SECOND_OPTION = 2;
        private const int THIRD_OPTION = 3;
        private const int FOURTH_OPTION = 4;
        private int _vocabularyNumber = 0;
        private const string ABOUT_DICTIONARY = "Total {0} words in the dictionary.";

        public TestForm(PresentationModel presentationModel)
        {
            InitializeComponent();
            _presentationModel = presentationModel;
            _vocabularyNumber = _presentationModel.CreateDictionary();
            _presentationModel._testCompleted += EndTest;

        }

        //refer to controls created in presentation model
        void ConnectControlsReference()
        {
            _menu = _presentationModel.GetMenu();
            _publicControls = _presentationModel.GetPublicControls();
            _customizationControls = _presentationModel.GetCustomizationControls();
            _fillInBlankModeControls = _presentationModel.GetFillInInBlankModeControls();
            _multipleChoiceModeControls = _presentationModel.GetMultipleChoiceModeControls();
        }

        //refresh user controls
        void RefreshUserControls()
        {
            //refresh customization controls' property
            _numberOfQuestionBox.Value = FIRST_DEFAULT_QUESTION_NUMBER;
            _questionTypeBox.SelectedIndex = 0;
            //refresh public controls' property
            _startButton.Enabled = _publicControls.IsStartButtonEnabled();
            _nextButton.Enabled = _publicControls.IsNextButtonEnabled();
            _stopButton.Enabled = _publicControls.IsStopButtonEnabled();
            _elapsedTimeLabel.Text = _publicControls.GetElapsedTime();
        }

        //refresh tested controls
        void RefreshTestControls()
        {
            //refresh FillInBlankMode controls' property
            _inputEnglish.Enabled = _fillInBlankModeControls.IsEnglishInputBoxEnabled();
            _outputChinese.Text = _fillInBlankModeControls.GetOutputChineseText();
            _inputEnglish.Text = _fillInBlankModeControls.GetInputEnglishText();
            //refresh MultipleChoiceMode controls' property
            _outputEnglish.Text = _multipleChoiceModeControls.GetOutputEnglishText();
            _firstOption.Checked = _multipleChoiceModeControls.IsOptionChecked(FIRST_OPTION);
            _firstOption.Text = _multipleChoiceModeControls.GetOption(FIRST_OPTION);
            _secondOption.Checked = _multipleChoiceModeControls.IsOptionChecked(SECOND_OPTION);
            _secondOption.Text = _multipleChoiceModeControls.GetOption(SECOND_OPTION);
            _thirdOption.Checked = _multipleChoiceModeControls.IsOptionChecked(THIRD_OPTION);
            _thirdOption.Text = _multipleChoiceModeControls.GetOption(THIRD_OPTION);
            _fourthOption.Checked = _multipleChoiceModeControls.IsOptionChecked(FOURTH_OPTION);
            _fourthOption.Text = _multipleChoiceModeControls.GetOption(FOURTH_OPTION);
        }

        //refresh UI
        void RefreshUserInterface()
        {
            //refresh Menu's property
            _startMenuItem.Enabled = _menu.IsStartMenuItemEnabled();
            _nextMenuItem.Enabled = _menu.IsNextMenuItemEnabled();
            _stopMenuItem.Enabled = _menu.IsStopMenuItemEnabled();
            _numberOfQuestionsMenuItem.Enabled = _menu.IsNumberOfQuestionsMenuItemEnabled();
            _questionTypeMenuItem.Enabled = _menu.IsQuestionTypeMenuItemEnabled();
            //Refresh form layout
            Size = new Size(_publicControls.GetFormSizeWidth(),_publicControls.GetFormSizeHeight());
            _customizationLayout.Visible = _customizationControls.IsCustomizationLayoutVisible();
            _fillTheBlankLayout.Visible = _fillInBlankModeControls.IsFillTheBlankLayoutVisible();
            _multipleChoiceLayout.Visible = _multipleChoiceModeControls.IsMultipleChoiceLayoutVisible();
            _testWindow.Text = _publicControls.GetTestWindowTitle();
        }

        //click exit button
        private void ClickExitMenuItem(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        //click Start button or start menu item
        private void ClickStartButton(object sender, EventArgs e)
        {
            _timerForQuestion.Start();
            _scoreLabel.Text = "Score: 0";
            ConnectControlsReference();
            _customizationControls.SetQuestionNumber((int)_numberOfQuestionBox.Value);
            _customizationControls.SetTestMode(_questionTypeBox.Text);
            _presentationModel.StartTest();
            RefreshUserControls();
            RefreshTestControls();
            RefreshUserInterface(); 
        }

        //click Next button or next menu item
        private void ClickNextButton(object sender, EventArgs e)
        {
            _deadlineProgressBar.Value = 0;
            _publicControls.SetTickTimes(0);
            _statusDisplay.Text = _presentationModel.GetResults(_inputEnglish.Text, new bool[]{_firstOption.Checked, _secondOption.Checked, _thirdOption.Checked, _fourthOption.Checked});
            _presentationModel.ClickNextButton();
            RefreshUserControls();
            RefreshTestControls();
            RefreshUserInterface();
        }

        //click Stop button or stop menu item
        private void ClickStopButton(object sender, EventArgs e)
        {
            _deadlineProgressBar.Value = 0;
            _statusDisplay.Text = _presentationModel.GetResults(_inputEnglish.Text, new bool[] { _firstOption.Checked, _secondOption.Checked, _thirdOption.Checked, _fourthOption.Checked });
            _presentationModel.EndTest();
            RefreshUserControls();
            RefreshTestControls();
            RefreshUserInterface();
        }

        //click ten-questions menu item
        private void ClickTenQuestionMenuItem(object sender, EventArgs e)
        {
            _numberOfQuestionBox.Value = FIRST_DEFAULT_QUESTION_NUMBER;
        }

        //click twenty-questions menu item
        private void ClickTwentyQuestionMenuItem(object sender, EventArgs e)
        {
            _numberOfQuestionBox.Value = SECOND_DEFAULT_QUESTION_NUMBER;
        }

        //click fifty-questions menu item
        private void ClickFiftyQuestionMenuItem(object sender, EventArgs e)
        {
            _numberOfQuestionBox.Value = THIRD_DEFAULT_QUESTION_NUMBER;
        }

        //refresh question type menu
        private void RefreshQuestionTypeMenu(bool[] isChecked)
        {
            _allFillInTheBlankMenuItem.Checked = isChecked[ALL_FILL_THE_BLANK_QUESTIONS_INDEX];
            _allMultipleChoiceMenuItem.Checked = isChecked[ALL_MULTIPLE_CHOICE_QUESTIONS_INDEX];
            _pickUpRandomlyMenuItem.Checked = isChecked[PICK_UP_QUESTION_RANDOMLY_INDEX];
            _allFillInTheBlankMenuItem.Enabled = !isChecked[ALL_FILL_THE_BLANK_QUESTIONS_INDEX];
            _allMultipleChoiceMenuItem.Enabled = !isChecked[ALL_MULTIPLE_CHOICE_QUESTIONS_INDEX];
            _pickUpRandomlyMenuItem.Enabled = !isChecked[PICK_UP_QUESTION_RANDOMLY_INDEX];
        }

        //click all fill in blank questions menu item
        private void ClickAllFillInBlankQuestionsMenuItem(object sender, EventArgs e)
        {
            _questionTypeBox.SelectedIndex = ALL_FILL_THE_BLANK_QUESTIONS_INDEX;
            RefreshQuestionTypeMenu(new bool[] { true, false, false });
        }

        //click all multiple-choice questions menu item
        private void ClickAllMultipleChoiceQuestionsMenuItem(object sender, EventArgs e)
        {
            _questionTypeBox.SelectedIndex = ALL_MULTIPLE_CHOICE_QUESTIONS_INDEX;
            RefreshQuestionTypeMenu(new bool[] { false, true, false });
        }

        //click pick up question randomly menu item
        private void ClickPickUpQuestionRandomlyMenuItem(object sender, EventArgs e)
        {
            _questionTypeBox.SelectedIndex = PICK_UP_QUESTION_RANDOMLY_INDEX;
            RefreshQuestionTypeMenu(new bool[] { false, false, true });
        }

        //click about dictionary menu item
        private void ClickAboutDictionaryMenuItem(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(ABOUT_DICTIONARY, _vocabularyNumber), "Dictionary");
        }

        //click about spelling checker menu item
        private void ClickAboutSpellingCheckerMenuItem(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        //timer ticking
        private void TickTimerForQuestion(object sender, EventArgs e)
        {
            _deadlineProgressBar.Increment(1);
            _publicControls.UpdateElapsedTime();
            _elapsedTimeLabel.Text = _publicControls.GetElapsedTime();
            _deadlineProgressBar.Value = _publicControls.SetProgressBarValue(_deadlineProgressBar.Value);
        }

        //response to observer
        private void EndTest()
        {
            _scoreLabel.Text = "Score: " + Math.Round(_presentationModel.GetScore(), MidpointRounding.ToEven).ToString();
            _publicControls.SetUrgedTimes(0);
            _timerForQuestion.Stop();
            _publicControls.SetTickTimes(0);
            IncorrectQuestionShowForm incorrectQuestionShowForm = new IncorrectQuestionShowForm(_presentationModel);
            incorrectQuestionShowForm.ShowDialog();
            _publicControls.SetElapsedTime(0, 0, 0);
            _elapsedTimeLabel.Text = _publicControls.GetElapsedTime();
            _scoreLabel.Text = "Score: 0";
            _statusDisplay.Text = "";
        }
    }
}
