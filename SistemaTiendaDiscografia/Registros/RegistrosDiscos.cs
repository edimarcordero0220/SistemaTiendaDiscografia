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
    public partial class RegistrosDiscos : Form
    {
        public RegistrosDiscos()
        {
            InitializeComponent();
        }
       

        Utilidades ut = new Utilidades();
        public void LlenarClase(Entidades.Discos d)
        {
            d.NombreDisco = NombretextBox.Text;
            d.Productor = ProductortextBox.Text;
            d.SelloDiscografico = SellotextBox.Text;
            d.Artista = ArtistatextBox.Text;
            d.FechaDeLanzamiento = FechaLamzamientodateTimePicker.Value;
            d.FechaCreacion = FechaCreaciondateTimePicker.Value;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (NombretextBox.Text == "" || ArtistatextBox.Text == "" || ProductortextBox.Text == "" || SellotextBox.Text == "")
            {
                MessageBox.Show("Por favor llenar Todos los campos");
            }
            else
            {
                Entidades.Discos discos = new Entidades.Discos();
                LlenarClase(discos);
                DiscosBLL.Insertar(discos);
                MessageBox.Show("Guardado");
            }

        }
        

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text == "")
            {
                MessageBox.Show("Para Eliminar Un Disco Debes Ingresar el Id");
            }
            else
            {
                BuscarDiscos(DiscosBLL.Buscar(String(IdtextBox.Text)));
            }
        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        public void BuscarDiscos(Entidades.Discos discos)
        {
            if (NombretextBox.Text == "" || ArtistatextBox.Text == "" || ProductortextBox.Text == ""
                || SellotextBox.Text == "")
            {
                MessageBox.Show("Por Favor Llenar Todos Los Campos Del Registro De Disco!!");
            }
            else
            {
                IdtextBox.Text = discos.IdDisco.ToString();
                NombretextBox.Text = discos.NombreDisco;
                ArtistatextBox.Text = discos.Artista;
                ProductortextBox.Text = discos.Productor;
                SellotextBox.Text = discos.SelloDiscografico;
                FechaLamzamientodateTimePicker.Value = discos.FechaDeLanzamiento;
                FechaCreaciondateTimePicker.Value = discos.FechaCreacion;

            }
        }
        
        

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdtextBox.Text = "";
            NombretextBox.Text = "";
            ArtistatextBox.Text = "";
            SellotextBox.Text = "";
            ProductortextBox.Text = "";
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text == "")
            {
                MessageBox.Show("Por favor ingrese Id");
            }
            else
            {
                DiscosBLL.Eliminar(ut.String(IdtextBox.Text));
                MessageBox.Show("Eliminado");
            }
        }

        private void RegistrosDiscos_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FechaLamzamientodateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ProductortextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SellotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArtistatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        private void IdtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clickbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
