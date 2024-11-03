namespace Matricula_GUI
{
    partial class RegistrarAlumno
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
            components = new System.ComponentModel.Container();
            txtGenero = new ComboBox();
            btnRegister = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dateAlumno = new DateTimePicker();
            boxDepartamento = new ComboBox();
            boxProvincia = new ComboBox();
            boxDistrito = new ComboBox();
            boxDomicilio = new TextBox();
            txtEmail = new TextBox();
            txtCelular = new TextBox();
            label1 = new Label();
            boxCarrera = new ComboBox();
            perfilBox = new PictureBox();
            btnImagen = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Carrera = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)perfilBox).BeginInit();
            SuspendLayout();
            // 
            // txtGenero
            // 
            txtGenero.Cursor = Cursors.Hand;
            txtGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGenero.FormattingEnabled = true;
            txtGenero.Location = new Point(279, 171);
            txtGenero.Margin = new Padding(3, 4, 3, 4);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(210, 28);
            txtGenero.TabIndex = 4;
            txtGenero.TabStop = false;
            txtGenero.SelectedIndexChanged += txtGenero_SelectedIndexChanged;
            txtGenero.SelectionChangeCommitted += txtGenero_SelectionChangeCommitted;
            txtGenero.Click += txtGenero_Click;
            txtGenero.KeyPress += txtGenero_KeyPress;
            txtGenero.MouseEnter += txtGenero_MouseEnter;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ButtonHighlight;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = SystemColors.ActiveCaptionText;
            btnRegister.Location = new Point(398, 433);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(135, 43);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegistrar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtDNI
            // 
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(279, 104);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.PlaceholderText = "DNI";
            txtDNI.Size = new Size(140, 27);
            txtDNI.TabIndex = 1;
            txtDNI.TextChanged += txtDNI_TextChanged;
            txtDNI.KeyPress += txtDNI_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(431, 104);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(205, 27);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += textBox2_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Location = new Point(648, 104);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(230, 27);
            txtApellido.TabIndex = 3;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // dateAlumno
            // 
            dateAlumno.Format = DateTimePickerFormat.Short;
            dateAlumno.Location = new Point(499, 171);
            dateAlumno.Margin = new Padding(3, 4, 3, 4);
            dateAlumno.Name = "dateAlumno";
            dateAlumno.Size = new Size(379, 27);
            dateAlumno.TabIndex = 8;
            // 
            // boxDepartamento
            // 
            boxDepartamento.AccessibleDescription = "";
            boxDepartamento.AccessibleName = "";
            boxDepartamento.Cursor = Cursors.Hand;
            boxDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            boxDepartamento.FormattingEnabled = true;
            boxDepartamento.Location = new Point(279, 312);
            boxDepartamento.Margin = new Padding(3, 4, 3, 4);
            boxDepartamento.Name = "boxDepartamento";
            boxDepartamento.Size = new Size(197, 28);
            boxDepartamento.TabIndex = 9;
            boxDepartamento.SelectionChangeCommitted += boxDepartamento_SelectionChangeCommitted;
            boxDepartamento.KeyPress += boxDepartamento_KeyPress;
            // 
            // boxProvincia
            // 
            boxProvincia.AccessibleDescription = "";
            boxProvincia.AccessibleName = "";
            boxProvincia.Cursor = Cursors.Hand;
            boxProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            boxProvincia.FormattingEnabled = true;
            boxProvincia.Location = new Point(483, 312);
            boxProvincia.Margin = new Padding(3, 4, 3, 4);
            boxProvincia.Name = "boxProvincia";
            boxProvincia.Size = new Size(182, 28);
            boxProvincia.TabIndex = 10;
            boxProvincia.SelectionChangeCommitted += boxProvincia_SelectionChangeCommitted;
            boxProvincia.KeyPress += boxProvincia_KeyPress;
            // 
            // boxDistrito
            // 
            boxDistrito.BackColor = SystemColors.Menu;
            boxDistrito.Cursor = Cursors.Hand;
            boxDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            boxDistrito.ForeColor = SystemColors.InfoText;
            boxDistrito.FormattingEnabled = true;
            boxDistrito.Location = new Point(673, 312);
            boxDistrito.Margin = new Padding(3, 4, 3, 4);
            boxDistrito.Name = "boxDistrito";
            boxDistrito.Size = new Size(205, 28);
            boxDistrito.TabIndex = 11;
            boxDistrito.SelectedIndexChanged += boxDistrito_SelectedIndexChanged;
            boxDistrito.KeyPress += boxDistrito_KeyPress;
            // 
            // boxDomicilio
            // 
            boxDomicilio.CharacterCasing = CharacterCasing.Upper;
            boxDomicilio.Location = new Point(279, 381);
            boxDomicilio.Margin = new Padding(3, 4, 3, 4);
            boxDomicilio.Name = "boxDomicilio";
            boxDomicilio.PlaceholderText = "Dirección de domicilio";
            boxDomicilio.Size = new Size(599, 27);
            boxDomicilio.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(279, 240);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Correo Electronico";
            txtEmail.Size = new Size(201, 27);
            txtEmail.TabIndex = 5;
            txtEmail.MouseClick += txtEmail_MouseClick;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(487, 240);
            txtCelular.Margin = new Padding(3, 4, 3, 4);
            txtCelular.MaxLength = 9;
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Numero de Celular";
            txtCelular.Size = new Size(181, 27);
            txtCelular.TabIndex = 6;
            txtCelular.TextChanged += textBox6_TextChanged;
            txtCelular.KeyPress += txtCelular_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(41, 33);
            label1.Name = "label1";
            label1.Size = new Size(242, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingresar datos del Alumno";
            label1.Click += label1_Click;
            // 
            // boxCarrera
            // 
            boxCarrera.Cursor = Cursors.Hand;
            boxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            boxCarrera.FormattingEnabled = true;
            boxCarrera.Location = new Point(675, 240);
            boxCarrera.Margin = new Padding(3, 4, 3, 4);
            boxCarrera.Name = "boxCarrera";
            boxCarrera.Size = new Size(203, 28);
            boxCarrera.TabIndex = 14;
            // 
            // perfilBox
            // 
            perfilBox.BackColor = SystemColors.ControlLight;
            perfilBox.Location = new Point(34, 112);
            perfilBox.Margin = new Padding(3, 4, 3, 4);
            perfilBox.Name = "perfilBox";
            perfilBox.Size = new Size(203, 272);
            perfilBox.SizeMode = PictureBoxSizeMode.Zoom;
            perfilBox.TabIndex = 15;
            perfilBox.TabStop = false;
            // 
            // btnImagen
            // 
            btnImagen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImagen.BackColor = SystemColors.ButtonHighlight;
            btnImagen.FlatStyle = FlatStyle.Flat;
            btnImagen.Location = new Point(93, 383);
            btnImagen.Margin = new Padding(3, 4, 3, 4);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(86, 31);
            btnImagen.TabIndex = 16;
            btnImagen.Text = "Subir Perfil";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += btnImagen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 288);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 17;
            label2.Text = "Despartamento";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(481, 289);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 18;
            label3.Text = "Provincia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(672, 288);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 19;
            label4.Text = "Distrito";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 175);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 20;
            // 
            // Carrera
            // 
            Carrera.AutoSize = true;
            Carrera.Location = new Point(673, 216);
            Carrera.Name = "Carrera";
            Carrera.Size = new Size(57, 20);
            Carrera.TabIndex = 23;
            Carrera.Text = "Carrera";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(497, 147);
            label9.Name = "label9";
            label9.Size = new Size(149, 20);
            label9.TabIndex = 24;
            label9.Text = "Fecha de Nacimiento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(430, 80);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 25;
            label10.Text = "Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(275, 80);
            label11.Name = "label11";
            label11.Size = new Size(35, 20);
            label11.TabIndex = 26;
            label11.Text = "DNI";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(277, 216);
            label12.Name = "label12";
            label12.Size = new Size(132, 20);
            label12.TabIndex = 27;
            label12.Text = "Correo Electronico";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(483, 216);
            label13.Name = "label13";
            label13.Size = new Size(132, 20);
            label13.TabIndex = 28;
            label13.Text = "Numero de celular";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(646, 80);
            label14.Name = "label14";
            label14.Size = new Size(66, 20);
            label14.TabIndex = 29;
            label14.Text = "Apellido";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(277, 147);
            label15.Name = "label15";
            label15.Size = new Size(57, 20);
            label15.TabIndex = 30;
            label15.Text = "Genero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 357);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 31;
            label6.Text = "Domicilio";
            // 
            // RegistrarAlumno
            // 
            AccessibleDescription = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(915, 507);
            Controls.Add(label6);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(Carrera);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnImagen);
            Controls.Add(perfilBox);
            Controls.Add(boxCarrera);
            Controls.Add(label1);
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
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "RegistrarAlumno";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Registro Alumno";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)perfilBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox txtGenero;
        private DateTimePicker dateAlumno;
        private ComboBox boxDepartamento;
        private ComboBox boxProvincia;
        private ComboBox boxDistrito;
        private TextBox boxDomicilio;
        private TextBox txtEmail;
        private TextBox txtCelular;
        private Label label1;
        private ComboBox boxCarrera;
        private PictureBox perfilBox;
        private Button btnImagen;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Carrera;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label6;
    }
}
