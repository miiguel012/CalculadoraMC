using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtcalcular_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            if (txtpeso.Text == "")
            {
                MessageBox.Show("Digite seu peso");
            }
            else if (txtaltura.Text == "")
            {
                MessageBox.Show("Digite seu altura");
            }
            else
            {
                double Peso = double.Parse(txtpeso.Text);
                double Altura = double.Parse(txtaltura.Text);

                double imc = Peso / (Altura * Altura);
                txtimc.Text = imc.ToString();

                if (imc < 18.5)
                {
                    lblresultado.Text = "Abaixo do peso";

                }
                else if (imc < 24.9)
                {
                    lblresultado.Text = "Peso ideal(parabens)";
                }
                else if (imc < 29.9)
                {
                    lblresultado.Text = "levemente acima do peso";
                }
                else if(imc <34.9)
                {
                    lblresultado.Text = "Obesidade grau 1";
                }
                else if (imc <39.9)
                {
                    lblresultado.Text = "Obesidade grau 2(severa)";
                }
                else 
                {
                    lblresultado.Text = "Obesidade 3 (morbida)";
                }
            }












        }
    }
}
