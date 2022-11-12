using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        bool dot = false;
        List<Value> numList = new List<Value>();
        Value value = new Value();

        public Form1()
        {
            InitializeComponent();
        }

        private void addChar(String character)
        {
            value.numString = labelResult.Text;
            value.numString = value.numString + character;
            labelResult.Text = value.numString;
        }

        private void butNum0_Click(object sender, EventArgs e)
        {
            addChar("0");
        }

        private void butNum1_Click(object sender, EventArgs e)
        {
            addChar("1");
        }

        private void butNum2_Click(object sender, EventArgs e)
        {
            addChar("2");
        }

        private void butNum3_Click(object sender, EventArgs e)
        {
            addChar("3");
        }

        private void butNum4_Click(object sender, EventArgs e)
        {
            addChar("4");
        }

        private void butNum5_Click(object sender, EventArgs e)
        {
            addChar("5");
        }

        private void butNum6_Click(object sender, EventArgs e)
        {
            addChar("6");
        }

        private void butNum7_Click(object sender, EventArgs e)
        {
            addChar("7");
        }

        private void butNum8_Click(object sender, EventArgs e)
        {
            addChar("8");
        }

        private void butNum9_Click(object sender, EventArgs e)
        {
            addChar("9");
        }

        private void butValueDot_Click(object sender, EventArgs e)
        {
            if (dot == false)
            {
                addChar(".");
                dot = true;
            }
        }

        private void butValueMinus_Click(object sender, EventArgs e)
        {
            if (labelResult.Text != "")
            {
                value.sign = "-";
                value.numDouble = Convert.ToDouble(value.numString);
                numList.Add(value);
                labelResult.Text = "";
            }
            butValuePlus.ForeColor = System.Drawing.Color.White;
            butValueMult.ForeColor = System.Drawing.Color.White;
            butValueMinus.ForeColor = System.Drawing.Color.Green;
            butValueDiv.ForeColor = System.Drawing.Color.White;
        }

        private void butValueMult_Click(object sender, EventArgs e)
        {
            if (labelResult.Text != "")
            {
                value.sign = "*";
                value.numDouble = Convert.ToDouble(value.numString);
                numList.Add(value);
                labelResult.Text = "";
            }
            butValuePlus.ForeColor = System.Drawing.Color.White;
            butValueMult.ForeColor = System.Drawing.Color.Green;
            butValueMinus.ForeColor = System.Drawing.Color.White;
            butValueDiv.ForeColor = System.Drawing.Color.White;
        }

        private void butValueDiv_Click(object sender, EventArgs e)
        {
            if (labelResult.Text != "")
            {
                value.sign = "/";
                value.numDouble = Convert.ToDouble(value.numString);
                numList.Add(value);
                labelResult.Text = "";
            }
            butValuePlus.ForeColor = System.Drawing.Color.White;
            butValueMult.ForeColor = System.Drawing.Color.White;
            butValueMinus.ForeColor = System.Drawing.Color.White;
            butValueDiv.ForeColor = System.Drawing.Color.Green;
        }

        private void butValuePlus_Click(object sender, EventArgs e)
        {
            if (labelResult.Text != "")
            {
                value.sign = "+";
                value.numDouble = Convert.ToDouble(value.numString);
                numList.Add(value);
                labelResult.Text = "";
            }
            butValuePlus.ForeColor = System.Drawing.Color.Green;
            butValueMult.ForeColor = System.Drawing.Color.White;
            butValueMinus.ForeColor = System.Drawing.Color.White;
            butValueDiv.ForeColor = System.Drawing.Color.White;
        }

        private void butQuit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void butValueDel_Click(object sender, EventArgs e)
        {
            butValuePlus.ForeColor = System.Drawing.Color.White;
            butValueMult.ForeColor = System.Drawing.Color.White;
            butValueMinus.ForeColor = System.Drawing.Color.White;
            butValueDiv.ForeColor = System.Drawing.Color.White;

            labelResult.Text = "";
            value = new Value();
            bool dot = false;                       //necessary in case the user resets a floating number
        }
    }
}
