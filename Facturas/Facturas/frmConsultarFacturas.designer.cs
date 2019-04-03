namespace Facturas
{
    partial class frmConsultarFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarFacturas));
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.dtgvFacturas = new System.Windows.Forms.DataGridView();
            this.dtgvDetalles = new System.Windows.Forms.DataGridView();
            this.lblFacturas = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.grpInfomacion = new System.Windows.Forms.GroupBox();
            this.cmbFacturas = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblSeleccionarFactura = new System.Windows.Forms.Label();
            this.ClaveFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalles)).BeginInit();
            this.grpInfomacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(139, 27);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(148, 21);
            this.cmbProveedores.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmbProveedores, "Seleccione un proveedor");
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(35, 31);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(89, 17);
            this.lblProveedor.TabIndex = 1;
            this.lblProveedor.Text = "PROVEEDOR";
            // 
            // dtgvFacturas
            // 
            this.dtgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factura,
            this.ClaveProveedor,
            this.Provedor,
            this.Importe,
            this.Fecha});
            this.dtgvFacturas.Location = new System.Drawing.Point(13, 60);
            this.dtgvFacturas.Name = "dtgvFacturas";
            this.dtgvFacturas.Size = new System.Drawing.Size(791, 181);
            this.dtgvFacturas.TabIndex = 2;
            // 
            // dtgvDetalles
            // 
            this.dtgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveFactura,
            this.ClaveArticulo,
            this.Articulo,
            this.Modelo,
            this.Cantidad,
            this.PrecioUnitario});
            this.dtgvDetalles.Location = new System.Drawing.Point(13, 366);
            this.dtgvDetalles.Name = "dtgvDetalles";
            this.dtgvDetalles.Size = new System.Drawing.Size(825, 181);
            this.dtgvDetalles.TabIndex = 3;
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturas.Location = new System.Drawing.Point(9, 26);
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(194, 20);
            this.lblFacturas.TabIndex = 4;
            this.lblFacturas.Text = "Facturas del proveedor";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(9, 328);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(199, 20);
            this.lblDetalles.TabIndex = 5;
            this.lblDetalles.Text = "Detalles de las facturas";
            // 
            // grpInfomacion
            // 
            this.grpInfomacion.Controls.Add(this.lblSeleccionarFactura);
            this.grpInfomacion.Controls.Add(this.cmbFacturas);
            this.grpInfomacion.Controls.Add(this.dtgvDetalles);
            this.grpInfomacion.Controls.Add(this.lblDetalles);
            this.grpInfomacion.Controls.Add(this.dtgvFacturas);
            this.grpInfomacion.Controls.Add(this.lblFacturas);
            this.grpInfomacion.Location = new System.Drawing.Point(25, 83);
            this.grpInfomacion.Name = "grpInfomacion";
            this.grpInfomacion.Size = new System.Drawing.Size(850, 520);
            this.grpInfomacion.TabIndex = 6;
            this.grpInfomacion.TabStop = false;
            this.grpInfomacion.Text = "Datos";
            // 
            // cmbFacturas
            // 
            this.cmbFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFacturas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFacturas.FormattingEnabled = true;
            this.cmbFacturas.Location = new System.Drawing.Point(98, 277);
            this.cmbFacturas.Name = "cmbFacturas";
            this.cmbFacturas.Size = new System.Drawing.Size(148, 21);
            this.cmbFacturas.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cmbFacturas, "Seleccione una Factura");
            this.cmbFacturas.SelectedIndexChanged += new System.EventHandler(this.cmbFacturas_SelectedIndexChanged);
            // 
            // lblSeleccionarFactura
            // 
            this.lblSeleccionarFactura.AutoSize = true;
            this.lblSeleccionarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarFactura.Location = new System.Drawing.Point(9, 275);
            this.lblSeleccionarFactura.Name = "lblSeleccionarFactura";
            this.lblSeleccionarFactura.Size = new System.Drawing.Size(71, 20);
            this.lblSeleccionarFactura.TabIndex = 8;
            this.lblSeleccionarFactura.Text = "Factura";
            // 
            // ClaveFactura
            // 
            this.ClaveFactura.HeaderText = "Factura";
            this.ClaveFactura.Name = "ClaveFactura";
            this.ClaveFactura.Width = 150;
            // 
            // ClaveArticulo
            // 
            this.ClaveArticulo.HeaderText = "Clave Articulo";
            this.ClaveArticulo.Name = "ClaveArticulo";
            this.ClaveArticulo.Width = 150;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "ArticuloDescripción";
            this.Articulo.Name = "Articulo";
            this.Articulo.Width = 150;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "ArticuloModelo";
            this.Modelo.Name = "Modelo";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 150;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 150;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.Width = 150;
            // 
            // ClaveProveedor
            // 
            this.ClaveProveedor.HeaderText = "Clave Provedor";
            this.ClaveProveedor.Name = "ClaveProveedor";
            this.ClaveProveedor.Width = 150;
            // 
            // Provedor
            // 
            this.Provedor.HeaderText = "Proveedor";
            this.Provedor.Name = "Provedor";
            this.Provedor.Width = 150;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(770, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpInfomacion);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cmbProveedores);
            this.Name = "frmConsultarFacturas";
            this.Text = "Consulta facturas proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalles)).EndInit();
            this.grpInfomacion.ResumeLayout(false);
            this.grpInfomacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.DataGridView dtgvFacturas;
        private System.Windows.Forms.DataGridView dtgvDetalles;
        private System.Windows.Forms.Label lblFacturas;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.GroupBox grpInfomacion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbFacturas;
        private System.Windows.Forms.Label lblSeleccionarFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}