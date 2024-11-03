namespace Matricula_GUI
{
    partial class RegistrarCurso
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
            boxCarrera = new ComboBox();
            txtCurso = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCrear = new Button();
            boxCiclo = new ComboBox();
            SuspendLayout();
            // 
            // boxCarrera
            // 
            boxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            boxCarrera.FormattingEnabled = true;
            boxCarrera.Location = new Point(53, 112);
            boxCarrera.Margin = new Padding(3, 4, 3, 4);
            boxCarrera.Name = "boxCarrera";
            boxCarrera.Size = new Size(186, 28);
            boxCarrera.TabIndex = 0;
            // 
            // txtCurso
            // 
            txtCurso.CharacterCasing = CharacterCasing.Upper;
            txtCurso.Location = new Point(53, 171);
            txtCurso.Margin = new Padding(3, 4, 3, 4);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(242, 27);
            txtCurso.TabIndex = 1;
            txtCurso.KeyPress += txtCurso_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 88);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 3;
            label1.Text = "Carrera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 88);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Ciclo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(117, 43);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 5;
            label3.Text = "Crear curso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 147);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 6;
            label4.Text = "Nombre del curso";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(134, 223);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(86, 31);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // boxCiclo
            // 
            boxCiclo.DropDownStyle = ComboBoxStyle.DropDownList;
            boxCiclo.FormattingEnabled = true;
            boxCiclo.Location = new Point(246, 112);
            boxCiclo.Margin = new Padding(3, 4, 3, 4);
            boxCiclo.Name = "boxCiclo";
            boxCiclo.Size = new Size(49, 28);
            boxCiclo.TabIndex = 8;
            // 
            // RegistrarCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 303);
            Controls.Add(boxCiclo);
            Controls.Add(btnCrear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCurso);
            Controls.Add(boxCarrera);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrarCurso";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "RegistrarCurso";
            Load += RegistrarCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox boxCarrera;
        private TextBox txtCurso;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCrear;
        private ComboBox boxCiclo;
    }
}