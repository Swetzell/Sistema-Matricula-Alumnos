using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matricula_BE;
using Matricula_BL;

namespace Matricula_GUI

{
    public partial class RegistrarSeccion : Form

    {
        SeccionBE objSeccionBE = new SeccionBE();
        SeccionBL SeccionBL = new SeccionBL();
        public RegistrarSeccion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
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
                    throw new Exception("Debe seleccionar una modalidad");
                }

                if(cboDocentes != null && cboDocentes.SelectedValue != null && cboDocentes.SelectedValue.ToString() != "0")
                {
                    objSeccionBE.dniDocente = cboDocentes.SelectedValue.ToString();
                }
                else
                {
                    throw new Exception("Debe seleccionar un docente.");
                }

                if (cboCurso != null && cboCurso.SelectedValue != null && cboCurso.SelectedValue.ToString() != "0")
                {
                    objSeccionBE.codCurso = cboCurso.SelectedValue.ToString();
                }
                else
                {
                    throw new Exception("Debe seleccionar un curso.");
                }

                if (cboAulas != null && cboAulas.SelectedValue != null && cboAulas.SelectedValue.ToString() != "0")
                {
                    objSeccionBE.Id_AulaDR = cboAulas.SelectedValue.ToString();
                }
                else
                {
                    throw new Exception("Debe seleccionar un aula.");
                }

                objSeccionBE.Usuario_Registro = "admin";
                objSeccionBE.EstadoSeccion = true;
                if (SeccionBL.RegistrarSeccion(objSeccionBE) == true)
                {
                    MessageBox.Show("Fue registrado con exito");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void CargarCurso(string codigo)
        {
            CursoBL objcursos = new CursoBL();

            
            DataTable tablaCursos = objcursos.ListarCursos();  

            
            DataRow nuevaFila = tablaCursos.NewRow();
            nuevaFila["Curso"] = 0;
            nuevaFila["Nombre"] = "--Seleccione--";          
            tablaCursos.Rows.InsertAt(nuevaFila, 0);

            
            cboCurso.DataSource = tablaCursos;
            cboCurso.ValueMember = "Curso";
            cboCurso.DisplayMember = "Nombre";
            cboCurso.SelectedValue = codigo;
        }
        public void CargarAulas(string codigo)
        {
            SeccionBL objseccion = new SeccionBL();


            DataTable tablaAulas = objseccion.ListarAula();


            DataRow nuevaFila = tablaAulas.NewRow();
            nuevaFila["Id_AulaDR"] = 0;
            nuevaFila["Id_AulaDR"] = "--Seleccione--";
            tablaAulas.Rows.InsertAt(nuevaFila, 0);


            cboAulas.DataSource = tablaAulas;
            cboAulas.ValueMember = "Id_AulaDR";
            cboAulas.DisplayMember = "Id_AulaDR";
            cboAulas.SelectedValue = codigo;
        }
        public void CargarDocentes(string codigo)
        {
            DocenteBL objdocentes = new DocenteBL();

            DataTable tablaDocentes = objdocentes.ListarDocente();


            DataRow nuevaFilaDocente = tablaDocentes.NewRow();
            nuevaFilaDocente["Dni"] = 0;
            nuevaFilaDocente["Nombre"] = "--Seleccione--";
            tablaDocentes.Rows.InsertAt(nuevaFilaDocente, 0);

            cboDocentes.DataSource = objdocentes.ListarDocenteC();
            cboDocentes.ValueMember = "Dni";
            cboDocentes.DisplayMember = "Nombre";
            cboDocentes.SelectedValue = codigo;
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
        }


        private void RegistrarSeccion_Load(object sender, EventArgs e)
        {
            CargarCurso("0");
            CargarDocentes("0");
            CargarDiaSemana("LUNES");
            CargarAulas("0");
        }

    }
}
