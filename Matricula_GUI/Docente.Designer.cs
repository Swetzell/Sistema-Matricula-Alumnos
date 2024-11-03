namespace Matricula_GUI
{
    partial class Docente
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
            dtgDocente = new DataGridView();
            btnEliminar_D = new Button();
            btnActualizar = new Button();
            btnRegistrarDoc = new Button();
            txtFiltroD = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDocente).BeginInit();
            SuspendLayout();
            // 
            // dtgDocente
            // 
            dtgDocente.AllowUserToAddRows = false;
            dtgDocente.AllowUserToDeleteRows = false;
            dtgDocente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDocente.Location = new Point(68, 129);
            dtgDocente.Margin = new Padding(2);
            dtgDocente.Name = "dtgDocente";
            dtgDocente.ReadOnly = true;
            dtgDocente.RowHeadersWidth = 82;
            dtgDocente.Size = new Size(1036, 354);
            dtgDocente.TabIndex = 2;
            // 
            // btnEliminar_D
            // 
            btnEliminar_D.Location = new Point(1012, 514);
            btnEliminar_D.Margin = new Padding(2);
            btnEliminar_D.Name = "btnEliminar_D";
            btnEliminar_D.Size = new Size(92, 29);
            btnEliminar_D.TabIndex = 4;
            btnEliminar_D.Text = "Eliminar";
            btnEliminar_D.UseVisualStyleBackColor = true;
            btnEliminar_D.Click += btnEliminar_D_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(902, 514);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(92, 29);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrarDoc
            // 
            btnRegistrarDoc.Location = new Point(799, 514);
            btnRegistrarDoc.Margin = new Padding(4);
            btnRegistrarDoc.Name = "btnRegistrarDoc";
            btnRegistrarDoc.Size = new Size(86, 31);
            btnRegistrarDoc.TabIndex = 6;
            btnRegistrarDoc.Text = "Registrar";
            btnRegistrarDoc.UseVisualStyleBackColor = true;
            btnRegistrarDoc.Click += btnRegistrarDoc_Click;
            // 
            // txtFiltroD
            // 
            txtFiltroD.CharacterCasing = CharacterCasing.Upper;
            txtFiltroD.Location = new Point(271, 28);
            txtFiltroD.Margin = new Padding(2);
            txtFiltroD.Name = "txtFiltroD";
            txtFiltroD.Size = new Size(220, 27);
            txtFiltroD.TabIndex = 7;
            txtFiltroD.TextChanged += txtFiltroD_TextChanged;
            txtFiltroD.KeyPress += txtFiltroD_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 8;
            label1.Text = "Ingrese Nombre de Docente:";
            // 
            // Docente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 594);
            Controls.Add(label1);
            Controls.Add(txtFiltroD);
            Controls.Add(btnRegistrarDoc);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar_D);
            Controls.Add(dtgDocente);
            Margin = new Padding(2);
            Name = "Docente";
            Text = "Docente";
            Load += Docente_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDocente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgDocente;
        private Button btnEliminar_D;
        private Button btnActualizar;
        private Button btnRegistrarDoc;
        private TextBox txtFiltroD;
        private Label label1;
    }
}