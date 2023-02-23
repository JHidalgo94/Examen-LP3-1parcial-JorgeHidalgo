namespace Primer_Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.calcularbutton1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.montotextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mesestextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcularbutton1
            // 
            this.calcularbutton1.Location = new System.Drawing.Point(371, 305);
            this.calcularbutton1.Name = "calcularbutton1";
            this.calcularbutton1.Size = new System.Drawing.Size(75, 23);
            this.calcularbutton1.TabIndex = 0;
            this.calcularbutton1.Text = "Calcular";
            this.calcularbutton1.UseVisualStyleBackColor = true;
            this.calcularbutton1.Click += new System.EventHandler(this.calcularbutton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(504, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // montotextBox1
            // 
            this.montotextBox1.Location = new System.Drawing.Point(160, 122);
            this.montotextBox1.Name = "montotextBox1";
            this.montotextBox1.Size = new System.Drawing.Size(100, 20);
            this.montotextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Favor ingrese el monto a calcular";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calculo de intereses por mes";
            // 
            // mesestextBox1
            // 
            this.mesestextBox1.Location = new System.Drawing.Point(160, 197);
            this.mesestextBox1.Name = "mesestextBox1";
            this.mesestextBox1.Size = new System.Drawing.Size(100, 20);
            this.mesestextBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Favor ingresar los meses a calcular";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mesestextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.montotextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.calcularbutton1);
            this.Name = "Form1";
            this.Text = "Calcular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularbutton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox montotextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mesestextBox1;
        private System.Windows.Forms.Label label3;
    }
}

