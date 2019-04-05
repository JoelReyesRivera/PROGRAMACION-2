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
    public partial class frmVistaBuscaFactura : Form
    {
        private ManejaDetalleFactura mD;
        private ManejaArticulos AdmA;
        int ClaveFactura;

        public frmVistaBuscaFactura(ManejaDetalleFactura mD,ManejaArticulos AdmA,int ClaveFactura)
        {
            InitializeComponent();
            this.mD = mD;
            this.AdmA = AdmA;
            this.ClaveFactura = ClaveFactura;
        }

        private void frmVistaBuscaFactura_Load(object sender, EventArgs e)
        {
            DetalleFactura[] D = mD.RetornaDetallesFactura(ClaveFactura);
            Articulo A;
            for (int i = 0; i < D.Length; i++)
            {
                if (D[i] != null)
                {
                    A = AdmA.RetornaArticulo(D[i].pClaveArt);
                    dvgDetalles.Rows.Add(D[i].pClaveArt, A.pDescripcion, A.pPrecio, D[i].pCant);
                }
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
