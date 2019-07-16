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
    public class CustomizationControlsTests
    {
        CustomizationControls _customizationControls = new CustomizationControls();

        //test customization layout setter
        [TestMethod()]
        public void SetCustomizationLayoutTest()
        {
            _customizationControls.SetCustomizationLayout(true);
            Assert.AreEqual(true, _customizationControls.IsCustomizationLayoutVisible());
            _customizationControls.SetCustomizationLayout(false);
            Assert.AreEqual(false, _customizationControls.IsCustomizationLayoutVisible());
        }

        //test question number setter
        [TestMethod()]
        public void SetQuestionNumberTest()
        {
            for (int i = 0; i < 10; i++)
            {
                _customizationControls.SetQuestionNumber(i);
                Assert.AreEqual(i, _customizationControls.GetQuestionNumber());
            }
        }

        //test test-mode setter
        [TestMethod()]
        public void SetTestModeTest()
        {
            _customizationControls.SetTestMode("All fill in the blank questions");
            Assert.AreEqual(1, _customizationControls.GetTestMode());
            _customizationControls.SetTestMode("All multiple-choice questions");
            Assert.AreEqual(2, _customizationControls.GetTestMode());
            _customizationControls.SetTestMode("Pick up questions randomly");
            Assert.AreEqual(3, _customizationControls.GetTestMode());
        }
    }
}