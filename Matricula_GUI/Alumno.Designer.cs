namespace Matricula_GUI
{
    partial class Alumno
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
            dtgAlumnos = new DataGridView();
            btnEliminar_A = new Button();
            btnActualizar = new Button();
            btnRegistrar = new Button();
            txtFiltroA = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dtgAlumnos
            // 
            dtgAlumnos.AllowUserToAddRows = false;
            dtgAlumnos.AllowUserToDeleteRows = false;
            dtgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlumnos.Location = new Point(73, 122);
            dtgAlumnos.Margin = new Padding(2, 1, 2, 1);
            dtgAlumnos.Name = "dtgAlumnos";
            dtgAlumnos.ReadOnly = true;
            dtgAlumnos.RowHeadersWidth = 82;
            dtgAlumnos.Size = new Size(1036, 354);
            dtgAlumnos.TabIndex = 0;
            dtgAlumnos.CellContentClick += dtgAlumnos_CellContentClick;
            // 
            // btnEliminar_A
            // 
            btnEliminar_A.Location = new Point(1015, 509);
            btnEliminar_A.Margin = new Padding(2, 1, 2, 1);
            btnEliminar_A.Name = "btnEliminar_A";
            btnEliminar_A.Size = new Size(92, 29);
            btnEliminar_A.TabIndex = 4;
            btnEliminar_A.Text = "Eliminar";
            btnEliminar_A.UseVisualStyleBackColor = true;
            btnEliminar_A.Click += btnEliminar_A_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(924, 509);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(831, 509);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(86, 31);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtFiltroA
            // 
            txtFiltroA.Location = new Point(245, 32);
            txtFiltroA.Margin = new Padding(2);
            txtFiltroA.Name = "txtFiltroA";
            txtFiltroA.Size = new Size(210, 27);
            txtFiltroA.TabIndex = 7;
            txtFiltroA.TextChanged += txtFiltroA_TextChanged;
            txtFiltroA.KeyPress += txtFiltroA_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 8;
            label1.Text = "Ingrese Dni del Alumno:";
            // 
            // Alumno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 569);
            Controls.Add(label1);
            Controls.Add(txtFiltroA);
            Controls.Add(btnRegistrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar_A);
            Controls.Add(dtgAlumnos);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Alumno";
            Text = "Alumno";
            Load += Alumno_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgAlumnos;
        private Button btnEliminar_A;
        private Button btnActualizar;
        private Button btnRegistrar;
        private TextBox txtFiltroA;
        private Label label1;
    }
}