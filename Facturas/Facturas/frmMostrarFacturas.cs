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
    public partial class frmMostrarFacturas : Form
    {
        ManejaFacturas mF;
        ManejaProveedores proveedores;

        public frmMostrarFacturas(ManejaFacturas mF, ManejaProveedores proveedores)
        {
            InitializeComponent();
            this.mF = mF;
            this.proveedores = proveedores;
        }

        private void frmMostrarFacturas_Load(object sender, EventArgs e)
        {
            KeyValuePair<int, Factura>[] F = mF.RetornaFacturas();
            string Proveedor="";
            string Fecha="";
            for (int i = 0; i < mF.pCount; i++)
            {
                Fecha = Rutinas.ConvierteFecha(F[i].Value.pDia,F[i].Value.pMes,F[i].Value.pAño);
                Proveedor = proveedores.RetornaProveedorClave(F[i].Value.pClaveProv).pNombre;
                dgvFacturas.Rows.Add(F[i].Key,F[i].Value.pClaveProv,Proveedor,F[i].Value.pImporte,Fecha);
            }
        }
    }
}
