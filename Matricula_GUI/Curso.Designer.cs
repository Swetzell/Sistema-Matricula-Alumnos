namespace Matricula_GUI
{
    partial class Curso
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
            dtgCursos = new DataGridView();
            btnEliminar_C = new Button();
            btnActualizarCurso = new Button();
            Registrar = new Button();
            txtFiltroC = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgCursos).BeginInit();
            SuspendLayout();
            // 
            // dtgCursos
            // 
            dtgCursos.AllowUserToAddRows = false;
            dtgCursos.AllowUserToDeleteRows = false;
            dtgCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCursos.Location = new Point(85, 116);
            dtgCursos.Margin = new Padding(2, 3, 2, 3);
            dtgCursos.Name = "dtgCursos";
            dtgCursos.ReadOnly = true;
            dtgCursos.RowHeadersWidth = 82;
            dtgCursos.Size = new Size(889, 345);
            dtgCursos.TabIndex = 0;
            dtgCursos.CellContentClick += dtgCursos_CellContentClick;
            // 
            // btnEliminar_C
            // 
            btnEliminar_C.Location = new Point(881, 480);
            btnEliminar_C.Margin = new Padding(2, 3, 2, 3);
            btnEliminar_C.Name = "btnEliminar_C";
            btnEliminar_C.Size = new Size(91, 29);
            btnEliminar_C.TabIndex = 1;
            btnEliminar_C.Text = "Eliminar";
            btnEliminar_C.UseVisualStyleBackColor = true;
            btnEliminar_C.Click += btnEliminar_C_Click;
            // 
            // btnActualizarCurso
            // 
            btnActualizarCurso.Location = new Point(779, 479);
            btnActualizarCurso.Margin = new Padding(3, 4, 3, 4);
            btnActualizarCurso.Name = "btnActualizarCurso";
            btnActualizarCurso.Size = new Size(86, 31);
            btnActualizarCurso.TabIndex = 2;
            btnActualizarCurso.Text = "Actualizar";
            btnActualizarCurso.UseVisualStyleBackColor = true;
            btnActualizarCurso.Click += btnActualizarCurso_Click;
            // 
            // Registrar
            // 
            Registrar.Location = new Point(673, 480);
            Registrar.Margin = new Padding(3, 4, 3, 4);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(86, 31);
            Registrar.TabIndex = 3;
            Registrar.Text = "Crear";
            Registrar.UseVisualStyleBackColor = true;
            Registrar.Click += Registrar_Click;
            // 
            // txtFiltroC
            // 
            txtFiltroC.CharacterCasing = CharacterCasing.Upper;
            txtFiltroC.Location = new Point(270, 30);
            txtFiltroC.Margin = new Padding(2);
            txtFiltroC.Name = "txtFiltroC";
            txtFiltroC.Size = new Size(215, 27);
            txtFiltroC.TabIndex = 4;
            txtFiltroC.TextChanged += txtFiltroC_TextChanged;
            txtFiltroC.KeyPress += txtFiltroC_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 5;
            label1.Text = "Ingrese Nombre del Curso:";
            // 
            // Curso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 544);
            Controls.Add(label1);
            Controls.Add(txtFiltroC);
            Controls.Add(Registrar);
            Controls.Add(btnActualizarCurso);
            Controls.Add(btnEliminar_C);
            Controls.Add(dtgCursos);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Curso";
            Text = "Curso";
            Load += Curso_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgCursos;
        private Button btnEliminar_C;
        private Button btnActualizarCurso;
        private Button Registrar;
        private TextBox txtFiltroC;
        private Label label1;
    }
}