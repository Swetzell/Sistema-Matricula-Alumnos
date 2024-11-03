using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matricula_BL;

namespace Matricula_GUI
{
    public partial class Docente : Form
    {
        // Instancias
        DocenteBL objDocenteBL = new DocenteBL();
        DataView dtv;
        public Docente()
        {
            InitializeComponent();
        }

        private void Docente_Load(object sender, EventArgs e)
        {
            CargarDatosD();
        }

        public void CargarDatosD(string filtro = "")
        {
            try
            {
                // Supongamos que objDocenteBL.ListarDocente() devuelve un DataTable
                DataTable docentesTable = objDocenteBL.ListarDocente();
                if (docentesTable == null || docentesTable.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron docentes.");
                }
                else
                {
                    dtv = new DataView(docentesTable);
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        dtv.RowFilter = $"Nombre LIKE '%{filtro}%'";
                    }
                    dtgDocente.DataSource = dtv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}");
            }
        }
        private void btnEliminar_D_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos el codigo de Alumno
                String strCodigo = dtgDocente.CurrentRow.Cells[0].Value.ToString();
                DialogResult vrpt = MessageBox.Show("¿Esta seguro de eliminar el registro?", "confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrpt == DialogResult.Yes)
                {
                    if (objDocenteBL.EliminarDocente(strCodigo) == true)
                    {
                        MessageBox.Show("Registro eliminado");
                        CargarDatosD(String.Empty);
                    }
                    else
                    {
                        throw new Exception("No se puede eliminar el registro porque esta vinculado a otra tabla");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDocenteForm objActualizarDocenteForn = new ActualizarDocenteForm();
            objActualizarDocenteForn.dniDoc = dtgDocente.CurrentRow.Cells[0].Value.ToString();
            objActualizarDocenteForn.ShowDialog();
            //para refrescar el dtgDatos..
            CargarDatosD(txtFiltroD.Text);
        }


        private void btnRegistrarDoc_Click(object sender, EventArgs e)
        {
            RegistrarDocente rdc = new RegistrarDocente();
            rdc.ShowDialog();

            //para refrescar el dtgDatos..
            CargarDatosD(txtFiltroD.Text);

        }

        private void txtFiltroD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosD(txtFiltroD.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtFiltroD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
    }
}
