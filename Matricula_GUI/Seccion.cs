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
    public partial class Seccion : Form
    {
        // Instancias
        SeccionBL objSeccionBL = new SeccionBL();
        DataView dtv;

        public Seccion()
        {
            InitializeComponent();
        }

        private void Seccion_Load(object sender, EventArgs e)
        {
            CargarDatosS("");
        }

        private void CargarDatosS(string filtro = "")
        {
            try
            {
                DataTable seccionesTable = objSeccionBL.ListarSecciones();
                if (seccionesTable == null || seccionesTable.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron secciones.");
                }
                else
                {
                    dtv = new DataView(objSeccionBL.ListarSecciones());
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        dtv.RowFilter = $"NRC LIKE '%{filtro}%'";
                    }
                    dtgSeccion.DataSource = dtv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}");
            }
        }

        private void btnEliminar_S_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos el codigo de Alumno
                String strCodigo = dtgSeccion.CurrentRow.Cells[0].Value.ToString();
                DialogResult vrpt = MessageBox.Show("¿Esta seguro de eliminar el registro?", "confimar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrpt == DialogResult.Yes)
                {
                    if (objSeccionBL.EliminarSeccion(strCodigo) == true)
                    {
                        CargarDatosS(String.Empty);
                        MessageBox.Show("Registro eliminado");
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

        private void btnActualizarSeccion_Click(object sender, EventArgs e)
        {
            ActualizarSeccionForm objactualizarSeccionForm = new ActualizarSeccionForm();
            objactualizarSeccionForm.NRC = dtgSeccion.CurrentRow.Cells[0].Value.ToString();
            objactualizarSeccionForm.ShowDialog();
            CargarDatosS(txtFiltroS.Text);
        }

        private void txtFiltroS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosS(txtFiltroS.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnseccion_Click(object sender, EventArgs e)
        {
            RegistrarSeccion seccion = new RegistrarSeccion();

            seccion.ShowDialog();
        }
    }
}
