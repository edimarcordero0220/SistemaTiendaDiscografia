using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace SistemaTiendaDiscografia.Consultas
{
    public partial class ReporteViewerClientes : Form
    {
        public ReporteViewerClientes()
        {
            InitializeComponent();
        }

        private void ReporteViewerClientes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\Edimar Cordero\Desktop\TIENDA DISCOGRAFIA\SistemaTiendaDiscografia\SistemaTiendaDiscografia\Reportes\ReporteCliente.rdlc";
            ReportDataSource source = new ReportDataSource("ClienteDataSet",
            ClientesBLL.GetLista());
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.LocalReport.Refresh();
        }
    }
}
