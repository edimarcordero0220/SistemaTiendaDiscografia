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
using SistemaTiendaDiscografia.Consultas;

namespace SistemaTiendaDiscografia.Consultas
{
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void DesdedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsulta() == true)
                BuscarCombo();
        }
        Utilidades util = new Utilidades();
        public List<Clientes> lista = new List<Clientes>();
        private void BuscarCombo()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = ClientesBLL.GetListaId(util.String(BuscartextBox.Text));
                }
                else
                {
                    lista = ClientesBLL.GetLista();
                }
                FiltrardataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = ClientesBLL.GetListaNombre(BuscartextBox.Text);
                }
                else
                {
                    lista = ClientesBLL.GetLista();
                }
                FiltrardataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = ClientesBLL.GetListaApellido(BuscartextBox.Text);
                }
                else
                {
                    lista = ClientesBLL.GetLista();

                }
                FiltrardataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 3)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = ClientesBLL.GetListaCedula((BuscartextBox.Text));
                }
                else
                {
                    lista = ClientesBLL.GetLista();
                }
                FiltrardataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = ClientesBLL.GetListaDireccion((BuscartextBox.Text));
                }
                else
                {
                    lista = ClientesBLL.GetLista();
                }
                FiltrardataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = ClientesBLL.GetListaFecha(DesdedateTimePicker.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = ClientesBLL.GetLista();
                }
                FiltrardataGridView.DataSource = lista;
            }
            
        }
        private bool ValidarConsulta()
        {
            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (DesdedateTimePicker.Value == HastadateTimePicker.Value)
                {
                    MessageBox.Show("Favor definir una fecha entre las fechas ");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (string.IsNullOrEmpty(BuscartextBox.Text))
            {
                errorProvider.SetError(BuscartextBox, "Ingrese el campo");
                return true;
            }
            if (FiltrarcomboBox.SelectedIndex == 1 && ClientesBLL.GetListaNombre(BuscartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 2 && ClientesBLL.GetListaApellido(BuscartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 3 && ClientesBLL.GetListaCedula(BuscartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 4 && ClientesBLL.GetListaDireccion(BuscartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }

            errorProvider.Clear();
            return true;
        }
        private void Cargar()
        {
            FiltrarcomboBox.Items.Insert(0, "IdCliente");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.Items.Insert(2, "Apellido");
            FiltrarcomboBox.Items.Insert(3, "Direccion");
            FiltrarcomboBox.Items.Insert(4, "Cedula");
            FiltrarcomboBox.Items.Insert(5, "Fecha");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            FiltrardataGridView.DataSource = ClientesBLL.GetLista();
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReporteViewerClientes viewer = new ReporteViewerClientes();
            viewer.Show();
        }
    }

    class filtrartextBox
    {
    }
}
