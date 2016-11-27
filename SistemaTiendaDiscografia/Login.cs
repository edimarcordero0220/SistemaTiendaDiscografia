using System;
//using SistemaTiendaDiscografia.Principal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace SistemaTiendaDiscografia
{
    public partial class Login : Form

    {
        Principal p = new Principal();
        private object then;
        public Login()
        {
            InitializeComponent();
        }

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarSesion()==DialogResult.OK)
            {
                this.Visible = false;
                p.Show();
            }
            /*else
            {
                MessageBox.Show("Llene Los Campos");
            }*/
        }
        public bool ValidarUsuario()
        {
            if(UsuariosBLL.GetListaNombre(NombretextBox.Text).Count()==0)
            {
                MessageBox.Show("Usuario No Registrado");
                return false;
            }
            return true;
        }
        public bool ValidarContrasena()
        {
            if (UsuariosBLL.GetContrasena(ContrasenatextBox.Text).Count()==0)
            {
                MessageBox.Show("Contrasena Invalida");
                return false;
            }
            return true;
        }

        public bool ValidTextB()
        {
            if(string.IsNullOrEmpty(NombretextBox.Text) && string.IsNullOrEmpty(ContrasenatextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese su Usuario");
                ContrasenaerrorProvider.SetError(ContrasenatextBox, "Ingrese su Contrasena");
                MessageBox.Show("Por Favor Completar Todos los Cammpos");

            }
            if(string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(ContrasenatextBox, "Ingrese el Usuario");
                return false;
            }
            if(string.IsNullOrEmpty(ContrasenatextBox.Text))
            {
                NombreerrorProvider.Clear();
                ContrasenaerrorProvider.SetError(ContrasenatextBox, "Ingrese su contrasena");
                return false;
            }
            return true;
        }
        public DialogResult ValidarSesion()
        {
            if(ValidTextB() == true && ValidarUsuario()&&ValidarContrasena()==true)
            {
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }

        private void NombretextBox_Validated(object sender, EventArgs e)
        {
            if (NombretextBox.Text.Trim()=="")
            {
                errorProvider1.SetError(NombretextBox, "Introduce el Nombre Por Favor!!");
                NombretextBox.Focus();
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
