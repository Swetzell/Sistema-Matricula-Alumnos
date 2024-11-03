namespace Matricula_GUI
{
    partial class MDI
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            statusStrip1 = new StatusStrip();
            lblConexion = new ToolStripStatusLabel();
            lblSesion = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            alumnoToolStripMenuItem1 = new ToolStripMenuItem();
            docenteToolStripMenuItem1 = new ToolStripMenuItem();
            seccionToolStripMenuItem1 = new ToolStripMenuItem();
            cursoToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1353, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblConexion, lblSesion });
            statusStrip1.Location = new Point(0, 890);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1353, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblConexion
            // 
            lblConexion.BackColor = SystemColors.HotTrack;
            lblConexion.ForeColor = SystemColors.Info;
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(71, 20);
            lblConexion.Text = "Conexion";
            // 
            // lblSesion
            // 
            lblSesion.Name = "lblSesion";
            lblSesion.Size = new Size(52, 20);
            lblSesion.Text = "Sesion";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alumnoToolStripMenuItem1, docenteToolStripMenuItem1, seccionToolStripMenuItem1, cursoToolStripMenuItem1 });
            mantenimientosToolStripMenuItem.Image = Properties.Resources.Editar;
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(150, 24);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // alumnoToolStripMenuItem1
            // 
            alumnoToolStripMenuItem1.Image = Properties.Resources.dude4;
            alumnoToolStripMenuItem1.Name = "alumnoToolStripMenuItem1";
            alumnoToolStripMenuItem1.Size = new Size(148, 26);
            alumnoToolStripMenuItem1.Text = "Alumno";
            alumnoToolStripMenuItem1.Click += mantenimientoToolStripMenuItem_Click;
            // 
            // docenteToolStripMenuItem1
            // 
            docenteToolStripMenuItem1.Image = Properties.Resources.user1;
            docenteToolStripMenuItem1.Name = "docenteToolStripMenuItem1";
            docenteToolStripMenuItem1.Size = new Size(148, 26);
            docenteToolStripMenuItem1.Text = "Docente";
            docenteToolStripMenuItem1.Click += mantenimientoToolStripMenuItem1_Click;
            // 
            // seccionToolStripMenuItem1
            // 
            seccionToolStripMenuItem1.Image = Properties.Resources.Home2;
            seccionToolStripMenuItem1.Name = "seccionToolStripMenuItem1";
            seccionToolStripMenuItem1.Size = new Size(148, 26);
            seccionToolStripMenuItem1.Text = "Seccion";
            seccionToolStripMenuItem1.Click += mantenimientoToolStripMenuItem2_Click;
            // 
            // cursoToolStripMenuItem1
            // 
            cursoToolStripMenuItem1.Image = Properties.Resources.book_blue;
            cursoToolStripMenuItem1.Name = "cursoToolStripMenuItem1";
            cursoToolStripMenuItem1.Size = new Size(148, 26);
            cursoToolStripMenuItem1.Text = "Curso";
            cursoToolStripMenuItem1.Click += mantenimientoToolStripMenuItem3_Click;
            // 
            // MDI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4e5ca683611aa9cace61bda974f1b344;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1353, 916);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1369, 952);
            Name = "MDI";
            Text = "MDI";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDI_FormClosing;
            FormClosed += MDI_FormClosed;
            Load += MDI_Load;
            Resize += MDI_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel lblConexion;
        private ToolStripStatusLabel lblSesion;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem alumnoToolStripMenuItem1;
        private ToolStripMenuItem docenteToolStripMenuItem1;
        private ToolStripMenuItem seccionToolStripMenuItem1;
        private ToolStripMenuItem cursoToolStripMenuItem1;
    }
}