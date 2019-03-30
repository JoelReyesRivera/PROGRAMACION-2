namespace Facturas
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
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.lblClaveArticuloAgregar = new System.Windows.Forms.Label();
            this.txtClaveArticuloAgregar = new System.Windows.Forms.TextBox();
            this.lblImporteTotal = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.lvArticulos = new System.Windows.Forms.ListView();
            this.ColumnClave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrecioFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lblClaveFactura.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveFactura.Location = new System.Drawing.Point(19, 26);
            this.lblClaveFactura.Name = "lblClaveFactura";
            this.lblClaveFactura.Size = new System.Drawing.Size(76, 14);
            this.lblClaveFactura.TabIndex = 0;
            this.lblClaveFactura.Text = "Clave Factura";
            // 
            // txtClaveFactura
            // 
            this.txtClaveFactura.Location = new System.Drawing.Point(20, 52);
            this.txtClaveFactura.Name = "txtClaveFactura";
            this.txtClaveFactura.Size = new System.Drawing.Size(115, 20);
            this.txtClaveFactura.TabIndex = 1;
            this.txtClaveFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveFactura_KeyPress);
            this.txtClaveFactura.Validated += new System.EventHandler(this.Valida_Factura);
            // 
            // lblClaveProveedor
            // 
            this.lblClaveProveedor.AutoSize = true;
            this.lblClaveProveedor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProveedor.Location = new System.Drawing.Point(17, 91);
            this.lblClaveProveedor.Name = "lblClaveProveedor";
            this.lblClaveProveedor.Size = new System.Drawing.Size(92, 14);
            this.lblClaveProveedor.TabIndex = 2;
            this.lblClaveProveedor.Text = "Clave Proveedor";
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.Location = new System.Drawing.Point(20, 116);
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.Size = new System.Drawing.Size(115, 20);
            this.txtClaveProveedor.TabIndex = 2;
            this.txtClaveProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveProveedor_KeyPress);
            this.txtClaveProveedor.Validated += new System.EventHandler(this.Valida_proveedor);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(451, 276);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 45);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Factura";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Location = new System.Drawing.Point(679, 277);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(137, 44);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar Ventana";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblClaveFactura);
            this.grpDatos.Controls.Add(this.txtClaveFactura);
            this.grpDatos.Controls.Add(this.lblClaveProveedor);
            this.grpDatos.Controls.Add(this.txtClaveProveedor);
            this.grpDatos.Location = new System.Drawing.Point(22, 22);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(167, 154);
            this.grpDatos.TabIndex = 6;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos de la factura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // grpAgregarArticulo
            // 
            this.grpAgregarArticulo.Controls.Add(this.numUpCantidad);
            this.grpAgregarArticulo.Controls.Add(this.lblCantidad);
            this.grpAgregarArticulo.Controls.Add(this.lblClaveArticuloAgregar);
            this.grpAgregarArticulo.Controls.Add(this.txtClaveArticuloAgregar);
            this.grpAgregarArticulo.Location = new System.Drawing.Point(22, 187);
            this.grpAgregarArticulo.Name = "grpAgregarArticulo";
            this.grpAgregarArticulo.Size = new System.Drawing.Size(167, 160);
            this.grpAgregarArticulo.TabIndex = 10;
            this.grpAgregarArticulo.TabStop = false;
            this.grpAgregarArticulo.Text = "Agregar Artículo";
            // 
            // numUpCantidad
            // 
            this.numUpCantidad.Location = new System.Drawing.Point(22, 114);
            this.numUpCantidad.Name = "numUpCantidad";
            this.numUpCantidad.ReadOnly = true;
            this.numUpCantidad.Size = new System.Drawing.Size(120, 20);
            this.numUpCantidad.TabIndex = 4;
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
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(19, 87);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(54, 14);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(216, 204);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(103, 23);
            this.btnAgregarArticulo.TabIndex = 5;
            this.btnAgregarArticulo.Text = "Agregar Artculo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            // 
            // lblClaveArticuloAgregar
            // 
            this.lblClaveArticuloAgregar.AutoSize = true;
            this.lblClaveArticuloAgregar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveArticuloAgregar.Location = new System.Drawing.Point(19, 22);
            this.lblClaveArticuloAgregar.Name = "lblClaveArticuloAgregar";
            this.lblClaveArticuloAgregar.Size = new System.Drawing.Size(98, 14);
            this.lblClaveArticuloAgregar.TabIndex = 0;
            this.lblClaveArticuloAgregar.Text = "Clave del Artículo";
            // 
            // txtClaveArticuloAgregar
            // 
            this.txtClaveArticuloAgregar.Location = new System.Drawing.Point(20, 52);
            this.txtClaveArticuloAgregar.Name = "txtClaveArticuloAgregar";
            this.txtClaveArticuloAgregar.Size = new System.Drawing.Size(115, 20);
            this.txtClaveArticuloAgregar.TabIndex = 3;
            this.txtClaveArticuloAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveArticuloAgregar_KeyPress);
            this.txtClaveArticuloAgregar.Validated += new System.EventHandler(this.Valida_claveartAgrega);
            // 
            // lblImporteTotal
            // 
            this.lblImporteTotal.AutoSize = true;
            this.lblImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTotal.Location = new System.Drawing.Point(748, 237);
            this.lblImporteTotal.Name = "lblImporteTotal";
            this.lblImporteTotal.Size = new System.Drawing.Size(111, 20);
            this.lblImporteTotal.TabIndex = 11;
            this.lblImporteTotal.Text = "ImporteTotal : ";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(865, 237);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(27, 20);
            this.lblImporte.TabIndex = 12;
            this.lblImporte.Text = "$0";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(216, 265);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(103, 23);
            this.btnEliminarArticulo.TabIndex = 6;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            // 
            // lvArticulos
            // 
            this.lvArticulos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnClave,
            this.ColumnDesc,
            this.ColumnModelo,
            this.ColumnPrecio,
            this.ColumnCantidad,
            this.ColumnPrecioFinal});
            this.lvArticulos.Location = new System.Drawing.Point(373, 32);
            this.lvArticulos.Name = "lvArticulos";
            this.lvArticulos.Size = new System.Drawing.Size(519, 195);
            this.lvArticulos.TabIndex = 13;
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
            // ColumnModelo
            // 
            this.ColumnModelo.Text = "Modelo";
            this.ColumnModelo.Width = 88;
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
            // frmAgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 354);
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
        private System.Windows.Forms.ColumnHeader ColumnModelo;
        private System.Windows.Forms.ColumnHeader ColumnPrecio;
        private System.Windows.Forms.ColumnHeader ColumnCantidad;
        private System.Windows.Forms.ColumnHeader ColumnPrecioFinal;
        private System.Windows.Forms.Button btnEliminarArticulo;
    }
}

