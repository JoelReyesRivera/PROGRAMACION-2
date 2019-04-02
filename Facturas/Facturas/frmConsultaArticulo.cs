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
    public partial class frmConsultaArticulo : Form
    {
        private ManejaArticulos AdmA;
        private List<Articulo> Art;
        public frmConsultaArticulo(ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.AdmA = AdmA;
            cmbArticulos.SelectedIndex = 0;
            Art = AdmA.ObtenArt();
        }

        private void frmConsultaArticulo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < AdmA.pCount; i++)
                this.cmbArticulos.Items.Add(Art.ElementAt(i).pDescripcion);
        }

        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedIndex != 0)
            {
                int p = cmbArticulos.SelectedIndex;

                lblDescripcion.Text= Art.ElementAt(p-1).pDescripcion;
                lblModelo.Text = Art.ElementAt(p-1).pModelo;
                lblPrecio.Text = "$"+Convert.ToString(Art.ElementAt(p-1).pPrecio);
                lblCantidad.Text = Convert.ToString(Art.ElementAt(p-1).pCantidad);
            }
            else
            {
                lblDescripcion.Text = "";
                lblModelo.Text = "";
                lblPrecio.Text = "";
                lblCantidad.Text = "";
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
