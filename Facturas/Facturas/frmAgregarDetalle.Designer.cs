namespace Facturas
{
    partial class frmAgregarDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblClaveProveedor = new System.Windows.Forms.Label();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.lblClaveFactura = new System.Windows.Forms.Label();
            this.txtClaveFactura = new System.Windows.Forms.TextBox();
            this.lblClaveArticulo = new System.Windows.Forms.Label();
            this.txtClaveArticulo = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMuestraProveedor = new System.Windows.Forms.TextBox();
            this.txtMuestraFactura = new System.Windows.Forms.TextBox();
            this.txtMuestraArticulo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.numUpCantidad = new System.Windows.Forms.NumericUpDown();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaveProveedor
            // 
            this.lblClaveProveedor.AutoSize = true;
            this.lblClaveProveedor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProveedor.Location = new System.Drawing.Point(14, 23);
            this.lblClaveProveedor.Name = "lblClaveProveedor";
            this.lblClaveProveedor.Size = new System.Drawing.Size(123, 14);
            this.lblClaveProveedor.TabIndex = 0;
            this.lblClaveProveedor.Text = "Número de proveedor";
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.Location = new System.Drawing.Point(17, 50);
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.Size = new System.Drawing.Size(120, 20);
            this.txtClaveProveedor.TabIndex = 1;
            this.txtClaveProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveProveedor_KeyPress);
            this.txtClaveProveedor.Validated += new System.EventHandler(this.Valida_proveedor);
            // 
            // lblClaveFactura
            // 
            this.lblClaveFactura.AutoSize = true;
            this.lblClaveFactura.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveFactura.Location = new System.Drawing.Point(15, 97);
            this.lblClaveFactura.Name = "lblClaveFactura";
            this.lblClaveFactura.Size = new System.Drawing.Size(76, 14);
            this.lblClaveFactura.TabIndex = 2;
            this.lblClaveFactura.Text = "Clave Factura";
            // 
            // txtClaveFactura
            // 
            this.txtClaveFactura.Location = new System.Drawing.Point(17, 124);
            this.txtClaveFactura.Name = "txtClaveFactura";
            this.txtClaveFactura.Size = new System.Drawing.Size(120, 20);
            this.txtClaveFactura.TabIndex = 3;
            this.txtClaveFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveFactura_KeyPress);
            this.txtClaveFactura.Validated += new System.EventHandler(this.Valida_factura);
            // 
            // lblClaveArticulo
            // 
            this.lblClaveArticulo.AutoSize = true;
            this.lblClaveArticulo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveArticulo.Location = new System.Drawing.Point(15, 166);
            this.lblClaveArticulo.Name = "lblClaveArticulo";
            this.lblClaveArticulo.Size = new System.Drawing.Size(79, 14);
            this.lblClaveArticulo.TabIndex = 4;
            this.lblClaveArticulo.Text = "Clave Artículo";
            // 
            // txtClaveArticulo
            // 
            this.txtClaveArticulo.Location = new System.Drawing.Point(17, 192);
            this.txtClaveArticulo.Name = "txtClaveArticulo";
            this.txtClaveArticulo.Size = new System.Drawing.Size(120, 20);
            this.txtClaveArticulo.TabIndex = 5;
            this.txtClaveArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveArticulo_KeyPress);
            this.txtClaveArticulo.Validated += new System.EventHandler(this.Valida_articulo);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(15, 235);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(54, 14);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(63, 348);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar Detalle";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtMuestraProveedor
            // 
            this.txtMuestraProveedor.Location = new System.Drawing.Point(173, 50);
            this.txtMuestraProveedor.Name = "txtMuestraProveedor";
            this.txtMuestraProveedor.ReadOnly = true;
            this.txtMuestraProveedor.Size = new System.Drawing.Size(117, 20);
            this.txtMuestraProveedor.TabIndex = 10;
            // 
            // txtMuestraFactura
            // 
            this.txtMuestraFactura.Location = new System.Drawing.Point(173, 124);
            this.txtMuestraFactura.Name = "txtMuestraFactura";
            this.txtMuestraFactura.ReadOnly = true;
            this.txtMuestraFactura.Size = new System.Drawing.Size(117, 20);
            this.txtMuestraFactura.TabIndex = 11;
            // 
            // txtMuestraArticulo
            // 
            this.txtMuestraArticulo.Location = new System.Drawing.Point(173, 191);
            this.txtMuestraArticulo.Name = "txtMuestraArticulo";
            this.txtMuestraArticulo.ReadOnly = true;
            this.txtMuestraArticulo.Size = new System.Drawing.Size(117, 20);
            this.txtMuestraArticulo.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(198, 348);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.numUpCantidad);
            this.grpDatos.Controls.Add(this.txtMuestraArticulo);
            this.grpDatos.Controls.Add(this.lblClaveProveedor);
            this.grpDatos.Controls.Add(this.txtClaveProveedor);
            this.grpDatos.Controls.Add(this.txtMuestraFactura);
            this.grpDatos.Controls.Add(this.lblClaveFactura);
            this.grpDatos.Controls.Add(this.txtMuestraProveedor);
            this.grpDatos.Controls.Add(this.txtClaveFactura);
            this.grpDatos.Controls.Add(this.lblClaveArticulo);
            this.grpDatos.Controls.Add(this.txtClaveArticulo);
            this.grpDatos.Controls.Add(this.lblCantidad);
            this.grpDatos.Location = new System.Drawing.Point(12, 23);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(306, 297);
            this.grpDatos.TabIndex = 14;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del detalle";
            // 
            // numUpCantidad
            // 
            this.numUpCantidad.Location = new System.Drawing.Point(18, 261);
            this.numUpCantidad.Name = "numUpCantidad";
            this.numUpCantidad.ReadOnly = true;
            this.numUpCantidad.Size = new System.Drawing.Size(76, 20);
            this.numUpCantidad.TabIndex = 15;
            this.numUpCantidad.Validated += new System.EventHandler(this.numUpCantidad_Validated);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmAgregarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 397);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmAgregarDetalle";
            this.Text = "Módulo Detalles de Factura";
            this.Load += new System.EventHandler(this.frmAgregarDetalle_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClaveProveedor;
        private System.Windows.Forms.TextBox txtClaveProveedor;
        private System.Windows.Forms.Label lblClaveFactura;
        private System.Windows.Forms.TextBox txtClaveFactura;
        private System.Windows.Forms.Label lblClaveArticulo;
        private System.Windows.Forms.TextBox txtClaveArticulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMuestraProveedor;
        private System.Windows.Forms.TextBox txtMuestraFactura;
        private System.Windows.Forms.TextBox txtMuestraArticulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.NumericUpDown numUpCantidad;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}