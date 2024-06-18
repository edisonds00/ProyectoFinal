namespace GestorMantenimientosTaller.View
{
    partial class frmRegistroMantenimiento
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
            groupBox1 = new GroupBox();
            btnMostrar = new Button();
            cbClientes = new ComboBox();
            btnCancelar = new Button();
            groupBox5 = new GroupBox();
            rdbPreventivo = new RadioButton();
            rdbCorrectivo = new RadioButton();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            repuestosBox = new GroupBox();
            clbRepuestos = new CheckedListBox();
            groupBox3 = new GroupBox();
            clbServicios = new CheckedListBox();
            rtbTrabajo = new RichTextBox();
            label10 = new Label();
            txtDiagnostico = new TextBox();
            label9 = new Label();
            groupBox2 = new GroupBox();
            txtTipo = new TextBox();
            txtAño = new TextBox();
            txtMarca = new TextBox();
            txtPlaca = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cbMecanicos = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            repuestosBox.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMostrar);
            groupBox1.Controls.Add(cbClientes);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(repuestosBox);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(rtbTrabajo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtDiagnostico);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cbMecanicos);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 27);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1195, 649);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de mantenimiento";
            // 
            // btnMostrar
            // 
            btnMostrar.Enabled = false;
            btnMostrar.Location = new Point(998, 588);
            btnMostrar.Margin = new Padding(3, 4, 3, 4);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(159, 32);
            btnMostrar.TabIndex = 27;
            btnMostrar.Text = "Mostrar Factura";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // cbClientes
            // 
            cbClientes.Enabled = false;
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(123, 95);
            cbClientes.Margin = new Padding(3, 4, 3, 4);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(306, 28);
            cbClientes.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(369, 588);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 32);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rdbPreventivo);
            groupBox5.Controls.Add(rdbCorrectivo);
            groupBox5.Location = new Point(781, 291);
            groupBox5.Margin = new Padding(3, 4, 3, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 4, 3, 4);
            groupBox5.Size = new Size(376, 55);
            groupBox5.TabIndex = 24;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tipo de Mantenimiento";
            // 
            // rdbPreventivo
            // 
            rdbPreventivo.AutoSize = true;
            rdbPreventivo.Enabled = false;
            rdbPreventivo.Location = new Point(105, 21);
            rdbPreventivo.Margin = new Padding(3, 4, 3, 4);
            rdbPreventivo.Name = "rdbPreventivo";
            rdbPreventivo.Size = new Size(99, 24);
            rdbPreventivo.TabIndex = 22;
            rdbPreventivo.TabStop = true;
            rdbPreventivo.Text = "Preventivo";
            rdbPreventivo.UseVisualStyleBackColor = true;
            rdbPreventivo.CheckedChanged += rdbPreventivo_CheckedChanged;
            // 
            // rdbCorrectivo
            // 
            rdbCorrectivo.AutoSize = true;
            rdbCorrectivo.Enabled = false;
            rdbCorrectivo.Location = new Point(7, 21);
            rdbCorrectivo.Margin = new Padding(3, 4, 3, 4);
            rdbCorrectivo.Name = "rdbCorrectivo";
            rdbCorrectivo.Size = new Size(98, 24);
            rdbCorrectivo.TabIndex = 23;
            rdbCorrectivo.TabStop = true;
            rdbCorrectivo.Text = "Correctivo";
            rdbCorrectivo.UseVisualStyleBackColor = true;
            rdbCorrectivo.CheckedChanged += rdbCorrectivo_CheckedChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(713, 588);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(93, 32);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(599, 588);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 32);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new Point(485, 588);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 32);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += Guardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(369, 588);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(93, 32);
            btnNuevo.TabIndex = 18;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // repuestosBox
            // 
            repuestosBox.Controls.Add(clbRepuestos);
            repuestosBox.Location = new Point(768, 353);
            repuestosBox.Margin = new Padding(3, 4, 3, 4);
            repuestosBox.Name = "repuestosBox";
            repuestosBox.Padding = new Padding(3, 4, 3, 4);
            repuestosBox.Size = new Size(389, 185);
            repuestosBox.TabIndex = 17;
            repuestosBox.TabStop = false;
            repuestosBox.Text = "Repuestos:";
            repuestosBox.Visible = false;
            // 
            // clbRepuestos
            // 
            clbRepuestos.CheckOnClick = true;
            clbRepuestos.Enabled = false;
            clbRepuestos.FormattingEnabled = true;
            clbRepuestos.Items.AddRange(new object[] { "Filtros de aceite", "Filtros de aire", "Filtros de combustible", "Pastillas de freno", "Discos de freno", "Amortiguadores", "Batería", "Bombillas (para faros, interiores)", "Correas (de distribución, alternador)", "Bujías" });
            clbRepuestos.Location = new Point(13, 36);
            clbRepuestos.Margin = new Padding(3, 4, 3, 4);
            clbRepuestos.MultiColumn = true;
            clbRepuestos.Name = "clbRepuestos";
            clbRepuestos.Size = new Size(354, 114);
            clbRepuestos.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(clbServicios);
            groupBox3.Location = new Point(599, 291);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(163, 248);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Servicios adicionales:";
            // 
            // clbServicios
            // 
            clbServicios.CheckOnClick = true;
            clbServicios.Enabled = false;
            clbServicios.FormattingEnabled = true;
            clbServicios.Items.AddRange(new object[] { "Lavado exterior e interior del vehículo", "Cambio de aceite", "Alineación y balanceo", "Cambio de filtros (aire, aceite, combustible)", "Revisión y carga de refrigerante", "Revisión y ajuste de frenos", "Revisión y ajuste de suspensión", "Limpieza y ajuste de bujías", "Revisión de sistemas eléctricos (luces, batería, alternador)", "Prueba y ajuste de presión de llantas" });
            clbServicios.Location = new Point(11, 36);
            clbServicios.Margin = new Padding(3, 4, 3, 4);
            clbServicios.Name = "clbServicios";
            clbServicios.Size = new Size(140, 180);
            clbServicios.TabIndex = 0;
            // 
            // rtbTrabajo
            // 
            rtbTrabajo.Location = new Point(120, 343);
            rtbTrabajo.Margin = new Padding(3, 4, 3, 4);
            rtbTrabajo.Name = "rtbTrabajo";
            rtbTrabajo.ReadOnly = true;
            rtbTrabajo.Size = new Size(457, 195);
            rtbTrabajo.TabIndex = 13;
            rtbTrabajo.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 347);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 12;
            label10.Text = "Trabajo:";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(120, 291);
            txtDiagnostico.Margin = new Padding(3, 4, 3, 4);
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.ReadOnly = true;
            txtDiagnostico.Size = new Size(457, 27);
            txtDiagnostico.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 295);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 9;
            label9.Text = "Diagnóstico:";
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
            groupBox2.Location = new Point(59, 152);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1097, 111);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del vehículo:";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(871, 48);
            txtTipo.Margin = new Padding(3, 4, 3, 4);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(103, 27);
            txtTipo.TabIndex = 10;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(607, 48);
            txtAño.Margin = new Padding(3, 4, 3, 4);
            txtAño.Name = "txtAño";
            txtAño.ReadOnly = true;
            txtAño.Size = new Size(103, 27);
            txtAño.TabIndex = 9;
            txtAño.KeyPress += soloNumeros;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(359, 48);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.ReadOnly = true;
            txtMarca.Size = new Size(103, 27);
            txtMarca.TabIndex = 5;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(115, 48);
            txtPlaca.Margin = new Padding(3, 4, 3, 4);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.ReadOnly = true;
            txtPlaca.Size = new Size(103, 27);
            txtPlaca.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(826, 52);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 3;
            label8.Text = "Tipo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(563, 52);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 2;
            label7.Text = "Año:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 52);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 1;
            label6.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 52);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 0;
            label5.Text = "Placa:";
            // 
            // cbMecanicos
            // 
            cbMecanicos.Enabled = false;
            cbMecanicos.FormattingEnabled = true;
            cbMecanicos.Location = new Point(525, 97);
            cbMecanicos.Margin = new Padding(3, 4, 3, 4);
            cbMecanicos.Name = "cbMecanicos";
            cbMecanicos.Size = new Size(309, 28);
            cbMecanicos.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(447, 97);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 6;
            label4.Text = "Mecanico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 97);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Cliente:";
            // 
            // txtId
            // 
            txtId.Location = new Point(122, 41);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(82, 27);
            txtId.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(437, 41);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 45);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha de mantenimiento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 45);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // frmRegistroMantenimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 692);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRegistroMantenimiento";
            Text = "frmRegistroMantenimiento";
            Load += frmRegistroMantenimiento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            repuestosBox.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbMecanicos;
        private Label label4;
        private Label label3;
        private TextBox txtId;
        private DateTimePicker dtpFecha;
        private Label label2;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private TextBox txtAño;
        private TextBox txtMarca;
        private TextBox txtPlaca;
        private TextBox txtDiagnostico;
        private Label label9;
        private TextBox txtTipo;
        private RichTextBox rtbTrabajo;
        private Label label10;
        private GroupBox groupBox3;
        private CheckedListBox clbServicios;
        private GroupBox repuestosBox;
        private CheckedListBox clbRepuestos;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnGuardar;
        private Button btnNuevo;
        private GroupBox groupBox5;
        private RadioButton rdbPreventivo;
        private RadioButton rdbCorrectivo;
        private Button btnCancelar;
        private ComboBox cbClientes;
        private Button btnMostrar;
    }
}