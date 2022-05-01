using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string typeEquacao = string.Empty;
        decimal v1 = 0;
        decimal v2 = 0;

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Resultado.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Resultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Resultado.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Resultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Resultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resultado.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Resultado.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Resultado.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Resultado.Text += "+";
            regraEquacao("+");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Resultado.Text += "-";
            regraEquacao("-");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Resultado.Text += "*";
            regraEquacao("*");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Resultado.Text += "/";
            regraEquacao("/");
        }

        private void regraEquacao(string regra)
        {
            if (string.IsNullOrEmpty(typeEquacao))
            {
                typeEquacao = regra;
            }
            else
            {

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var arrayResult = Resultado.Text.Split(typeEquacao);
            


            if (typeEquacao == "+")
            {
                v1 = Convert.ToInt32(arrayResult[0]);
                v2 = Convert.ToInt32(arrayResult[1]);
                Resultado.Text = Convert.ToString(v1 + v2);
            }
            if (typeEquacao == "-")
            {
                v1 = Convert.ToInt32(arrayResult[0]);
                v2 = Convert.ToInt32(arrayResult[1]);
                Resultado.Text = Convert.ToString(v1 - v2);
            }
            if (typeEquacao == "*")
            {
                v1 = Convert.ToInt32(arrayResult[0]);
                v2 = Convert.ToInt32(arrayResult[1]);
                Resultado.Text = Convert.ToString(v1 * v2);
            }
            if (typeEquacao == "/")
            {
                v1 = Convert.ToInt32(arrayResult[0]);
                v2 = Convert.ToInt32(arrayResult[1]);
                Resultado.Text = Convert.ToString(v1 / v2);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            v1 = 0;
            v2 = 0;
            Resultado.Clear();
        }
    }
}
