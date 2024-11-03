using Matricula_BE;
using Matricula_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula_GUI
{
    public partial class ActualizarDocenteForm : Form
    {
        DocenteBL objDocenteBL = new DocenteBL();
        DocenteBE objDocenteBE = new DocenteBE();
        UbigeoBE objUbigeoBE = new UbigeoBE();
        UbigeoBL objUbigeoBL = new UbigeoBL();
        public ActualizarDocenteForm()
        {
            InitializeComponent();
        }
        public String dniDoc { get; set; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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

        private void ActualizarDocenteForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos de la tabla Ubigeo
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

                objDocenteBE = objDocenteBL.ConsultarDocente(this.dniDoc);
                if (objDocenteBE == null)
                {
                    throw new Exception("No se encontró el docente con el DNI especificado.");
                }

                // Liberar imagen previa si existe
                if (perfilBox.Image != null)
                {
                    perfilBox.Image.Dispose();
                    perfilBox.Image = null;
                }

                // Cargar la nueva imagen
                string fullPath = Path.Combine(Application.StartupPath, objDocenteBE.FotoDocente);
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
                

                lblDniDocente.Text = objDocenteBE.dniDocente;
                if (string.IsNullOrWhiteSpace(lblDniDocente.Text))
                {
                    throw new Exception("El DNI del docente es obligatorio.");
                }

                txtNombre.Text = objDocenteBE.nombreDoc;
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    throw new Exception("El nombre del docente es obligatorio.");
                }

                txtApellido.Text = objDocenteBE.apellidoDoc;
                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    throw new Exception("El apellido del docente es obligatorio.");
                }

                txtCorreo.Text = objDocenteBE.correoDoc;
                if (!EsValidoEmail(txtCorreo.Text))
                {
                    throw new Exception("El correo electrónico del docente no es válido.");
                }

                if (objDocenteBE.fechaNacimiento != DateTime.MinValue)
                {
                    dtFechaDocente.Value = objDocenteBE.fechaNacimiento;
                }
                else
                {
                    dtFechaDocente.Value = DateTime.Now; 
                }

                mskCelular.Text = objDocenteBE.celularDoc.ToString();
                if (!EsValidoNumero(mskCelular.Text))
                {
                    throw new Exception("El número de celular del docente no es válido. Debe contener exactamente 9 dígitos.");
                }

                txtDomicilio.Text = objDocenteBE.DireccionDomicilio;
                if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
                {
                    throw new Exception("El domicilio del docente es obligatorio.");
                }

                CargarCarrera(objDocenteBE.codCarrera.ToString());

                if (objDocenteBE.idDepartamento != null && objDocenteBE.idProvincia != null && objDocenteBE.idDistrito != null)
                {
                    CargarUbigeo(objDocenteBE.idDepartamento.ToString(), objDocenteBE.idProvincia.ToString(), objDocenteBE.idDistrito.ToString());
                }
                else
                {
                    throw new Exception("No carga el ubigeo.");
                }

                checkEstado.Checked = objDocenteBE.EstadoDoc;

                if (objDocenteBE.generoDoc == "M")
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
        private bool EsValidoNumero(string numero)
        {
            // Verificar si el número contiene  9 dígitos
            return Regex.IsMatch(numero, @"^\d{9}$");
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

        private string nombreArchivo;

        private void btnImagen_Click(object sender, EventArgs e)
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos obligatorios
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    throw new Exception("El campo nombre es obligatorio.");
                }
                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    throw new Exception("El campo apellido es obligatorio.");
                }
                if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    throw new Exception("El campo correo electrónico es obligatorio.");
                }
                if (!EsValidoEmail(txtCorreo.Text))
                {
                    throw new Exception("El correo electrónico no es válido.");
                }
                if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
                {
                    throw new Exception("El campo domicilio es obligatorio.");
                }
                if (string.IsNullOrWhiteSpace(mskCelular.Text) || !EsValidoNumero(mskCelular.Text))
                {
                    throw new Exception("El número de celular no es válido. Debe contener exactamente 9 dígitos.");
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
                    relativePath = Path.Combine("Resources", "Perfil", "Docente", lblDniDocente.Text + Path.GetExtension(fileName));
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
                    relativePath = objDocenteBE.FotoDocente;
                }

                // Actualizar datos del objeto DocenteBE
                objDocenteBE.FotoDocente = relativePath;
                objDocenteBE.dniDocente = lblDniDocente.Text;
                objDocenteBE.nombreDoc = txtNombre.Text;
                objDocenteBE.apellidoDoc = txtApellido.Text;
                objDocenteBE.correoDoc = txtCorreo.Text;
                objDocenteBE.fechaNacimiento = dtFechaDocente.Value;
                objDocenteBE.celularDoc = Convert.ToInt64(mskCelular.Text);
                objDocenteBE.codCarrera = Convert.ToInt64(cboCarreras.SelectedValue);
                objDocenteBE.DireccionDomicilio = txtDomicilio.Text;
                objDocenteBE.idDepartamento = cboDepartamento.SelectedValue.ToString();
                objDocenteBE.idProvincia = cboProvincia.SelectedValue.ToString();
                objDocenteBE.idDistrito = cboDistrito.SelectedValue.ToString();
                objDocenteBE.EstadoDoc = checkEstado.Checked;
                if (radioMasculino.Checked)
                {
                    objDocenteBE.generoDoc = "M";
                }
                else if (radioFemenino.Checked)
                {
                    objDocenteBE.generoDoc = "F";
                }
                objDocenteBE.Fecha_Ult_Modificacion = DateTime.Now.Date;
                objDocenteBE.Usuario_Ult_Modificacion = "admin";

                // Llamar al método de actualización en el objeto BL
                if (objDocenteBL.ActualizarDocente(objDocenteBE))
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void perfilBox_Click(object sender, EventArgs e)
        {

        }
    }
}