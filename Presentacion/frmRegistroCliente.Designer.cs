namespace GestorMantenimientosTaller.View
{
    partial class frmRegistroCliente
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
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1 = new Panel();
            txtCedula = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            txtdireccion = new TextBox();
            txtTelefono = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            btnGuardar = new Button();
            btnNuevo = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(25, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 71);
            panel1.TabIndex = 0;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(128, 26);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(106, 23);
            txtCedula.TabIndex = 5;
            txtCedula.KeyPress += soloNumeros;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(578, 26);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(147, 23);
            txtApellido.TabIndex = 4;
            txtApellido.KeyPress += soloAlfabeto;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 29);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 2;
            label4.Text = "Número de cédula:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(320, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(133, 23);
            txtNombre.TabIndex = 3;
            txtNombre.KeyPress += soloAlfabeto;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 29);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(513, 29);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 1;
            label3.Text = "Apellidos:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtdireccion);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(25, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(742, 71);
            panel2.TabIndex = 1;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(475, 23);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.ReadOnly = true;
            txtdireccion.Size = new Size(142, 23);
            txtdireccion.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(161, 23);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(139, 23);
            txtTelefono.TabIndex = 2;
            txtTelefono.KeyPress += soloNumerosTelefono;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 26);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 1;
            label6.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 26);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 0;
            label5.Text = "Teléfono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 15);
            label1.TabIndex = 2;
            label1.Text = "Complete la siguiente información:";
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new Point(274, 199);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 32);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += Guardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(142, 199);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(97, 32);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(422, 199);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 32);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(567, 199);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 32);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(142, 199);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 32);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmRegistroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 245);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmRegistroCliente";
            Text = "frmRegistroCliente";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnGuardar;
        private TextBox txtdireccion;
        private TextBox txtTelefono;
        private TextBox txtCedula;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnCancelar;
    }
}