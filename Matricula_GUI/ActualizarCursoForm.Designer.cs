namespace Matricula_GUI
{
    partial class ActualizarCursoForm
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
            lblCodCurso = new Label();
            txtCarrera = new TextBox();
            btnCancelar = new Button();
            label1 = new Label();
            btnActualizar = new Button();
            mskCiclo = new MaskedTextBox();
            checkEstado = new CheckBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCodCurso);
            groupBox1.Controls.Add(txtCarrera);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnActualizar);
            groupBox1.Controls.Add(mskCiclo);
            groupBox1.Controls.Add(checkEstado);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(32, 47);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(498, 459);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Curso";
            // 
            // lblCodCurso
            // 
            lblCodCurso.BorderStyle = BorderStyle.FixedSingle;
            lblCodCurso.Location = new Point(189, 53);
            lblCodCurso.Name = "lblCodCurso";
            lblCodCurso.Size = new Size(172, 31);
            lblCodCurso.TabIndex = 2;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(189, 131);
            txtCarrera.Margin = new Padding(3, 4, 3, 4);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(172, 27);
            txtCarrera.TabIndex = 12;
            txtCarrera.KeyPress += txtCarrera_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(395, 412);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 65);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Código del curso:";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(395, 373);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // mskCiclo
            // 
            mskCiclo.Location = new Point(189, 255);
            mskCiclo.Margin = new Padding(3, 4, 3, 4);
            mskCiclo.Mask = "9";
            mskCiclo.Name = "mskCiclo";
            mskCiclo.Size = new Size(172, 27);
            mskCiclo.TabIndex = 9;
            // 
            // checkEstado
            // 
            checkEstado.AutoSize = true;
            checkEstado.Location = new Point(189, 333);
            checkEstado.Margin = new Padding(3, 4, 3, 4);
            checkEstado.Name = "checkEstado";
            checkEstado.Size = new Size(73, 24);
            checkEstado.TabIndex = 7;
            checkEstado.Text = "Activo";
            checkEstado.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(189, 189);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(172, 27);
            txtNombre.TabIndex = 6;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 333);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 265);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Ciclo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 193);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre de curso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 131);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 1;
            label2.Text = "Código de Carrera:";
            // 
            // ActualizarCursoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 531);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ActualizarCursoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Curso";
            Load += ActualizarCursoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblCodCurso;
        private Button btnCancelar;
        private Button btnActualizar;
        private MaskedTextBox mskCiclo;
        private CheckBox checkEstado;
        private TextBox txtCarrera;
    }
}