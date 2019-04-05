namespace Facturas
{
    partial class frmBuscarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarFactura));
            this.lblClaveFactura = new System.Windows.Forms.Label();
            this.txtClaveFactura = new System.Windows.Forms.TextBox();
            this.lblClaveProveedor = new System.Windows.Forms.Label();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.lblNumDetalles = new System.Windows.Forms.LinkLabel();
            this.lblCantDetalles = new System.Windows.Forms.Label();
            this.txtCantDetalles = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaveFactura
            // 
            this.lblClaveFactura.AutoSize = true;
<<<<<<< HEAD
            this.lblClaveFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblClaveFactura.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveFactura.Location = new System.Drawing.Point(78, 48);
=======
            this.lblClaveFactura.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveFactura.Location = new System.Drawing.Point(83, 48);
>>>>>>> master
            this.lblClaveFactura.Name = "lblClaveFactura";
            this.lblClaveFactura.Size = new System.Drawing.Size(113, 17);
            this.lblClaveFactura.TabIndex = 0;
            this.lblClaveFactura.Text = "CLAVE FACTURA";
            // 
            // txtClaveFactura
            // 
<<<<<<< HEAD
            this.txtClaveFactura.Location = new System.Drawing.Point(60, 78);
=======
            this.txtClaveFactura.Location = new System.Drawing.Point(56, 79);
>>>>>>> master
            this.txtClaveFactura.Name = "txtClaveFactura";
            this.txtClaveFactura.Size = new System.Drawing.Size(150, 20);
            this.txtClaveFactura.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtClaveFactura, "Introduza la clave de la factura a buscar");
            this.txtClaveFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveFactura_KeyPress);
            this.txtClaveFactura.Validated += new System.EventHandler(this.Valida_factura);
            // 
            // lblClaveProveedor
            // 
            this.lblClaveProveedor.AutoSize = true;
            this.lblClaveProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProveedor.Location = new System.Drawing.Point(29, 35);
            this.lblClaveProveedor.Name = "lblClaveProveedor";
            this.lblClaveProveedor.Size = new System.Drawing.Size(95, 15);
            this.lblClaveProveedor.TabIndex = 3;
            this.lblClaveProveedor.Text = "Clave proveedor";
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.Location = new System.Drawing.Point(130, 35);
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.ReadOnly = true;
            this.txtClaveProveedor.Size = new System.Drawing.Size(114, 21);
            this.txtClaveProveedor.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtClaveProveedor, "Clave correspondiente al proveedor");
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(29, 79);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(63, 15);
            this.lblProveedor.TabIndex = 5;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(32, 119);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(49, 15);
            this.lblImporte.TabIndex = 6;
            this.lblImporte.Text = "Importe";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(32, 158);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(130, 76);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(114, 21);
            this.txtProveedor.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtProveedor, "Nombre del proveedor");
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(130, 116);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(114, 21);
            this.txtImporte.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtImporte, "Importe de la factura $");
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(130, 158);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(114, 21);
            this.txtFecha.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtFecha, "Fecha de la factura");
            // 
            // grpInformacion
            // 
            this.grpInformacion.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.grpInformacion.Location = new System.Drawing.Point(266, 48);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(283, 248);
            this.grpInformacion.TabIndex = 11;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Información de la factura";
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
            this.lblNumDetalles.Click += new System.EventHandler(this.lblNumDetalles_Click);
            // 
            // lblCantDetalles
            // 
            this.lblCantDetalles.AutoSize = true;
            this.lblCantDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantDetalles.Location = new System.Drawing.Point(32, 203);
            this.lblCantDetalles.Name = "lblCantDetalles";
            this.lblCantDetalles.Size = new System.Drawing.Size(85, 15);
            this.lblCantDetalles.TabIndex = 12;
            this.lblCantDetalles.Text = "Num. Detalles";
            // 
            // txtCantDetalles
            // 
            this.txtCantDetalles.Location = new System.Drawing.Point(130, 200);
            this.txtCantDetalles.Name = "txtCantDetalles";
            this.txtCantDetalles.ReadOnly = true;
            this.txtCantDetalles.Size = new System.Drawing.Size(114, 21);
            this.txtCantDetalles.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtCantDetalles, "Cantidad de detalles de la factura (clic para visualizarlos)");
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(260, 321);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 41);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar la factura");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(364, 321);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 41);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar campos de texto");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(465, 321);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 41);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalir, "Cerrar ventana");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
<<<<<<< HEAD
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(201, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 20);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "BUSCAR FACTURA";
=======
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(194, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(145, 18);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "BUSCA FACTURA";
>>>>>>> master
            // 
            // frmBuscarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
=======
>>>>>>> master
            this.ClientSize = new System.Drawing.Size(574, 373);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.txtClaveFactura);
            this.Controls.Add(this.lblClaveFactura);
            this.Name = "frmBuscarFactura";
            this.Text = "Buscar factura";
            this.Load += new System.EventHandler(this.frmBuscarFactura_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaveFactura;
        private System.Windows.Forms.TextBox txtClaveFactura;
        private System.Windows.Forms.Label lblClaveProveedor;
        private System.Windows.Forms.TextBox txtClaveProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCantDetalles;
        private System.Windows.Forms.LinkLabel lblNumDetalles;
        private System.Windows.Forms.TextBox txtCantDetalles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTitulo;
    }
}