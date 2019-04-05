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
    public partial class frmConsultaProveedores : Form
    {
        ManejaProveedores proveedores;
        public frmConsultaProveedores(ManejaProveedores proveedores)
        {
            InitializeComponent();
            this.proveedores = proveedores;
            CargarDataGridView();
        }

        public void CargarDataGridView()
        {
            int[] claves = proveedores.GetClaves();
            Proveedor[] provedoresExistentes = proveedores.GetProveedores();
            for (int i = 0; i < claves.Length; i++)
            {
                dtgvProveedores.Rows.Add(claves[i], provedoresExistentes[i].pRFC, provedoresExistentes[i].pNombre, provedoresExistentes[i].pDomicilio, "$" +provedoresExistentes[i].pSaldo);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA SALIR?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
                this.Close();
        }
    }
}
