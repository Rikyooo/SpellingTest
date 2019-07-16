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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        //click lab link
        private void ClickLabLinkLabel(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _labLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://csie.ntut.edu.tw/labsdtl/");
        }

        //click department link
        private void ClickDepartmentLinkLabel(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _departmentLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://csie.ntut.edu.tw");
        }

        //cliak school link
        private void ClickSchoolLinkLabel(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _schoolLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.ntut.edu.tw");
        }

        //click confirm button
        private void ClickConfirmButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
