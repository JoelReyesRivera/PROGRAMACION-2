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
    public partial class frmReporteDetalleFacturas : Form
    {
        public frmReporteDetalleFacturas()
        {
            InitializeComponent();
        }

        private void frmReporteDetalleFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reporteDetalleFacturas.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill(this.reporteDetalleFacturas.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
