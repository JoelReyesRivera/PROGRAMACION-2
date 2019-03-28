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
    public partial class frmMenuInventario : Form
    {
        private ManejaArticulos AdmA;

        public frmMenuInventario(ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.AdmA = AdmA;
        }

        private void btnAgregaArticulo_Click(object sender, EventArgs e)
        {
            frmAgregaArticulo AgregaArt = new frmAgregaArticulo(AdmA);
            AgregaArt.ShowDialog();
        }

        private void lblConsultarArticulo_Click(object sender, EventArgs e)
        {
            if (AdmA.pCount == 0)
            {
                MessageBox.Show("NO HAY ARTICULOS EN EL SISTEMA", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmConsultaArticulo ConsultaArt = new frmConsultaArticulo(AdmA);
            ConsultaArt.ShowDialog();
        }

        private void btnVerArticulos_Click(object sender, EventArgs e)
        {
            if (AdmA.pCount == 0)
            {
                MessageBox.Show("NO HAY ARTICULOS EN EL SISTEMA", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmConsultaArticulos VerArt = new frmConsultaArticulos(AdmA);
            VerArt.ShowDialog();
        }

        private void btnModificaArticulo_Click(object sender, EventArgs e)
        {
            if (AdmA.pCount == 0)
            {
                MessageBox.Show("NO HAY ARTICULOS EN EL SISTEMA", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmModificaExistenciaArticulo Modifica = new frmModificaExistenciaArticulo(AdmA);
            Modifica.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenuInventario_Load(object sender, EventArgs e)
        {
        }
    }
}
