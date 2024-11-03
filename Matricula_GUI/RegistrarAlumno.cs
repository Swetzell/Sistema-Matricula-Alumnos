using System.Data;
using System.Windows.Forms;
using Matricula_BL;
using Matricula_BE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Matricula_GUI
{

    public partial class RegistrarAlumno : Form
    {
        AlumnoBL objAlumnoBL = new AlumnoBL();
        AlumnoBE objAlumnoBE = new AlumnoBE();
        public RegistrarAlumno()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private string nombreArchivo;

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.png;)| *.jpg; *.jpeg; *.png;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = open.FileName;
                perfilBox.Image = new Bitmap(open.FileName);
            }
        }
        public event EventHandler AlumnoRegistrado;
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
        private void btnRegistrar_Click(object sender, EventArgs e)
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
                string relativePath = Path.Combine("Resources", "Perfil", "Alumno", txtDNI.Text + Path.GetExtension(fileName));
                string destinationPath = Path.Combine(baseDirectory, relativePath);

                // Crear directorio si no existe
                string directoryPath = Path.GetDirectoryName(destinationPath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Copiar el archivo a la nueva ubicación con la extensión correcta
                File.Copy(nombreArchivo, destinationPath, true);

                objAlumnoBE.dniAlum = txtDNI.Text;
                objAlumnoBE.nombreAlum = txtNombre.Text.Trim();
                objAlumnoBE.apellidolAlum = txtApellido.Text.Trim();
                objAlumnoBE.fechaNacimiento = dateAlumno.Value;
                objAlumnoBE.correoAlum = txtEmail.Text.Trim();
                objAlumnoBE.celularAlum = Convert.ToInt64(txtCelular.Text);
                objAlumnoBE.DireccionDomicilio = boxDomicilio.Text.Trim();
                objAlumnoBE.codCarrera = Convert.ToInt16(boxCarrera.SelectedValue.ToString());
                objAlumnoBE.foto = relativePath;
                objAlumnoBE.idDepartamento = boxDepartamento.SelectedValue.ToString();
                objAlumnoBE.idProvincia = boxProvincia.SelectedValue.ToString();
                objAlumnoBE.idDistrito = boxDistrito.SelectedValue.ToString();
                objAlumnoBE.Usuario_Registro = "admin";
                objAlumnoBE.EstadoAlum = true;
                objAlumnoBE.certificadoAlum = true;
                objAlumnoBE.generoAlum = txtGenero.SelectedValue.ToString();

                if (objAlumnoBL.RegistrarAlumno(objAlumnoBE) == true)
                {
                    MessageBox.Show("Fue creado con exito");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void txtGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtGenero_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void txtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtGenero_Click(object sender, EventArgs e)
        {
            txtGenero.DroppedDown = true;

        }

        private void txtGenero_MouseEnter(object sender, EventArgs e)
        {

        }

        private void boxDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void boxProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void boxDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boxDistrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boxDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(boxDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void boxProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(boxDepartamento.SelectedValue.ToString(), boxProvincia.SelectedValue.ToString(), "01");
        }

        private void perfilBox_Click(object sender, EventArgs e)
        {

        }
    }
}
