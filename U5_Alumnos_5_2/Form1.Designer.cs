namespace U5_Alumnos_5_2
{
    partial class FormAlumno
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
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGrabar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.panelDatosAlumno = new System.Windows.Forms.Panel();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.chkActividad = new System.Windows.Forms.CheckBox();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.chkHijos = new System.Windows.Forms.CheckBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cboCarrera = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.panelDatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 20;
            this.lstAlumnos.Location = new System.Drawing.Point(539, 12);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(261, 324);
            this.lstAlumnos.TabIndex = 15;
            this.lstAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstAlumnos_SelectedIndexChanged);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(160, 388);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(94, 29);
            this.btEditar.TabIndex = 17;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(280, 394);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 18;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(482, 397);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 20;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGrabar
            // 
            this.btGrabar.Location = new System.Drawing.Point(383, 397);
            this.btGrabar.Name = "btGrabar";
            this.btGrabar.Size = new System.Drawing.Size(75, 23);
            this.btGrabar.TabIndex = 19;
            this.btGrabar.Text = "Grabar";
            this.btGrabar.UseVisualStyleBackColor = true;
            this.btGrabar.Click += new System.EventHandler(this.btGrabar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(36, 391);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 16;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(697, 397);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 21;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // panelDatosAlumno
            // 
            this.panelDatosAlumno.Controls.Add(this.lblCarrera);
            this.panelDatosAlumno.Controls.Add(this.lblDoc);
            this.panelDatosAlumno.Controls.Add(this.lblCalle);
            this.panelDatosAlumno.Controls.Add(this.lblNro);
            this.panelDatosAlumno.Controls.Add(this.lblNombre);
            this.panelDatosAlumno.Controls.Add(this.lblFechaNac);
            this.panelDatosAlumno.Controls.Add(this.lblSexo);
            this.panelDatosAlumno.Controls.Add(this.label6);
            this.panelDatosAlumno.Controls.Add(this.lblCantidad);
            this.panelDatosAlumno.Controls.Add(this.lblApellido);
            this.panelDatosAlumno.Controls.Add(this.rbtFemenino);
            this.panelDatosAlumno.Controls.Add(this.rbtMasculino);
            this.panelDatosAlumno.Controls.Add(this.dtpFecha);
            this.panelDatosAlumno.Controls.Add(this.txtDoc);
            this.panelDatosAlumno.Controls.Add(this.chkActividad);
            this.panelDatosAlumno.Controls.Add(this.chkCasado);
            this.panelDatosAlumno.Controls.Add(this.chkHijos);
            this.panelDatosAlumno.Controls.Add(this.cboTipoDocumento);
            this.panelDatosAlumno.Controls.Add(this.cboCarrera);
            this.panelDatosAlumno.Controls.Add(this.txtApellido);
            this.panelDatosAlumno.Controls.Add(this.txtNombre);
            this.panelDatosAlumno.Controls.Add(this.txtCalle);
            this.panelDatosAlumno.Controls.Add(this.txtNro);
            this.panelDatosAlumno.Controls.Add(this.txtCantidad);
            this.panelDatosAlumno.Location = new System.Drawing.Point(12, 5);
            this.panelDatosAlumno.Name = "panelDatosAlumno";
            this.panelDatosAlumno.Size = new System.Drawing.Size(521, 380);
            this.panelDatosAlumno.TabIndex = 58;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(114, 342);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(57, 20);
            this.lblCarrera.TabIndex = 80;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(311, 191);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(36, 20);
            this.lblDoc.TabIndex = 79;
            this.lblDoc.Text = "Doc";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(79, 224);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(42, 20);
            this.lblCalle.TabIndex = 78;
            this.lblCalle.Text = "Calle";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(313, 228);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(34, 20);
            this.lblNro.TabIndex = 77;
            this.lblNro.Text = "Nro";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(114, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 76;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(59, 128);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(128, 20);
            this.lblFechaNac.TabIndex = 75;
            this.lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(103, 157);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 20);
            this.lblSexo.TabIndex = 74;
            this.lblSexo.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Tipo Doc";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(313, 306);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 20);
            this.lblCantidad.TabIndex = 72;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(121, 57);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 71;
            this.lblApellido.Text = "Apellido";
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(296, 155);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(37, 24);
            this.rbtFemenino.TabIndex = 61;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "F";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(229, 160);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(43, 24);
            this.rbtMasculino.TabIndex = 60;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "M";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(229, 123);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 27);
            this.dtpFecha.TabIndex = 59;
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(391, 184);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(76, 27);
            this.txtDoc.TabIndex = 63;
            // 
            // chkActividad
            // 
            this.chkActividad.AutoSize = true;
            this.chkActividad.Location = new System.Drawing.Point(144, 254);
            this.chkActividad.Name = "chkActividad";
            this.chkActividad.Size = new System.Drawing.Size(94, 24);
            this.chkActividad.TabIndex = 66;
            this.chkActividad.Text = "Actividad";
            this.chkActividad.UseVisualStyleBackColor = true;
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(141, 281);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(80, 24);
            this.chkCasado.TabIndex = 67;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // chkHijos
            // 
            this.chkHijos.AutoSize = true;
            this.chkHijos.Location = new System.Drawing.Point(144, 301);
            this.chkHijos.Name = "chkHijos";
            this.chkHijos.Size = new System.Drawing.Size(65, 24);
            this.chkHijos.TabIndex = 68;
            this.chkHijos.Text = "Hijos";
            this.chkHijos.UseVisualStyleBackColor = true;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(144, 187);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(146, 28);
            this.cboTipoDocumento.TabIndex = 62;
            // 
            // cboCarrera
            // 
            this.cboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCarrera.FormattingEnabled = true;
            this.cboCarrera.Location = new System.Drawing.Point(248, 339);
            this.cboCarrera.Name = "cboCarrera";
            this.cboCarrera.Size = new System.Drawing.Size(260, 28);
            this.cboCarrera.TabIndex = 70;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(231, 57);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(250, 27);
            this.txtApellido.TabIndex = 57;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(229, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 27);
            this.txtNombre.TabIndex = 58;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(152, 221);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(138, 27);
            this.txtCalle.TabIndex = 64;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(373, 221);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(76, 27);
            this.txtNro.TabIndex = 65;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(392, 306);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 27);
            this.txtCantidad.TabIndex = 69;
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDatosAlumno);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btGrabar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.lstAlumnos);
            this.Name = "FormAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alumnos";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.FormAlumno_Load);
            this.panelDatosAlumno.ResumeLayout(false);
            this.panelDatosAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox lstAlumnos;
        private Button btEditar;
        private Button btBorrar;
        private Button btCancelar;
        private Button btGrabar;
        private Button btNuevo;
        private Button btSalir;
        private Panel panelDatosAlumno;
        private Label lblCarrera;
        private Label lblDoc;
        private Label lblCalle;
        private Label lblNro;
        private Label lblNombre;
        private Label lblFechaNac;
        private Label lblSexo;
        private Label label6;
        private Label lblCantidad;
        private Label lblApellido;
        private RadioButton rbtFemenino;
        private RadioButton rbtMasculino;
        private DateTimePicker dtpFecha;
        private TextBox txtDoc;
        private CheckBox chkActividad;
        private CheckBox chkCasado;
        private CheckBox chkHijos;
        private ComboBox cboTipoDocumento;
        private ComboBox cboCarrera;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtCalle;
        private TextBox txtNro;
        private TextBox txtCantidad;
    }
}