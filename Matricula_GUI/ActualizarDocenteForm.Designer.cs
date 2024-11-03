namespace Matricula_GUI
{
    partial class ActualizarDocenteForm
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
            groupBox1 = new GroupBox();
            btnImagen = new Button();
            perfilBox = new PictureBox();
            cboCarreras = new ComboBox();
            btnCancelar = new Button();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            lblDniDocente = new Label();
            cboDepartamento = new ComboBox();
            txtDomicilio = new TextBox();
            mskCelular = new MaskedTextBox();
            dtFechaDocente = new DateTimePicker();
            txtCorreo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnActualizar = new Button();
            checkEstado = new CheckBox();
            label15 = new Label();
            groupBox2 = new GroupBox();
            radioFemenino = new RadioButton();
            radioMasculino = new RadioButton();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)perfilBox).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Dni:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImagen);
            groupBox1.Controls.Add(perfilBox);
            groupBox1.Controls.Add(cboCarreras);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(cboDistrito);
            groupBox1.Controls.Add(cboProvincia);
            groupBox1.Controls.Add(lblDniDocente);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboDepartamento);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(mskCelular);
            groupBox1.Controls.Add(dtFechaDocente);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(checkEstado);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(28, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 416);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Docente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnImagen
            // 
            btnImagen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImagen.BackColor = SystemColors.ButtonHighlight;
            btnImagen.FlatStyle = FlatStyle.Flat;
            btnImagen.Location = new Point(561, 344);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(75, 23);
            btnImagen.TabIndex = 35;
            btnImagen.Text = "Subir Perfil";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += btnImagen_Click;
            // 
            // perfilBox
            // 
            perfilBox.BackColor = SystemColors.ControlLight;
            perfilBox.Location = new Point(463, 303);
            perfilBox.Name = "perfilBox";
            perfilBox.Size = new Size(92, 99);
            perfilBox.SizeMode = PictureBoxSizeMode.Zoom;
            perfilBox.TabIndex = 34;
            perfilBox.TabStop = false;
            perfilBox.Click += perfilBox_Click;
            // 
            // cboCarreras
            // 
            cboCarreras.FormattingEnabled = true;
            cboCarreras.Location = new Point(175, 347);
            cboCarreras.Name = "cboCarreras";
            cboCarreras.Size = new Size(192, 23);
            cboCarreras.TabIndex = 33;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(765, 376);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 26);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboDistrito
            // 
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(615, 175);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(210, 23);
            cboDistrito.TabIndex = 30;
            cboDistrito.SelectionChangeCommitted += cboDistrito_SelectionChangeCommitted;
            // 
            // cboProvincia
            // 
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(615, 128);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(210, 23);
            cboProvincia.TabIndex = 29;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // lblDniDocente
            // 
            lblDniDocente.BorderStyle = BorderStyle.FixedSingle;
            lblDniDocente.Location = new Point(175, 34);
            lblDniDocente.Name = "lblDniDocente";
            lblDniDocente.Size = new Size(192, 23);
            lblDniDocente.TabIndex = 2;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(615, 80);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(210, 23);
            cboDepartamento.TabIndex = 28;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // txtDomicilio
            // 
            txtDomicilio.CharacterCasing = CharacterCasing.Upper;
            txtDomicilio.Location = new Point(615, 32);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(210, 23);
            txtDomicilio.TabIndex = 27;
            // 
            // mskCelular
            // 
            mskCelular.Location = new Point(175, 289);
            mskCelular.Mask = "999999999";
            mskCelular.Name = "mskCelular";
            mskCelular.Size = new Size(192, 23);
            mskCelular.TabIndex = 25;
            // 
            // dtFechaDocente
            // 
            dtFechaDocente.Format = DateTimePickerFormat.Short;
            dtFechaDocente.Location = new Point(175, 233);
            dtFechaDocente.MaxDate = new DateTime(2028, 12, 31, 0, 0, 0, 0);
            dtFechaDocente.MinDate = new DateTime(1923, 1, 1, 0, 0, 0, 0);
            dtFechaDocente.Name = "dtFechaDocente";
            dtFechaDocente.Size = new Size(192, 23);
            dtFechaDocente.TabIndex = 24;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(175, 181);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(192, 23);
            txtCorreo.TabIndex = 22;
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Location = new Point(175, 131);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(192, 23);
            txtApellido.TabIndex = 21;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(175, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(192, 23);
            txtNombre.TabIndex = 20;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(765, 344);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(79, 26);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // checkEstado
            // 
            checkEstado.AutoSize = true;
            checkEstado.Location = new Point(765, 245);
            checkEstado.Name = "checkEstado";
            checkEstado.Size = new Size(60, 19);
            checkEstado.TabIndex = 17;
            checkEstado.Text = "Activo";
            checkEstado.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(679, 246);
            label15.Name = "label15";
            label15.Size = new Size(45, 15);
            label15.TabIndex = 16;
            label15.Text = "Estado:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioFemenino);
            groupBox2.Controls.Add(radioMasculino);
            groupBox2.Location = new Point(425, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 77);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Género";
            // 
            // radioFemenino
            // 
            radioFemenino.AutoSize = true;
            radioFemenino.Location = new Point(64, 50);
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
            radioMasculino.Location = new Point(64, 22);
            radioMasculino.Name = "radioMasculino";
            radioMasculino.Size = new Size(80, 19);
            radioMasculino.TabIndex = 0;
            radioMasculino.TabStop = true;
            radioMasculino.Text = "Masculino";
            radioMasculino.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(425, 181);
            label13.Name = "label13";
            label13.Size = new Size(120, 15);
            label13.TabIndex = 13;
            label13.Text = "Distrito de residencia:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(425, 131);
            label12.Name = "label12";
            label12.Size = new Size(131, 15);
            label12.TabIndex = 12;
            label12.Text = "Provincia de residencia:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(425, 83);
            label11.Name = "label11";
            label11.Size = new Size(158, 15);
            label11.TabIndex = 11;
            label11.Text = "Departamento de residencia:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 352);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 10;
            label10.Text = "Carrera:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(425, 40);
            label9.Name = "label9";
            label9.Size = new Size(130, 15);
            label9.TabIndex = 9;
            label9.Text = "Dirección de Domicilio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 297);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 7;
            label7.Text = "Número de celular:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 241);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 6;
            label6.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 189);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 5;
            label5.Text = "Correo Electrónico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 139);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 91);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombres:";
            // 
            // ActualizarDocenteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 459);
            Controls.Add(groupBox1);
            Name = "ActualizarDocenteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Docente";
            Load += ActualizarDocenteForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)perfilBox).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblDniDocente;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label7;
        private Button btnActualizar;
        private CheckBox checkEstado;
        private Label label15;
        private GroupBox groupBox2;
        private RadioButton radioFemenino;
        private RadioButton radioMasculino;
        private MaskedTextBox mskCelular;
        private DateTimePicker dtFechaDocente;
        private TextBox txtCorreo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnCancelar;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
        private TextBox txtDomicilio;
        private ComboBox cboCarreras;
        private PictureBox perfilBox;
        private Button btnImagen;
    }
}