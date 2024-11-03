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
    public partial class Curso : Form
    {
        // Instancias
        CursoBL objCursoBL = new CursoBL();
        DataView dtv;
        public Curso()
        {
            InitializeComponent();
        }


        private void CargarDatosD(string filtro = "")
        {
            try
            {
                DataTable cursosTable = objCursoBL.ListarCursos();
                if (cursosTable == null || cursosTable.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron cursos.");
                }
                else
                {
                    dtv = new DataView(cursosTable);
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        dtv.RowFilter = $"Nombre LIKE '%{filtro}%'";
                    }
                    dtgCursos.DataSource = dtv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}");
            }
        }

        private void btnActualizarCurso_Click(object sender, EventArgs e)
        {
            ActualizarCursoForm objActualizarCursoForm = new ActualizarCursoForm();
            objActualizarCursoForm.Codigo = dtgCursos.CurrentRow.Cells[0].Value.ToString();
            objActualizarCursoForm.ShowDialog();
            //para refrescar el dtgDatos..
            CargarDatosD(txtFiltroC.Text);
        }

        private void Curso_Load_1(object sender, EventArgs e)
        {
            CargarDatosD();
        }

        private void dtgCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            RegistrarCurso curso = new RegistrarCurso();
            curso.ShowDialog();

            CargarDatosD(txtFiltroC.Text);
        }

        private void btnEliminar_C_Click(object sender, EventArgs e)
        {
            try
            {
                String strCodigo = dtgCursos.CurrentRow.Cells[0].Value.ToString();
                DialogResult vrpt = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirmar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrpt == DialogResult.Yes)
                {
                    if (objCursoBL.EliminarCursos(strCodigo) == true)
                    {
                        CargarDatosD(String.Empty);
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

        private void txtFiltroC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosD(txtFiltroC.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtFiltroC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
    }
}
