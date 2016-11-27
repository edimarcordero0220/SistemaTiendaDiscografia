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
        public void LlenarClase(Discos d)
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
            Discos discos = new Discos();
            LlenarClase(discos);
            DiscosBLL.Insertar(discos);
            MessageBox.Show("Guardado");

        }
        

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BuscarDiscos(DiscosBLL.Buscar(String(IdtextBox.Text)));
        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        public void BuscarDiscos(Discos discos)
        {
            IdtextBox.Text = discos.IdDisco.ToString();
            NombretextBox.Text = discos.NombreDisco;
            ArtistatextBox.Text = discos.Artista;
            ProductortextBox.Text = discos.Productor;
            SellotextBox.Text = discos.SelloDiscografico;
            FechaLamzamientodateTimePicker.Value = discos.FechaDeLanzamiento;
            FechaCreaciondateTimePicker.Value = discos.FechaCreacion;
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

            DiscosBLL.Eliminar(ut.String(IdtextBox.Text));
            MessageBox.Show("Eliminado");
        }
    }
}
