using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBD;

namespace Facturas
{
    public partial class frmAgregarFactura : Form
    {
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores proveedores;
        ManejaArticulos AdmA;

        public frmAgregarFactura(ManejaFacturas mF, ManejaDetalleFactura mD, ManejaProveedores proveedores, ManejaArticulos AdmA)
        {
            InitializeComponent();
            cmbArticulo.SelectedIndex = -1;
            cmbProveedores.SelectedIndex = -1;
            this.mF = mF;
            this.mD = mD;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA AGREGAR LA FACTURA?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                string ClaveF = Convert.ToString(txtClaveFactura.Text); string Proveedor = Convert.ToString(cmbProveedores.SelectedItem);
                string ClaveA = Convert.ToString(cmbArticulo.SelectedItem);
                int ClaveFactura; int ClaveProveedor;

                if (ClaveF.Length == 0)
                {
                    MessageBox.Show("CLAVE DE FACTURA VACÍA", "CAMPO VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Rutinas.ValidaTextoNum(ClaveF))
                {
                    MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "SÓLO NÚMEROS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    ClaveFactura = int.Parse(ClaveF);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("CLAVE DE FACTURA NO VÁLIDA", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (mF.BuscaFacturaClave(ClaveFactura) > 0 )
                {
                    MessageBox.Show("LA FACTURA YA EXISTE", "CLAVE FACTURA DUPLICADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ClaveProveedor = proveedores.BuscarPosNombre(Proveedor);
                int CantArt = lvArticulos.Items.Count;
                if (ClaveProveedor == -1)
                {
                    MessageBox.Show("EL PROVEEDOR NO SE ENCUENTRA EN EL SISTEMA", "PROVEEDOR INEXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (CantArt == 0)
                {
                    MessageBox.Show("NO SE PUEDE GUARDAR LA FACTURA, NO HAY ARTICULOS SELECCIONADOS", "SIN ARTICULOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DateTime fecha = DateTime.Now; float Monto = CalculaImporte();
                MessageBox.Show(Monto.ToString());
                mF.AgregarFactura(ClaveFactura, ClaveProveedor, fecha, Monto);

                //CREA DETALLE FACTURA POR CADA DIFERENTE TIPO DE ARTICULO
                for (int i = 0; i < lvArticulos.Items.Count; i++)
                {
                    int ClaveArt = Convert.ToInt32(lvArticulos.Items[i].Text);
                    int Cant = Convert.ToInt32(lvArticulos.Items[i].SubItems[4].Text);
                    string strConexion1 = Rutinas.GetConnectionString();

                    SqlConnection Con1 = UsoBD.ConectaBD(strConexion1);

                    if (Con1 == null)
                    {
                        MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                        foreach (SqlError E in UsoBD.ESalida.Errors)
                            MessageBox.Show(E.Message);
                        return;
                    }

                    string strComando1 = "UPDATE Articulo SET Cantidad = Cantidad - @Cant WHERE Clave=" + ClaveArt;

                    SqlCommand UpdateA = new SqlCommand(strComando1, Con1);

                    UpdateA.Parameters.AddWithValue("@Cant", Cant);

                    try
                    {
                        UpdateA.ExecuteNonQuery();
                    }
                    catch (SqlException Ex)
                    {
                        foreach (SqlError item in Ex.Errors)
                            MessageBox.Show(item.Message);

                        Con1.Close();
                        return;
                    }
                    Con1.Close();

                    mD.AgregarDetalle(ClaveFactura, ClaveArt, Cant);
                }
                float Importe = CalculaImporte();

                string strConexion = Rutinas.GetConnectionString();
                SqlConnection Con = UsoBD.ConectaBD(strConexion);

                if (Con == null)
                {
                    MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }

                string strComando = "UPDATE Factura SET Monto=Monto+@Importe WHERE Clave = " + ClaveFactura;

                SqlCommand UpdateF = new SqlCommand(strComando, Con);

                UpdateF.Parameters.AddWithValue("@Importe", Importe);

                try
                {
                    UpdateF.ExecuteNonQuery();
                }
                catch (SqlException Ex)
                {
                    foreach (SqlError item in Ex.Errors)
                        MessageBox.Show(item.Message);

                    Con.Close();
                    return;
                }
                Con.Close();

                string strConexion2 = Rutinas.GetConnectionString();
                SqlConnection Con2 = UsoBD.ConectaBD(strConexion2);

                if (Con == null)
                {
                    MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                    foreach (SqlError E in UsoBD.ESalida.Errors)
                        MessageBox.Show(E.Message);
                    return;
                }

                string strComando2 = "UPDATE Proveedor SET Saldo = Saldo + @Importe WHERE Clave = " + ClaveProveedor;

                SqlCommand UpdateP = new SqlCommand(strComando2, Con2);

                UpdateP.Parameters.AddWithValue("@Importe", Importe);

                try
                {
                    UpdateP.ExecuteNonQuery();
                }
                catch (SqlException Ex)
                {
                    foreach (SqlError item in Ex.Errors)
                        MessageBox.Show(item.Message);

                    Con2.Close();
                    return;
                }
                Con2.Close();

                MessageBox.Show("FACTURA CREADA CORRECTAMENTE CON SUS " + CantArt + " DETALLES DE FACTURA", "FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }

        }
        private void numUpCantidad_Validated(object sender, EventArgs e)
        {
            if (numUpCantidad.Value <= 0)
            {
                errorP.SetError(numUpCantidad, "DEBE SELECCIONAR AL MENOS 1 ARTICULO");
                numUpCantidad.Focus();
            }
            else
            {
                errorP.SetError(numUpCantidad, "");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtClaveFactura.Text = "";
            cmbProveedores.Text = "";
            cmbProveedores.SelectedIndex = -1;
            txtClave.Text = "";
            cmbArticulo.Text = "";
            cmbArticulo.SelectedIndex = -1;
            txtClave.Text = "";
            txtClaveArt.Text = "";
            txtPrecio.Text = "";
            txtExistencia.Text = "";
            numUpCantidad.Value = 1;
            lvArticulos.Items.Clear();
            lblImporte.Text = "$0";
            errorP.Clear();

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            string ClaveF = Convert.ToString(txtClaveFactura), ClaveP = Convert.ToString(cmbProveedores.SelectedItem); string Articulo = Convert.ToString(cmbArticulo.SelectedItem);
            int ClaveArticulo;
            if (ClaveF.Length == 0)
            {
                MessageBox.Show("NO PUEDE AGREGAR ARTICULOS SI NO TIENE UNA FACTURA", "SIN FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbProveedores.SelectedIndex == -1)
            {
                MessageBox.Show("SELECCIONE UN PROVEEDOR", "PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbArticulo.SelectedIndex == -1)
            {
                MessageBox.Show("SELECCIONE UN ARTÍCULO", "ARTÍCULO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int CantArt = lvArticulos.Items.Count;
            if (CantArt >= 3)
            {
                MessageBox.Show("NO SE PUEDE AGRGAR MÁS DE 3 TIPOS DIFERENTES DE ARTICULOS", "ARTICULOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClaveArticulo = AdmA.BuscaClaveArt(Articulo);
            if (ClaveArticulo == -1)
            {
                MessageBox.Show("EL ARTICULO NO SE ENCONTRO EN EL SISTEMA", "ARTICULO INEXISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float ArtP = 0; int ArtC = 0; string ArtD = "", ArtM = "";
            string strConexion = Rutinas.GetConnectionString();

            SqlConnection Con = UsoBD.ConectaBD(strConexion);
            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            SqlDataReader Lector = null;

            string strComando = "SELECT Precio,Cantidad,Descripcion, Marca FROM Articulo WHERE Clave=" + ClaveArticulo;

            Lector = UsoBD.Consulta(strComando, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    ArtP = Convert.ToSingle(Lector.GetValue(0).ToString());
                    ArtC = Convert.ToInt32(Lector.GetValue(1).ToString());
                    ArtD = Lector.GetValue(2).ToString();
                    ArtM = Lector.GetValue(3).ToString();
                }
            }
            Con.Close();

            int Cant = Convert.ToInt32(numUpCantidad.Value);
            float PrecioTotal = Cant * ArtP;
            MessageBox.Show(PrecioTotal.ToString());

            for (int i = 0; i < lvArticulos.Items.Count; i++) //BUSCA SI EL ARTICULO YA ESTA AGREGADO EN EL LIST VIEW
            {
                if (lvArticulos.Items[i].Text.Trim() == ClaveArticulo.ToString())
                {
                    int rc = Convert.ToInt32(lvArticulos.Items[i].SubItems[4].Text); //CANTIDAD DEL ARTICULO REGISTRADO
                    int SumCant = ArtC - (rc + Cant);
                    if (SumCant < 0)
                    {
                        MessageBox.Show("LA EXISTENCIA DEL ARTICULO NO ES LA SUFICIENTE PARA LA CANTIDAD INGRESADA", "EXISTENCIA INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int cf = rc + Cant; //CANTIDAD FINAL
                    lvArticulos.Items[i].SubItems[4].Text = cf.ToString();
                    float rp = Convert.ToSingle(lvArticulos.Items[i].SubItems[5].Text);
                    float pf = PrecioTotal + rp; //PRECIO FINAL
                    lvArticulos.Items[i].SubItems[5].Text = pf.ToString();
                    CalculaImporte();
                    return;
                }

            }
            //SI EL ARTICULO A AGREGAR NO SE ENCUENTRA EN LA LIST VIEW 
            int DifCant = ArtC - Cant;
            if (DifCant < 0)
            {
                MessageBox.Show("LA EXISTENCIA DEL ARTICULO NO ES LA SUFICIENTE PARA LA CANTIDAD INGRESADA", "EXISTENCIA INSUFICIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //AGREGA LOS DATOS DEL ARTICULO EN UNA LISTA
            ListViewItem Registro = new ListViewItem(ClaveArticulo.ToString());
            Registro.SubItems.Add(ArtD);
            Registro.SubItems.Add(ArtM);
            Registro.SubItems.Add(ArtP.ToString());
            Registro.SubItems.Add(Cant.ToString());
            Registro.SubItems.Add(PrecioTotal.ToString());
            //AGREGA LA LISTA CON TODOS LOS DATOS DEL ARTICULO EN EL LIST VIEW
            lvArticulos.Items.Add(Registro);
            CalculaImporte();
        }

        private float CalculaImporte()
        {
            int Count = lvArticulos.Items.Count; float Importe = 0;
            if (Count == 0)
            {
                lblImporte.Text = "$0";
            }
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    float Cantidad = Convert.ToSingle(lvArticulos.Items[i].SubItems[5].Text);
                    Importe += Cantidad;
                    lblImporte.Text = "$" + Importe;
                }
            }
            return Importe;
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (lvArticulos.SelectedItems.Count == 0)
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUN ARTICULO", "SIN SELECCIONAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult R = MessageBox.Show("¿DESEA ELIMINAR EL ARTICULO SELECCIONADO?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            {
                for (int i = 0; i < lvArticulos.Items.Count; i++)
                {
                    if (lvArticulos.SelectedItems.Contains(lvArticulos.Items[i]))
                        lvArticulos.Items[i].Remove();
                }
                CalculaImporte();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("¿DESEA SALIR?", "CERRAR VENTANA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
                this.Close();
        }

        private void frmAgregarFactura_Load(object sender, EventArgs e)
        {
            string strConexion = Rutinas.GetConnectionString();
            SqlConnection Con = UsoBD.ConectaBD(strConexion);

            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }

            SqlDataReader Lector = null;

            string strComando = "SELECT Nombre FROM Proveedor ORDER BY Nombre ASC";

            Lector = UsoBD.Consulta(strComando, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                    cmbProveedores.Items.Add(Lector.GetValue(0).ToString());
            }
            Con.Close();

            string strConexion2 = Rutinas.GetConnectionString();
            SqlConnection Con2 = UsoBD.ConectaBD(strConexion2);

            if (Con2 == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }

            SqlDataReader Lector2 = null;

            string strComando2 = "SELECT Descripcion FROM Articulo ORDER BY Descripcion ASC";

            Lector2 = UsoBD.Consulta(strComando2, Con2);

            if (Lector2 == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con2.Close();
                return;
            }
            if (Lector2.HasRows)
            {
                while (Lector2.Read())
                    cmbArticulo.Items.Add(Lector2.GetValue(0).ToString());
            }
            Con2.Close();
        }
            
        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedIndex < 0)
                return;
            string Proveedor = Convert.ToString(cmbProveedores.SelectedItem);
            int ClaveProv = proveedores.BuscarPosNombre(Proveedor);
            txtClave.Text = ClaveProv.ToString();
        }

        private void cmbProveedores_Validated(object sender, EventArgs e)
        {
            bool flag = false;
            string Proveedor = cmbProveedores.Text;
            string Elemento = "";
            for (int i = 0; i < cmbProveedores.Items.Count; i++)
            {
                Elemento = cmbProveedores.GetItemText(cmbProveedores.Items[i]);
                if (Elemento.CompareTo(Proveedor) == 0)
                {
                    flag = true;
                    cmbProveedores.SelectedIndex = i;
                }
            }
            if (!flag)
            {
                errorP.SetError(cmbProveedores, "PROVEEDOR NO ENCONTRADO");
                txtClave.Text = "";
                cmbProveedores.SelectedIndex = -1;
                cmbProveedores.Focus();
            }
            else
            {
                errorP.SetError(cmbProveedores, "");
            }
        }

        private void cmbProveedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(cmbProveedores, "SÓLO SE PERMITEN LETRAS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(cmbProveedores, "");
            }

        }

        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulo.SelectedIndex < 0)
                return;

            string Articulo = Convert.ToString(cmbArticulo.SelectedItem);

            string strConexion = Rutinas.GetConnectionString();

            SqlConnection Con = UsoBD.ConectaBD(strConexion);
            if (Con == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS");

                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);
                return;
            }
            SqlDataReader Lector = null;

            string strComando = "SELECT Clave,Cantidad,Precio FROM Articulo WHERE Descripcion LIKE '" +Articulo+"'";

            Lector = UsoBD.Consulta(strComando, Con);

            if (Lector == null)
            {
                MessageBox.Show("ERROR AL HACER LA CONSULTA");
                foreach (SqlError E in UsoBD.ESalida.Errors)
                    MessageBox.Show(E.Message);

                Con.Close();
                return;
            }
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    txtClaveArt.Text = Lector.GetValue(0).ToString();
                    txtExistencia.Text = Lector.GetValue(1).ToString();
                    txtPrecio.Text = Lector.GetValue(2).ToString();
                }
            }
            Con.Close();
        }

        private void cmbArticulo_Validated(object sender, EventArgs e)
        {
            bool flag = false;
            string Articulo = cmbArticulo.Text;
            string Elemento = "";
            for (int i = 0; i < cmbArticulo.Items.Count; i++)
            {
                Elemento = cmbArticulo.GetItemText(cmbArticulo.Items[i]);
                if (Elemento.CompareTo(Articulo) == 0)
                {
                    flag = true;
                    cmbArticulo.SelectedIndex = i;
                }
            }
            if (!flag)
            {
                errorP.SetError(cmbArticulo, "ARTÍCULO NO ENCONTRADO");
                txtClaveArt.Text = "";
                txtExistencia.Text = "";
                txtPrecio.Text = "";
                cmbArticulo.SelectedIndex = -1;
                cmbArticulo.Focus();
            }
            else
            {
                errorP.SetError(cmbArticulo, "");
            }
        }

        private void cmbArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(cmbArticulo, "SÓLO SE PERMITEN LETRAS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(cmbArticulo, "");
            }
        }

        private void txtClaveFactura_Validated(object sender, EventArgs e)
        {
            string ClaveFactura = txtClaveFactura.Text;
            if (!Rutinas.ValidaTextoNum(ClaveFactura))
            {
                errorP.SetError(txtClaveFactura, "CLAVE DE FACTURA NO VÁLIDA");
                txtClaveFactura.Focus();
            }
            else
            {
                errorP.SetError(txtClaveFactura, "");
            }
        }

        private void txtClaveFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                errorP.SetError(txtClaveFactura, "SÓLO SE PERMITEN NÚMEROS");
                e.Handled = false;
            }
            else
            {
                errorP.SetError(txtClaveFactura, "");
            }
        }
    }
}
