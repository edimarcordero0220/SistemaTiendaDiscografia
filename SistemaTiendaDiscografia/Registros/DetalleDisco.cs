using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTiendaDiscografia.Registros
{
    public partial class DetalleDisco : Form
    {
        public DetalleDisco()
        {
            InitializeComponent();
        }
        public void LlenarCombo()
        {
            DiscocomboBox.DataSource = BLL.DiscosBLL.GetLista();
            DiscocomboBox.DisplayMember = "NombreDisco";
            DiscocomboBox.ValueMember = "IdDisco";
        }
        
        private void Guardarbutton_Click(object sender, EventArgs e)
        {

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
    }
}
