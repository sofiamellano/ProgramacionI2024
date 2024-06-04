namespace BooksDesktops.Views
{
    partial class AgregarEditarLibroView
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
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            txtPortadaUrl = new TextBox();
            txtSinopsis = new TextBox();
            txtGenero = new TextBox();
            numericPages = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericPages).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtName
            // 
            txtName.Location = new Point(88, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(363, 23);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Editorial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 4;
            label4.Text = "Portada Url:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 228);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 5;
            label5.Text = "Sinopsis:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 284);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 6;
            label6.Text = "Paginas:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 331);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 7;
            label7.Text = "Genero:";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(88, 80);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(363, 23);
            txtAutor.TabIndex = 8;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(88, 126);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(363, 23);
            txtEditorial.TabIndex = 9;
            // 
            // txtPortadaUrl
            // 
            txtPortadaUrl.Location = new Point(88, 168);
            txtPortadaUrl.Name = "txtPortadaUrl";
            txtPortadaUrl.Size = new Size(363, 23);
            txtPortadaUrl.TabIndex = 10;
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(88, 205);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(363, 57);
            txtSinopsis.TabIndex = 11;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(88, 328);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(363, 23);
            txtGenero.TabIndex = 13;
            // 
            // numericPages
            // 
            numericPages.Location = new Point(88, 282);
            numericPages.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericPages.Name = "numericPages";
            numericPages.Size = new Size(130, 23);
            numericPages.TabIndex = 14;
            numericPages.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(143, 386);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "&Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(292, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "&Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AgregarEditarLibroView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 502);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numericPages);
            Controls.Add(txtGenero);
            Controls.Add(txtSinopsis);
            Controls.Add(txtPortadaUrl);
            Controls.Add(txtEditorial);
            Controls.Add(txtAutor);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "AgregarEditarLibroView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar/EditarLibro";
            ((System.ComponentModel.ISupportInitialize)numericPages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private TextBox txtPortadaUrl;
        private TextBox txtSinopsis;
        private TextBox txtGenero;
        private NumericUpDown numericPages;
        private Button btnSave;
        private Button btnCancel;
    }
}