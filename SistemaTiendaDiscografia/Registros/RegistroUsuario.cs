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
            if (NombretextBox.Text =="" || ContrasenatextBox.Text == "" || ConfirmarContrasenatextBox.Text=="" )
            {
                MessageBox.Show("Por favor Llenar Todos Los campos");
            }else
            {
                Usuarios usuario = new Usuarios();
                LlenarClase(usuario);
                UsuariosBLL.Insertar(usuario);
                MessageBox.Show("Registro Exitoso!!!");

            }
            

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BuscarUsuario(UsuariosBLL.Buscar(String(IdtextBox.Text)));
            ValidarBuscar();
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
            if (IdtextBox.Text == "")
            {
                MessageBox.Show("Por favor ingrese Id");
            }
            else
            {
                UsuariosBLL.Eliminar(ut.String(IdtextBox.Text));
                MessageBox.Show("Eliminado");
            }
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

        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmarContrasenatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ContrasenatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
                    }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void IdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
