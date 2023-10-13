using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator_Example
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.plus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum is:" + sum);
            }
        }

        bool ValidateInputs()
        {
            bool isValis = true;

            if (txtNumber1.Value == 0)
            {
                isValis = false;
                MessageBox.Show("لطفاً عدد اول را وارد نمایید");
            }
            else
            {
                if (txtNumber2.Value == 0)
                {
                    isValis = false;
                MessageBox.Show("لطفاً عدد دوم را وارد نمایید");

                }
            }



            return isValis;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int minus = calculate.minus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Minus is:" + minus);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int multiple = calculate.multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Multiple is:" + multiple);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int divide = calculate.divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Divide is:" + divide);
            }
        }
    }
}
