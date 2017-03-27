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
using SistemaTiendaDiscografia.Registros;
namespace SistemaTiendaDiscografia.Registros
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        Entidades.Discos dico = new Entidades.Discos();
        Utilidades u = new Utilidades();
        public void LlenarClase(Entidades.Discos dc)

        {

            dc.NombreDisco = IdNombretextBox.Text;
        }
        private void Llenar(Entidades.Discos disco)
        {
            var dcs = DiscosBLL.Buscar(u.String(IdtextBox.Text));
            IdtextBox.Text = disco.IdDisco.ToString();
            NombretextBox.Text = disco.NombreDisco;
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = disco.IdDisco;

        }
        private void LlenandoCombo()
        {
            //grupo = new Grupos();
            comboBox1.DataSource = DiscosBLL.GetLista();
            comboBox1.DisplayMember = "NombreDisco";
            comboBox1.ValueMember = "IdDisco";

        }
        private void DetalleFactura_Load(object sender, EventArgs e)
        {
            LlenandoCombo();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Entidades.Factura Detalle= new Entidades.Factura();
            //Llenar(Detalle);
            DetalleFacturaBLL.Guardar(Detalle);
            MessageBox.Show("Guardado");
        }
        public int String(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            /*dico.DetalleFactura.Add(new Factura((int)comboBox1.SelectedValue, comboBox1.Text));
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = dico.DetalleFactura;
            DetalledataGridView.Text = "";*/
        }
    }
}
