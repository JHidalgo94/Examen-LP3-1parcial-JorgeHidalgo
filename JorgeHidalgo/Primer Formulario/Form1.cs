using System;
using System.Windows.Forms;

namespace Primer_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double operacion = 0;
        private void calcularbutton1_Click(object sender, EventArgs e)
        {
            double deposito = Convert.ToDouble(montotextBox1.Text);
            double meses = Convert.ToDouble(mesestextBox1.Text);

            Calcular(deposito, meses);


            MessageBox.Show(Convert.ToString(Calcular(deposito, meses)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Double Calcular(double monto, Double tiempo)
        {

            return monto * 0.015 * tiempo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
