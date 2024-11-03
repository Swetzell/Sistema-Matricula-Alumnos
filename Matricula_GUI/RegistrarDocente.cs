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
using Matricula_BE;

namespace Matricula_GUI
{
    public partial class RegistrarDocente : Form
    {
        DocenteBE docBe = new DocenteBE();
        DocenteBL docBL = new DocenteBL();
        Docente docenteForm = new Docente();

        public RegistrarDocente()
        {
            InitializeComponent();
        }

        public void CargarUbigeo(String idDepa, String idProv, String idDist)
        {
            UbigeoBL ubigeoBL = new UbigeoBL();

            boxDepartamento.DataSource = ubigeoBL.Ubigeo_Departamentos();
            boxDepartamento.ValueMember = "idDepa";
            boxDepartamento.DisplayMember = "Departamento";
            boxDepartamento.SelectedValue = idDepa;

            boxProvincia.DataSource = ubigeoBL.Ubigeo_ProvinciasDepartamentos(idDepa);
            boxProvincia.ValueMember = "idProv";
            boxProvincia.DisplayMember = "Provincia";
            boxProvincia.SelectedValue = idProv;

            boxDistrito.DataSource = ubigeoBL.Ubigeo_DistritosProvinciaDepartamento(idDepa, idProv);
            boxDistrito.ValueMember = "idDist";
            boxDistrito.DisplayMember = "Distrito";
            boxDistrito.SelectedValue = idDist;
        }

        public void CargarCarrera(string codigo)
        {
            CursoBL cursos = new CursoBL();

            boxCarrera.DataSource = cursos.ListaCarreras();
            boxCarrera.ValueMember = "codCarrera";
            boxCarrera.DisplayMember = "nomCarrera";
            boxCarrera.SelectedValue = codigo;


        }

        private void CargarGenero(string genero)
        {
            DataTable dtGeneros = new DataTable();
            dtGeneros.Columns.Add("Nombre");
            dtGeneros.Columns.Add("Valor");

            dtGeneros.Rows.Add("Femenino", "F");
            dtGeneros.Rows.Add("Masculino", "M");

            txtGenero.DataSource = dtGeneros;

            txtGenero.DisplayMember = "Nombre";
            txtGenero.ValueMember = "Valor";
            txtGenero.SelectedValue = genero;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarUbigeo("14", "01", "01");
            CargarCarrera("13");
            CargarGenero("M");
        }

        private void RegistrarDocente_Load(object sender, EventArgs e)
        {
            CargarUbigeo("14", "01", "01");
            CargarCarrera("13");
            CargarGenero("M");
        }

        private void boxDepartamento_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            CargarUbigeo(boxDepartamento.SelectedValue.ToString(), "01", "01");

        }

        private void boxProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(boxDepartamento.SelectedValue.ToString(), boxProvincia.SelectedValue.ToString(), "01");
        }

        private string nombreArchivo;

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.png;)| *.jpg; *.jpeg; *.png;"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = open.FileName;
                perfilBox.Image = new Bitmap(open.FileName);
            }
        }
        private bool ValidarCorreo(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nombreArchivo) || !File.Exists(nombreArchivo))
                {
                    MessageBox.Show("Error: Falta poner una foto.");
                    return;
                }

                if (!ValidarCorreo(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Error: El formato del correo es inválido.");
                    return;
                }

                string fileName = Path.GetFileName(nombreArchivo);

                // Obtener el directorio base de la aplicación
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string relativePath = Path.Combine("Resources", "Perfil", "Docente", txtDNI.Text + Path.GetExtension(fileName));
                string destinationPath = Path.Combine(baseDirectory, relativePath);

                // Crear directorio si no existe
                string directoryPath = Path.GetDirectoryName(destinationPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Copiar el archivo a la nueva ubicación con la extensión correcta
                File.Copy(nombreArchivo, destinationPath, true);

                docBe.dniDocente = txtDNI.Text.Trim();
                docBe.nombreDoc = txtNombre.Text.Trim();
                docBe.apellidoDoc = txtApellido.Text.Trim();
                docBe.correoDoc = txtEmail.Text.Trim();
                docBe.celularDoc = Convert.ToInt64(txtCelular.Text);
                docBe.idUbigeo = boxDepartamento.SelectedValue.ToString() + boxProvincia.SelectedValue.ToString() + boxDistrito.SelectedValue.ToString();
                docBe.DireccionDomicilio = boxDomicilio.Text.Trim();
                docBe.codCarrera = Convert.ToInt64(boxCarrera.SelectedValue.ToString());
                docBe.EstadoDoc = true;
                docBe.Usuario_Registro = "admin";
                docBe.FotoDocente = relativePath; // Guardar la ruta relativa en la base de datos
                docBe.fechaNacimiento = dateAlumno.Value;
                docBe.generoDoc = txtGenero.SelectedValue.ToString();

                if (docBL.RegistrarDocente(docBe) == true)
                {
                    MessageBox.Show("Fue creado con exito");
                    this.Close();
                    docenteForm.CargarDatosD();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: El formato del correo es inválido.");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("correo electrónico") || ex.Message.Contains("email"))
                {
                    MessageBox.Show("Error: El correo es inválido.");
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
    }
}