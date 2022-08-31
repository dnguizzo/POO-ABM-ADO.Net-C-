namespace U5_Libros_5_4
{
    partial class Form1
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
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblFormato = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rbtImpreso = new System.Windows.Forms.RadioButton();
            this.rbtDigital = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstLibros
            // 
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.ItemHeight = 20;
            this.lstLibros.Location = new System.Drawing.Point(475, 26);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.Size = new System.Drawing.Size(297, 284);
            this.lstLibros.TabIndex = 7;
            this.lstLibros.SelectedIndexChanged += new System.EventHandler(this.lstLibros_SelectedIndexChanged);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(290, 233);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 27);
            this.txtImporte.TabIndex = 4;
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(290, 106);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(100, 27);
            this.textTitulo.TabIndex = 2;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(290, 47);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 27);
            this.textCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(44, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(44, 106);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 20);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Título";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(44, 176);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(57, 20);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "Género";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(44, 236);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(62, 20);
            this.lblImporte.TabIndex = 15;
            this.lblImporte.Text = "Importe";
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(44, 290);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(65, 20);
            this.lblFormato.TabIndex = 17;
            this.lblFormato.Text = "Formato";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(269, 173);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 28);
            this.cboGenero.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(60, 386);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(269, 386);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 9;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(432, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(635, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rbtImpreso
            // 
            this.rbtImpreso.AutoSize = true;
            this.rbtImpreso.Location = new System.Drawing.Point(181, 286);
            this.rbtImpreso.Name = "rbtImpreso";
            this.rbtImpreso.Size = new System.Drawing.Size(106, 24);
            this.rbtImpreso.TabIndex = 5;
            this.rbtImpreso.TabStop = true;
            this.rbtImpreso.Text = "1 - Impreso";
            this.rbtImpreso.UseVisualStyleBackColor = true;
            // 
            // rbtDigital
            // 
            this.rbtDigital.AutoSize = true;
            this.rbtDigital.Location = new System.Drawing.Point(332, 286);
            this.rbtDigital.Name = "rbtDigital";
            this.rbtDigital.Size = new System.Drawing.Size(97, 24);
            this.rbtDigital.TabIndex = 6;
            this.rbtDigital.TabStop = true;
            this.rbtDigital.Text = "2 - Digital";
            this.rbtDigital.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtDigital);
            this.Controls.Add(this.rbtImpreso);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lstLibros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstLibros;
        private TextBox txtImporte;
        private TextBox textTitulo;
        private TextBox textCodigo;
        private Label lblCodigo;
        private Label lblTitulo;
        private Label lblGenero;
        private Label lblImporte;
        private Label lblFormato;
        private ComboBox cboGenero;
        private Button btnNuevo;
        private Button btnGrabar;
        private Button btnCancelar;
        private Button btnSalir;
        private RadioButton rbtImpreso;
        private RadioButton rbtDigital;
    }
}