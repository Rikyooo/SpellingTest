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
    public class AnswerCheckerTests
    {
        AnswerChecker _answerChecker = new AnswerChecker();

        //test result getter
        [TestMethod()]
        public void GetResultsInFillModeTest()
        {
            _answerChecker.ClearTheResult();
            _answerChecker.ResetIncorrectQuestionList();
            Assert.AreEqual("Correct!!", _answerChecker.GetResultsInFillMode("Hello", "Hello", "Hello"));
            Assert.AreEqual(1, _answerChecker.GetCorrectNumber());
            Assert.AreEqual("It should be Goodbye", _answerChecker.GetResultsInFillMode("Hello", "Goodbye", "Goodbye"));
            Assert.AreEqual("Goodbye Goodbye", _answerChecker.GetIncorrectQuestionList()[0]);
        }

        //test result getter
        [TestMethod()]
        public void GetResultsInChoiceModeTest()
        {
            _answerChecker.ClearTheResult();
            _answerChecker.ResetIncorrectQuestionList();
            bool[] isOptionChecked = new bool[4] { true, false, false, false };
            Assert.AreEqual("Correct!!", _answerChecker.GetResultsInChoiceMode(isOptionChecked, 1, "one", "one"));
            Assert.AreEqual(1, _answerChecker.GetCorrectNumber());
            Assert.AreEqual("It should be two", _answerChecker.GetResultsInChoiceMode(isOptionChecked, 2, "two", "two"));
            Assert.AreEqual("two two", _answerChecker.GetIncorrectQuestionList()[0]);
        }

        //test score calculator
        [TestMethod()]
        public void CalculateScoreTest()
        {
            _answerChecker.ClearTheResult();
            _answerChecker.CalculateScore(10, 1);
            Assert.AreEqual(0, _answerChecker.GetScore());
            _answerChecker.SetCorrectNumber(5);
            _answerChecker.CalculateScore(10, 0);
            Assert.AreEqual(50, _answerChecker.GetScore());
            _answerChecker.CalculateScore(10, 2);
            Assert.AreEqual(48, _answerChecker.GetScore());
        }
    }
}