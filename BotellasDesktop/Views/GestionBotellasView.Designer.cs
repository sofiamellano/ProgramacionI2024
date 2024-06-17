namespace BotellasDesktop.Views
{
    partial class GestionBotellasView
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
            dataGridBotellas = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridBotellas).BeginInit();
            SuspendLayout();
            // 
            // dataGridBotellas
            // 
            dataGridBotellas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridBotellas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBotellas.Location = new Point(12, 12);
            dataGridBotellas.Name = "dataGridBotellas";
            dataGridBotellas.ReadOnly = true;
            dataGridBotellas.RowHeadersVisible = false;
            dataGridBotellas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridBotellas.Size = new Size(860, 373);
            dataGridBotellas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.Location = new Point(40, 405);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom;
            btnEditar.Location = new Point(152, 405);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "E&ditar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(270, 405);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(797, 408);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // GestionBotellasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 443);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridBotellas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionBotellasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestion de Botellas";
            ((System.ComponentModel.ISupportInitialize)dataGridBotellas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridBotellas;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}