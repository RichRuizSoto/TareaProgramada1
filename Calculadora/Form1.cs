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
		public int numeroUno = 0;
		public int numeroDos = 0;
		public int resultado = 0;
		public string operador = "";
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ventanaDeResultados.Text == "0")
			{
				ventanaDeResultados.Text = "";
			}
			else
			{
				ventanaDeResultados.Text = ventanaDeResultados.Text + "1";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (ventanaDeResultados.Text == "0")
			{
				ventanaDeResultados.Text = "";
			}
			else
			{
				ventanaDeResultados.Text = ventanaDeResultados.Text + "2";
			}
		}

        private void button3_Click(object sender, EventArgs e)
        {
            if (ventanaDeResultados.Text == "0")
            {
                ventanaDeResultados.Text = "";
            }
            else
            {
                ventanaDeResultados.Text = ventanaDeResultados.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ventanaDeResultados.Text == "0")
            {
                ventanaDeResultados.Text = "";
            }
            else
            {
                ventanaDeResultados.Text = ventanaDeResultados.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ventanaDeResultados.Text == "0")
            {
                ventanaDeResultados.Text = "";
            }
            else
            {
                ventanaDeResultados.Text = ventanaDeResultados.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ventanaDeResultados.Text == "0")
            {
                ventanaDeResultados.Text = "";
            }
            else
            {
                ventanaDeResultados.Text = ventanaDeResultados.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ventanaDeResultados.Text == "0")
            {
                ventanaDeResultados.Text = "";
            }
            else
            {
                ventanaDeResultados.Text = ventanaDeResultados.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ventanaDeResultados.Text == "0")
            {
                ventanaDeResultados.Text = "";
            }
            else
            {
                ventanaDeResultados.Text = ventanaDeResultados.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ventanaDeResultados.Text == "0")
            {
                ventanaDeResultados.Text = "";
            }
            else
            {
                ventanaDeResultados.Text = ventanaDeResultados.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ventanaDeResultados.Text == "0")
            {
                ventanaDeResultados.Text = "";
            }
            else
            {
                ventanaDeResultados.Text = ventanaDeResultados.Text + "0";
            }
        }

        private void botonSuma_Click(object sender, EventArgs e)
		{
			numeroUno = int.Parse(ventanaDeResultados.Text);
			ventanaDeResultados.Text = "";
			operador = "+";
		}

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            numeroUno = int.Parse(ventanaDeResultados.Text);
            ventanaDeResultados.Text = "";
            operador = "-";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            numeroUno = int.Parse(ventanaDeResultados.Text);
            ventanaDeResultados.Text = "";
            operador = "*";
        }


        private void buttonIgual_Click(object sender, EventArgs e)
		{
			switch (operador)
			{
				case "+":
					{
						Suma();
						break;
					}
                case "-":
                    {
                        Resta();
                        break;
                    }
                case "*":
                    {
                        Multiplicacion();
                        break;
                    }
            }
		}
		private void Suma()
		{
			numeroDos = int.Parse(ventanaDeResultados.Text);
			resultado = numeroUno + numeroDos;
			ventanaDeResultados.Text = resultado.ToString();
		}

        private void Resta()
        {
            numeroDos = int.Parse(ventanaDeResultados.Text);
            resultado = numeroUno - numeroDos;
            ventanaDeResultados.Text = resultado.ToString();
        }

        private void Multiplicacion()
        {
            numeroDos = int.Parse(ventanaDeResultados.Text);
            resultado = numeroUno * numeroDos;
            ventanaDeResultados.Text = resultado.ToString();
        }
    }
}
