using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregado
using Matricula_BL;

namespace Matricula_GUI
{
    public partial class Alumno : Form
    {
        // Instancias
        AlumnoBL objAlumnoBL = new AlumnoBL();
        DataView dtv;
        public Alumno()
        {
            InitializeComponent();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }
        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objAlumnoBL.ListarAlumno());
            dtv.RowFilter = "Dni like '%" + strFiltro + "%'";
            dtgAlumnos.DataSource = dtv;


        }
        private void btnEliminar_A_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos el codigo de Alumno
                String strCodigo = dtgAlumnos.CurrentRow.Cells[0].Value.ToString();
                DialogResult vrpt = MessageBox.Show("¿Esta seguro de eliminar el registro?", "confimar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrpt == DialogResult.Yes)
                {
                    if (objAlumnoBL.EliminarAlumno(strCodigo) == true)
                    {
                        CargarDatos(String.Empty);
                    }
                    else
                    {
                        throw new Exception("No se puede eliminar el registro porque esta vinculado a otra tabla");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarAlumnoForm objActualizarAlumnoForm = new ActualizarAlumnoForm();
            objActualizarAlumnoForm.DniAlum = dtgAlumnos.CurrentRow.Cells[0].Value.ToString();
            objActualizarAlumnoForm.ShowDialog();

            //para refrescar el dtgDatos..
            CargarDatos(txtFiltroA.Text);
        }

        private void dtgAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarAlumno rgAlumno = new RegistrarAlumno();
            rgAlumno.ShowDialog();
            //para refrescar el dtgDatos..
            CargarDatos(txtFiltroA.Text);
        }

        private void txtFiltroA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltroA.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtFiltroA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
