using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator23
{
    public partial class Calculator : Form
    {
        double firstNum, result;
        string operation;
        
        
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            firstNum = 0;
            DialogResult = 0;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNum = firstNum + double.Parse(txtDisplay.Text);
            operation = "-";
            txtDisplay.Clear();

        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operation=="+")
            {
                result = firstNum + double.Parse(txtDisplay.Text);               
                
            }
            else if (operation=="-")
            {
                result = firstNum - double.Parse(txtDisplay.Text);
                //txtDisplay.Text = result.ToString();                
            }
            else if (operation=="*")
            {
                result = firstNum * double.Parse(txtDisplay.Text);
            }
            else if (operation=="/")
            {
                result = firstNum / double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = result.ToString();
            firstNum = 0;
            //result = 0;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            firstNum = firstNum + double.Parse(txtDisplay.Text);
            operation = "*";
            txtDisplay.Clear();
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            firstNum = firstNum + double.Parse(txtDisplay.Text);
            operation = "/";
            txtDisplay.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNum = firstNum + double.Parse(txtDisplay.Text);
            operation = "+";
            txtDisplay.Clear();
        }



    }
}
