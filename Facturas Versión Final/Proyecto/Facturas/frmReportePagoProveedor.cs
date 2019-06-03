using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturas
{
    public partial class frmReportePagoProveedor : Form
    {
        public frmReportePagoProveedor()
        {
            InitializeComponent();
        }

        private void frmReportePagoProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReportePagoProveedor.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.ReportePagoProveedor.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
