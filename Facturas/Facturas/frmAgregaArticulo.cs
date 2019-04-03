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

            string Desc = txtDescripcion.Text, Prec = txtPrecio.Text, Modelo = txtModelo.Text; ; float Precio; int Cant = Convert.ToInt32(nudCantidad.Value);

            if (Rutinas.IsEmpty(Desc))
            {
                MessageBox.Show("FAVOR DE ESCRIBIR UNA DESCRIPCION", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Rutinas.IsEmpty(Modelo))
            {
                MessageBox.Show("FAVOR DE ESCRIBIR EL MODELO", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(Rutinas.ValidaTextoNum(Prec)))
            {
                MessageBox.Show("EL PRECIO SOLO PUEDE CONTENER NUMEROS", "FORMATO INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            try
            {
                Precio = Convert.ToSingle(txtPrecio.Text);
            }
            catch (FormatException E)
            {
                MessageBox.Show("EL PRECIO NO PUEDE ESTAR VACIO", "CAMPO VACIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
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
            if (AdmA.BuscaDesc(Desc))
            {
                MessageBox.Show("EL ARTICULO YA FUE REGISTRADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }

            AdmA.AgregaArt(Desc, Modelo, Precio, Cant);
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
            txtModelo.Text = "";
            txtPrecio.Text = "";
            nudCantidad.Value = 1;
            Error.Clear();
        }
  
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)(Keys.Back)))
            {
                Error.SetError(txtPrecio, "EN ESTE APARTADO SOLO SE ACEPTAN NUMEROS");
                e.Handled = false;
            }
            else
                Error.SetError(txtPrecio, "");

        }

        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            string P = txtPrecio.Text;
            if (!(Rutinas.ValidaTextoNum(P)))
            {
                Error.SetError(txtPrecio, "PRECIO ESCRITO EN FORMA INCORRECTA");
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
