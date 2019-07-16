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
    public class FillInBlankModeControlsTests
    {
        FillInBlankModeControls _fillInBlankModeControls = new FillInBlankModeControls();

        //test fill the blank layout setter
        [TestMethod()]
        public void SetFillTheBlankLayoutTest()
        {
            _fillInBlankModeControls.SetFillTheBlankLayout(true);
            Assert.AreEqual(true, _fillInBlankModeControls.IsFillTheBlankLayoutVisible());
            _fillInBlankModeControls.SetFillTheBlankLayout(false);
            Assert.AreEqual(false, _fillInBlankModeControls.IsFillTheBlankLayoutVisible());
        }

        //test english input box setter
        [TestMethod()]
        public void SetEnglishInputBoxTest()
        {
            _fillInBlankModeControls.SetEnglishInputBox(true);
            Assert.AreEqual(true, _fillInBlankModeControls.IsEnglishInputBoxEnabled());
            _fillInBlankModeControls.SetEnglishInputBox(false);
            Assert.AreEqual(false, _fillInBlankModeControls.IsEnglishInputBoxEnabled());
        }

        //test chinese output box setter
        [TestMethod()]
        public void SetOutputChineseTextTest()
        {
            for(int i = 0; i < 10; i++)
            {
                _fillInBlankModeControls.SetOutputChineseText(i.ToString());
                Assert.AreEqual(i.ToString(), _fillInBlankModeControls.GetOutputChineseText());
            } 
        }

        //test input english text setter
        [TestMethod()]
        public void SetInputEnglishTextTest()
        {
            for (int i = 0; i < 10; i++)
            {
                _fillInBlankModeControls.SetInputEnglishText(i.ToString());
                Assert.AreEqual(i.ToString(), _fillInBlankModeControls.GetInputEnglishText());
            }
        }
    }
}