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
    public partial class RegistrarCurso : Form
    {
        CursoBL cursol = new CursoBL();
        CursoBE cursob = new CursoBE();

        public RegistrarCurso()
        {
            InitializeComponent();
        }

        private void CargarCiclo(string genero)
        {
            DataTable dtGeneros = new DataTable();
            dtGeneros.Columns.Add("Nombre");
            dtGeneros.Columns.Add("Valor");

            dtGeneros.Rows.Add("1", "1");
            dtGeneros.Rows.Add("2", "2");
            dtGeneros.Rows.Add("3", "3");
            dtGeneros.Rows.Add("4", "4");
            dtGeneros.Rows.Add("5", "5");
            dtGeneros.Rows.Add("6", "6");

            boxCiclo.DataSource = dtGeneros;

            boxCiclo.DisplayMember = "Nombre";
            boxCiclo.ValueMember = "Valor";
            boxCiclo.SelectedValue = genero;
        }

        public void CargarCarrera(string codigo)
        {
            CursoBL cursos = new CursoBL();

            boxCarrera.DataSource = cursos.ListaCarreras();
            boxCarrera.ValueMember = "codCarrera";
            boxCarrera.DisplayMember = "nomCarrera";
            boxCarrera.SelectedValue = codigo;


        }

        private void RegistrarCurso_Load(object sender, EventArgs e)
        {
            CargarCarrera("1");
            CargarCiclo("1");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                cursob.codCarrera = Convert.ToInt16(boxCarrera.SelectedValue);
                cursob.ciclo = Convert.ToInt16(boxCiclo.SelectedValue);
                cursob.nomCurso = txtCurso.Text.Trim();
                cursob.Usuario_Registro = "admin";
                cursob.EstadoCurso = true;

                if (cursol.RegistrarCurso(cursob) == true)
                {
                    MessageBox.Show("Se realizo con exito la creacion del curso");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
    }
}
