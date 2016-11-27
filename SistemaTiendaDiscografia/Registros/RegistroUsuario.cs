using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace SistemaTiendaDiscografia
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }
        Utilidades ut = new Utilidades();
        private void LlenarClase(Usuarios u)
        {
            u.NombreUsuario = NombretextBox.Text;
            u.Contrasena = ContrasenatextBox.Text;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            LlenarClase(usuario);
            UsuariosBLL.Insertar(usuario);
            MessageBox.Show("Registro Exitoso!!!");

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BuscarUsuario(UsuariosBLL.Buscar(String(IdtextBox.Text)));
        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        private void LlenarUsuarios(Usuarios usuario)
        {
            IdtextBox.Text = usuario.UsuarioId.ToString();
            NombretextBox.Text = usuario.NombreUsuario;
            ContrasenatextBox.Text = usuario.Contrasena;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdtextBox.Text = "";
            NombretextBox.Text = "";
            ContrasenatextBox.Text = "";
            ConfirmarContrasenatextBox.Text = "";
        }
        public void BuscarUsuario(Usuarios usuario)
        {
            if (IdtextBox.Text == "")
            {
                MessageBox.Show("Para hacer una busqueda de Usuario debe ingresar el ID");
            }
            else
            {
               
                IdtextBox.Text = usuario.UsuarioId.ToString();
                NombretextBox.Text = usuario.NombreUsuario.ToString();
                ConfirmarContrasenatextBox.Text = usuario.Contrasena.ToString();
                ContrasenatextBox.Text = usuario.Contrasena.ToString();
                
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            UsuariosBLL.Eliminar(ut.String(IdtextBox.Text));
            MessageBox.Show("Eliminado");
        }

        private bool ValidarBuscar()
        {
            if (UsuariosBLL.Buscar(String(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;

            }

            return true;


        }



    }
}
