    using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula_GUI
{
    public partial class MDI : Form
    {
        TimeSpan horaInicio;
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Fecha y Hora: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            validarConexion();
            lblSesion.Text = "Sesión: " + (DateTime.Now.TimeOfDay - horaInicio).ToString().Substring(0, 8);
        }

        private void validarConexion()
        {
            Computer miPc = new Computer();
            if (miPc.Network.IsAvailable)
            {
                lblConexion.Text = "Internet Conectado";
            }
            else
            {
                lblConexion.Text = "Internet Desconectado";
            }
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            horaInicio = DateTime.Now.TimeOfDay;
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumno frmAlumno = new Alumno();
            frmAlumno.MdiParent = this;
            frmAlumno.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Docente frmDocente = new Docente();
            frmDocente.MdiParent = this;
            frmDocente.Show();
        }

        private void mantenimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Seccion frmSeccion = new Seccion();
            frmSeccion.MdiParent = this;
            frmSeccion.Show();
        }

        private void mantenimientoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Curso frmCurso = new Curso();
            frmCurso.MdiParent = this;
            frmCurso.Show();
        }

        private void MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpt = MessageBox.Show("¿Esta seguro de cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vrpt == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
