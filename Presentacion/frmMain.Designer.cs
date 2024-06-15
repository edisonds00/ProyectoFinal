namespace WinFormsApp1
{
    partial class frmMain
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
            registroToolStripMenuItem = new ToolStripMenuItem();
            registrarClienteToolStripMenuItem = new ToolStripMenuItem();
            nuevoVehículoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            nuevoMantenimientoToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarClienteToolStripMenuItem, nuevoVehículoToolStripMenuItem, nuevoToolStripMenuItem, nuevoMantenimientoToolStripMenuItem });
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(78, 24);
            registroToolStripMenuItem.Text = "Registro";
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // registrarClienteToolStripMenuItem
            // 
            registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            registrarClienteToolStripMenuItem.Size = new Size(240, 26);
            registrarClienteToolStripMenuItem.Text = "Nuevo Cliente";
            registrarClienteToolStripMenuItem.Click += registrarClienteToolStripMenuItem_Click;
            // 
            // nuevoVehículoToolStripMenuItem
            // 
            nuevoVehículoToolStripMenuItem.Name = "nuevoVehículoToolStripMenuItem";
            nuevoVehículoToolStripMenuItem.Size = new Size(240, 26);
            nuevoVehículoToolStripMenuItem.Text = "Nuevo Vehículo";
            nuevoVehículoToolStripMenuItem.Click += nuevoVehículoToolStripMenuItem_Click;
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(240, 26);
            nuevoToolStripMenuItem.Text = "Nuevo Mecánico";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // nuevoMantenimientoToolStripMenuItem
            // 
            nuevoMantenimientoToolStripMenuItem.Name = "nuevoMantenimientoToolStripMenuItem";
            nuevoMantenimientoToolStripMenuItem.Size = new Size(240, 26);
            nuevoMantenimientoToolStripMenuItem.Text = "Nuevo Mantenimiento";
            nuevoMantenimientoToolStripMenuItem.Click += nuevoMantenimientoToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(97, 24);
            acercaDeToolStripMenuItem.Text = "Integrantes";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registroToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            Text = "Gestor de Mantenimientos";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmMain_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem registrarClienteToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem nuevoMantenimientoToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevoVehículoToolStripMenuItem;
    }
}