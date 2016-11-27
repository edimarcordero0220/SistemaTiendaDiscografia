using SistemaTiendaDiscografia;
using SistemaTiendaDiscografia.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTiendaDiscografia;


namespace SistemaTiendaDiscografia
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario u = new RegistroUsuario();
            
            u.Show();
        }

        private void discosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrosDiscos d = new RegistrosDiscos();
            d.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes d = new RegistroClientes();
            d.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuarios cu = new Consultas.ConsultaUsuarios();
            //cu.MdiParent = this;
            cu.Show();
        }
    }
}
