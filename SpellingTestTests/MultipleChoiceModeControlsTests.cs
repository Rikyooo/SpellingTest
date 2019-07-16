using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpellingTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingTest.Tests
{
    [TestClass()]
    public class MultipleChoiceModeControlsTests
    {
        MultipleChoiceModeControls _multipleChoiceModeControls = new MultipleChoiceModeControls();

        //test multiple choice layout setter
        [TestMethod()]
        public void SetMultipleChoiceLayoutTest()
        {
            _multipleChoiceModeControls.SetMultipleChoiceLayout(true);
            Assert.AreEqual(true, _multipleChoiceModeControls.IsMultipleChoiceLayoutVisible());
            _multipleChoiceModeControls.SetMultipleChoiceLayout(false);
            Assert.AreEqual(false, _multipleChoiceModeControls.IsMultipleChoiceLayoutVisible());
        }

        //test output english text setter
        [TestMethod()]
        public void SetOutputEnglishTextTest()
        {
            for (int i = 0; i < 10; i++)
            {
                _multipleChoiceModeControls.SetOutputEnglishText(i.ToString());
                Assert.AreEqual(i.ToString(), _multipleChoiceModeControls.GetOutputEnglishText());
            }
        }

        //test option list setter
        [TestMethod()]
        public void SetOptionListTest()
        {
            string[] test = new string[4] { "1", "2", "3", "4" };
            _multipleChoiceModeControls.SetOptionList(test);
            Assert.AreEqual("1", _multipleChoiceModeControls.GetOption(1));
            Assert.AreEqual("2", _multipleChoiceModeControls.GetOption(2));
            Assert.AreEqual("3", _multipleChoiceModeControls.GetOption(3));
            Assert.AreEqual("4", _multipleChoiceModeControls.GetOption(4));
        }

        //test option status setter
        [TestMethod()]
        public void SetOptionStatusTest()
        {
            bool[] test = new bool[4] { true, true, true, true };
            _multipleChoiceModeControls.SetOptionStatus(test);
            for(int i = 1; i <= 4; i++)
            {
                Assert.AreEqual(true, _multipleChoiceModeControls.IsOptionChecked(i));
            }  
        }
    }
}