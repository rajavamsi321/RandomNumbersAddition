using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumbersAddition
{
    public partial class frmAdd : Form
    {
        int a;
        int b;
        Random randNum;
        public frmAdd()
        {
            InitializeComponent();
        }
        
        private void frmAdd_Load(object sender, EventArgs e)
        {
            // random variable instance
            randNum = new Random();
            a = randNum.Next(100, 501);
            b = randNum.Next(100, 501);
            lblTwoNumAdd.Text = a + "+" + b + "= ?";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            int answer;
            if (int.TryParse(tBoxAdd.Text, out answer))
            {
                if (answer == a + b)
                {
                    lblMsg.Text = "ADDITION IS CORRECT.";
                }
                else
                {
                    lblMsg.Text = "INCORRECT." + "\n" + 
                        "CORRECT ANSWER IS: " + (a + b);
                }
                a = randNum.Next(100, 501);
                b = randNum.Next(100, 501);
                lblTwoNumAdd.Text = a + "+" + b + "= ?";

            }
            else
            {
                MessageBox.Show("Enter Valid Number", "Invalid input");
            }
        }
    }
}
