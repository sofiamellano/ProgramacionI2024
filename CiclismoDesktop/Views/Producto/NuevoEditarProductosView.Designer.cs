namespace CiclismoDesktopPorCodigo.Views
{
    partial class NuevoEditarProductosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombreProducto = new TextBox();
            txtColor = new TextBox();
            txtM_F = new TextBox();
            txtClaseProducto = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            numericUpDownTalla = new NumericUpDown();
            label6 = new Label();
            numericUpDownPrecio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 30);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 92);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 168);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Talla:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 238);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "M/F:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 365);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 4;
            label5.Text = "Clase De Producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(195, 27);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(188, 23);
            txtNombreProducto.TabIndex = 5;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(195, 89);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(188, 23);
            txtColor.TabIndex = 6;
            // 
            // txtM_F
            // 
            txtM_F.Location = new Point(195, 235);
            txtM_F.Name = "txtM_F";
            txtM_F.Size = new Size(188, 23);
            txtM_F.TabIndex = 8;
            // 
            // txtClaseProducto
            // 
            txtClaseProducto.Location = new Point(195, 365);
            txtClaseProducto.Name = "txtClaseProducto";
            txtClaseProducto.Size = new Size(188, 23);
            txtClaseProducto.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(90, 440);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(293, 440);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // numericUpDownTalla
            // 
            numericUpDownTalla.Location = new Point(195, 166);
            numericUpDownTalla.Name = "numericUpDownTalla";
            numericUpDownTalla.Size = new Size(188, 23);
            numericUpDownTalla.TabIndex = 12;
            numericUpDownTalla.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 304);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 13;
            label6.Text = "Precio:";
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownPrecio.Location = new Point(201, 302);
            numericUpDownPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(182, 23);
            numericUpDownPrecio.TabIndex = 7;
            numericUpDownPrecio.TextAlign = HorizontalAlignment.Right;
            numericUpDownPrecio.ThousandsSeparator = true;
            // 
            // NuevoEditarProductosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 519);
            Controls.Add(numericUpDownPrecio);
            Controls.Add(label6);
            Controls.Add(numericUpDownTalla);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtClaseProducto);
            Controls.Add(txtM_F);
            Controls.Add(txtColor);
            Controls.Add(txtNombreProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NuevoEditarProductosView";
            Text = "NuevoEditarProductosView";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombreProducto;
        private TextBox txtColor;
        private TextBox txtM_F;
        private TextBox txtClaseProducto;
        private Button btnGuardar;
        private Button btnCancelar;
        private NumericUpDown numericUpDownTalla;
        private Label label6;
        private NumericUpDown numericUpDownPrecio;
    }
}