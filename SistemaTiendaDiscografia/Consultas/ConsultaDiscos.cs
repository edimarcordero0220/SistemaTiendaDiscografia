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
    public partial class ConsultaDiscos : Form
    {
        public ConsultaDiscos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValiConsulta() == true)
                BuscarCombo();
        }
        Utilidades util = new Utilidades();
        public List<DetalleFactura> lista = new List<DetalleFactura>();
        private void BuscarCombo()
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = DiscosBLL.GetListaId(util.String(BuscartextBox.Text));
                }
                else
                {
                    lista = DiscosBLL.GetLista();
                }
                FiltrardataGridView1.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = DiscosBLL.GetListaNombre(BuscartextBox.Text);
                }
                else
                {
                    lista = DiscosBLL.GetLista();
                }
                FiltrardataGridView1.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = DiscosBLL.GetArtista(BuscartextBox.Text);
                }
                else
                {
                    lista = DiscosBLL.GetLista();

                }
                FiltrardataGridView1.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 3)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = DiscosBLL.GetProductor((BuscartextBox.Text));
                }
                else
                {
                    lista = DiscosBLL.GetLista();
                }
                FiltrardataGridView1.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = DiscosBLL.GetSello((BuscartextBox.Text));
                }
                else
                {
                    lista = DiscosBLL.GetLista();
                }
                FiltrardataGridView1.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = DiscosBLL.GetFecha(DesdedateTimePicker.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = DiscosBLL.GetLista();
                }
                FiltrardataGridView1.DataSource = lista;
            }
        }
        private bool ValiConsulta()
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
                errorProvider1.SetError(BuscartextBox, "Ingrese el campo");
                return true;
            }
            if (FiltrarcomboBox.SelectedIndex == 1 && DiscosBLL.GetListaNombre(BuscartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 2 && DiscosBLL.GetArtista(BuscartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 1 && DiscosBLL.GetProductor(BuscartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            if (FiltrarcomboBox.SelectedIndex == 2 && DiscosBLL.GetSello(BuscartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
        private void Cargar()
        {
            FiltrarcomboBox.Items.Insert(0, "Id Disco");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.Items.Insert(2, "Artista");
            FiltrarcomboBox.Items.Insert(3, "productor");
            FiltrarcomboBox.Items.Insert(4, "sello");
            FiltrarcomboBox.Items.Insert(5, "Fecha");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            FiltrardataGridView1.DataSource = DiscosBLL.GetLista();
        }

        private void ConsultaDiscos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReporteViewerDiscos viewer = new ReporteViewerDiscos();
            viewer.Show();
        }
    }
}