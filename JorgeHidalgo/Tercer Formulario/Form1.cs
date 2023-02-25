using System;
using System.Windows.Forms;

namespace Tercer_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Mostrar_Numeros()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add("Jorge y Alvarez" + Environment.NewLine);
                }
                else if (i % 3 == 0)
                {
                    listBox1.Items.Add("Jorge" + Environment.NewLine);
                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add("Alvarez" + Environment.NewLine);
                }
                else
                {
                    listBox1.Items.Add(i.ToString() + Environment.NewLine);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Numeros();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
