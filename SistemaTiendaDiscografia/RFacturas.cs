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
    public partial class RFacturas : Form
    {
        Utilidades ut = new Utilidades();
        public RFacturas()
        {
            InitializeComponent();
        }

        public void LlenarClase(Factura c)
        {
            
            c.IdFactura = Utilidades.TOINT(FacturaIdtextBox.Text);
            c.IdCliente = Utilidades.TOINT(ClienteIdtextBox.Text);

            c.FechaVenta = FechadateTimePicker.Value;
            c.Nombre = NombretextBox.Text;
            c.NombreDisco = DescripcionDiscotextBox.Text;
            c.Precio = Utilidades.TOINT(PreciotextBox.Text);
            
        }




        public void BuscarClientes(Clientes cliente)
        {
            ClienteIdtextBox.Text = cliente.IdCliente.ToString();
            NombretextBox.Text = cliente.NombreCliente;
           
        }
        public void BuscarDisco(Discos disco)
        {
            IdDiscotextBox.Text = disco.IdDisco.ToString();
            DescripcionDiscotextBox.Text = disco.NombreDisco;

        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            BuscarClientes(ClientesBLL.Buscar(String(ClienteIdtextBox.Text)));
        }

        private void BuscarDiscbutton_Click(object sender, EventArgs e)
        {
            BuscarDisco(DiscosBLL.Buscar(String(IdDiscotextBox.Text)));
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (IdDiscotextBox.Text != string.Empty && DescripcionDiscotextBox.Text != string.Empty && PreciotextBox.Text != string.Empty)
            {
                dataGridView.Rows.Add(IdDiscotextBox.Text, DescripcionDiscotextBox.Text, PreciotextBox.Text);
            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            c.HeaderText = "Disco Id";
            c.Width = 200;
            c.ReadOnly = true;


            DataGridViewTextBoxColumn d = new DataGridViewTextBoxColumn();
            d.HeaderText = "Descripcion";
            d.Width = 200;
            d.ReadOnly = true;

            DataGridViewTextBoxColumn f = new DataGridViewTextBoxColumn();
            f.HeaderText = "Precio";
            f.Width = 200;
            f.ReadOnly = true;

            dataGridView.Columns.Add(c);
            dataGridView.Columns.Add(d);
            dataGridView.Columns.Add(f);


        }
        
       
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Factura F = new Factura();
            LlenarClase(F);
            FacturaBLL.Insertar(F);
            MessageBox.Show("Guardado con Exito");

        }


    }
}
