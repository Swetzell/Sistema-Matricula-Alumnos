using Matricula_BE;
using Matricula_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula_GUI
{
    public partial class Login : Form
    {
        Int16 intentos = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUsuario.Text.Trim();
                string contrasena = txtContrasena.Text.Trim();

                if (usuario == String.Empty || contrasena == String.Empty)
                {
                    intentos++;
                    validarIntentos();
                    throw new Exception("Debe ingresar el usuario y contraseña");
                }

                UserBL userBL = new UserBL();
                UserBE usuarioValidado = userBL.ValidarUsuario(usuario, contrasena);

                if (usuarioValidado != null)
                {
                    MDI frm1 = new MDI();
                    frm1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                    intentos++;
                    validarIntentos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void validarIntentos()
        {
            if(intentos == 3)
            {
                MessageBox.Show("Superó el numero de intentos",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
