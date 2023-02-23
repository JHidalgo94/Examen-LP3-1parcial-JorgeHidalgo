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

        private void calcularbutton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Double calcular(double monto, double interes, Double tiempo)
        {

            return monto * interes * tiempo;
        }
    }
}
