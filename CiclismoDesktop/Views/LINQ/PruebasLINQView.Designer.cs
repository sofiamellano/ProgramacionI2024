namespace CiclismoDesktopPorCodigo.Views.LINQ
{
    partial class PruebasLINQView
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
            dataGridResultados = new DataGridView();
            btnPruebaArray = new Button();
            btnPruebaSQL = new Button();
            btnPruebaSelectMany = new Button();
            btnPruebaJSON = new Button();
            btnPruebaSelect = new Button();
            btnSelectMany = new Button();
            btnPruebaWhere = new Button();
            btnPruebaWhereAvanzado = new Button();
            txtFiltro = new TextBox();
            btnOrderBy = new Button();
            label1 = new Label();
            btnPruebaOrderByAvanzado = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).BeginInit();
            SuspendLayout();
            // 
            // dataGridResultados
            // 
            dataGridResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResultados.Location = new Point(249, 171);
            dataGridResultados.Name = "dataGridResultados";
            dataGridResultados.ReadOnly = true;
            dataGridResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridResultados.Size = new Size(637, 332);
            dataGridResultados.TabIndex = 0;
            // 
            // btnPruebaArray
            // 
            btnPruebaArray.Location = new Point(12, 450);
            btnPruebaArray.Name = "btnPruebaArray";
            btnPruebaArray.Size = new Size(102, 53);
            btnPruebaArray.TabIndex = 1;
            btnPruebaArray.Text = "Prueba Array";
            btnPruebaArray.UseVisualStyleBackColor = true;
            btnPruebaArray.Click += btnPruebaArray_Click;
            // 
            // btnPruebaSQL
            // 
            btnPruebaSQL.Location = new Point(141, 450);
            btnPruebaSQL.Name = "btnPruebaSQL";
            btnPruebaSQL.Size = new Size(102, 53);
            btnPruebaSQL.TabIndex = 2;
            btnPruebaSQL.Text = "Prueba SQL";
            btnPruebaSQL.UseVisualStyleBackColor = true;
            btnPruebaSQL.Click += btnPruebaSQL_Click;
            // 
            // btnPruebaSelectMany
            // 
            btnPruebaSelectMany.Location = new Point(12, 372);
            btnPruebaSelectMany.Name = "btnPruebaSelectMany";
            btnPruebaSelectMany.Size = new Size(102, 53);
            btnPruebaSelectMany.TabIndex = 3;
            btnPruebaSelectMany.Text = "Prueba XML";
            btnPruebaSelectMany.UseVisualStyleBackColor = true;
            btnPruebaSelectMany.Click += btnPruebaXML_Click;
            // 
            // btnPruebaJSON
            // 
            btnPruebaJSON.Location = new Point(141, 372);
            btnPruebaJSON.Name = "btnPruebaJSON";
            btnPruebaJSON.Size = new Size(102, 53);
            btnPruebaJSON.TabIndex = 4;
            btnPruebaJSON.Text = "Prueba JSON";
            btnPruebaJSON.UseVisualStyleBackColor = true;
            btnPruebaJSON.Click += btnPruebaJSON_Click;
            // 
            // btnPruebaSelect
            // 
            btnPruebaSelect.Location = new Point(12, 281);
            btnPruebaSelect.Name = "btnPruebaSelect";
            btnPruebaSelect.Size = new Size(102, 53);
            btnPruebaSelect.TabIndex = 5;
            btnPruebaSelect.Text = "Prueba Select";
            btnPruebaSelect.UseVisualStyleBackColor = true;
            btnPruebaSelect.Click += btnPruebaSelect_Click;
            // 
            // btnSelectMany
            // 
            btnSelectMany.BackColor = SystemColors.Highlight;
            btnSelectMany.Location = new Point(141, 281);
            btnSelectMany.Name = "btnSelectMany";
            btnSelectMany.Size = new Size(102, 53);
            btnSelectMany.TabIndex = 6;
            btnSelectMany.Text = "Prueba Select Many";
            btnSelectMany.UseVisualStyleBackColor = false;
            btnSelectMany.Click += btnSelectMany_Click;
            // 
            // btnPruebaWhere
            // 
            btnPruebaWhere.Location = new Point(12, 202);
            btnPruebaWhere.Name = "btnPruebaWhere";
            btnPruebaWhere.Size = new Size(102, 53);
            btnPruebaWhere.TabIndex = 7;
            btnPruebaWhere.Text = "Prueba Where";
            btnPruebaWhere.UseVisualStyleBackColor = true;
            btnPruebaWhere.Click += btnPruebaWhere_Click;
            // 
            // btnPruebaWhereAvanzado
            // 
            btnPruebaWhereAvanzado.Location = new Point(141, 202);
            btnPruebaWhereAvanzado.Name = "btnPruebaWhereAvanzado";
            btnPruebaWhereAvanzado.Size = new Size(102, 53);
            btnPruebaWhereAvanzado.TabIndex = 8;
            btnPruebaWhereAvanzado.Text = "Prueba Where Avanzado";
            btnPruebaWhereAvanzado.UseVisualStyleBackColor = true;
            btnPruebaWhereAvanzado.Click += btnPruebaWhereAvanzado_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(784, 36);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(102, 23);
            txtFiltro.TabIndex = 9;
            // 
            // btnOrderBy
            // 
            btnOrderBy.Location = new Point(12, 115);
            btnOrderBy.Name = "btnOrderBy";
            btnOrderBy.Size = new Size(102, 53);
            btnOrderBy.TabIndex = 10;
            btnOrderBy.Text = "Prueba OrderBy";
            btnOrderBy.UseVisualStyleBackColor = true;
            btnOrderBy.Click += btnOrderBy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(815, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 11;
            label1.Text = "Filtro Where";
            // 
            // btnPruebaOrderByAvanzado
            // 
            btnPruebaOrderByAvanzado.Location = new Point(141, 115);
            btnPruebaOrderByAvanzado.Name = "btnPruebaOrderByAvanzado";
            btnPruebaOrderByAvanzado.Size = new Size(102, 53);
            btnPruebaOrderByAvanzado.TabIndex = 12;
            btnPruebaOrderByAvanzado.Text = "Prueba OrderBy Avanzado";
            btnPruebaOrderByAvanzado.UseVisualStyleBackColor = true;
            btnPruebaOrderByAvanzado.Click += btnPruebaOrderByAvanzado_Click;
            // 
            // PruebasLINQView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 515);
            Controls.Add(btnPruebaOrderByAvanzado);
            Controls.Add(label1);
            Controls.Add(btnOrderBy);
            Controls.Add(txtFiltro);
            Controls.Add(btnPruebaWhereAvanzado);
            Controls.Add(btnPruebaWhere);
            Controls.Add(btnSelectMany);
            Controls.Add(btnPruebaSelect);
            Controls.Add(btnPruebaJSON);
            Controls.Add(btnPruebaSelectMany);
            Controls.Add(btnPruebaSQL);
            Controls.Add(btnPruebaArray);
            Controls.Add(dataGridResultados);
            Name = "PruebasLINQView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pruebas LINQ";
            ((System.ComponentModel.ISupportInitialize)dataGridResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridResultados;
        private Button btnPruebaArray;
        private Button btnPruebaSQL;
        private Button btnPruebaSelectMany;
        private Button btnPruebaJSON;
        private Button btnPruebaSelect;
        private Button btnSelectMany;
        private Button btnPruebaWhere;
        private Button btnPruebaWhereAvanzado;
        private TextBox txtFiltro;
        private Button btnOrderBy;
        private Label label1;
        private Button btnPruebaOrderByAvanzado;
    }
}