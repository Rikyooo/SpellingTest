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
    public class ModelTests
    {
        Model _model = new Model();
        Dictionary _dictionary;
        AnswerChecker _answerChecker;

        //test dictionary creator
        [TestMethod()]
        public void CreateDictionaryTest()
        {
            _model.CreateDictionary();
            Assert.AreEqual(4, _model.GetVocabularyNumber());
        }

        //test question type selector
        [TestMethod()]
        public void SelectQuestionTypeTest()
        {
            _model.SelectQuestionType();
            Assert.IsTrue(_model.GetQuestionType() >= 1);
            Assert.IsTrue(_model.GetQuestionType() < 3);
        }

        //test word selector
        [TestMethod()]
        public void SelectWordTest()
        {
            _dictionary = _model.GetDictionary();
            string[] _output = new string[4];
            _model.CreateDictionary();
            _model.SetQuestionType(2);
            _model.CopyDictionary();
            _model.SelectWord();
            Assert.AreEqual(_dictionary.GetEnglishText(), _model.GetOutputText());
            _output = _model.GetOptionList();
            Assert.IsTrue(_output.Contains("1"));
            Assert.IsTrue(_output.Contains("2"));
            Assert.IsTrue(_output.Contains("3"));
            Assert.IsTrue(_output.Contains("4"));
            _model.SetQuestionType(1);
            _model.CopyDictionary();
            for (int i = 0; i < 4; i++)
            {
                _model.SelectWord();
                _output[i] = _model.GetOutputText();
            }
            Assert.IsTrue(_output.Contains("1 o___e (3)"));
            Assert.IsTrue(_output.Contains("2(2)"));
            Assert.IsTrue(_output.Contains("3 t___e (5)"));
            Assert.IsTrue(_output.Contains("4 f___r (4)"));
        }

        //test result getter
        [TestMethod()]
        public void GetResultsInFillModeTest()
        {
            _dictionary = _model.GetDictionary();
            _model.ClearTheResult();
            _model.ResetIncorrectQuestionList();
            _model.SetQuestionText("Hello");
            _dictionary.SetEnglishText("Hello");
            Assert.AreEqual("Correct!!", _model.GetResultsInFillMode("Hello"));
            Assert.AreEqual(1, _model.GetCorrectNumber());
            _model.SetQuestionText("Goodbye");
            _dictionary.SetEnglishText("Goodbye");
            Assert.AreEqual("It should be Goodbye", _model.GetResultsInFillMode("Hello"));
            Assert.AreEqual("Goodbye Goodbye", _model.GetIncorrectQuestionList()[0]);
        }

        //test result getter
        [TestMethod()]
        public void GetResultsInChoiceModeTest()
        {
            _dictionary = _model.GetDictionary();
            _model.ClearTheResult();
            _model.ResetIncorrectQuestionList();
            bool[] isOptionChecked = new bool[4] { true, false, false, false };
            _model.SetCorrectOptionOrdinalNumber(1);
            _model.SetQuestionText("one");
            _model.SetCorrectOptionText("one");
            Assert.AreEqual("Correct!!", _model.GetResultsInChoiceMode(isOptionChecked));
            Assert.AreEqual(1, _model.GetCorrectNumber());
            _model.SetCorrectOptionOrdinalNumber(2);
            _model.SetQuestionText("two");
            _model.SetCorrectOptionText("two");
            Assert.AreEqual("It should be two", _model.GetResultsInChoiceMode(isOptionChecked));
            Assert.AreEqual("two two", _model.GetIncorrectQuestionList()[0]);
        }

        //test score getter
        [TestMethod()]
        public void GetScoreTest()
        {
            _answerChecker = _model.GetAnswerChecker();
            _model.ClearTheResult();
            Assert.AreEqual(0, _model.GetScore(10, 1));
            _answerChecker.SetCorrectNumber(5);
            Assert.AreEqual(50, _model.GetScore(10, 0));
            Assert.AreEqual(48, _model.GetScore(10, 2));
        }
    }
}