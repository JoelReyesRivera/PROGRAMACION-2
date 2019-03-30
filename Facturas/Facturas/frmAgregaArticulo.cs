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

            if (IsEmpty(Desc))
            {
                MessageBox.Show("FAVOR DE ESCRIBIR UNA DESCRIPCION EN FORMATO CORRECTO", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsEmpty(Modelo))
            {
                MessageBox.Show("FAVOR DE ESCRIBIR EL MODELO EN FORMATO CORRECTO", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(ValidaTexto(Desc)))
            {
                MessageBox.Show("LA DESCRIPCION ESTA ESCRITA DE FORMA INCORRECTA","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            if (!(ValidaTexto(Modelo)))
            {
                MessageBox.Show("EL MODELO ESTA ESCRITO DE FORMA INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            if (!(ValidaTextoNum(Prec)))
            {
                MessageBox.Show("EL PRECIO ESTA ESCRITO DE FORMA INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            try
            {
                Precio = Convert.ToSingle(txtPrecio.Text);
            }
            catch (FormatException E)
            {
                MessageBox.Show("EL PRECIO ESTA ESCRITO EN UN FORMATO INCORRECTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
                return;
            }
            if (Precio < 1)
            {
                MessageBox.Show("EL PRECIO NO PUEDE SER MENOR A 1", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Cant < 1)
            {
                MessageBox.Show("LA CANTIDAD DE ARTICULOS A INGRESAR NO PUEDE SER MENOR A 1", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    
        private bool IsEmpty(string Cadena)
        {
            if (string.IsNullOrWhiteSpace(Cadena) || string.IsNullOrEmpty(Cadena))
                return true;

            return false;
        }

        private bool ValidaTexto(string Cadena)
        {
            foreach (char C in Cadena)
            {
                if (!(Char.IsLetter(C)))
                    return false;
            }
            return true;
        }

        private bool ValidaTextoNum(string Cadena)
        {
            foreach (char C in Cadena)
            {
                if (C < '0' || C > '9')
                    return false;
            }
            return true;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                Error.SetError(txtDescripcion, "EN ESTE APARADO SOLO SE ACEPTAN LETRAS");
                e.Handled = false;
            }
            else
                Error.SetError(txtDescripcion, "");
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            string D = txtDescripcion.Text;
            if (!ValidaTexto(D))
            {
                Error.SetError(txtDescripcion, "DESCRIPCION ESCRITA EN FORMA INCORRECTA");
                txtDescripcion.Focus();
            }
            else
                Error.SetError(txtDescripcion, "");
        }

        private void txtModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                Error.SetError(txtModelo, "EN ESTE APARADO SOLO SE ACEPTAN LETRAS");
                e.Handled = false;
            }
            else
                Error.SetError(txtModelo, "");
        }

        private void txtModelo_Validated(object sender, EventArgs e)
        {
            string M = txtModelo.Text;
            if (!ValidaTexto(M))
            {
                Error.SetError(txtModelo, "MODELO ESCRITO EN FORMA INCORRECTA");
                txtModelo.Focus();
            }
            else
                Error.SetError(txtModelo, "");
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
            if (!(ValidaTextoNum(P)))
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
            DialogResult Result = MessageBox.Show("¿DESEA SALIR DE ESTA VENTANA?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
                this.Close();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
