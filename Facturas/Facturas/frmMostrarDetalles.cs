﻿using System;
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
    public partial class frmMostrarDetalles : Form
    {
        ManejaFacturas mF;
        ManejaDetalleFactura mD;
        ManejaProveedores proveedores;
        ManejaArticulos AdmA;

        public frmMostrarDetalles(ManejaDetalleFactura mD, ManejaFacturas mF, ManejaProveedores proveedores, ManejaArticulos AdmA)
        {
            InitializeComponent();
            this.mF = mF;
            this.mD = mD;
            this.proveedores = proveedores;
            this.AdmA = AdmA;
        }

        private void frmMostrarDetalles_Load(object sender, EventArgs e)
        {
            List<DetalleFactura> D = mD.RetornaDetalles();
            Articulo A;
            float Importe = 0;
            for (int i = 0; i < D.Count; i++)
            {
                A = AdmA.RetornaArticulo(D.ElementAt(i).pClaveArt);
                Importe = D.ElementAt(i).pCant * A.pPrecio;
                dgvDetalles.Rows.Add(D.ElementAt(i).pClaveFact,D.ElementAt(i).pClaveArt,A.pDescripcion,D.ElementAt(i).pPrecio,D.ElementAt(i).pCant,Importe);
            }
                
        }
    }
}
