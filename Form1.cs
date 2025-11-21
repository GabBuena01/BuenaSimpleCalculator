using BuenaCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuenaCalculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFirstNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Addition plus = new Addition();
            plus.num1 = Convert.ToInt32(txtFirstNum.Text);
            plus.num2 = Convert.ToInt32(txtSecondNum.Text);

            double sum = plus.add();
            txtResult.Text = sum.ToString();
        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
            Substraction minus = new Substraction();
            minus.num1 = Convert.ToInt32(txtFirstNum.Text);
            minus.num2 = Convert.ToInt32(txtSecondNum.Text);

            double diff = minus.substract();
            txtResult.Text = diff.ToString();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            Multiplication times = new Multiplication();
            times.num1 = Convert.ToInt32(txtFirstNum.Text);
            times.num2 = Convert.ToInt32(txtSecondNum.Text);

            double product = times.multiply();
            txtResult.Text = product.ToString();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            Division dby = new Division();
            dby.num1 = Convert.ToInt32(txtFirstNum.Text);
            dby.num2 = Convert.ToInt32(txtSecondNum.Text);

            double product = dby.divide();
            txtResult.Text = product.ToString();

            if (dby.num2 == 0)
            {
                MessageBox.Show("You cannot divide it by zero :3");
                txtResult.Text = "Error";
                return;
            }
        }
    }
}
