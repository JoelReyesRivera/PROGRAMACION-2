using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturas
{
    public partial class frmAgregaArticulo : Form
    {
        private ManejaArticulos AdmA;

        public frmAgregaArticulo(ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.AdmA = AdmA;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult Result= MessageBox.Show("¿DESEA GUARDAR LA INFORMACION?","PREGUNTA",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (Result == DialogResult.No)
                return;

            string Desc = txtDescripcion.Text, Prec = txtPrecio.Text, Marca = txtMarca.Text; ; float Precio; int Cant = Convert.ToInt32(nudCantidad.Value);

            if (Rutinas.IsEmpty(Desc))
            {
                MessageBox.Show("FAVOR DE ESCRIBIR UNA DESCRIPCION", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Rutinas.IsEmpty(Marca))
            {
                MessageBox.Show("FAVOR DE ESCRIBIR EL MODELO", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(Rutinas.validadDecimal(Prec)))
            {
                MessageBox.Show("SOLO SE ACEPTAN NUMEROS EN FORMATO (0.00)", "FORMATO INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Precio = Convert.ToSingle(txtPrecio.Text);
            }
            catch (FormatException E)
            {
                MessageBox.Show("EL PRECIO NO PUEDE ESTAR VACIO", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Precio < 1)
            {
                MessageBox.Show("EL PRECIO NO PUEDE SER MENOR A 1", "VALOR FUERA DE RANGO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Cant < 1)
            {
                MessageBox.Show("LA CANTIDAD DE ARTICULOS A INGRESAR NO PUEDE SER MENOR A 1", "VALOR FUERA DE RANGO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AdmA.BuscaClaveArt(Desc) > -1)
            {
                MessageBox.Show("EL ARTICULO YA FUE REGISTRADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!AdmA.AgregaArt(Desc, Marca, Precio, Cant))
            {
                MessageBox.Show("NO SE PUDO GUARDAR EL ARTICULO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("ARTICULO AGREGADO EXITOSAMENTE", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            nudCantidad.Value = 1;
            Error.Clear();
        }
  
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(".") || e.KeyChar==46)
            {
                return;
            }
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)(Keys.Back)))
            {
                Error.SetError(txtPrecio, "EN ESTE APARTADO SOLO SE ACEPTAN NUMEROS, FORMATO (0.00)");
                e.Handled = false;
            }
            else
                Error.SetError(txtPrecio, "");
        }

        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            string P = txtPrecio.Text;
            if (!(Rutinas.validadDecimal(P)))
            {
                Error.SetError(txtPrecio,"PRECIO ESCRITO EN FORMA INCORRECTA, FORMATO (0.00)");
                txtPrecio.Focus();
            }
            else
                Error.SetError(txtPrecio, "");
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            int Cant = Convert.ToInt32(nudCantidad.Value);

            if (Cant == 0)
                Error.SetError(nudCantidad, "NUMERO FUERA DEL RANGO PERMITIDO");
            else
                Error.SetError(nudCantidad, "");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("¿DESEA SALIR?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
                this.Close();
        }

    }
}
