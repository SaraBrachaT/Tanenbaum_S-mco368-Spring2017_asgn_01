using PresidentialEligibilityClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool naturalBorn;
        int age;
        int resYears;
        bool lessThanTwoTerms;
        bool impeached;
        bool rebellious;

        public Form1()
        {
            InitializeComponent();
        }

        private void naturalBornChkbx_CheckedChanged(object sender, EventArgs e)
        {
            if(naturalBornChkbx.Checked)naturalBorn = true;   
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            age = DateTime.Now.Year - dateTimePicker1.Value.Year;
        }

        private void residentYrsTxtbx_TextChanged(object sender, EventArgs e)
        {
            resYears = Convert.ToInt32(residentYrsTxtbx.Text);
        }

        private void numTermsTxtbx_TextChanged(object sender, EventArgs e)
        {
            int terms = Convert.ToInt32(numTermsTxtbx.Text);
            if (terms < 2) lessThanTwoTerms = true;
        }

        private void impeachedChkbx_CheckedChanged(object sender, EventArgs e)
        {
            if(impeachedChkbx.Checked)impeached = true;
        }

        private void rebelliousChkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (rebelliousChkbx.Checked) rebellious = true;
        }

        private void eligibilityCheckerBtn_Click(object sender, EventArgs e)
        {
            EligibilityChecker ec = new EligibilityChecker(naturalBorn, age, resYears, lessThanTwoTerms, impeached, rebellious);
            if(ec.check())
            {
                eligibilityCheckerBtn.Visible = false;
                resultLabel.Text = "I Am Eligible!";
            }
            else
            {
                eligibilityCheckerBtn.Visible = false;
                resultLabel.Text = "I Am Not Eligible";
            }
        }
    }
}
