namespace Matricula_GUI
{
    partial class RegistrarDocente
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
            label6 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            Carrera = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            boxCarrera = new ComboBox();
            txtCelular = new TextBox();
            txtEmail = new TextBox();
            boxDomicilio = new TextBox();
            boxDistrito = new ComboBox();
            boxProvincia = new ComboBox();
            boxDepartamento = new ComboBox();
            dateAlumno = new DateTimePicker();
            txtGenero = new ComboBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            btnImagen = new Button();
            perfilBox = new PictureBox();
            label1 = new Label();
            btnRegister = new Button();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)perfilBox).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 384);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 54;
            label6.Text = "Domicilio";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(641, 107);
            label14.Name = "label14";
            label14.Size = new Size(66, 20);
            label14.TabIndex = 53;
            label14.Text = "Apellido";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(479, 243);
            label13.Name = "label13";
            label13.Size = new Size(132, 20);
            label13.TabIndex = 52;
            label13.Text = "Numero de celular";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(272, 243);
            label12.Name = "label12";
            label12.Size = new Size(132, 20);
            label12.TabIndex = 51;
            label12.Text = "Correo Electronico";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(271, 107);
            label11.Name = "label11";
            label11.Size = new Size(35, 20);
            label11.TabIndex = 50;
            label11.Text = "DNI";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(425, 107);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 49;
            label10.Text = "Nombre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(493, 173);
            label9.Name = "label9";
            label9.Size = new Size(149, 20);
            label9.TabIndex = 48;
            label9.Text = "Fecha de Nacimiento";
            // 
            // Carrera
            // 
            Carrera.AutoSize = true;
            Carrera.Location = new Point(669, 243);
            Carrera.Name = "Carrera";
            Carrera.Size = new Size(57, 20);
            Carrera.TabIndex = 47;
            Carrera.Text = "Carrera";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(667, 315);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 46;
            label4.Text = "Distrito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 316);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 45;
            label3.Text = "Provincia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 315);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 44;
            label2.Text = "Despartamento";
            // 
            // boxCarrera
            // 
            boxCarrera.Cursor = Cursors.Hand;
            boxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            boxCarrera.FormattingEnabled = true;
            boxCarrera.Location = new Point(671, 267);
            boxCarrera.Margin = new Padding(3, 4, 3, 4);
            boxCarrera.Name = "boxCarrera";
            boxCarrera.Size = new Size(203, 28);
            boxCarrera.TabIndex = 43;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(482, 267);
            txtCelular.Margin = new Padding(3, 4, 3, 4);
            txtCelular.MaxLength = 9;
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Numero de Celular";
            txtCelular.Size = new Size(181, 27);
            txtCelular.TabIndex = 37;
            txtCelular.KeyPress += txtCelular_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(274, 267);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Correo Electronico";
            txtEmail.Size = new Size(201, 27);
            txtEmail.TabIndex = 36;
            // 
            // boxDomicilio
            // 
            boxDomicilio.CharacterCasing = CharacterCasing.Upper;
            boxDomicilio.Location = new Point(274, 408);
            boxDomicilio.Margin = new Padding(3, 4, 3, 4);
            boxDomicilio.Name = "boxDomicilio";
            boxDomicilio.PlaceholderText = "Dirección de domicilio";
            boxDomicilio.Size = new Size(599, 27);
            boxDomicilio.TabIndex = 42;
            // 
            // boxDistrito
            // 
            boxDistrito.BackColor = SystemColors.Menu;
            boxDistrito.Cursor = Cursors.Hand;
            boxDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            boxDistrito.ForeColor = SystemColors.InfoText;
            boxDistrito.FormattingEnabled = true;
            boxDistrito.Location = new Point(669, 339);
            boxDistrito.Margin = new Padding(3, 4, 3, 4);
            boxDistrito.Name = "boxDistrito";
            boxDistrito.Size = new Size(205, 28);
            boxDistrito.TabIndex = 41;
            // 
            // boxProvincia
            // 
            boxProvincia.AccessibleDescription = "";
            boxProvincia.AccessibleName = "";
            boxProvincia.Cursor = Cursors.Hand;
            boxProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            boxProvincia.FormattingEnabled = true;
            boxProvincia.Location = new Point(479, 339);
            boxProvincia.Margin = new Padding(3, 4, 3, 4);
            boxProvincia.Name = "boxProvincia";
            boxProvincia.Size = new Size(182, 28);
            boxProvincia.TabIndex = 40;
            boxProvincia.SelectionChangeCommitted += boxProvincia_SelectionChangeCommitted;
            // 
            // boxDepartamento
            // 
            boxDepartamento.AccessibleDescription = "";
            boxDepartamento.AccessibleName = "";
            boxDepartamento.Cursor = Cursors.Hand;
            boxDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            boxDepartamento.FormattingEnabled = true;
            boxDepartamento.Location = new Point(274, 339);
            boxDepartamento.Margin = new Padding(3, 4, 3, 4);
            boxDepartamento.Name = "boxDepartamento";
            boxDepartamento.Size = new Size(197, 28);
            boxDepartamento.TabIndex = 39;
            boxDepartamento.SelectionChangeCommitted += boxDepartamento_SelectionChangeCommitted_1;
            // 
            // dateAlumno
            // 
            dateAlumno.Format = DateTimePickerFormat.Short;
            dateAlumno.Location = new Point(495, 197);
            dateAlumno.Margin = new Padding(3, 4, 3, 4);
            dateAlumno.Name = "dateAlumno";
            dateAlumno.Size = new Size(379, 27);
            dateAlumno.TabIndex = 38;
            // 
            // txtGenero
            // 
            txtGenero.Cursor = Cursors.Hand;
            txtGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGenero.FormattingEnabled = true;
            txtGenero.Location = new Point(274, 197);
            txtGenero.Margin = new Padding(3, 4, 3, 4);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(210, 28);
            txtGenero.TabIndex = 35;
            txtGenero.TabStop = false;
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Location = new Point(643, 131);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(230, 27);
            txtApellido.TabIndex = 34;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(426, 131);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(205, 27);
            txtNombre.TabIndex = 33;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtDNI
            // 
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(274, 131);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "DNI";
            txtDNI.Size = new Size(140, 27);
            txtDNI.TabIndex = 32;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // btnImagen
            // 
            btnImagen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImagen.BackColor = SystemColors.ButtonHighlight;
            btnImagen.FlatStyle = FlatStyle.Flat;
            btnImagen.Location = new Point(94, 415);
            btnImagen.Margin = new Padding(3, 4, 3, 4);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(86, 31);
            btnImagen.TabIndex = 58;
            btnImagen.Text = "Subir Perfil";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += btnImagen_Click;
            // 
            // perfilBox
            // 
            perfilBox.BackColor = SystemColors.ControlLight;
            perfilBox.Location = new Point(35, 144);
            perfilBox.Margin = new Padding(3, 4, 3, 4);
            perfilBox.Name = "perfilBox";
            perfilBox.Size = new Size(203, 272);
            perfilBox.SizeMode = PictureBoxSizeMode.Zoom;
            perfilBox.TabIndex = 57;
            perfilBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 57);
            label1.Name = "label1";
            label1.Size = new Size(244, 28);
            label1.TabIndex = 55;
            label1.Text = "Ingresar datos del docente";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ButtonHighlight;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = SystemColors.ActiveCaptionText;
            btnRegister.Location = new Point(399, 465);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(135, 43);
            btnRegister.TabIndex = 56;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(274, 173);
            label15.Name = "label15";
            label15.Size = new Size(57, 20);
            label15.TabIndex = 59;
            label15.Text = "Genero";
            // 
            // RegistrarDocente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 563);
            Controls.Add(label15);
            Controls.Add(btnImagen);
            Controls.Add(perfilBox);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(Carrera);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(boxCarrera);
            Controls.Add(txtCelular);
            Controls.Add(txtEmail);
            Controls.Add(boxDomicilio);
            Controls.Add(boxDistrito);
            Controls.Add(boxProvincia);
            Controls.Add(boxDepartamento);
            Controls.Add(dateAlumno);
            Controls.Add(txtGenero);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrarDocente";
            Text = "RegistrarDocente";
            Load += RegistrarDocente_Load;
            ((System.ComponentModel.ISupportInitialize)perfilBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label Carrera;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox boxCarrera;
        private TextBox txtCelular;
        private TextBox txtEmail;
        private TextBox boxDomicilio;
        private ComboBox boxDistrito;
        private ComboBox boxProvincia;
        private ComboBox boxDepartamento;
        private DateTimePicker dateAlumno;
        private ComboBox txtGenero;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private Button btnImagen;
        private PictureBox perfilBox;
        private Label label1;
        private Button btnRegister;
        private Label label15;
    }
}