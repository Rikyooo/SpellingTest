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
    public class MenuTests
    {
        Menu _menu = new Menu();

        //test start menu item setter
        [TestMethod()]
        public void SetStartMenuItemTest()
        {
            _menu.SetStartMenuItem(true);
            Assert.AreEqual(true, _menu.IsStartMenuItemEnabled());
            _menu.SetStartMenuItem(false);
            Assert.AreEqual(false, _menu.IsStartMenuItemEnabled());
        }

        //test next menu iten setter
        [TestMethod()]
        public void SetNextMenuItemTest()
        {
            _menu.SetNextMenuItem(true);
            Assert.AreEqual(true, _menu.IsNextMenuItemEnabled());
            _menu.SetNextMenuItem(false);
            Assert.AreEqual(false, _menu.IsNextMenuItemEnabled());
        }

        //test stop menu item setter
        [TestMethod()]
        public void SetStopMenuItemTest()
        {
            _menu.SetStopMenuItem(true);
            Assert.AreEqual(true, _menu.IsStopMenuItemEnabled());
            _menu.SetStopMenuItem(false);
            Assert.AreEqual(false, _menu.IsStopMenuItemEnabled());
        }

        //test number of question menu item setter
        [TestMethod()]
        public void SetNumberOfQuestionsMenuItemTest()
        {
            _menu.SetNumberOfQuestionsMenuItem(true);
            Assert.AreEqual(true, _menu.IsNumberOfQuestionsMenuItemEnabled());
            _menu.SetNumberOfQuestionsMenuItem(false);
            Assert.AreEqual(false, _menu.IsNumberOfQuestionsMenuItemEnabled());
        }

        //test question of type menu item setter
        [TestMethod()]
        public void SetQuestionTypeMenuItemTest()
        {
            _menu.SetQuestionTypeMenuItem(true);
            Assert.AreEqual(true, _menu.IsQuestionTypeMenuItemEnabled());
            _menu.SetQuestionTypeMenuItem(false);
            Assert.AreEqual(false, _menu.IsQuestionTypeMenuItemEnabled());
        }
    }
}