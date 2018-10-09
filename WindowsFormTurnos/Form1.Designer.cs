namespace WindowsFormTurnos
{
    partial class Form1
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
            this.lblTurnosCancelados = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFiltrarTurnos = new System.Windows.Forms.TextBox();
            this.btnCargarListado = new System.Windows.Forms.Button();
            this.btnUpdateListado = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckbEritro = new System.Windows.Forms.CheckBox();
            this.ckbReti = new System.Windows.Forms.CheckBox();
            this.ckbCito = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbExt = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbrirAdmPacientes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.btnGrabarTurno = new System.Windows.Forms.Button();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExisteTurno = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVerificarTurno = new System.Windows.Forms.Button();
            this.txtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.cboHora = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurnosCancelados
            // 
            this.lblTurnosCancelados.AutoSize = true;
            this.lblTurnosCancelados.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTurnosCancelados.ForeColor = System.Drawing.Color.Red;
            this.lblTurnosCancelados.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTurnosCancelados.Location = new System.Drawing.Point(531, 509);
            this.lblTurnosCancelados.Name = "lblTurnosCancelados";
            this.lblTurnosCancelados.Size = new System.Drawing.Size(26, 18);
            this.lblTurnosCancelados.TabIndex = 65;
            this.lblTurnosCancelados.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(353, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 18);
            this.label11.TabIndex = 64;
            this.label11.Text = "Turnos cancelados";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(587, 501);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 31);
            this.button2.TabIndex = 63;
            this.button2.Text = "Ver";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(7, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 18);
            this.label10.TabIndex = 62;
            this.label10.Text = "Filtrar turno por DNI";
            // 
            // txtFiltrarTurnos
            // 
            this.txtFiltrarTurnos.Location = new System.Drawing.Point(200, 510);
            this.txtFiltrarTurnos.MaxLength = 8;
            this.txtFiltrarTurnos.Name = "txtFiltrarTurnos";
            this.txtFiltrarTurnos.Size = new System.Drawing.Size(120, 20);
            this.txtFiltrarTurnos.TabIndex = 61;
            // 
            // btnCargarListado
            // 
            this.btnCargarListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarListado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarListado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCargarListado.Location = new System.Drawing.Point(5, 554);
            this.btnCargarListado.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarListado.Name = "btnCargarListado";
            this.btnCargarListado.Size = new System.Drawing.Size(193, 46);
            this.btnCargarListado.TabIndex = 60;
            this.btnCargarListado.Text = "Cargar Listado";
            this.btnCargarListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarListado.UseVisualStyleBackColor = true;
            // 
            // btnUpdateListado
            // 
            this.btnUpdateListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateListado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateListado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdateListado.Location = new System.Drawing.Point(1117, 404);
            this.btnUpdateListado.Name = "btnUpdateListado";
            this.btnUpdateListado.Size = new System.Drawing.Size(40, 41);
            this.btnUpdateListado.TabIndex = 59;
            this.btnUpdateListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateListado.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.ckbEritro);
            this.groupBox4.Controls.Add(this.ckbReti);
            this.groupBox4.Controls.Add(this.ckbCito);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(668, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 105);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pedidos";
            // 
            // ckbEritro
            // 
            this.ckbEritro.AutoSize = true;
            this.ckbEritro.Checked = true;
            this.ckbEritro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbEritro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbEritro.Location = new System.Drawing.Point(26, 26);
            this.ckbEritro.Name = "ckbEritro";
            this.ckbEritro.Size = new System.Drawing.Size(202, 22);
            this.ckbEritro.TabIndex = 2;
            this.ckbEritro.Text = "Eritrosedimentación";
            this.ckbEritro.UseVisualStyleBackColor = true;
            // 
            // ckbReti
            // 
            this.ckbReti.AutoSize = true;
            this.ckbReti.Checked = true;
            this.ckbReti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbReti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbReti.Location = new System.Drawing.Point(26, 51);
            this.ckbReti.Name = "ckbReti";
            this.ckbReti.Size = new System.Drawing.Size(137, 22);
            this.ckbReti.TabIndex = 3;
            this.ckbReti.Text = "Reticulocitos";
            this.ckbReti.UseVisualStyleBackColor = true;
            // 
            // ckbCito
            // 
            this.ckbCito.AutoSize = true;
            this.ckbCito.Checked = true;
            this.ckbCito.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCito.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbCito.Location = new System.Drawing.Point(26, 77);
            this.ckbCito.Name = "ckbCito";
            this.ckbCito.Size = new System.Drawing.Size(111, 22);
            this.ckbCito.TabIndex = 1;
            this.ckbCito.Text = "Citológico";
            this.ckbCito.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.ckbExt);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(668, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 97);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acto Bioquimico";
            // 
            // ckbExt
            // 
            this.ckbExt.AutoSize = true;
            this.ckbExt.Checked = true;
            this.ckbExt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbExt.Enabled = false;
            this.ckbExt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckbExt.Location = new System.Drawing.Point(26, 45);
            this.ckbExt.Name = "ckbExt";
            this.ckbExt.Size = new System.Drawing.Size(212, 22);
            this.ckbExt.TabIndex = 0;
            this.ckbExt.Text = "Extracción de sangre";
            this.ckbExt.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(5, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(993, 30);
            this.label6.TabIndex = 55;
            this.label6.Text = "Listado de Turnos ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(1005, 510);
            this.txtBuscar.MaxLength = 8;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(105, 20);
            this.txtBuscar.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(916, 505);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 27);
            this.button1.TabIndex = 50;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAbrirAdmPacientes
            // 
            this.btnAbrirAdmPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAbrirAdmPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirAdmPacientes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnAbrirAdmPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirAdmPacientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAbrirAdmPacientes.Location = new System.Drawing.Point(1117, 453);
            this.btnAbrirAdmPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirAdmPacientes.Name = "btnAbrirAdmPacientes";
            this.btnAbrirAdmPacientes.Size = new System.Drawing.Size(40, 40);
            this.btnAbrirAdmPacientes.TabIndex = 51;
            this.btnAbrirAdmPacientes.Text = "...";
            this.btnAbrirAdmPacientes.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalir.Location = new System.Drawing.Point(964, 554);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(193, 46);
            this.btnSalir.TabIndex = 49;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lstPacientes
            // 
            this.lstPacientes.Font = new System.Drawing.Font("Verdana", 12F);
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 18;
            this.lstPacientes.Location = new System.Drawing.Point(1005, 75);
            this.lstPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(105, 418);
            this.lstPacientes.TabIndex = 54;
            // 
            // btnGrabarTurno
            // 
            this.btnGrabarTurno.Enabled = false;
            this.btnGrabarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabarTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabarTurno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGrabarTurno.Location = new System.Drawing.Point(553, 554);
            this.btnGrabarTurno.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabarTurno.Name = "btnGrabarTurno";
            this.btnGrabarTurno.Size = new System.Drawing.Size(193, 46);
            this.btnGrabarTurno.TabIndex = 47;
            this.btnGrabarTurno.Text = "Generar Turno";
            this.btnGrabarTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabarTurno.UseVisualStyleBackColor = true;
            this.btnGrabarTurno.Click += new System.EventHandler(this.btnGrabarTurno_Click);
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarTurno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminarTurno.Location = new System.Drawing.Point(758, 554);
            this.btnEliminarTurno.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(193, 46);
            this.btnEliminarTurno.TabIndex = 48;
            this.btnEliminarTurno.Text = "Cancelar Turno";
            this.btnEliminarTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarTurno.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblHoraActual);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblExisteTurno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnVerificarTurno);
            this.groupBox1.Controls.Add(this.txtCodigoPaciente);
            this.groupBox1.Controls.Add(this.cboHora);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(5, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(656, 208);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos turno";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(401, 80);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(133, 27);
            this.txtFecha.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(321, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(26, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Hora Actual:";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.BackColor = System.Drawing.Color.Black;
            this.lblHoraActual.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblHoraActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHoraActual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHoraActual.Location = new System.Drawing.Point(193, 173);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(0, 25);
            this.lblHoraActual.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(401, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(248, 27);
            this.txtNombre.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(319, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // lblExisteTurno
            // 
            this.lblExisteTurno.AutoSize = true;
            this.lblExisteTurno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblExisteTurno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblExisteTurno.Location = new System.Drawing.Point(494, 176);
            this.lblExisteTurno.Name = "lblExisteTurno";
            this.lblExisteTurno.Size = new System.Drawing.Size(26, 18);
            this.lblExisteTurno.TabIndex = 14;
            this.lblExisteTurno.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(28, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Código paciente";
            // 
            // btnVerificarTurno
            // 
            this.btnVerificarTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVerificarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificarTurno.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnVerificarTurno.ForeColor = System.Drawing.Color.White;
            this.btnVerificarTurno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVerificarTurno.Location = new System.Drawing.Point(284, 169);
            this.btnVerificarTurno.Name = "btnVerificarTurno";
            this.btnVerificarTurno.Size = new System.Drawing.Size(193, 32);
            this.btnVerificarTurno.TabIndex = 1;
            this.btnVerificarTurno.Text = "Verificar Turno ";
            this.btnVerificarTurno.UseVisualStyleBackColor = false;
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.Enabled = false;
            this.txtCodigoPaciente.Location = new System.Drawing.Point(180, 46);
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.ReadOnly = true;
            this.txtCodigoPaciente.Size = new System.Drawing.Size(133, 27);
            this.txtCodigoPaciente.TabIndex = 8;
            // 
            // cboHora
            // 
            this.cboHora.FormattingEnabled = true;
            this.cboHora.Location = new System.Drawing.Point(180, 112);
            this.cboHora.Margin = new System.Windows.Forms.Padding(4);
            this.cboHora.Name = "cboHora";
            this.cboHora.Size = new System.Drawing.Size(133, 26);
            this.cboHora.TabIndex = 0;
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(180, 80);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(133, 27);
            this.txtDni.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(28, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Paciente DNI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(1, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(997, 163);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(4, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(993, 223);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 621);
            this.Controls.Add(this.lblTurnosCancelados);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFiltrarTurnos);
            this.Controls.Add(this.btnCargarListado);
            this.Controls.Add(this.btnUpdateListado);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAbrirAdmPacientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lstPacientes);
            this.Controls.Add(this.btnGrabarTurno);
            this.Controls.Add(this.btnEliminarTurno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Turnos";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnosCancelados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFiltrarTurnos;
        private System.Windows.Forms.Button btnCargarListado;
        private System.Windows.Forms.Button btnUpdateListado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckbEritro;
        private System.Windows.Forms.CheckBox ckbReti;
        private System.Windows.Forms.CheckBox ckbCito;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckbExt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAbrirAdmPacientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Button btnGrabarTurno;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExisteTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVerificarTurno;
        private System.Windows.Forms.TextBox txtCodigoPaciente;
        private System.Windows.Forms.ComboBox cboHora;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

