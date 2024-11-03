namespace Matricula_GUI
{
    partial class ActualizarAlumnoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            btnImagen = new Button();
            perfilBox = new PictureBox();
            cboCarreras = new ComboBox();
            btnCancelar = new Button();
            brnGrabar = new Button();
            checkCertificado = new CheckBox();
            checkEstado = new CheckBox();
            lblDni = new Label();
            groupBox2 = new GroupBox();
            radioFemenino = new RadioButton();
            radioMasculino = new RadioButton();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDepartamento = new ComboBox();
            txtDomicilio = new TextBox();
            mskCelular = new MaskedTextBox();
            dtFecha = new DateTimePicker();
            txtCorreo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)perfilBox).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 40);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Dni:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 85);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 135);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 177);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 225);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 4;
            label5.Text = "Correo Electrónico:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 275);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 5;
            label6.Text = "Número de celular:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 365);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 6;
            label7.Text = "Carrera:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 319);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 7;
            label8.Text = "Dirección de Domicilio:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImagen);
            groupBox1.Controls.Add(perfilBox);
            groupBox1.Controls.Add(cboCarreras);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(brnGrabar);
            groupBox1.Controls.Add(checkCertificado);
            groupBox1.Controls.Add(checkEstado);
            groupBox1.Controls.Add(lblDni);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cboDistrito);
            groupBox1.Controls.Add(cboProvincia);
            groupBox1.Controls.Add(cboDepartamento);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(mskCelular);
            groupBox1.Controls.Add(dtFecha);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(26, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(937, 417);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alumno";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnImagen
            // 
            btnImagen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImagen.BackColor = SystemColors.ButtonHighlight;
            btnImagen.FlatStyle = FlatStyle.Flat;
            btnImagen.Location = new Point(604, 356);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(75, 23);
            btnImagen.TabIndex = 36;
            btnImagen.Text = "Subir Perfil";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += btnImagen_Click_2;
            // 
            // perfilBox
            // 
            perfilBox.BackColor = SystemColors.ControlLight;
            perfilBox.Location = new Point(492, 256);
            perfilBox.Name = "perfilBox";
            perfilBox.Size = new Size(106, 124);
            perfilBox.SizeMode = PictureBoxSizeMode.Zoom;
            perfilBox.TabIndex = 16;
            perfilBox.TabStop = false;
            perfilBox.Click += perfilBox_Click;
            // 
            // cboCarreras
            // 
            cboCarreras.FormattingEnabled = true;
            cboCarreras.Location = new Point(179, 357);
            cboCarreras.Name = "cboCarreras";
            cboCarreras.Size = new Size(200, 23);
            cboCarreras.TabIndex = 30;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(833, 365);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 29);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // brnGrabar
            // 
            brnGrabar.Location = new Point(833, 324);
            brnGrabar.Name = "brnGrabar";
            brnGrabar.Size = new Size(88, 30);
            brnGrabar.TabIndex = 28;
            brnGrabar.Text = "Grabar";
            brnGrabar.UseVisualStyleBackColor = true;
            brnGrabar.Click += brnGrabar_Click;
            // 
            // checkCertificado
            // 
            checkCertificado.AutoSize = true;
            checkCertificado.Location = new Point(789, 221);
            checkCertificado.Name = "checkCertificado";
            checkCertificado.Size = new Size(76, 19);
            checkCertificado.TabIndex = 27;
            checkCertificado.Text = "Obtenido";
            checkCertificado.UseVisualStyleBackColor = true;
            // 
            // checkEstado
            // 
            checkEstado.AutoSize = true;
            checkEstado.Location = new Point(789, 175);
            checkEstado.Name = "checkEstado";
            checkEstado.Size = new Size(60, 19);
            checkEstado.TabIndex = 26;
            checkEstado.Text = "Activo";
            checkEstado.UseVisualStyleBackColor = true;
            // 
            // lblDni
            // 
            lblDni.BorderStyle = BorderStyle.FixedSingle;
            lblDni.Location = new Point(179, 33);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(200, 22);
            lblDni.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioFemenino);
            groupBox2.Controls.Add(radioMasculino);
            groupBox2.Location = new Point(467, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(175, 79);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Género:";
            // 
            // radioFemenino
            // 
            radioFemenino.AutoSize = true;
            radioFemenino.Location = new Point(70, 47);
            radioFemenino.Name = "radioFemenino";
            radioFemenino.Size = new Size(78, 19);
            radioFemenino.TabIndex = 1;
            radioFemenino.TabStop = true;
            radioFemenino.Text = "Femenino";
            radioFemenino.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            radioMasculino.AutoSize = true;
            radioMasculino.Location = new Point(70, 22);
            radioMasculino.Name = "radioMasculino";
            radioMasculino.Size = new Size(80, 19);
            radioMasculino.TabIndex = 0;
            radioMasculino.TabStop = true;
            radioMasculino.Text = "Masculino";
            radioMasculino.UseVisualStyleBackColor = true;
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(644, 124);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(208, 23);
            cboDistrito.TabIndex = 23;
            cboDistrito.SelectionChangeCommitted += cboDistrito_SelectionChangeCommitted;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(644, 85);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(208, 23);
            cboProvincia.TabIndex = 22;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(644, 32);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(208, 23);
            cboDepartamento.TabIndex = 21;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // txtDomicilio
            // 
            txtDomicilio.CharacterCasing = CharacterCasing.Upper;
            txtDomicilio.Location = new Point(179, 310);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(200, 23);
            txtDomicilio.TabIndex = 19;
            // 
            // mskCelular
            // 
            mskCelular.Location = new Point(179, 265);
            mskCelular.Mask = "999999999";
            mskCelular.Name = "mskCelular";
            mskCelular.Size = new Size(200, 23);
            mskCelular.TabIndex = 18;
            // 
            // dtFecha
            // 
            dtFecha.Format = DateTimePickerFormat.Short;
            dtFecha.Location = new Point(179, 171);
            dtFecha.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtFecha.MinDate = new DateTime(1953, 1, 1, 0, 0, 0, 0);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(200, 23);
            dtFecha.TabIndex = 17;
            dtFecha.Value = new DateTime(2008, 12, 31, 0, 0, 0, 0);
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(179, 216);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(200, 23);
            txtCorreo.TabIndex = 16;
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Location = new Point(179, 122);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 23);
            txtApellido.TabIndex = 15;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(179, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 14;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(706, 225);
            label14.Name = "label14";
            label14.Size = new Size(68, 15);
            label14.TabIndex = 13;
            label14.Text = "Certificado:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(706, 179);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 12;
            label13.Text = "Estado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(467, 130);
            label11.Name = "label11";
            label11.Size = new Size(120, 15);
            label11.TabIndex = 10;
            label11.Text = "Distrito de residencia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(467, 88);
            label10.Name = "label10";
            label10.Size = new Size(131, 15);
            label10.TabIndex = 9;
            label10.Text = "Provincia de residencia:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(467, 40);
            label9.Name = "label9";
            label9.Size = new Size(161, 15);
            label9.TabIndex = 8;
            label9.Text = "Departamento de Residencia:";
            // 
            // ActualizarAlumnoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 473);
            Controls.Add(groupBox1);
            Name = "ActualizarAlumnoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Alumno";
            Load += ActualizarAlumnoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)perfilBox).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label10;
        private Label label9;
        private MaskedTextBox mskCelular;
        private DateTimePicker dtFecha;
        private TextBox txtCorreo;
        private TextBox txtApellido;
        private ComboBox cboDepartamento;
        private TextBox txtDomicilio;
        private Button btnCancelar;
        private Button brnGrabar;
        private CheckBox checkCertificado;
        private CheckBox checkEstado;
        private GroupBox groupBox2;
        private RadioButton radioFemenino;
        private RadioButton radioMasculino;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private Label lblDni;
        private ComboBox cboCarreras;
        private PictureBox perfilBox;
        private Button btnImagen;
    }
}