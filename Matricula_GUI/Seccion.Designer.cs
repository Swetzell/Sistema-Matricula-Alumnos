namespace Matricula_GUI
{
    partial class Seccion
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
            dtgSeccion = new DataGridView();
            btnEliminar_S = new Button();
            btnActualizarSeccion = new Button();
            label1 = new Label();
            txtFiltroS = new TextBox();
            btnseccion = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgSeccion).BeginInit();
            SuspendLayout();
            // 
            // dtgSeccion
            // 
            dtgSeccion.AllowUserToAddRows = false;
            dtgSeccion.AllowUserToDeleteRows = false;
            dtgSeccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSeccion.Location = new Point(65, 121);
            dtgSeccion.Margin = new Padding(2, 3, 2, 3);
            dtgSeccion.Name = "dtgSeccion";
            dtgSeccion.ReadOnly = true;
            dtgSeccion.RowHeadersWidth = 82;
            dtgSeccion.Size = new Size(1035, 355);
            dtgSeccion.TabIndex = 2;
            // 
            // btnEliminar_S
            // 
            btnEliminar_S.Location = new Point(1009, 513);
            btnEliminar_S.Margin = new Padding(2, 3, 2, 3);
            btnEliminar_S.Name = "btnEliminar_S";
            btnEliminar_S.Size = new Size(91, 29);
            btnEliminar_S.TabIndex = 4;
            btnEliminar_S.Text = "Eliminar";
            btnEliminar_S.UseVisualStyleBackColor = true;
            btnEliminar_S.Click += btnEliminar_S_Click;
            // 
            // btnActualizarSeccion
            // 
            btnActualizarSeccion.Location = new Point(918, 513);
            btnActualizarSeccion.Margin = new Padding(3, 4, 3, 4);
            btnActualizarSeccion.Name = "btnActualizarSeccion";
            btnActualizarSeccion.Size = new Size(86, 31);
            btnActualizarSeccion.TabIndex = 5;
            btnActualizarSeccion.Text = "Actualizar";
            btnActualizarSeccion.UseVisualStyleBackColor = true;
            btnActualizarSeccion.Click += btnActualizarSeccion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 7;
            label1.Text = "Ingrese NRC de Seccion:";
            // 
            // txtFiltroS
            // 
            txtFiltroS.CharacterCasing = CharacterCasing.Upper;
            txtFiltroS.Location = new Point(279, 40);
            txtFiltroS.Margin = new Padding(2, 1, 2, 1);
            txtFiltroS.Name = "txtFiltroS";
            txtFiltroS.Size = new Size(174, 27);
            txtFiltroS.TabIndex = 8;
            txtFiltroS.TextChanged += txtFiltroS_TextChanged;
            // 
            // btnseccion
            // 
            btnseccion.Location = new Point(825, 513);
            btnseccion.Margin = new Padding(3, 4, 3, 4);
            btnseccion.Name = "btnseccion";
            btnseccion.Size = new Size(86, 31);
            btnseccion.TabIndex = 9;
            btnseccion.Text = "Registrar";
            btnseccion.UseVisualStyleBackColor = true;
            btnseccion.Click += btnseccion_Click;
            // 
            // Seccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 576);
            Controls.Add(btnseccion);
            Controls.Add(txtFiltroS);
            Controls.Add(label1);
            Controls.Add(btnActualizarSeccion);
            Controls.Add(btnEliminar_S);
            Controls.Add(dtgSeccion);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Seccion";
            Text = "Seccion";
            Load += Seccion_Load;
            ((System.ComponentModel.ISupportInitialize)dtgSeccion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgSeccion;
        private Button btnEliminar_S;
        private Button btnActualizarSeccion;
        private Label label1;
        private TextBox txtFiltroS;
        private Button btnseccion;
    }
}