namespace Matricula_GUI
{
    partial class RegistrarSeccion
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
            cboAulas = new ComboBox();
            groupBox2 = new GroupBox();
            radioRemoto = new RadioButton();
            radioPresencial = new RadioButton();
            cboDiaSemana = new ComboBox();
            cboDocentes = new ComboBox();
            cboCurso = new ComboBox();
            label10 = new Label();
            btnRegistrar = new Button();
            dtFechaInicio = new DateTimePicker();
            dtFechaFinal = new DateTimePicker();
            dtHoraFin = new DateTimePicker();
            dtHoraInicio = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboAulas);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cboDiaSemana);
            groupBox1.Controls.Add(cboDocentes);
            groupBox1.Controls.Add(cboCurso);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(dtFechaInicio);
            groupBox1.Controls.Add(dtFechaFinal);
            groupBox1.Controls.Add(dtHoraFin);
            groupBox1.Controls.Add(dtHoraInicio);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(72, 97);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1083, 407);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seccion";
            // 
            // cboAulas
            // 
            cboAulas.FormattingEnabled = true;
            cboAulas.Location = new Point(280, 176);
            cboAulas.Margin = new Padding(3, 4, 3, 4);
            cboAulas.Name = "cboAulas";
            cboAulas.Size = new Size(266, 28);
            cboAulas.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioRemoto);
            groupBox2.Controls.Add(radioPresencial);
            groupBox2.Location = new Point(631, 224);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(347, 108);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modalidad:";
            // 
            // radioRemoto
            // 
            radioRemoto.AutoSize = true;
            radioRemoto.Location = new Point(127, 63);
            radioRemoto.Margin = new Padding(3, 4, 3, 4);
            radioRemoto.Name = "radioRemoto";
            radioRemoto.Size = new Size(83, 24);
            radioRemoto.TabIndex = 28;
            radioRemoto.TabStop = true;
            radioRemoto.Text = "Remoto";
            radioRemoto.UseVisualStyleBackColor = true;
            // 
            // radioPresencial
            // 
            radioPresencial.AutoSize = true;
            radioPresencial.Location = new Point(127, 23);
            radioPresencial.Margin = new Padding(3, 4, 3, 4);
            radioPresencial.Name = "radioPresencial";
            radioPresencial.Size = new Size(96, 24);
            radioPresencial.TabIndex = 27;
            radioPresencial.TabStop = true;
            radioPresencial.Text = "Presencial";
            radioPresencial.UseVisualStyleBackColor = true;
            // 
            // cboDiaSemana
            // 
            cboDiaSemana.FormattingEnabled = true;
            cboDiaSemana.Location = new Point(785, 167);
            cboDiaSemana.Margin = new Padding(3, 4, 3, 4);
            cboDiaSemana.Name = "cboDiaSemana";
            cboDiaSemana.Size = new Size(201, 28);
            cboDiaSemana.TabIndex = 7;
            // 
            // cboDocentes
            // 
            cboDocentes.FormattingEnabled = true;
            cboDocentes.Location = new Point(280, 105);
            cboDocentes.Margin = new Padding(3, 4, 3, 4);
            cboDocentes.Name = "cboDocentes";
            cboDocentes.Size = new Size(266, 28);
            cboDocentes.TabIndex = 1;
            // 
            // cboCurso
            // 
            cboCurso.FormattingEnabled = true;
            cboCurso.Location = new Point(280, 44);
            cboCurso.Margin = new Padding(3, 4, 3, 4);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(266, 28);
            cboCurso.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(631, 180);
            label10.Name = "label10";
            label10.Size = new Size(127, 20);
            label10.TabIndex = 22;
            label10.Text = "Día de la semana:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(975, 357);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(86, 31);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Format = DateTimePickerFormat.Short;
            dtFechaInicio.Location = new Point(785, 42);
            dtFechaInicio.Margin = new Padding(3, 4, 3, 4);
            dtFechaInicio.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtFechaInicio.MinDate = new DateTime(1903, 1, 1, 0, 0, 0, 0);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(203, 27);
            dtFechaInicio.TabIndex = 5;
            // 
            // dtFechaFinal
            // 
            dtFechaFinal.Format = DateTimePickerFormat.Short;
            dtFechaFinal.Location = new Point(785, 103);
            dtFechaFinal.Margin = new Padding(3, 4, 3, 4);
            dtFechaFinal.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtFechaFinal.MinDate = new DateTime(1903, 1, 1, 0, 0, 0, 0);
            dtFechaFinal.Name = "dtFechaFinal";
            dtFechaFinal.Size = new Size(203, 27);
            dtFechaFinal.TabIndex = 6;
            // 
            // dtHoraFin
            // 
            dtHoraFin.Format = DateTimePickerFormat.Time;
            dtHoraFin.Location = new Point(280, 301);
            dtHoraFin.Margin = new Padding(3, 4, 3, 4);
            dtHoraFin.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtHoraFin.MinDate = new DateTime(1903, 1, 1, 0, 0, 0, 0);
            dtHoraFin.Name = "dtHoraFin";
            dtHoraFin.Size = new Size(266, 27);
            dtHoraFin.TabIndex = 4;
            // 
            // dtHoraInicio
            // 
            dtHoraInicio.Format = DateTimePickerFormat.Time;
            dtHoraInicio.Location = new Point(280, 243);
            dtHoraInicio.Margin = new Padding(3, 4, 3, 4);
            dtHoraInicio.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtHoraInicio.MinDate = new DateTime(1903, 1, 1, 0, 0, 0, 0);
            dtHoraInicio.Name = "dtHoraInicio";
            dtHoraInicio.Size = new Size(266, 27);
            dtHoraInicio.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 301);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 6;
            label7.Text = "Hora de Fin:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 243);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 5;
            label6.Text = "Hora de Inicio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(631, 116);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha Final:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(631, 52);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 180);
            label3.Name = "label3";
            label3.Size = new Size(224, 20);
            label3.TabIndex = 2;
            label3.Text = "Código de la Dirección del Aula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 116);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Docente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 55);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar Curso";
            // 
            // RegistrarSeccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 600);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrarSeccion";
            Text = "RegistrarSeccion";
            Load += RegistrarSeccion_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label10;
        private Button btnRegistrar;
        private DateTimePicker dtFechaInicio;
        private DateTimePicker dtFechaFinal;
        private DateTimePicker dtHoraFin;
        private DateTimePicker dtHoraInicio;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboCurso;
        private ComboBox cboDocentes;
        private ComboBox cboDiaSemana;
        private GroupBox groupBox2;
        private RadioButton radioRemoto;
        private RadioButton radioPresencial;
        private ComboBox cboAulas;
    }
}