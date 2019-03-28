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
    public partial class frmModificaExistenciaArticulo : Form
    {
        private ManejaArticulos AdmA;
        List<Articulo> Art;

        public frmModificaExistenciaArticulo(ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.AdmA = AdmA;
            cmbArticulos.SelectedIndex = 0;
            Art = AdmA.ObtenArt();
        }

        private void frmModificaExistenciaArticulo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < AdmA.pCount; i++)
                this.cmbArticulos.Items.Add(Art.ElementAt(i).pDescripcion);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA GUARDAR LOS CAMBIOS?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.No)
                return;

            if(cmbArticulos.SelectedIndex == 0)
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUN ARTICULO", "INFORMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                return;
            }
            int Cant = Convert.ToInt32(nudCantidad.Value);
            if (Cant < 1)
            {
                MessageBox.Show("LA CANTIDAD NO PUEDE SER MENOR A 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            int Clave = Art.ElementAt((cmbArticulos.SelectedIndex-1)).pClave;
            Articulo Articulo = AdmA.RetornaArticulo(Clave);
            Articulo.pCantidad += Cant;

            MessageBox.Show("MODIFICACION EXITOSA", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            cmbArticulos.SelectedIndex = 0;
            nudCantidad.Value = 1;
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            int Cant = Convert.ToInt32(nudCantidad.Value);

            if (Cant == 0)
                Error.SetError(nudCantidad, "NUMERO FUERA DEL RANGO PERMITIDO");
            else
                Error.SetError(nudCantidad, "");
        }

        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
