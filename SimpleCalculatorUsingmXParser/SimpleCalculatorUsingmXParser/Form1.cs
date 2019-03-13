using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using org.mariuszgromada.math.mxparser.mathcollection;

namespace SimpleCalculatorUsingmXParser
{
    public partial class Form1 : Form
    {
        String e;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            String processor;
            processor = tvExpression.Text;
            processor = processor.Substring(0, processor.Length-1);
            tvExpression.Text = processor;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            writeExpression("^");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            writeExpression("+");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            writeExpression("9");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            writeExpression("8");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            writeExpression("7");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            writeExpression("-");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            writeExpression("6");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            writeExpression("5");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            writeExpression("4");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            writeExpression("*");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            writeExpression("3");
        }

      /*  private void btnTwi_Click(object sender, EventArgs e)
        {
            
        }*/

        private void btnOne_Click(object sender, EventArgs e)
        {
            writeExpression("1");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            writeExpression("/");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            writeExpression("0");
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            writeExpression(".");
        }

        private void btnDoubleZero_Click(object sender, EventArgs e)
        {
            writeExpression("00");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            String expression = tvExpression.Text;
            Expression e1 = new Expression(expression);
            String result = e1.calculate().ToString();

            tvResult.Text = result;
        }

        void writeExpression(String value)
        {
            String expression = tvExpression.Text;
            expression = expression + value;

            tvExpression.Text = expression;
        }

        void clearScreen()
        {
            tvExpression.Text = "";
            tvResult.Text = "";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            writeExpression("2");
        }
    }
}
