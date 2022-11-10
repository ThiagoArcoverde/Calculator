using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        bool dot = false;
        bool sign = false;
        String value1;
        String value2;
        public Form1()
        {
            InitializeComponent();
        }

        private void addChar(String character)
        {
            if (sign == true)
            {
                value1 = labelResult.Text;
                value1 = value1 + character;
                labelResult.Text = value1;
            }
            else
            {
                value2 = labelResult.Text;
                value2 = value2 + character;
                labelResult.Text = value2;
            }
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
            if(dot == false)
            {
                addChar(".");
                dot = true;
            }
        }
    }
}
