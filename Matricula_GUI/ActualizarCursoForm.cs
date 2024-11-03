using Matricula_BE;
using Matricula_BL;
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
    public partial class ActualizarCursoForm : Form
    {
        CursoBE objcursoBE = new CursoBE();
        CursoBL objcursoBL = new CursoBL();

        public ActualizarCursoForm()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCarrera.Text.Trim() == String.Empty)
                {
                    throw new Exception("El código de la carrera es obligatorio");
                }
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre del curso es obligatorio");
                }
                objcursoBE.codCurso = lblCodCurso.Text;
                objcursoBE.codCarrera = Convert.ToInt16(txtCarrera.Text);
                objcursoBE.nomCurso = txtNombre.Text;
                objcursoBE.ciclo = Convert.ToInt16(mskCiclo.Text);
                objcursoBE.EstadoCurso = Convert.ToBoolean(checkEstado.Checked);
                objcursoBE.Fecha_Ult_Modificacion = DateTime.Now.Date;
                objcursoBE.Usuario_Ult_Modificacion = "admin";

                if (objcursoBL.ActualizarCurso(objcursoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizó el registro, contacte con soporte");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void ActualizarCursoForm_Load(object sender, EventArgs e)
        {
            try
            {
                objcursoBE = objcursoBL.ConsultarCurso(this.Codigo);
                lblCodCurso.Text = objcursoBE.codCurso;
                txtCarrera.Text = objcursoBE.codCarrera.ToString();
                txtNombre.Text = objcursoBE.nomCurso;
                mskCiclo.Text = objcursoBE.ciclo.ToString();
                checkEstado.Checked = Convert.ToBoolean(objcursoBE.EstadoCurso);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
    }
}
