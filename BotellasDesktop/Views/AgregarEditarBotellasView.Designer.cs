namespace BotellasDesktop.Views
{
    partial class AgregarEditarBotellasView
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
            txtTipo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            numericUpDown = new NumericUpDown();
            txtImgUrl = new TextBox();
            picturePortada = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePortada).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 39);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Botella:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(117, 36);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(282, 23);
            txtTipo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 140);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Imagen Url:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 349);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Lts/ml:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(36, 414);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(324, 414);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // numericUpDown
            // 
            numericUpDown.DecimalPlaces = 2;
            numericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown.Location = new Point(117, 341);
            numericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(282, 23);
            numericUpDown.TabIndex = 7;
            numericUpDown.TextAlign = HorizontalAlignment.Right;
            numericUpDown.ThousandsSeparator = true;
            // 
            // txtImgUrl
            // 
            txtImgUrl.Location = new Point(117, 137);
            txtImgUrl.Name = "txtImgUrl";
            txtImgUrl.Size = new Size(282, 23);
            txtImgUrl.TabIndex = 8;
            // 
            // picturePortada
            // 
            picturePortada.Location = new Point(158, 176);
            picturePortada.Name = "picturePortada";
            picturePortada.Size = new Size(179, 140);
            picturePortada.SizeMode = PictureBoxSizeMode.Zoom;
            picturePortada.TabIndex = 9;
            picturePortada.TabStop = false;
            // 
            // AgregarEditarBotellasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 449);
            Controls.Add(picturePortada);
            Controls.Add(txtImgUrl);
            Controls.Add(numericUpDown);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTipo);
            Controls.Add(label1);
            Name = "AgregarEditarBotellasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar/Editar Botellas";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTipo;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private Button btnCancelar;
        private NumericUpDown numericUpDown;
        private TextBox txtImgUrl;
        private PictureBox picturePortada;
    }
}