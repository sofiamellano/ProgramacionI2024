namespace CiclismoDesktopPorCodigo.Views
{
    partial class NuevoEditarClienteSPView
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
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtApellidoContacto = new TextBox();
            txtNombreContacto = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(278, 358);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(73, 358);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtApellidoContacto
            // 
            txtApellidoContacto.Location = new Point(205, 246);
            txtApellidoContacto.Name = "txtApellidoContacto";
            txtApellidoContacto.Size = new Size(197, 23);
            txtApellidoContacto.TabIndex = 13;
            // 
            // txtNombreContacto
            // 
            txtNombreContacto.Location = new Point(205, 151);
            txtNombreContacto.Name = "txtNombreContacto";
            txtNombreContacto.Size = new Size(197, 23);
            txtNombreContacto.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(205, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 151);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 10;
            label3.Text = "Nombre contacto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 249);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 9;
            label2.Text = "Apellido contacto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 61);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            // 
            // NuevoEditarClienteSPView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtApellidoContacto);
            Controls.Add(txtNombreContacto);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NuevoEditarClienteSPView";
            Text = "NuevoEditarClienteSPView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtApellidoContacto;
        private TextBox txtNombreContacto;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}