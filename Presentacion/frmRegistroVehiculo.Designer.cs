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
            dgvVehiculos.Location = new Point(14, 299);
            dgvVehiculos.Margin = new Padding(3, 4, 3, 4);
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.RowHeadersWidth = 51;
            dgvVehiculos.RowTemplate.Height = 25;
            dgvVehiculos.Size = new Size(559, 285);
            dgvVehiculos.TabIndex = 0;
            dgvVehiculos.CellClick += dgvVehiculos_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(71, 16);
            cbClientes.Margin = new Padding(3, 4, 3, 4);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(189, 28);
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
            groupBox2.Location = new Point(14, 71);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(558, 152);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del vehículo:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(341, 107);
            txtTipo.Margin = new Padding(3, 4, 3, 4);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(103, 27);
            txtTipo.TabIndex = 10;
            txtTipo.KeyPress += soloAlfabeto;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(151, 107);
            txtAño.Margin = new Padding(3, 4, 3, 4);
            txtAño.Name = "txtAño";
            txtAño.ReadOnly = true;
            txtAño.Size = new Size(103, 27);
            txtAño.TabIndex = 9;
            txtAño.KeyPress += soloNumeros;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(341, 41);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.ReadOnly = true;
            txtMarca.Size = new Size(103, 27);
            txtMarca.TabIndex = 5;
            txtMarca.KeyPress += soloAlfabeto;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(151, 41);
            txtPlaca.Margin = new Padding(3, 4, 3, 4);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.ReadOnly = true;
            txtPlaca.Size = new Size(103, 27);
            txtPlaca.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(285, 111);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 3;
            label8.Text = "Tipo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(107, 111);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 2;
            label7.Text = "Año:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(285, 45);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 1;
            label6.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 45);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 0;
            label5.Text = "Placa:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(120, 247);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(86, 31);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new Point(250, 247);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(373, 247);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(121, 247);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmRegistroVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 600);
            Controls.Add(dgvVehiculos);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(cbClientes);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox2);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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