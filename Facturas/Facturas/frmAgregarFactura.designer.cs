﻿namespace Facturas
{
    partial class frmAgregarFactura
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarFactura));
            this.lblClaveFactura = new System.Windows.Forms.Label();
            this.txtClaveFactura = new System.Windows.Forms.TextBox();
            this.lblClaveProveedor = new System.Windows.Forms.Label();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpAgregarArticulo = new System.Windows.Forms.GroupBox();
            this.numUpCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblClaveArticuloAgregar = new System.Windows.Forms.Label();
            this.txtClaveArticuloAgregar = new System.Windows.Forms.TextBox();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.lvArticulos = new System.Windows.Forms.ListView();
            this.ColumnClave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrecioFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpAgregarArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaveFactura
            // 
            this.lblClaveFactura.AutoSize = true;
            this.lblClaveFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveFactura.Location = new System.Drawing.Point(19, 26);
            this.lblClaveFactura.Name = "lblClaveFactura";
            this.lblClaveFactura.Size = new System.Drawing.Size(81, 15);
            this.lblClaveFactura.TabIndex = 0;
            this.lblClaveFactura.Text = "Clave Factura";
            // 
            // txtClaveFactura
            // 
            this.txtClaveFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveFactura.Location = new System.Drawing.Point(20, 52);
            this.txtClaveFactura.Name = "txtClaveFactura";
            this.txtClaveFactura.Size = new System.Drawing.Size(115, 21);
            this.txtClaveFactura.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtClaveFactura, "Proporcione una clave a la factura");
            this.txtClaveFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveFactura_KeyPress);
            this.txtClaveFactura.Validated += new System.EventHandler(this.Valida_Factura);
            // 
            // lblClaveProveedor
            // 
            this.lblClaveProveedor.AutoSize = true;
            this.lblClaveProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProveedor.Location = new System.Drawing.Point(17, 91);
            this.lblClaveProveedor.Name = "lblClaveProveedor";
            this.lblClaveProveedor.Size = new System.Drawing.Size(96, 15);
            this.lblClaveProveedor.TabIndex = 2;
            this.lblClaveProveedor.Text = "Clave Proveedor";
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveProveedor.Location = new System.Drawing.Point(20, 116);
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.Size = new System.Drawing.Size(115, 21);
            this.txtClaveProveedor.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtClaveProveedor, "Proporcione la clave del proveedor");
            this.txtClaveProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveProveedor_KeyPress);
            this.txtClaveProveedor.Validated += new System.EventHandler(this.Valida_proveedor);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(386, 292);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 34);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Factura";
            this.toolTip1.SetToolTip(this.btnAgregar, "Crear la factura con la información correspondiente");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(555, 293);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 33);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar Ventana";
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar campos de texto y selección");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.Transparent;
            this.grpDatos.Controls.Add(this.lblClaveFactura);
            this.grpDatos.Controls.Add(this.txtClaveFactura);
            this.grpDatos.Controls.Add(this.lblClaveProveedor);
            this.grpDatos.Controls.Add(this.txtClaveProveedor);
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(22, 22);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(167, 154);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos de la factura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // grpAgregarArticulo
            // 
            this.grpAgregarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.grpAgregarArticulo.Controls.Add(this.numUpCantidad);
            this.grpAgregarArticulo.Controls.Add(this.lblCantidad);
            this.grpAgregarArticulo.Controls.Add(this.lblClaveArticuloAgregar);
            this.grpAgregarArticulo.Controls.Add(this.txtClaveArticuloAgregar);
            this.grpAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgregarArticulo.Location = new System.Drawing.Point(22, 187);
            this.grpAgregarArticulo.Name = "grpAgregarArticulo";
            this.grpAgregarArticulo.Size = new System.Drawing.Size(167, 160);
            this.grpAgregarArticulo.TabIndex = 1;
            this.grpAgregarArticulo.TabStop = false;
            this.grpAgregarArticulo.Text = "Agregar Artículo";
            // 
            // numUpCantidad
            // 
            this.numUpCantidad.Location = new System.Drawing.Point(22, 114);
            this.numUpCantidad.Name = "numUpCantidad";
            this.numUpCantidad.ReadOnly = true;
            this.numUpCantidad.Size = new System.Drawing.Size(120, 21);
            this.numUpCantidad.TabIndex = 4;
            this.toolTip1.SetToolTip(this.numUpCantidad, "Seleccione una cantidad");
            this.numUpCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpCantidad.Validated += new System.EventHandler(this.numUpCantidad_Validated);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(19, 87);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblClaveArticuloAgregar
            // 
            this.lblClaveArticuloAgregar.AutoSize = true;
            this.lblClaveArticuloAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveArticuloAgregar.Location = new System.Drawing.Point(19, 22);
            this.lblClaveArticuloAgregar.Name = "lblClaveArticuloAgregar";
            this.lblClaveArticuloAgregar.Size = new System.Drawing.Size(100, 15);
            this.lblClaveArticuloAgregar.TabIndex = 0;
            this.lblClaveArticuloAgregar.Text = "Clave del Artículo";
            // 
            // txtClaveArticuloAgregar
            // 
            this.txtClaveArticuloAgregar.Location = new System.Drawing.Point(20, 52);
            this.txtClaveArticuloAgregar.Name = "txtClaveArticuloAgregar";
            this.txtClaveArticuloAgregar.Size = new System.Drawing.Size(115, 21);
            this.txtClaveArticuloAgregar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtClaveArticuloAgregar, "Proporcione la clave del artículo");
            this.txtClaveArticuloAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveArticuloAgregar_KeyPress);
            this.txtClaveArticuloAgregar.Validated += new System.EventHandler(this.Valida_claveartAgrega);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(202, 235);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(114, 31);
            this.btnAgregarArticulo.TabIndex = 5;
            this.btnAgregarArticulo.Text = "Agregar Artculo";
            this.toolTip1.SetToolTip(this.btnAgregarArticulo, "Agregar artículo a la lista de detalle");
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.Location = new System.Drawing.Point(721, 253);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(108, 16);
            this.lblImporteTotal.TabIndex = 0;
            this.lblImporteTotal.Text = "ImporteTotal : ";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.BackColor = System.Drawing.Color.Transparent;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(835, 253);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(24, 16);
            this.lblImporte.TabIndex = 0;
            this.lblImporte.Text = "$0";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(202, 286);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(114, 31);
            this.btnEliminarArticulo.TabIndex = 6;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.toolTip1.SetToolTip(this.btnEliminarArticulo, "Eliminar artículo de la lista de detalle");
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // lvArticulos
            // 
            this.lvArticulos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnClave,
            this.ColumnDesc,
            this.ColumnMarca,
            this.ColumnPrecio,
            this.ColumnCantidad,
            this.ColumnPrecioFinal});
            this.lvArticulos.Location = new System.Drawing.Point(342, 48);
            this.lvArticulos.Name = "lvArticulos";
            this.lvArticulos.Size = new System.Drawing.Size(529, 202);
            this.lvArticulos.TabIndex = 0;
            this.lvArticulos.UseCompatibleStateImageBehavior = false;
            this.lvArticulos.View = System.Windows.Forms.View.Details;
            // 
            // ColumnClave
            // 
            this.ColumnClave.Text = "Clave Articulo";
            this.ColumnClave.Width = 90;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.Text = "Descripción";
            this.ColumnDesc.Width = 104;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.Text = "Marca";
            this.ColumnMarca.Width = 88;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.Text = "Precio Unitario";
            this.ColumnPrecio.Width = 88;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.Text = "Cantidad";
            this.ColumnCantidad.Width = 82;
            // 
            // ColumnPrecioFinal
            // 
            this.ColumnPrecioFinal.Text = "Precio ";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(722, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 33);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalir, "Cerrar ventana");
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(509, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(168, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ARTICULOS A LLEVAR";
            // 
            // frmAgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(883, 349);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvArticulos);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.lblImporteTotal);
            this.Controls.Add(this.grpAgregarArticulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmAgregarFactura";
            this.Text = "Agregar nueva factura";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpAgregarArticulo.ResumeLayout(false);
            this.grpAgregarArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaveFactura;
        private System.Windows.Forms.TextBox txtClaveFactura;
        private System.Windows.Forms.Label lblClaveProveedor;
        private System.Windows.Forms.TextBox txtClaveProveedor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpAgregarArticulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Label lblClaveArticuloAgregar;
        private System.Windows.Forms.TextBox txtClaveArticuloAgregar;
        private System.Windows.Forms.Label lblImporteTotal;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.NumericUpDown numUpCantidad;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.ListView lvArticulos;
        private System.Windows.Forms.ColumnHeader ColumnClave;
        private System.Windows.Forms.ColumnHeader ColumnDesc;
        private System.Windows.Forms.ColumnHeader ColumnMarca;
        private System.Windows.Forms.ColumnHeader ColumnPrecio;
        private System.Windows.Forms.ColumnHeader ColumnCantidad;
        private System.Windows.Forms.ColumnHeader ColumnPrecioFinal;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
    }
}

