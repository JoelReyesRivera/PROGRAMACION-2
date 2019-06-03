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
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvDetalles = new System.Windows.Forms.DataGridView();
            this.ClaveFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFacturas = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.grpInfomacion = new System.Windows.Forms.GroupBox();
            this.lblSeleccionarFactura = new System.Windows.Forms.Label();
            this.cmbFacturas = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalles)).BeginInit();
            this.grpInfomacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProveedores.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmbProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(126, 16);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(148, 21);
            this.cmbProveedores.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbProveedores, "Seleccione un proveedor");
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
            this.cmbProveedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProveedores_KeyPress);
            this.cmbProveedores.Validated += new System.EventHandler(this.cmbProveedores_Validated);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.Color.Transparent;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(22, 20);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(89, 17);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "PROVEEDOR";
            // 
            // dtgvFacturas
            // 
            this.dtgvFacturas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
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
            this.dtgvFacturas.ReadOnly = true;
            this.dtgvFacturas.Size = new System.Drawing.Size(794, 181);
            this.dtgvFacturas.TabIndex = 0;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Width = 150;
            // 
            // ClaveProveedor
            // 
            this.ClaveProveedor.HeaderText = "Clave Provedor";
            this.ClaveProveedor.Name = "ClaveProveedor";
            this.ClaveProveedor.ReadOnly = true;
            this.ClaveProveedor.Width = 150;
            // 
            // Provedor
            // 
            this.Provedor.HeaderText = "Proveedor";
            this.Provedor.Name = "Provedor";
            this.Provedor.ReadOnly = true;
            this.Provedor.Width = 150;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 150;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // dtgvDetalles
            // 
            this.dtgvDetalles.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveFactura,
            this.ClaveArticulo,
            this.Articulo,
            this.Modelo,
            this.Cantidad,
            this.PrecioUnitario,
            this.ImporteDetalle});
            this.dtgvDetalles.Location = new System.Drawing.Point(6, 337);
            this.dtgvDetalles.Name = "dtgvDetalles";
            this.dtgvDetalles.ReadOnly = true;
            this.dtgvDetalles.Size = new System.Drawing.Size(813, 177);
            this.dtgvDetalles.TabIndex = 0;
            // 
            // ClaveFactura
            // 
            this.ClaveFactura.HeaderText = "Factura";
            this.ClaveFactura.Name = "ClaveFactura";
            this.ClaveFactura.ReadOnly = true;
            // 
            // ClaveArticulo
            // 
            this.ClaveArticulo.HeaderText = "Clave Articulo";
            this.ClaveArticulo.Name = "ClaveArticulo";
            this.ClaveArticulo.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "ArticuloDescripción";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 200;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "ArticuloModelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 75;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 75;
            // 
            // ImporteDetalle
            // 
            this.ImporteDetalle.HeaderText = "Importe";
            this.ImporteDetalle.Name = "ImporteDetalle";
            this.ImporteDetalle.ReadOnly = true;
            this.ImporteDetalle.Width = 120;
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturas.Location = new System.Drawing.Point(9, 26);
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(194, 20);
            this.lblFacturas.TabIndex = 0;
            this.lblFacturas.Text = "Facturas del proveedor";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(9, 314);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(199, 20);
            this.lblDetalles.TabIndex = 0;
            this.lblDetalles.Text = "Detalles de las facturas";
            // 
            // grpInfomacion
            // 
            this.grpInfomacion.BackColor = System.Drawing.Color.Transparent;
            this.grpInfomacion.Controls.Add(this.lblSeleccionarFactura);
            this.grpInfomacion.Controls.Add(this.cmbFacturas);
            this.grpInfomacion.Controls.Add(this.dtgvDetalles);
            this.grpInfomacion.Controls.Add(this.lblDetalles);
            this.grpInfomacion.Controls.Add(this.dtgvFacturas);
            this.grpInfomacion.Controls.Add(this.lblFacturas);
            this.grpInfomacion.Location = new System.Drawing.Point(19, 43);
            this.grpInfomacion.Name = "grpInfomacion";
            this.grpInfomacion.Size = new System.Drawing.Size(838, 520);
            this.grpInfomacion.TabIndex = 0;
            this.grpInfomacion.TabStop = false;
            this.grpInfomacion.Text = "Datos";
            // 
            // lblSeleccionarFactura
            // 
            this.lblSeleccionarFactura.AutoSize = true;
            this.lblSeleccionarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarFactura.Location = new System.Drawing.Point(9, 275);
            this.lblSeleccionarFactura.Name = "lblSeleccionarFactura";
            this.lblSeleccionarFactura.Size = new System.Drawing.Size(71, 20);
            this.lblSeleccionarFactura.TabIndex = 0;
            this.lblSeleccionarFactura.Text = "Factura";
            // 
            // cmbFacturas
            // 
            this.cmbFacturas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFacturas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFacturas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmbFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFacturas.FormattingEnabled = true;
            this.cmbFacturas.Location = new System.Drawing.Point(107, 274);
            this.cmbFacturas.Name = "cmbFacturas";
            this.cmbFacturas.Size = new System.Drawing.Size(148, 21);
            this.cmbFacturas.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cmbFacturas, "Seleccione una Factura");
            this.cmbFacturas.SelectedIndexChanged += new System.EventHandler(this.cmbFacturas_SelectedIndexChanged);
            this.cmbFacturas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFacturas_KeyPress);
            this.cmbFacturas.Validated += new System.EventHandler(this.cmbFacturas_Validated);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(705, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(777, 569);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(659, 569);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 34);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmConsultarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(883, 615);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpInfomacion);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cmbProveedores);
            this.Name = "frmConsultarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta facturas proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalles)).EndInit();
            this.grpInfomacion.ResumeLayout(false);
            this.grpInfomacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteDetalle;
    }
}