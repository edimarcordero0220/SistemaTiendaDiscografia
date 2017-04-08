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

namespace SistemaTiendaDiscografia.Registros
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }
        Utilidades ut = new Utilidades();
        public void LlenarClase(Clientes c)
        {
            c.NombreCliente = NombreCliente.Text;
            c.ApellidoCliente = ApellidotextBox.Text;
            c.DireccionCliente = DirecciontextBox.Text;
            c.CedulaCliente = CedulatextBox.Text;
            c.FechaCreacion = FechaCreaciondateTimePicker.Value;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (NombreCliente.Text == "" || ApellidotextBox.Text == "" || DirecciontextBox.Text == "" || CedulatextBox.Text == "" )
            {
                MessageBox.Show("Por Favor Llenar Todos Los Campos!!");
            }
            else
            {
                Clientes cliente = new Clientes();
                LlenarClase(cliente);
                ClientesBLL.Insertar(cliente);
                MessageBox.Show("Guardado con Exito");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdtextBox.Text = "";
            NombreCliente.Text = "";
            ApellidotextBox.Text = "";
            DirecciontextBox.Text = "";
            CedulatextBox.Text = "";

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BuscarClientes(ClientesBLL.Buscar(String(IdtextBox.Text)));
        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        private bool ValidarBuscar()
        {
            if (ClientesBLL.Buscar(String(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;

            }

            return true;


        }
        public void BuscarClientes(Clientes cliente)
        {
            if (IdtextBox.Text == "")
            {
                MessageBox.Show("Favor ingrese el Id Para Realizar una busqueda de Disco");
            }
            else
            {
                IdtextBox.Text = cliente.IdCliente.ToString();
                NombreCliente.Text = cliente.NombreCliente;
                ApellidotextBox.Text = cliente.ApellidoCliente;
                DirecciontextBox.Text = cliente.DireccionCliente;
                CedulatextBox.Text = cliente.CedulaCliente;
                FechaCreaciondateTimePicker.Value = cliente.FechaCreacion;
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text == "")
            {
                MessageBox.Show("Para Eliminar un cliente Debes introducir su ID");
            } else {
                ClientesBLL.Eliminar(ut.String(IdtextBox.Text));
                MessageBox.Show("Eliminado");
            }
        }

        private void NombreCliente_Validated(object sender, EventArgs e)
        {
           /* if (NombreCliente.Text.Trim()=="")
            {
                errorProvider.SetError(NombreCliente, "Introduce el Nombre!!");
                NombreCliente.Focus();
            }else
            {
                errorProvider.Clear();
            }*/
        }

        private void FechaCreaciondateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
