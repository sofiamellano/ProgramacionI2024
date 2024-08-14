namespace CiclismoDesktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            principalToolStripMenuItem = new ToolStripMenuItem();
            gestionDeClientesToolStripMenuItem = new ToolStripMenuItem();
            gestionDeEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            gestionDeProductosToolStripMenuItem = new ToolStripMenuItem();
            gestionDeTipoDeProductoToolStripMenuItem = new ToolStripMenuItem();
            gestionDeClientesStoredProceduresToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            gestionClientesORMToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { principalToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            principalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDeClientesToolStripMenuItem, gestionDeEmpleadosToolStripMenuItem, gestionDeProductosToolStripMenuItem, gestionDeTipoDeProductoToolStripMenuItem, gestionDeClientesStoredProceduresToolStripMenuItem, gestionClientesORMToolStripMenuItem });
            principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            principalToolStripMenuItem.Size = new Size(65, 20);
            principalToolStripMenuItem.Text = "Principal";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            gestionDeClientesToolStripMenuItem.Size = new Size(274, 22);
            gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            gestionDeClientesToolStripMenuItem.Click += gestionDeClientesToolStripMenuItem_Click;
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            gestionDeEmpleadosToolStripMenuItem.Size = new Size(274, 22);
            gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de Empleados";
            gestionDeEmpleadosToolStripMenuItem.Click += gestionDeEmpleadosToolStripMenuItem_Click;
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            gestionDeProductosToolStripMenuItem.Size = new Size(274, 22);
            gestionDeProductosToolStripMenuItem.Text = "Gestion de Productos";
            gestionDeProductosToolStripMenuItem.Click += gestionDeProductosToolStripMenuItem_Click;
            // 
            // gestionDeTipoDeProductoToolStripMenuItem
            // 
            gestionDeTipoDeProductoToolStripMenuItem.Name = "gestionDeTipoDeProductoToolStripMenuItem";
            gestionDeTipoDeProductoToolStripMenuItem.Size = new Size(274, 22);
            gestionDeTipoDeProductoToolStripMenuItem.Text = "Gestion de Tipo de Producto";
            gestionDeTipoDeProductoToolStripMenuItem.Click += gestionDeTipoDeProductoToolStripMenuItem_Click;
            // 
            // gestionDeClientesStoredProceduresToolStripMenuItem
            // 
            gestionDeClientesStoredProceduresToolStripMenuItem.Name = "gestionDeClientesStoredProceduresToolStripMenuItem";
            gestionDeClientesStoredProceduresToolStripMenuItem.Size = new Size(274, 22);
            gestionDeClientesStoredProceduresToolStripMenuItem.Text = "Gestion de Clientes Stored Procedures";
            gestionDeClientesStoredProceduresToolStripMenuItem.Click += gestionDeClientesStoredProceduresToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirDelSistemaToolStripMenuItem });
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            salirDelSistemaToolStripMenuItem.Size = new Size(159, 22);
            salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            salirDelSistemaToolStripMenuItem.Click += salirDelSistemaToolStripMenuItem_Click;
            // 
            // gestionClientesORMToolStripMenuItem
            // 
            gestionClientesORMToolStripMenuItem.Name = "gestionClientesORMToolStripMenuItem";
            gestionClientesORMToolStripMenuItem.Size = new Size(274, 22);
            gestionClientesORMToolStripMenuItem.Text = "Gestion Clientes ORM";
            gestionClientesORMToolStripMenuItem.Click += gestionClientesORMToolStripMenuItem_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ciclismo Desktop Por Codigo";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem principalToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private ToolStripMenuItem gestionDeEmpleadosToolStripMenuItem;
        private ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private ToolStripMenuItem gestionDeTipoDeProductoToolStripMenuItem;
        private ToolStripMenuItem gestionDeClientesStoredProceduresToolStripMenuItem;
        private ToolStripMenuItem gestionClientesORMToolStripMenuItem;
    }
}
