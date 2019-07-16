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
    public partial class IncorrectQuestionShowForm : Form
    {
        Model _model;

        public IncorrectQuestionShowForm(PresentationModel presentationModel)
        {
            InitializeComponent();
            _model = presentationModel.GetModel();
            _incorrectQuestionList.DataSource = _model.GetIncorrectQuestionList();
            _resultLabel.Text = string.Format("You pass {0} of {1} questions!!", _model.GetCorrectNumber(), presentationModel.GetClickTimes());
            //MessageBox.Show(string.Format("You pass {0} of {1} questions!!", 1, 10));
            _model.ResetIncorrectQuestionList();
        }
    }
}
