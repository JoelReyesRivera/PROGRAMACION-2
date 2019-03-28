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
    public partial class frmConsultaArticulos : Form
    {
        private ManejaArticulos AdmA;

        public frmConsultaArticulos(ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.AdmA = AdmA;
        }

        private void frmConsultaArticulos_Load(object sender, EventArgs e)
        {
            List<Articulo> Art = AdmA.ObtenArt();
            for (int i = 0; i < AdmA.pCount; i++)
                dgwArticulos.Rows.Add(Art.ElementAt(i).pClave, Art.ElementAt(i).pDescripcion, Art.ElementAt(i).pModelo, Art.ElementAt(i).pPrecio, Art.ElementAt(i).pCantidad); 
        }
    }
}
