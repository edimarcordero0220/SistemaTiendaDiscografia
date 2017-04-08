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
        Factura factura = new Factura();



        public RFacturas()
        {
            InitializeComponent();
            LlenarUsuario();
        }

        public void LlenarClase(Factura c)
        {
            
            c.IdFactura = Utilidades.TOINT(FacturaIdtextBox.Text);
            c.IdCliente = Utilidades.TOINT(ClienteIdtextBox.Text);

            c.FechaVenta = FechadateTimePicker.Value;
            c.Nombre = NombretextBox.Text;
            c.NombreDisco = DescripcionDiscotextBox.Text;
            c.Precio = Convert.ToDecimal(PreciotextBox.Text);
            
            //c.Precio = Utilidades.TOINT(PreciotextBox.Text);

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
            if (ClienteIdtextBox.Text == "")
            {
                MessageBox.Show("Para Realizar una busqueda debe llenar el campo Cliente Id");
            }
            else
            {
                BuscarClientes(ClientesBLL.Buscar(String(ClienteIdtextBox.Text)));
            }
        }

        private void BuscarDiscbutton_Click(object sender, EventArgs e)
        {
            if (IdDiscotextBox.Text == "")
            {
                MessageBox.Show("Favor Digite el Id del disco que desea buscar");
            }
            else
            {
                BuscarDisco(DiscosBLL.Buscar(String(IdDiscotextBox.Text)));
            }
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
        private void LlenarUsuario()
         {
             List<Usuarios> lista = BLL.UsuariosBLL.GetLista();
             ModificadorcomboBox.DataSource = lista;
             ModificadorcomboBox.DisplayMember = "NombreUsuario";
             ModificadorcomboBox.ValueMember = "UsuarioId";
         }

        /*private void CalcularTotal()
        {
            factura.Total += detalle.Factura.Costo * CantidadnumericUpDown.Value;
            TotaltextBox.Text = factura.Total.ToString();
        }*/
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Factura F = new Factura();
            LlenarClase(F);
            FacturaBLL.Insertar(F);
            MessageBox.Show("Guardado con Exito");

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            FacturaBLL.Eliminar(ut.String(FacturaIdtextBox.Text));
            MessageBox.Show("Eliminado");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (FacturaIdtextBox.Text == "")
            {
                MessageBox.Show("Para Buscar una Factura, Favor Llenar el Campo Id Factura");
            }
            else
            {

                BuscarFactura(FacturaBLL.Buscar(String(FacturaIdtextBox.Text)));
            }
        }
        public void BuscarFactura(Entidades.Factura factura)
        {
            
                FacturaIdtextBox.Text = factura.IdFactura.ToString();
                NombretextBox.Text = factura.Nombre;
                DescripcionDiscotextBox.Text = factura.NombreDisco;
            IdDiscotextBox.Text = factura.IdCliente.ToString();
            

            FechadateTimePicker.Value = factura.FechaVenta;
            LlenarGrid(factura);
            


        }
        private void LlenarGrid(Factura factura)
        {
           /* dataGridView.DataSource = null;
            dataGridView.DataSource = factura.Detalle.ToList();
            this.dataGridView.Columns["FacturaServicioId"].Visible = false;
            this.dataGridView.Columns["FacturaId"].Visible = false;
            this.dataGridView.Columns["Servicio"].Visible = false;*/

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdDiscotextBox.Text = "";
            NombretextBox.Text = "";
            DescripcionDiscotextBox.Text = "";

        }

        private void eliminarfilabutton_Click(object sender, EventArgs e)
        {
            if(dataGridView.DataSource != null)
            {
                MessageBox.Show("No ha selecionado una fila ");
            }else
            {
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
            }
        }
    }
}
