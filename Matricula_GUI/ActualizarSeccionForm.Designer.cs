namespace Matricula_GUI
{
    partial class ActualizarSeccionForm
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
            cboDocentes = new ComboBox();
            cboCurso = new ComboBox();
            groupBox2 = new GroupBox();
            radioRemoto = new RadioButton();
            radioPresencial = new RadioButton();
            cboDiaSemana = new ComboBox();
            label10 = new Label();
            btnCancelarSeccion = new Button();
            btnActualizarSeccion = new Button();
            label9 = new Label();
            lblNrc = new Label();
            checkEstado = new CheckBox();
            label8 = new Label();
            dtFechaInicio = new DateTimePicker();
            dtFechaFinal = new DateTimePicker();
            dtHoraFin = new DateTimePicker();
            dtHoraInicio = new DateTimePicker();
            txtDireccionA = new TextBox();
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
            groupBox1.Controls.Add(cboDocentes);
            groupBox1.Controls.Add(cboCurso);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cboDiaSemana);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnCancelarSeccion);
            groupBox1.Controls.Add(btnActualizarSeccion);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblNrc);
            groupBox1.Controls.Add(checkEstado);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtFechaInicio);
            groupBox1.Controls.Add(dtFechaFinal);
            groupBox1.Controls.Add(dtHoraFin);
            groupBox1.Controls.Add(dtHoraInicio);
            groupBox1.Controls.Add(txtDireccionA);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 37);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1083, 509);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seccion";
            // 
            // cboDocentes
            // 
            cboDocentes.FormattingEnabled = true;
            cboDocentes.Location = new Point(287, 163);
            cboDocentes.Margin = new Padding(3, 4, 3, 4);
            cboDocentes.Name = "cboDocentes";
            cboDocentes.Size = new Size(277, 28);
            cboDocentes.TabIndex = 30;
            // 
            // cboCurso
            // 
            cboCurso.FormattingEnabled = true;
            cboCurso.Location = new Point(287, 103);
            cboCurso.Margin = new Padding(3, 4, 3, 4);
            cboCurso.Name = "cboCurso";
            cboCurso.Size = new Size(277, 28);
            cboCurso.TabIndex = 29;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioRemoto);
            groupBox2.Controls.Add(radioPresencial);
            groupBox2.Location = new Point(631, 225);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(347, 108);
            groupBox2.TabIndex = 28;
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
            cboDiaSemana.Location = new Point(765, 169);
            cboDiaSemana.Margin = new Padding(3, 4, 3, 4);
            cboDiaSemana.Name = "cboDiaSemana";
            cboDiaSemana.Size = new Size(203, 28);
            cboDiaSemana.TabIndex = 24;
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
            // btnCancelarSeccion
            // 
            btnCancelarSeccion.Location = new Point(971, 440);
            btnCancelarSeccion.Margin = new Padding(3, 4, 3, 4);
            btnCancelarSeccion.Name = "btnCancelarSeccion";
            btnCancelarSeccion.Size = new Size(86, 31);
            btnCancelarSeccion.TabIndex = 21;
            btnCancelarSeccion.Text = "Cancelar";
            btnCancelarSeccion.UseVisualStyleBackColor = true;
            btnCancelarSeccion.Click += btnCancelarSeccion_Click_1;
            // 
            // btnActualizarSeccion
            // 
            btnActualizarSeccion.Location = new Point(971, 401);
            btnActualizarSeccion.Margin = new Padding(3, 4, 3, 4);
            btnActualizarSeccion.Name = "btnActualizarSeccion";
            btnActualizarSeccion.Size = new Size(86, 31);
            btnActualizarSeccion.TabIndex = 20;
            btnActualizarSeccion.Text = "Actualizar";
            btnActualizarSeccion.UseVisualStyleBackColor = true;
            btnActualizarSeccion.Click += btnActualizarSeccion_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 52);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 20;
            label9.Text = "NRC:";
            // 
            // lblNrc
            // 
            lblNrc.BorderStyle = BorderStyle.FixedSingle;
            lblNrc.Location = new Point(287, 41);
            lblNrc.Name = "lblNrc";
            lblNrc.Size = new Size(277, 30);
            lblNrc.TabIndex = 22;
            // 
            // checkEstado
            // 
            checkEstado.AutoSize = true;
            checkEstado.Location = new Point(765, 351);
            checkEstado.Margin = new Padding(3, 4, 3, 4);
            checkEstado.Name = "checkEstado";
            checkEstado.Size = new Size(73, 24);
            checkEstado.TabIndex = 19;
            checkEstado.Text = "Activo";
            checkEstado.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(631, 352);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 18;
            label8.Text = "Estado:";
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Format = DateTimePickerFormat.Short;
            dtFechaInicio.Location = new Point(765, 44);
            dtFechaInicio.Margin = new Padding(3, 4, 3, 4);
            dtFechaInicio.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtFechaInicio.MinDate = new DateTime(1903, 1, 1, 0, 0, 0, 0);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(203, 27);
            dtFechaInicio.TabIndex = 17;
            // 
            // dtFechaFinal
            // 
            dtFechaFinal.Format = DateTimePickerFormat.Short;
            dtFechaFinal.Location = new Point(765, 105);
            dtFechaFinal.Margin = new Padding(3, 4, 3, 4);
            dtFechaFinal.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtFechaFinal.MinDate = new DateTime(1903, 1, 1, 0, 0, 0, 0);
            dtFechaFinal.Name = "dtFechaFinal";
            dtFechaFinal.Size = new Size(203, 27);
            dtFechaFinal.TabIndex = 16;
            // 
            // dtHoraFin
            // 
            dtHoraFin.Format = DateTimePickerFormat.Time;
            dtHoraFin.Location = new Point(287, 352);
            dtHoraFin.Margin = new Padding(3, 4, 3, 4);
            dtHoraFin.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtHoraFin.MinDate = new DateTime(1903, 1, 1, 0, 0, 0, 0);
            dtHoraFin.Name = "dtHoraFin";
            dtHoraFin.Size = new Size(277, 27);
            dtHoraFin.TabIndex = 15;
            // 
            // dtHoraInicio
            // 
            dtHoraInicio.Format = DateTimePickerFormat.Time;
            dtHoraInicio.Location = new Point(287, 287);
            dtHoraInicio.Margin = new Padding(3, 4, 3, 4);
            dtHoraInicio.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtHoraInicio.MinDate = new DateTime(1903, 1, 1, 0, 0, 0, 0);
            dtHoraInicio.Name = "dtHoraInicio";
            dtHoraInicio.Size = new Size(277, 27);
            dtHoraInicio.TabIndex = 14;
            // 
            // txtDireccionA
            // 
            txtDireccionA.CharacterCasing = CharacterCasing.Upper;
            txtDireccionA.Location = new Point(287, 225);
            txtDireccionA.Margin = new Padding(3, 4, 3, 4);
            txtDireccionA.Name = "txtDireccionA";
            txtDireccionA.Size = new Size(277, 27);
            txtDireccionA.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 363);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 6;
            label7.Text = "Hora de Fin:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 297);
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
            label3.Location = new Point(43, 236);
            label3.Name = "label3";
            label3.Size = new Size(224, 20);
            label3.TabIndex = 2;
            label3.Text = "Código de la Dirección del Aula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 173);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Docente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 113);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Curso:";
            // 
            // ActualizarSeccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 572);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ActualizarSeccionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Sección";
            Load += ActualizarSeccionForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDireccionA;
        private Label label7;
        private DateTimePicker dtFechaInicio;
        private DateTimePicker dtFechaFinal;
        private DateTimePicker dtHoraFin;
        private DateTimePicker dtHoraInicio;
        private Button btnCancelarSeccion;
        private Button btnActualizarSeccion;
        private CheckBox checkEstado;
        private Label label8;
        private Label label9;
        private Label lblNrc;
        private EventHandler btnCancelarSeccion_Click;
        private Label label10;
        private ComboBox cboDiaSemana;
        private GroupBox groupBox2;
        private RadioButton radioRemoto;
        private RadioButton radioPresencial;
        private ComboBox cboCurso;
        private ComboBox cboDocentes;
    }
}