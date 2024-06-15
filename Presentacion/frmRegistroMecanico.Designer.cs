namespace GestorMantenimientosTaller.View
{
    partial class frmRegistroMecanico
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
            lbNombreMecanico = new Label();
            txtNombreMecanico = new TextBox();
            txtApellidoMecanico = new TextBox();
            lbApellidoMecanico = new Label();
            lbCedulaMecanico = new Label();
            txtCedulaMecanico = new TextBox();
            lbEspecialidadMecanico = new Label();
            lbJornadaMecanico = new Label();
            btnGuardarMecanico = new Button();
            gboxDisponibilidad = new GroupBox();
            cbxJornadaMecanico = new ComboBox();
            cbxEspecialidadMecanico = new ComboBox();
            gBoxIdentificarMecanico = new GroupBox();
            lbIntrucción = new Label();
            btnCancelar = new Button();
            btnBuscarMecanico = new Button();
            btnEliminarMecanico = new Button();
            btnNuevo = new Button();
            gboxDisponibilidad.SuspendLayout();
            gBoxIdentificarMecanico.SuspendLayout();
            SuspendLayout();
            // 
            // lbNombreMecanico
            // 
            lbNombreMecanico.AutoSize = true;
            lbNombreMecanico.Location = new Point(5, 36);
            lbNombreMecanico.Name = "lbNombreMecanico";
            lbNombreMecanico.Size = new Size(54, 15);
            lbNombreMecanico.TabIndex = 0;
            lbNombreMecanico.Text = "Nombre:";
            // 
            // txtNombreMecanico
            // 
            txtNombreMecanico.Location = new Point(68, 34);
            txtNombreMecanico.Margin = new Padding(3, 2, 3, 2);
            txtNombreMecanico.Name = "txtNombreMecanico";
            txtNombreMecanico.ReadOnly = true;
            txtNombreMecanico.Size = new Size(191, 23);
            txtNombreMecanico.TabIndex = 1;
            txtNombreMecanico.KeyPress += soloAlfabeto;
            // 
            // txtApellidoMecanico
            // 
            txtApellidoMecanico.Location = new Point(353, 34);
            txtApellidoMecanico.Margin = new Padding(3, 2, 3, 2);
            txtApellidoMecanico.Name = "txtApellidoMecanico";
            txtApellidoMecanico.ReadOnly = true;
            txtApellidoMecanico.Size = new Size(204, 23);
            txtApellidoMecanico.TabIndex = 2;
            txtApellidoMecanico.KeyPress += soloAlfabeto;
            // 
            // lbApellidoMecanico
            // 
            lbApellidoMecanico.AutoSize = true;
            lbApellidoMecanico.Location = new Point(284, 36);
            lbApellidoMecanico.Name = "lbApellidoMecanico";
            lbApellidoMecanico.Size = new Size(57, 15);
            lbApellidoMecanico.TabIndex = 3;
            lbApellidoMecanico.Text = "Apelllido:";
            // 
            // lbCedulaMecanico
            // 
            lbCedulaMecanico.AutoSize = true;
            lbCedulaMecanico.Location = new Point(602, 36);
            lbCedulaMecanico.Name = "lbCedulaMecanico";
            lbCedulaMecanico.Size = new Size(47, 15);
            lbCedulaMecanico.TabIndex = 4;
            lbCedulaMecanico.Text = "Cédula:";
            // 
            // txtCedulaMecanico
            // 
            txtCedulaMecanico.Location = new Point(658, 34);
            txtCedulaMecanico.Margin = new Padding(3, 2, 3, 2);
            txtCedulaMecanico.Name = "txtCedulaMecanico";
            txtCedulaMecanico.Size = new Size(110, 23);
            txtCedulaMecanico.TabIndex = 5;
            txtCedulaMecanico.KeyPress += soloNumeros;
            // 
            // lbEspecialidadMecanico
            // 
            lbEspecialidadMecanico.AutoSize = true;
            lbEspecialidadMecanico.Location = new Point(5, 43);
            lbEspecialidadMecanico.Name = "lbEspecialidadMecanico";
            lbEspecialidadMecanico.Size = new Size(75, 15);
            lbEspecialidadMecanico.TabIndex = 6;
            lbEspecialidadMecanico.Text = "Especialidad:";
            // 
            // lbJornadaMecanico
            // 
            lbJornadaMecanico.AutoSize = true;
            lbJornadaMecanico.Location = new Point(510, 43);
            lbJornadaMecanico.Name = "lbJornadaMecanico";
            lbJornadaMecanico.Size = new Size(51, 15);
            lbJornadaMecanico.TabIndex = 8;
            lbJornadaMecanico.Text = "Jornada:";
            // 
            // btnGuardarMecanico
            // 
            btnGuardarMecanico.Location = new Point(302, 204);
            btnGuardarMecanico.Margin = new Padding(3, 2, 3, 2);
            btnGuardarMecanico.Name = "btnGuardarMecanico";
            btnGuardarMecanico.Size = new Size(82, 22);
            btnGuardarMecanico.TabIndex = 10;
            btnGuardarMecanico.Text = "Guardar";
            btnGuardarMecanico.UseVisualStyleBackColor = true;
            btnGuardarMecanico.Click += btnGuardarMecanico_Click_1;
            // 
            // gboxDisponibilidad
            // 
            gboxDisponibilidad.Controls.Add(cbxJornadaMecanico);
            gboxDisponibilidad.Controls.Add(cbxEspecialidadMecanico);
            gboxDisponibilidad.Controls.Add(lbEspecialidadMecanico);
            gboxDisponibilidad.Controls.Add(lbJornadaMecanico);
            gboxDisponibilidad.Location = new Point(10, 124);
            gboxDisponibilidad.Margin = new Padding(3, 2, 3, 2);
            gboxDisponibilidad.Name = "gboxDisponibilidad";
            gboxDisponibilidad.Padding = new Padding(3, 2, 3, 2);
            gboxDisponibilidad.Size = new Size(794, 72);
            gboxDisponibilidad.TabIndex = 11;
            gboxDisponibilidad.TabStop = false;
            gboxDisponibilidad.Text = "Disponibilidad";
            // 
            // cbxJornadaMecanico
            // 
            cbxJornadaMecanico.Enabled = false;
            cbxJornadaMecanico.FormattingEnabled = true;
            cbxJornadaMecanico.Location = new Point(570, 40);
            cbxJornadaMecanico.Margin = new Padding(3, 2, 3, 2);
            cbxJornadaMecanico.Name = "cbxJornadaMecanico";
            cbxJornadaMecanico.Size = new Size(197, 23);
            cbxJornadaMecanico.TabIndex = 10;
            // 
            // cbxEspecialidadMecanico
            // 
            cbxEspecialidadMecanico.Enabled = false;
            cbxEspecialidadMecanico.FormattingEnabled = true;
            cbxEspecialidadMecanico.Location = new Point(94, 40);
            cbxEspecialidadMecanico.Margin = new Padding(3, 2, 3, 2);
            cbxEspecialidadMecanico.Name = "cbxEspecialidadMecanico";
            cbxEspecialidadMecanico.Size = new Size(347, 23);
            cbxEspecialidadMecanico.TabIndex = 9;
            // 
            // gBoxIdentificarMecanico
            // 
            gBoxIdentificarMecanico.Controls.Add(lbNombreMecanico);
            gBoxIdentificarMecanico.Controls.Add(txtNombreMecanico);
            gBoxIdentificarMecanico.Controls.Add(lbApellidoMecanico);
            gBoxIdentificarMecanico.Controls.Add(txtCedulaMecanico);
            gBoxIdentificarMecanico.Controls.Add(txtApellidoMecanico);
            gBoxIdentificarMecanico.Controls.Add(lbCedulaMecanico);
            gBoxIdentificarMecanico.Location = new Point(10, 35);
            gBoxIdentificarMecanico.Margin = new Padding(3, 2, 3, 2);
            gBoxIdentificarMecanico.Name = "gBoxIdentificarMecanico";
            gBoxIdentificarMecanico.Padding = new Padding(3, 2, 3, 2);
            gBoxIdentificarMecanico.Size = new Size(794, 72);
            gBoxIdentificarMecanico.TabIndex = 12;
            gBoxIdentificarMecanico.TabStop = false;
            gBoxIdentificarMecanico.Text = "Datos de Identificación";
            // 
            // lbIntrucción
            // 
            lbIntrucción.AutoSize = true;
            lbIntrucción.Location = new Point(10, 7);
            lbIntrucción.Name = "lbIntrucción";
            lbIntrucción.Size = new Size(227, 15);
            lbIntrucción.TabIndex = 13;
            lbIntrucción.Text = "A continuación, complete la información:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(202, 204);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelarMecanico_Click;
            // 
            // btnBuscarMecanico
            // 
            btnBuscarMecanico.Location = new Point(411, 204);
            btnBuscarMecanico.Margin = new Padding(3, 2, 3, 2);
            btnBuscarMecanico.Name = "btnBuscarMecanico";
            btnBuscarMecanico.Size = new Size(82, 22);
            btnBuscarMecanico.TabIndex = 15;
            btnBuscarMecanico.Text = "Buscar";
            btnBuscarMecanico.UseVisualStyleBackColor = true;
            btnBuscarMecanico.Click += btnBuscarMecanico_Click;
            // 
            // btnEliminarMecanico
            // 
            btnEliminarMecanico.Location = new Point(520, 204);
            btnEliminarMecanico.Margin = new Padding(3, 2, 3, 2);
            btnEliminarMecanico.Name = "btnEliminarMecanico";
            btnEliminarMecanico.Size = new Size(82, 22);
            btnEliminarMecanico.TabIndex = 16;
            btnEliminarMecanico.Text = "Eliminar";
            btnEliminarMecanico.UseVisualStyleBackColor = true;
            btnEliminarMecanico.Click += btnEliminarMecanico_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(202, 204);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(82, 22);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevoMecanico_Click;
            // 
            // frmRegistroMecanico
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 232);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminarMecanico);
            Controls.Add(btnBuscarMecanico);
            Controls.Add(btnCancelar);
            Controls.Add(lbIntrucción);
            Controls.Add(gBoxIdentificarMecanico);
            Controls.Add(gboxDisponibilidad);
            Controls.Add(btnGuardarMecanico);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmRegistroMecanico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Nuevo Mecánico";
            gboxDisponibilidad.ResumeLayout(false);
            gboxDisponibilidad.PerformLayout();
            gBoxIdentificarMecanico.ResumeLayout(false);
            gBoxIdentificarMecanico.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombreMecanico;
        private TextBox txtNombreMecanico;
        private TextBox txtApellidoMecanico;
        private Label lbApellidoMecanico;
        private Label lbCedulaMecanico;
        private TextBox txtCedulaMecanico;
        private TextBox txtEspecialidadMecanico;
        private Label lbEspecialidadMecanico;
        private TextBox txtCorreoMecanico;
        private Label lbJornadaMecanico;
        private Button btnGuardarMecanico;
        private GroupBox gboxDisponibilidad;
        private GroupBox gBoxIdentificarMecanico;
        private Label lbIntrucción;
        private ComboBox cbxJornadaMecanico;
        private ComboBox cbxEspecialidadMecanico;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnCancelar;
        private Button btnBuscarMecanico;
        private Button btnEliminarMecanico;
        private Button btnNuevo;


    }
}