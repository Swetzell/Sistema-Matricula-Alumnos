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
using Matricula_BE;

namespace Matricula_GUI
{
    public partial class ActualizarAlumnoForm : Form
    {
        AlumnoBL objAlumnoBL = new AlumnoBL();
        AlumnoBE objAlumnoBE = new AlumnoBE();
        UbigeoBE objUbigeoBE = new UbigeoBE();
        UbigeoBL objUbigeoBL = new UbigeoBL();

        public ActualizarAlumnoForm()
        {
            InitializeComponent();
        }
        public String DniAlum { get; set; }

        public void CargarCarrera(string codigo)
        {
            CursoBL cursos = new CursoBL();

            cboCarreras.DataSource = cursos.ListaCarreras();
            cboCarreras.ValueMember = "codCarrera";
            cboCarreras.DisplayMember = "nomCarrera";
            cboCarreras.SelectedValue = codigo;
        }

        public void CargarUbigeo(String idDepa, String idProv, String idDist)
        {
            UbigeoBL ubigeoBL = new UbigeoBL();

            cboDepartamento.DataSource = ubigeoBL.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "idDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = idDepa;

            cboProvincia.DataSource = ubigeoBL.Ubigeo_ProvinciasDepartamentos(idDepa);
            cboProvincia.ValueMember = "idProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = idProv;

            cboDistrito.DataSource = ubigeoBL.Ubigeo_DistritosProvinciaDepartamento(idDepa, idProv);
            cboDistrito.ValueMember = "idDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = idDist;
        }

        private void ActualizarAlumnoForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtDepartamentos = objUbigeoBL.Ubigeo_Departamentos();
                if (dtDepartamentos != null && dtDepartamentos.Rows.Count > 0)
                {
                    cboDepartamento.DataSource = dtDepartamentos;
                    cboDepartamento.DisplayMember = "Departamento";
                    cboDepartamento.ValueMember = "IdDepa";
                }
                else
                {
                    throw new Exception("No se encontraron departamentos.");
                }

                // Cargar los datos de provincias basado en el departamento seleccionado
                if (cboDepartamento.SelectedValue != null)
                {
                    DataTable dtProvincias = objUbigeoBL.Ubigeo_ProvinciasDepartamentos(cboDepartamento.SelectedValue.ToString());
                    if (dtProvincias != null && dtProvincias.Rows.Count > 0)
                    {
                        cboProvincia.DataSource = dtProvincias;
                        cboProvincia.DisplayMember = "Provincia";
                        cboProvincia.ValueMember = "IdProv";
                    }
                    else
                    {
                        throw new Exception("No se encontraron provincias para el departamento seleccionado.");
                    }
                }

                // Cargar los datos de distritos basado en la provincia seleccionada
                if (cboDepartamento.SelectedValue != null && cboProvincia.SelectedValue != null)
                {
                    DataTable dtDistrito = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString());
                    if (dtDistrito != null && dtDistrito.Rows.Count > 0)
                    {
                        cboDistrito.DataSource = dtDistrito;
                        cboDistrito.DisplayMember = "Distrito";
                        cboDistrito.ValueMember = "IdDist";
                    }
                    else
                    {
                        throw new Exception("No se encontraron distritos para la provincia seleccionada.");
                    }
                }

                // Consultar datos del alumno
                objAlumnoBE = objAlumnoBL.ConsultarAlumno(this.DniAlum);
                if (objAlumnoBE == null)
                {
                    throw new Exception("No se encontró el alumno con el DNI especificado.");
                }

                // Cargar la imagen del perfil
                if (perfilBox.Image != null)
                {
                    perfilBox.Image.Dispose();
                    perfilBox.Image = null;
                }

                string fullPath = Path.Combine(Application.StartupPath, objAlumnoBE.foto);
                if (File.Exists(fullPath))
                {
                    try
                    {
                        perfilBox.Image = new Bitmap(fullPath);
                    }
                    catch
                    {
                        throw new Exception("El archivo de imagen de perfil no es válido.");
                    }
                }
                

                lblDni.Text = objAlumnoBE.dniAlum;
                if (string.IsNullOrWhiteSpace(lblDni.Text))
                {
                    throw new Exception("El DNI del alumno es obligatorio.");
                }

                txtNombre.Text = objAlumnoBE.nombreAlum;
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    throw new Exception("El nombre del alumno es obligatorio.");
                }

                txtApellido.Text = objAlumnoBE.apellidolAlum;
                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    throw new Exception("El apellido del alumno es obligatorio.");
                }

                if (objAlumnoBE.fechaNacimiento != DateTime.MinValue)
                {
                    dtFecha.Value = objAlumnoBE.fechaNacimiento;
                }
                else
                {
                    dtFecha.Value = DateTime.Now; 
                }

                txtCorreo.Text = objAlumnoBE.correoAlum;
                if (!EsValidoEmail(txtCorreo.Text))
                {
                    throw new Exception("El correo electrónico del alumno no es válido.");
                }

                mskCelular.Text = objAlumnoBE.celularAlum.ToString();
                if (!EsValidoNumero(mskCelular.Text))
                {
                    throw new Exception("El número de celular del alumno no es válido. Debe contener exactamente 9 dígitos.");
                }

                txtDomicilio.Text = objAlumnoBE.DireccionDomicilio;
                if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
                {
                    throw new Exception("El domicilio del alumno es obligatorio.");
                }

                CargarCarrera(objAlumnoBE.codCarrera.ToString());

                if (objAlumnoBE.idDepartamento != null && objAlumnoBE.idProvincia != null && objAlumnoBE.idDistrito != null)
                {
                    CargarUbigeo(objAlumnoBE.idDepartamento.ToString(), objAlumnoBE.idProvincia.ToString(), objAlumnoBE.idDistrito.ToString());
                }
                else
                {
                    throw new Exception("No carga el ubigeo.");
                }

                checkEstado.Checked = objAlumnoBE.EstadoAlum;
                checkCertificado.Checked = objAlumnoBE.certificadoAlum;

                if (objAlumnoBE.generoAlum == "M")
                {
                    radioMasculino.Checked = true;
                }
                else
                {
                    radioFemenino.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool EsValidoEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool EsValidoNumero(string numeroCel)
        {

            return numeroCel.All(char.IsDigit) && numeroCel.Length == 9;
        }

        private string nombreArchivo;

        private void btnImagen_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.png;)| *.jpg; *.jpeg; *.png;"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                // Liberar imagen previa si existe
                if (perfilBox.Image != null)
                {
                    perfilBox.Image.Dispose();
                    perfilBox.Image = null;
                }

                nombreArchivo = open.FileName;
                perfilBox.Image = new Bitmap(open.FileName);
            }
        }

        private void brnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    throw new Exception("El nombre es obligatorio");
                }

                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    throw new Exception("El apellido es obligatorio");
                }

                if (string.IsNullOrWhiteSpace(mskCelular.Text))
                {
                    throw new Exception("El número de celular es obligatorio");
                }
                else if (!EsValidoNumero(mskCelular.Text))
                {
                    throw new Exception("El número de celular no es válido. Debe contener exactamente 9 dígitos.");
                }

                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    throw new Exception("El correo electrónico es obligatorio");
                }
                else if (!EsValidoEmail(txtCorreo.Text))
                {
                    throw new Exception("El correo electrónico no es válido.");
                }

                if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
                {
                    throw new Exception("La dirección de domicilio es obligatoria");
                }

                if (cboDepartamento.SelectedValue == null)
                {
                    throw new Exception("Debe seleccionar un departamento.");
                }

                if (cboProvincia.SelectedValue == null)
                {
                    throw new Exception("Debe seleccionar una provincia.");
                }

                if (cboDistrito.SelectedValue == null)
                {
                    throw new Exception("Debe seleccionar un distrito.");
                }

                string relativePath = string.Empty;
                if (!string.IsNullOrEmpty(nombreArchivo))
                {
                    string fileName = Path.GetFileName(nombreArchivo);

                    // Obtener el directorio base de la aplicación
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    relativePath = Path.Combine("Resources", "Perfil", "Alumno", lblDni.Text.Trim() + Path.GetExtension(fileName));
                    string destinationPath = Path.Combine(baseDirectory, relativePath);

                    // Crear directorio si no existe
                    string directoryPath = Path.GetDirectoryName(destinationPath);
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    // Liberar la imagen en el PictureBox antes de copiar el archivo
                    if (perfilBox.Image != null)
                    {
                        perfilBox.Image.Dispose();
                        perfilBox.Image = null;
                    }

                    // Copiar el archivo a la nueva ubicación con la extensión correcta usando FileStream
                    using (FileStream sourceStream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read))
                    using (FileStream destinationStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
                    {
                        sourceStream.CopyTo(destinationStream);
                    }
                }
                else
                {
                    // Si no se seleccionó una nueva imagen, mantener la imagen existente del docente
                    relativePath = objAlumnoBE.foto;
                }

                // Actualizar datos del objeto DocenteBE
                objAlumnoBE.foto = relativePath;
                objAlumnoBE.dniAlum = lblDni.Text;
                objAlumnoBE.nombreAlum = txtNombre.Text.Trim();
                objAlumnoBE.apellidolAlum = txtApellido.Text.Trim();
                objAlumnoBE.fechaNacimiento = dtFecha.Value;
                objAlumnoBE.correoAlum = txtCorreo.Text.Trim();
                objAlumnoBE.celularAlum = Convert.ToInt64(mskCelular.Text.Trim());
                objAlumnoBE.DireccionDomicilio = txtDomicilio.Text.Trim();
                objAlumnoBE.codCarrera = Convert.ToInt64(cboCarreras.SelectedValue);
                objAlumnoBE.idDepartamento = cboDepartamento.SelectedValue.ToString();
                objAlumnoBE.idProvincia = cboProvincia.SelectedValue.ToString();
                objAlumnoBE.idDistrito = cboDistrito.SelectedValue.ToString();
                objAlumnoBE.EstadoAlum = checkEstado.Checked;
                objAlumnoBE.certificadoAlum = checkCertificado.Checked;
                objAlumnoBE.Usuario_Ult_Modificacion = "admin";
                objAlumnoBE.Fecha_Ult_Modificacion = DateTime.Now.Date;
                if (radioMasculino.Checked == true)
                {
                    objAlumnoBE.generoAlum = "M";
                }
                else
                {
                    objAlumnoBE.generoAlum = "F";
                }
                if (objAlumnoBL.ActualizarAlumno(objAlumnoBE) == true)
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), cboDistrito.SelectedValue.ToString());
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), cboDistrito.SelectedValue.ToString());
        }

        private void cboDistrito_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), cboDistrito.SelectedValue.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void perfilBox_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}