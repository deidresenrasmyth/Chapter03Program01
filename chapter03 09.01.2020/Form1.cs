using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter03_09._01._2020
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ButnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            decimal operand1;
            decimal operand2;
            decimal answer;
            //Input Step
            //Check first input...
            flag = decimal.TryParse(TxtOperand1.Text, out operand1);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                TxtOperand1.Focus();
                return;
            }
                // Check second input...
            flag = decimal.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
             }
            //Process Step
            answer = operand1 / operand2;
            // Display Step
            txtResult.Text = operand1.ToString() + "divided by" +
                operand2.ToString() +
                "equals" + answer.ToString();
            txtResult.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
                    }
    }
}
