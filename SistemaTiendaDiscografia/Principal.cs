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
//using SistemaTiendaDiscografia;
using SistemaTiendaDiscografia.Consultas;

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
            cu.MdiParent = this.MdiParent;
            cu.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaClientes cu = new ConsultaClientes();
            cu.MdiParent = this.MdiParent;
            cu.Show();
        }

        private void discosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaDiscos cu = new ConsultaDiscos();
            cu.MdiParent = this.MdiParent;
            cu.Show();
        }

        private void detalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RFacturas cu = new RFacturas();
            cu.MdiParent = this.MdiParent;
            cu.Show();
        }
    }
}
