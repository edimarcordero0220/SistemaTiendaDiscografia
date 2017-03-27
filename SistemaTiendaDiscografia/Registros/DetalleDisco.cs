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
    public partial class DetalleDisco : Form
    {
        public DetalleDisco()
        {
            InitializeComponent();
        }
        public void LlenarClase(DetallesDeDiscos d)
        {
           d.Cancion= CanciontextBox.Text;
            d.DuracionDeLaCancion = DuraciontextBox.Text;
            d.FechaCreacion = dateTimePicker.Value;
            

        }
        public void LlenarCombo()
        {
            DiscocomboBox.DataSource = BLL.DiscosBLL.GetLista();
            DiscocomboBox.DisplayMember = "NombreDisco";
            DiscocomboBox.ValueMember = "IdDisco";
       

        }
        
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            DetallesDeDiscos detalle = new DetallesDeDiscos();
            //DetalleDisco di = new DetalleDisco();
            LlenarClase(detalle);
            DetallesDeDiscosBLL.Insertar(detalle);
            MessageBox.Show("Guardado con Exito");
            /*
             DetallesDeDiscos detalle = new DetallesDeDiscos();

             LlenarClase(detalle);

            DetallesDeDiscosBLL.Insertar(detalle);*/




        }

        private void DetalleDisco_Load(object sender, EventArgs e)
        {
            

            LlenarCombo();
            DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            c.HeaderText = "Cancion/es";
            c.Width = 200;
            c.ReadOnly = true;

            
            DataGridViewTextBoxColumn d = new DataGridViewTextBoxColumn();
            d.HeaderText = "Duracion";
            d.Width = 200;
            d.ReadOnly = true;

            dataGridView.Columns.Add(c);
            dataGridView.Columns.Add(d);
              

           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CanciontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (CanciontextBox.Text != string.Empty && DuraciontextBox.Text!=string.Empty)
            {
                dataGridView.Rows.Add(CanciontextBox.Text, DuraciontextBox.Text);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
