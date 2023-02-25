using System;
using System.Windows.Forms;

namespace Segundo_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Agregar columnas al DataGridView en tiempo de ejecución
            dgvProductos.Columns.Add("Descripcion", "Descripción ");
            dgvProductos.Columns.Add("Precio", "Precio");
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            string descripcion;
            double precio;
            double totalNeto = 0;
            double totalBruto = 0;
            double descuento = 0;

            //Validar que se haya ingresado al menos un producto
            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto.");
                return;
            }

            //Recorrer la tabla de productos y calcular el descuento del 15%
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                //descripcion = fila.Cells["Descripcion"].Value.ToString();
                if (fila.Cells["Descripcion"].Value != null && !string.IsNullOrEmpty(fila.Cells["Descripcion"].Value.ToString()))
                {
                    descripcion = fila.Cells["Descripcion"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Debe ingresar una descripción válida para el producto.");
                    return;
                }

                if (fila.Cells["Precio"].Value != null && !string.IsNullOrEmpty(fila.Cells["Precio"].Value.ToString()))
                {
                    precio = Convert.ToDouble(fila.Cells["Precio"].Value);
                }
                else
                {
                    MessageBox.Show("Debe ingresar un precio válido para el producto.");
                    return;
                }

                //Agregar el producto al total bruto
                totalBruto += Convert.ToDouble(fila.Cells["Precio"].Value);
            }

            //Calcular el descuento del 15%
            descuento = totalBruto * 0.15;

            //Agregar el producto al total neto
            totalNeto += totalBruto - descuento;

            //Mostrar los resultados en las cajas de texto correspondientes
            txtTotalNeto.Text = totalNeto.ToString("C");
            txtdescuento.Text = descuento.ToString("C");
            txtTotalBruto.Text = totalBruto.ToString("C");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que se hayan ingresado la descripción y el precio del producto
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar la descripción y el precio del producto.");
                return;
            }


            //Agregar el producto a la tabla de productos

            dgvProductos.Rows.Add(txtDescripcion.Text, Convert.ToDouble(txtPrecio.Text));

            //Limpiar las cajas de texto
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            txtDescripcion.Clear();
            txtdescuento.Clear();
            txtTotalNeto.Clear();
            txtTotalBruto.Clear();
            dgvProductos.Rows.Clear();
        }
    }
}

