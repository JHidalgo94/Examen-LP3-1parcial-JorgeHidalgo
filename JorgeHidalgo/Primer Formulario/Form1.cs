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
            double deposito = Convert.ToDouble(montotextBox1.Text);
            double meses = Convert.ToInt16(mesestextBox1.Text);





            listBox1.Items.Add(Convert.ToString(operacion));


            //MessageBox.Show(Convert.ToString(Calcular(deposito, meses)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Double calcular(double a, double b) //donde a es el monto y b es el tiempo(meses)
        {

            double total, total1 = 0;
            for (int d = 0; d < b; d++)
            {
                total = a * 0.015;
                total1 = total + total1;

            }
            return total1;


        }
    }
}




