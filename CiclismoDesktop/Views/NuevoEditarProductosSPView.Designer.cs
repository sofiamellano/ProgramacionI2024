namespace CiclismoDesktopPorCodigo.Views
{
    partial class NuevoEditarProductosSPView
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
            numericUpDownPrecio = new NumericUpDown();
            label6 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtM_F = new TextBox();
            txtColor = new TextBox();
            txtNombreProducto = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTalla = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownPrecio.Location = new Point(237, 303);
            numericUpDownPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(182, 23);
            numericUpDownPrecio.TabIndex = 21;
            numericUpDownPrecio.TextAlign = HorizontalAlignment.Right;
            numericUpDownPrecio.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(148, 305);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 27;
            label6.Text = "Precio:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(323, 387);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(130, 387);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtM_F
            // 
            txtM_F.Location = new Point(231, 236);
            txtM_F.Name = "txtM_F";
            txtM_F.Size = new Size(188, 23);
            txtM_F.TabIndex = 22;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(231, 90);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(188, 23);
            txtColor.TabIndex = 20;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(231, 28);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(188, 23);
            txtNombreProducto.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 239);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 17;
            label4.Text = "M/F:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 169);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 16;
            label3.Text = "Talla:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 93);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 15;
            label2.Text = "Color:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 31);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 14;
            label1.Text = "Nombre Producto:";
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(231, 169);
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(188, 23);
            txtTalla.TabIndex = 28;
            // 
            // NuevoEditarProductosSPView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 492);
            Controls.Add(txtTalla);
            Controls.Add(numericUpDownPrecio);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtM_F);
            Controls.Add(txtColor);
            Controls.Add(txtNombreProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NuevoEditarProductosSPView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NuevoEditarProductosSPView";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownPrecio;
        private Label label6;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtM_F;
        private TextBox txtColor;
        private TextBox txtNombreProducto;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTalla;
    }
}