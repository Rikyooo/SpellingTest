using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace SpellingTestUITests
{
    /// <summary>
    /// TestFormUITest 的摘要说明
    /// </summary>
    [CodedUITest]
    public class TestFormUITest
    {
        const string FILE_PATH = @"..\..\..\SpellingTest\bin\Debug\SpellingTest.exe";
        private const string CHECKER_TITLE = "Spelling Checker 1000 words";

        /// <summary>
        /// Launches the Checker
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, CHECKER_TITLE);
        }

        /// <summary>
        /// Closes the launched program
        /// </summary>
        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        //test button
        [TestMethod]
        public void TestButton()
        {
            Robot.SetNumericUpDown("NumberOfQuestion", "1");
            Robot.AssertNumericUpDown("NumberOfQuestion", "1");
            Robot.SetComboBox("QuestionType", "All fill in the blank questions");
            Robot.AssertComboBox("QuestionType", "All fill in the blank questions");
            Robot.ClickButton("StartButton");
            Robot.AssertText("Score", "Score: 0");
            Robot.AssertEditEnable("EnglishInputBox", true);
            Robot.AssertButtonEnable("StartButton", false);
            Robot.AssertMenuItemEnable("Start", false);
            Robot.AssertButtonEnable("NextButton", true);
            Robot.AssertMenuItemEnable("Next", true);
            Robot.AssertButtonEnable("StopButton", true);
            Robot.AssertMenuItemEnable("Stop", true);
            Robot.AssertMenuItemEnable("Number of Questions", false);
            Robot.AssertMenuItemEnable("Question Type", false);
            Robot.SetEdit("EnglishInputBox", "English");
            Robot.AssertEdit("EnglishInputBox", "English");
            Robot.ClickButton("NextButton");
            Robot.AssertWindowExist("Incorrect Questions", true);
            Robot.CloseWindowWithoutButton("Incorrect Questions");
            Robot.SetNumericUpDown("NumberOfQuestion", "1");
            Robot.SetComboBox("QuestionType", "All multiple-choice questions");
            Robot.AssertComboBox("QuestionType", "All multiple-choice questions");
            Robot.ClickButton("StartButton");
            Robot.ClickRadioButton("FirstOption");
            Robot.AssertRadioButtonChecked("FirstOption", true);
            Robot.AssertRadioButtonChecked("SecondOption", false);
            Robot.AssertRadioButtonChecked("ThirdOption", false);
            Robot.AssertRadioButtonChecked("FourthOption", false);
            Robot.ClickButton("StopButton");
            Robot.AssertWindowExist("Incorrect Questions", true);
            Robot.CloseWindowWithoutButton("Incorrect Questions");
        }

        //test menu item
        [TestMethod]
        public void TestMenuItem()
        {
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "Pick up questions randomly" });
            Robot.AssertMenuItemEnable("Pick up questions randomly", false);
            Robot.AssertComboBox("QuestionType", "Pick up questions randomly");
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "All fill in the blank questions" });
            Robot.AssertMenuItemEnable("Pick up questions randomly", true);
            Robot.AssertComboBox("QuestionType", "All fill in the blank questions");
            Robot.SetNumericUpDown("NumberOfQuestion", "1");
            Robot.ClickMenuItem(new string[] { "Examination", "Start" });
            Robot.AssertText("Score", "Score: 0");
            Robot.AssertEditEnable("EnglishInputBox", true);
            Robot.AssertButtonEnable("StartButton", false);
            Robot.AssertMenuItemEnable("Start", false);
            Robot.AssertButtonEnable("NextButton", true);
            Robot.AssertMenuItemEnable("Next", true);
            Robot.AssertButtonEnable("StopButton", true);
            Robot.AssertMenuItemEnable("Stop", true);
            Robot.AssertMenuItemEnable("Number of Questions", false);
            Robot.AssertMenuItemEnable("Question Type", false);
            Robot.SetEdit("EnglishInputBox", "English");
            Robot.AssertEdit("EnglishInputBox", "English");
            Robot.ClickMenuItem(new string[] { "Examination", "Next" });
            Robot.AssertWindowExist("Incorrect Questions", true);
            Robot.CloseWindowWithoutButton("Incorrect Questions");
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "All multiple-choice questions" });
            Robot.AssertComboBox("QuestionType", "All multiple-choice questions");
            Robot.ClickMenuItem(new string[] { "Examination", "Number Of Questions", "10 Questions" });
            Robot.AssertText("Score", "Score: 0");
            Robot.AssertEditEnable("EnglishInputBox", true);
            Robot.AssertButtonEnable("StartButton", false);
            Robot.AssertMenuItemEnable("Start", false);
            Robot.AssertButtonEnable("NextButton", true);
            Robot.AssertMenuItemEnable("Next", true);
            Robot.AssertButtonEnable("StopButton", true);
            Robot.AssertMenuItemEnable("Stop", true);
            Robot.AssertMenuItemEnable("Number of Questions", false);
            Robot.AssertMenuItemEnable("Question Type", false);
            Robot.ClickButton("StartButton");
            Robot.ClickRadioButton("FirstOption");
            Robot.AssertRadioButtonChecked("FirstOption", true);
            Robot.AssertRadioButtonChecked("SecondOption", false);
            Robot.AssertRadioButtonChecked("ThirdOption", false);
            Robot.AssertRadioButtonChecked("FourthOption", false);
            Robot.ClickMenuItem(new string[] { "Examination", "Stop" });
            Robot.AssertWindowExist("Incorrect Questions", true);
            Robot.CloseWindowWithoutButton("Incorrect Questions");
            Robot.ClickMenuItem(new string[] { "Examination", "Number Of Questions", "20 Questions" });
            Robot.AssertText("Score", "Score: 0");
            Robot.ClickMenuItem(new string[] { "Examination", "Stop" });
            Robot.AssertWindowExist("Incorrect Questions", true);
            Robot.CloseWindowWithoutButton("Incorrect Questions");
            Robot.ClickMenuItem(new string[] { "Examination", "Number Of Questions", "50 Questions" });
            Robot.AssertText("Score", "Score: 0");
            Robot.ClickMenuItem(new string[] { "Examination", "Stop" });
            Robot.AssertWindowExist("Incorrect Questions", true);
            Robot.CloseWindowWithoutButton("Incorrect Questions");

        }

        //test about dictionary
        [TestMethod]
        public void TestAbout()
        {
            Robot.ClickMenuItem(new string[] { "Help", "About Dictionary" });
            Robot.AssertWindowExist("Dictionary", true);
            Robot.SendKeyEnterToMessageBox("Dictionary");
        }

        //test exit
        [TestMethod]
        public void TestExit()
        {
            Robot.ClickMenuItem(new string[] { "File", "Exit" });
            Robot.AssertWindowExist(CHECKER_TITLE, false);
        }
    }
}
