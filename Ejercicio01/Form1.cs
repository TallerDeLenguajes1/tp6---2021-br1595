using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        Calculadora Calcular = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Escribir("*");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Resultado();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Escribir("8");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Escribir("7");
        }

        private void Escribir(string Dato)
        {
            bool Contiene = false;
            switch (Dato)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    Contiene = true;
                    break;
                default:
                    break;
            }

            if((textBox1.Text.Contains("+") || textBox1.Text.Contains("-") || textBox1.Text.Contains("*") || textBox1.Text.Contains("/")) && Contiene)
            {
                Resultado();
            }
            else
            {
                textBox1.Text += Dato;
            }
        }

        public void Resultado()
        {
            string Auxiliar = textBox1.Text;
            string[] Variable = textBox1.Text.Split(new Char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
            textBox1.Clear();
            char Signo = Convert.ToChar(Auxiliar[Variable[0].Length]);

            Calcular.Numero1 = float.Parse(Variable[0]);
            Calcular.Numero2 = float.Parse(Variable[1]);


            switch (Signo)
            {
                case '+':
                    textBox1.Text = Convert.ToString(Calcular.Suma());
                    break;
                case '-':
                    textBox1.Text = Convert.ToString(Calcular.Resta());
                    break;
                case '*':
                    textBox1.Text = Convert.ToString(Calcular.Multiplicacion());
                    break;
                case '/':
                    if (Calcular.Numero2 != 0)
                    {
                        textBox1.Text = Convert.ToString(Calcular.Division());
                    }
                    else
                    {
                        textBox1.Text = "ERROR";
                    }
                    break;
                default:
                    break;
            }
            Calcular = new Calculadora();
        }
    }

    
}
