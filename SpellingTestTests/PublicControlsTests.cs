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
    public class PublicControlsTests
    {
        PublicControls _publicControls = new PublicControls();

        //test form size setter
        [TestMethod()]
        public void SetFormSizeTest()
        {
            _publicControls.SetFormSize(50, 100);
            Assert.AreEqual(50, _publicControls.GetFormSizeWidth());
            Assert.AreEqual(100, _publicControls.GetFormSizeHeight());
        }

        //test start button setter
        [TestMethod()]
        public void SetStartButtonTest()
        {
            _publicControls.SetStartButton(true);
            Assert.AreEqual(true, _publicControls.IsStartButtonEnabled());
            _publicControls.SetStartButton(false);
            Assert.AreEqual(false, _publicControls.IsStartButtonEnabled());
        }

        //set next button setter
        [TestMethod()]
        public void SetNextButtonTest()
        {
            _publicControls.SetNextButton(true);
            Assert.AreEqual(true, _publicControls.IsNextButtonEnabled());
            _publicControls.SetNextButton(false);
            Assert.AreEqual(false, _publicControls.IsNextButtonEnabled());
        }

        //test stop button setter
        [TestMethod()]
        public void SetStopButtonTest()
        {
            _publicControls.SetStopButton(true);
            Assert.AreEqual(true, _publicControls.IsStopButtonEnabled());
            _publicControls.SetStopButton(false);
            Assert.AreEqual(false, _publicControls.IsStopButtonEnabled());
        }

        //test windows title setter
        [TestMethod()]
        public void SetTestWindowTitleTest()
        {
            _publicControls.SetTestWindowTitle(1, 1);
            Assert.AreEqual("Q1 : Fill in the Blanks", _publicControls.GetTestWindowTitle());
            _publicControls.SetTestWindowTitle(2, 1);
            Assert.AreEqual("Q1 : Multiple Choice Question", _publicControls.GetTestWindowTitle());
            _publicControls.SetTestWindowTitle(0, 0);
            Assert.AreEqual("Customize Your Examination", _publicControls.GetTestWindowTitle());
        }

        //test progress bar
        [TestMethod()]
        public void ProgressBarValueTest()
        {
            _publicControls.SetTickTimes(0);
            _publicControls.SetUrgedTimes(0);
            Assert.AreEqual(1, _publicControls.SetProgressBarValue(1));
            Assert.AreEqual(1, _publicControls.GetTickTimes());
            _publicControls.SetTickTimes(9);
            Assert.AreEqual(0, _publicControls.SetProgressBarValue(10));
            Assert.AreEqual(0, _publicControls.GetTickTimes());
            Assert.AreEqual(1, _publicControls.GetUrgedTimes());
        }

        //test elapsed time
        [TestMethod()]
        public void ElapsedTimeTest()
        {
            _publicControls.SetElapsedTime(0, 0, 0);
            Assert.AreEqual("00:00:00", _publicControls.GetElapsedTime());
            _publicControls.SetElapsedTime(0, 0, 59);
            _publicControls.UpdateElapsedTime();
            Assert.AreEqual("00:01:00", _publicControls.GetElapsedTime());
            _publicControls.SetElapsedTime(0, 59, 00);
            for (int i = 0; i < 60; i++)
                _publicControls.UpdateElapsedTime();
            Assert.AreEqual("01:00:00", _publicControls.GetElapsedTime());
        }
    }
}