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
    /// AboutFormUITest 的摘要说明
    /// </summary>
    [CodedUITest]
    public class AboutFormUITest
    {
        const string FILE_PATH = @"..\..\..\SpellingTest\bin\Debug\SpellingTest.exe";
        const string START_UP_FORM_NAME = "Spelling Checker 1000 words";
        const string TARGET_FORM_NAME = "Spelling Checker";

        /// <summary>
        /// Launches aboutForm
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, START_UP_FORM_NAME);
            Robot.ClickMenuItem(new string[] { "Help", "About Spelling Checker" });
            Robot.SetForm(TARGET_FORM_NAME);
        }

        /// <summary>
        /// Closes the launched program
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            Robot.CleanUp();
        }

        //test hyperlink
        [TestMethod]
        public void TestHyperlink()
        {
            Robot.ClickHyperlink("SDT Lab");
            Robot.ClickHyperlink("CSIE");
            Robot.ClickHyperlink("NTUT");
            Robot.ClickButton("OK");
        }


    }
}
