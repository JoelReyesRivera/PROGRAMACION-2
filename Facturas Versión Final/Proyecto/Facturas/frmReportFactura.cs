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
    public partial class frmReportFactura : Form
    {
        public frmReportFactura()
        {
            InitializeComponent();
        }

        private void frmReportFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReportFactura.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.ReportFactura.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
