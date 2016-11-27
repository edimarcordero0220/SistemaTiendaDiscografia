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

namespace SistemaTiendaDiscografia.Consultas
{
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsulta() == true)
                BuscarCombo();
        }

        Utilidades util = new Utilidades();
        public List<Usuarios> lista = new List<Usuarios>();

        private void BuscarCombo()
        {
            if (FiltrarcomboBox.SelectedIndex==0)
            {
                if(!String.IsNullOrEmpty(filtrartextBox.Text))
                {
                    lista = UsuariosBLL.GetLista(util.String(filtrartextBox.Text));
                }
                else
                {
                    lista = UsuariosBLL.GetLista();
                }
                ConsultadataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(filtrartextBox.Text))
                {
                    lista = UsuariosBLL.GetListaNombre(filtrartextBox.Text);
                }
                else
                {
                    lista = UsuariosBLL.GetLista();
                }
                ConsultadataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(filtrartextBox.Text))
                {
                    lista = UsuariosBLL.GetContrasena(filtrartextBox.Text);
                }
                else
                {
                    lista = UsuariosBLL.GetLista();
                }
                ConsultadataGridView.DataSource = lista;
            }
        }
        private bool ValidarConsulta()
        {
            if (string.IsNullOrEmpty(filtrartextBox.Text))
            {
                errorProvider.SetError(filtrartextBox, "Ingrese el campo");
                return true;
            }
            if(FiltrarcomboBox.SelectedIndex == 1 && UsuariosBLL.GetListaNombre(filtrartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if(FiltrarcomboBox.SelectedIndex == 2 && UsuariosBLL.GetContrasena(filtrartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            errorProvider.Clear();
            return true;
        }
        private void Cargar()
        {
            FiltrarcomboBox.Items.Insert(0, "UsuarioId");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.Items.Insert(2, "Contraseña");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultadataGridView.DataSource = UsuariosBLL.GetLista();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReporteViewerUsuarios viewer = new ReporteViewerUsuarios();
            viewer.Show();
        }
    }
}
