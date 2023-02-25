using System;
using System.Windows.Forms;

namespace Primer_Formulario_1._2
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
            Procesar();
        }

        private void Procesar()
        {

            double capital = 200000;
            int tiempo = 12;

            InteresDataGridView.ColumnCount = 3;
            InteresDataGridView.Columns[0].Name = "Mes";
            InteresDataGridView.Columns[1].Name = "Interés";
            InteresDataGridView.Columns[2].Name = "Nuevo Capital";

            double acumuinteres = 0;
            double interesTotal = 0;

            for (int i = 1; i <= tiempo; i++)
            {
                DateTime fecha = new DateTime(DateTime.Now.Year, i, 1);
                string mesEnLetras = fecha.ToString("MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"));

                capital += interesTotal; // actualizar capital con el interes del mes anterior
                                         //double interesMensual = capital * tasa / 12;
                double interesMensual = capital * 0.015;

                acumuinteres = interesMensual + acumuinteres;

                capital += interesMensual;

                InteresDataGridView.Rows.Add(mesEnLetras, interesMensual.ToString("C"), capital.ToString("C"));
            }

            InteresDataGridView.Rows.Add("Total", acumuinteres.ToString("C"), capital.ToString("C"));
        }
    }
}

