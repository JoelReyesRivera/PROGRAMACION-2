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
            cmbArticulos.SelectedIndex = -1;
            Art = AdmA.ObtenArt();
        }

        private void frmConsultaArticulo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < AdmA.pCount; i++)
                this.cmbArticulos.Items.Add(Art.ElementAt(i).pDescripcion);
        }

        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedIndex < 0)
                return;
            string Articulo = Convert.ToString(cmbArticulos.SelectedItem);
            int ClaveArticulo = AdmA.BuscaClaveArt(Articulo);
            Articulo A = AdmA.RetornaArticulo(ClaveArticulo);
            lblDescripcion.Text = A.pDescripcion;
            lblMarca.Text = A.pMarca;
            lblPrecio.Text = "$ "+A.pPrecio;
            lblCantidad.Text = A.pCantidad+"";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA SALIR?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
                this.Close();
        }

        private void cmbArticulos_Validated(object sender, EventArgs e)
        {
            bool flag = false;
            string Articulo = cmbArticulos.Text;
            string Elemento = "";
            for (int i = 0; i < cmbArticulos.Items.Count; i++)
            {
                Elemento = cmbArticulos.GetItemText(cmbArticulos.Items[i]);
                if (Elemento.CompareTo(Articulo) == 0)
                {
                    flag = true;
                    cmbArticulos.SelectedIndex = i;
                }
            }
            if (!flag)
            {
                errorP.SetError(cmbArticulos, "ARTÍCULO NO ENCONTRADO");
                cmbArticulos.SelectedIndex = -1;
                lblDescripcion.Text = "";
                lblMarca.Text = "";
                lblPrecio.Text = "";
                lblCantidad.Text = "";
                cmbArticulos.Focus();
            }
            else
            {
                errorP.SetError(cmbArticulos, "");
            }
        }

        private void cmbArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(cmbArticulos, "SÓLO SE PERMITEN LETRAS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(cmbArticulos, "");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            cmbArticulos.Text = "";
            cmbArticulos.SelectedIndex = -1;
            lblDescripcion.Text = "";
            lblMarca.Text = "";
            lblPrecio.Text = "";
            lblCantidad.Text = "";
        }

        private void cmbArticulos_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
