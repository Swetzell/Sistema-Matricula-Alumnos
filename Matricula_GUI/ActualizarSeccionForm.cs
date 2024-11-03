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
    public partial class ActualizarSeccionForm : Form
    {

        SeccionBE objSeccionBE = new SeccionBE();
        SeccionBL objSeccionBL = new SeccionBL();
        public ActualizarSeccionForm()
        {
            InitializeComponent();
        }
        public String NRC { get; set; }
        private void btnActualizarSeccion_Click(object sender, EventArgs e)
        {
            try
            {
                           
                if (txtDireccionA.Text.Trim() == String.Empty)
                {
                    throw new Exception("El campo dirección del aula es obligatorio");
                }
                
                objSeccionBE.seccionNRC = lblNrc.Text;
                objSeccionBE.codCurso = cboCurso.SelectedValue.ToString();
                objSeccionBE.dniDocente = cboDocentes.SelectedValue.ToString();
                objSeccionBE.Id_AulaDR = txtDireccionA.Text;
                objSeccionBE.horaInicio = dtHoraInicio.Value.TimeOfDay;
                objSeccionBE.horaFin = dtHoraFin.Value.TimeOfDay;
                objSeccionBE.fechaInicio = dtFechaInicio.Value;
                objSeccionBE.fechaFinal = dtFechaFinal.Value;
                objSeccionBE.diaSemana = cboDiaSemana.SelectedValue.ToString();
                if (radioPresencial.Checked)
                {
                    objSeccionBE.modalidad = "PRESENCIAL";
                }
                else if (radioRemoto.Checked)
                {
                    objSeccionBE.modalidad = "REMOTA";
                }
                else
                {
                    throw new Exception("Debe seleccionar una modalidad (Presencial o Virtual)");
                }
                objSeccionBE.EstadoSeccion = checkEstado.Checked;
                objSeccionBE.Fecha_Ult_Modificacion = DateTime.Now.Date;
                objSeccionBE.Usuario_Ult_Modificacion = "cadminnnn";

                if (objSeccionBL.ActualizarSeccion(objSeccionBE) == true)
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

        private void ActualizarSeccionForm_Load(object sender, EventArgs e)
        {
            try
            {
                objSeccionBE = objSeccionBL.ConsultarSeccion(this.NRC);
                lblNrc.Text = objSeccionBE.seccionNRC;
                txtDireccionA.Text = objSeccionBE.Id_AulaDR.ToString();

                DateTime today = DateTime.Today;
                dtHoraInicio.Value = today.Add(objSeccionBE.horaInicio);
                dtHoraFin.Value = today.Add(objSeccionBE.horaFin);
                dtFechaInicio.Value = Convert.ToDateTime(objSeccionBE.fechaInicio);
                dtFechaFinal.Value = Convert.ToDateTime(objSeccionBE.fechaFinal);
                checkEstado.Checked = Convert.ToBoolean(objSeccionBE.EstadoSeccion);
                CargarModalidad(objSeccionBE.modalidad);
                CargarDiaSemana(objSeccionBE.diaSemana);
                CargarCurso(objSeccionBE.codCurso);
                CargarDocentes(objSeccionBE.dniDocente);
           
                checkEstado.Checked = Convert.ToBoolean(objSeccionBE.EstadoSeccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        public void CargarCurso(string codigo)
        {
            CursoBL objcursos = new CursoBL();

            cboCurso.DataSource = objcursos.ListarCursos();
            cboCurso.ValueMember = "Curso";
            cboCurso.DisplayMember = "Nombre";
            cboCurso.SelectedValue = codigo;
        }

        public void CargarDocentes(string codigo)
        {
            DocenteBL objdocentes = new DocenteBL();

            cboDocentes.DataSource = objdocentes.ListarDocenteC();
            cboDocentes.ValueMember = "Dni";
            cboDocentes.DisplayMember = "Nombre";
            cboDocentes.SelectedValue = codigo;
        }

        public void CargarModalidad(string modalidad)
        {
            if (modalidad == "PRESENCIAL")
            {
                radioPresencial.Checked = true;
                radioRemoto.Checked = false;
            }
            else if (modalidad == "REMOTA")
            {
                radioPresencial.Checked = false;
                radioRemoto.Checked = true;
            }
            else
            {
                radioPresencial.Checked = false;
                radioRemoto.Checked = false;
            }
        }

        public void CargarDiaSemana(string diaSemana)
        {
            List<string> diasSemana = new List<string>
            {
                 "LUNES",
                 "MARTES",
                 "MIERCOLES",
                 "JUEVES",
                 "VIERNES",
                 "SABADO",              
            };

            cboDiaSemana.DataSource = diasSemana;

            if (!string.IsNullOrEmpty(diaSemana) && diasSemana.Contains(diaSemana))
            {
                cboDiaSemana.SelectedItem = diaSemana;
            }
            else
            {
                cboDiaSemana.SelectedIndex = 0; // Selecciona el primer día de la semana por defecto si el valor no es válido
            }
        }
        
        private void btnCancelarSeccion_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
    }
}
