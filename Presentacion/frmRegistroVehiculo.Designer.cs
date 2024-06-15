namespace Presentación.Formularios
{
    partial class frmRegistroVehiculo
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
            dgvVehiculos = new DataGridView();
            label1 = new Label();
            cbClientes = new ComboBox();
            groupBox2 = new GroupBox();
            txtTipo = new TextBox();
            txtAño = new TextBox();
            txtMarca = new TextBox();
            txtPlaca = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Location = new Point(12, 224);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.RowTemplate.Height = 25;
            dgvVehiculos.Size = new Size(489, 214);
            dgvVehiculos.TabIndex = 0;
            dgvVehiculos.CellClick += dgvVehiculos_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(62, 12);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(166, 23);
            cbClientes.TabIndex = 11;
            cbClientes.SelectedIndexChanged += cbClientes_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTipo);
            groupBox2.Controls.Add(txtAño);
            groupBox2.Controls.Add(txtMarca);
            groupBox2.Controls.Add(txtPlaca);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(488, 114);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del vehículo:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(298, 80);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(91, 23);
            txtTipo.TabIndex = 10;
            txtTipo.KeyPress += soloAlfabeto;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(132, 80);
            txtAño.Name = "txtAño";
            txtAño.ReadOnly = true;
            txtAño.Size = new Size(91, 23);
            txtAño.TabIndex = 9;
            txtAño.KeyPress += soloNumeros;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(298, 31);
            txtMarca.Name = "txtMarca";
            txtMarca.ReadOnly = true;
            txtMarca.Size = new Size(91, 23);
            txtMarca.TabIndex = 5;
            txtMarca.KeyPress += soloAlfabeto;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(132, 31);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.ReadOnly = true;
            txtPlaca.Size = new Size(91, 23);
            txtPlaca.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(249, 83);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 3;
            label8.Text = "Tipo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 83);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 2;
            label7.Text = "Año:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 34);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 1;
            label6.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 34);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 0;
            label5.Text = "Placa:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(105, 185);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new Point(219, 185);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += Guardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(326, 185);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(106, 185);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmRegistroVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
            Controls.Add(dgvVehiculos);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(cbClientes);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox2);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Name = "frmRegistroVehiculo";
            Text = "Gestor de Vehículos";
            Load += frmVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvVehiculos;
        private ComboBox cbClientes;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtTipo;
        private TextBox txtAño;
        private TextBox txtMarca;
        private TextBox txtPlaca;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}