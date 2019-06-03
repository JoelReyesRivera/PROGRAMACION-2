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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarDetalle));
            this.lblClaveFactura = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDatosFactura = new System.Windows.Forms.GroupBox();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.lblNumDetalles = new System.Windows.Forms.LinkLabel();
            this.lblCantDetalles = new System.Windows.Forms.Label();
            this.txtCantDetalles = new System.Windows.Forms.TextBox();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblClaveProveedor = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbClaveFactura = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numUpCantidad = new System.Windows.Forms.NumericUpDown();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.brnSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpDatosArticulo = new System.Windows.Forms.GroupBox();
            this.grpArticulo = new System.Windows.Forms.GroupBox();
            this.txtClaveArt = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.grpDatosFactura.SuspendLayout();
            this.grpInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.grpDatosArticulo.SuspendLayout();
            this.grpArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClaveFactura
            // 
            this.lblClaveFactura.AutoSize = true;
            this.lblClaveFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveFactura.Location = new System.Drawing.Point(20, 29);
            this.lblClaveFactura.Name = "lblClaveFactura";
            this.lblClaveFactura.Size = new System.Drawing.Size(91, 16);
            this.lblClaveFactura.TabIndex = 0;
            this.lblClaveFactura.Text = "Clave Factura";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(16, 28);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(52, 16);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Artículo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(16, 87);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(395, 509);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 42);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar Detalle";
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar el detalle a la factura");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(201, 54);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 26);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar campos de texto y selección");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpDatosFactura
            // 
            this.grpDatosFactura.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosFactura.Controls.Add(this.grpInformacion);
            this.grpDatosFactura.Controls.Add(this.cmbClaveFactura);
            this.grpDatosFactura.Controls.Add(this.btnLimpiar);
            this.grpDatosFactura.Controls.Add(this.lblClaveFactura);
            this.grpDatosFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosFactura.Location = new System.Drawing.Point(25, 24);
            this.grpDatosFactura.Name = "grpDatosFactura";
            this.grpDatosFactura.Size = new System.Drawing.Size(321, 392);
            this.grpDatosFactura.TabIndex = 0;
            this.grpDatosFactura.TabStop = false;
            this.grpDatosFactura.Text = "Datos de la factura";
            // 
            // grpInformacion
            // 
            this.grpInformacion.BackColor = System.Drawing.Color.MistyRose;
            this.grpInformacion.Controls.Add(this.btnVerDetalles);
            this.grpInformacion.Controls.Add(this.lblNumDetalles);
            this.grpInformacion.Controls.Add(this.lblCantDetalles);
            this.grpInformacion.Controls.Add(this.txtCantDetalles);
            this.grpInformacion.Controls.Add(this.txtClaveProveedor);
            this.grpInformacion.Controls.Add(this.txtFecha);
            this.grpInformacion.Controls.Add(this.lblClaveProveedor);
            this.grpInformacion.Controls.Add(this.txtImporte);
            this.grpInformacion.Controls.Add(this.lblProveedor);
            this.grpInformacion.Controls.Add(this.txtProveedor);
            this.grpInformacion.Controls.Add(this.lblImporte);
            this.grpInformacion.Controls.Add(this.lblFecha);
            this.grpInformacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformacion.Location = new System.Drawing.Point(19, 96);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(283, 274);
            this.grpInformacion.TabIndex = 0;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Información de la factura";
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerDetalles.Location = new System.Drawing.Point(35, 234);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(89, 23);
            this.btnVerDetalles.TabIndex = 3;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // lblNumDetalles
            // 
            this.lblNumDetalles.AutoSize = true;
            this.lblNumDetalles.LinkColor = System.Drawing.Color.Black;
            this.lblNumDetalles.Location = new System.Drawing.Point(179, 203);
            this.lblNumDetalles.Name = "lblNumDetalles";
            this.lblNumDetalles.Size = new System.Drawing.Size(0, 15);
            this.lblNumDetalles.TabIndex = 13;
            this.lblNumDetalles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNumDetalles_LinkClicked);
            // 
            // lblCantDetalles
            // 
            this.lblCantDetalles.AutoSize = true;
            this.lblCantDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantDetalles.Location = new System.Drawing.Point(32, 203);
            this.lblCantDetalles.Name = "lblCantDetalles";
            this.lblCantDetalles.Size = new System.Drawing.Size(85, 15);
            this.lblCantDetalles.TabIndex = 0;
            this.lblCantDetalles.Text = "Num. Detalles";
            // 
            // txtCantDetalles
            // 
            this.txtCantDetalles.Location = new System.Drawing.Point(130, 200);
            this.txtCantDetalles.Name = "txtCantDetalles";
            this.txtCantDetalles.ReadOnly = true;
            this.txtCantDetalles.Size = new System.Drawing.Size(114, 21);
            this.txtCantDetalles.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtCantDetalles, "Cantidad de detalles de la factura (clic para visualizarlos)");
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.Location = new System.Drawing.Point(130, 35);
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.ReadOnly = true;
            this.txtClaveProveedor.Size = new System.Drawing.Size(114, 21);
            this.txtClaveProveedor.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtClaveProveedor, "Clave correspondiente al proveedor");
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(130, 158);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(114, 21);
            this.txtFecha.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtFecha, "Fecha de la factura");
            // 
            // lblClaveProveedor
            // 
            this.lblClaveProveedor.AutoSize = true;
            this.lblClaveProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProveedor.Location = new System.Drawing.Point(29, 35);
            this.lblClaveProveedor.Name = "lblClaveProveedor";
            this.lblClaveProveedor.Size = new System.Drawing.Size(95, 15);
            this.lblClaveProveedor.TabIndex = 0;
            this.lblClaveProveedor.Text = "Clave proveedor";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(130, 116);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(114, 21);
            this.txtImporte.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtImporte, "Importe de la factura $");
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(29, 79);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(63, 15);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(130, 76);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(114, 21);
            this.txtProveedor.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtProveedor, "Nombre del proveedor");
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(32, 119);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(49, 15);
            this.lblImporte.TabIndex = 0;
            this.lblImporte.Text = "Importe";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(32, 158);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // cmbClaveFactura
            // 
            this.cmbClaveFactura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClaveFactura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClaveFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClaveFactura.FormattingEnabled = true;
            this.cmbClaveFactura.Location = new System.Drawing.Point(23, 57);
            this.cmbClaveFactura.Name = "cmbClaveFactura";
            this.cmbClaveFactura.Size = new System.Drawing.Size(143, 23);
            this.cmbClaveFactura.TabIndex = 1;
            this.cmbClaveFactura.SelectedIndexChanged += new System.EventHandler(this.cmbClaveFactura_SelectedIndexChanged);
            this.cmbClaveFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbClaveFactura_KeyPress);
            this.cmbClaveFactura.Validated += new System.EventHandler(this.cmbClaveFactura_Validated);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(452, 368);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // numUpCantidad
            // 
            this.numUpCantidad.Location = new System.Drawing.Point(19, 105);
            this.numUpCantidad.Name = "numUpCantidad";
            this.numUpCantidad.ReadOnly = true;
            this.numUpCantidad.Size = new System.Drawing.Size(71, 20);
            this.numUpCantidad.TabIndex = 5;
            this.toolTip1.SetToolTip(this.numUpCantidad, "Seleccione una cantidad");
            this.numUpCantidad.Validated += new System.EventHandler(this.numUpCantidad_Validated);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // brnSalir
            // 
            this.brnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnSalir.Location = new System.Drawing.Point(545, 509);
            this.brnSalir.Name = "brnSalir";
            this.brnSalir.Size = new System.Drawing.Size(120, 42);
            this.brnSalir.TabIndex = 7;
            this.brnSalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.brnSalir, "Cerrar ventana");
            this.brnSalir.UseVisualStyleBackColor = true;
            this.brnSalir.Click += new System.EventHandler(this.brnRegresar_Click);
            // 
            // grpDatosArticulo
            // 
            this.grpDatosArticulo.BackColor = System.Drawing.Color.Transparent;
            this.grpDatosArticulo.Controls.Add(this.grpArticulo);
            this.grpDatosArticulo.Controls.Add(this.cmbArticulo);
            this.grpDatosArticulo.Controls.Add(this.lblArticulo);
            this.grpDatosArticulo.Controls.Add(this.lblCantidad);
            this.grpDatosArticulo.Controls.Add(this.numUpCantidad);
            this.grpDatosArticulo.Location = new System.Drawing.Point(25, 422);
            this.grpDatosArticulo.Name = "grpDatosArticulo";
            this.grpDatosArticulo.Size = new System.Drawing.Size(321, 162);
            this.grpDatosArticulo.TabIndex = 0;
            this.grpDatosArticulo.TabStop = false;
            this.grpDatosArticulo.Text = "Datos del detalle";
            // 
            // grpArticulo
            // 
            this.grpArticulo.BackColor = System.Drawing.Color.MistyRose;
            this.grpArticulo.Controls.Add(this.txtClaveArt);
            this.grpArticulo.Controls.Add(this.txtExistencia);
            this.grpArticulo.Controls.Add(this.lblClave);
            this.grpArticulo.Controls.Add(this.lblPrecio);
            this.grpArticulo.Controls.Add(this.lblExistencia);
            this.grpArticulo.Controls.Add(this.txtPrecio);
            this.grpArticulo.Location = new System.Drawing.Point(178, 9);
            this.grpArticulo.Name = "grpArticulo";
            this.grpArticulo.Size = new System.Drawing.Size(137, 148);
            this.grpArticulo.TabIndex = 0;
            this.grpArticulo.TabStop = false;
            this.grpArticulo.Text = "Info artículo";
            // 
            // txtClaveArt
            // 
            this.txtClaveArt.Location = new System.Drawing.Point(22, 38);
            this.txtClaveArt.Name = "txtClaveArt";
            this.txtClaveArt.ReadOnly = true;
            this.txtClaveArt.Size = new System.Drawing.Size(100, 20);
            this.txtClaveArt.TabIndex = 0;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(22, 122);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.ReadOnly = true;
            this.txtExistencia.Size = new System.Drawing.Size(100, 20);
            this.txtExistencia.TabIndex = 0;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(19, 22);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(19, 66);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(19, 105);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(55, 13);
            this.lblExistencia.TabIndex = 0;
            this.lblExistencia.Text = "Existencia";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(22, 82);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 0;
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(19, 47);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(143, 21);
            this.cmbArticulo.TabIndex = 4;
            this.cmbArticulo.SelectedIndexChanged += new System.EventHandler(this.cmbArticulo_SelectedIndexChanged);
            this.cmbArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbArticulo_KeyPress);
            this.cmbArticulo.Validated += new System.EventHandler(this.cmbArticulo_Validated);
            // 
            // frmAgregarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(690, 595);
            this.ControlBox = false;
            this.Controls.Add(this.grpDatosArticulo);
            this.Controls.Add(this.brnSalir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpDatosFactura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmAgregarDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Detalle";
            this.Load += new System.EventHandler(this.frmAgregarDetalle_Load);
            this.grpDatosFactura.ResumeLayout(false);
            this.grpDatosFactura.PerformLayout();
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.grpDatosArticulo.ResumeLayout(false);
            this.grpDatosArticulo.PerformLayout();
            this.grpArticulo.ResumeLayout(false);
            this.grpArticulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblClaveFactura;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpDatosFactura;
        private System.Windows.Forms.NumericUpDown numUpCantidad;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button brnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbClaveFactura;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.LinkLabel lblNumDetalles;
        private System.Windows.Forms.Label lblCantDetalles;
        private System.Windows.Forms.TextBox txtCantDetalles;
        private System.Windows.Forms.TextBox txtClaveProveedor;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblClaveProveedor;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox grpDatosArticulo;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox grpArticulo;
        private System.Windows.Forms.TextBox txtClaveArt;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnVerDetalles;
    }
}