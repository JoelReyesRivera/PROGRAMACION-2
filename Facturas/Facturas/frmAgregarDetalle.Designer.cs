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
            this.lblClaveProveedor = new System.Windows.Forms.Label();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.lblClaveFactura = new System.Windows.Forms.Label();
            this.txtClaveFactura = new System.Windows.Forms.TextBox();
            this.lblClaveArticulo = new System.Windows.Forms.Label();
            this.txtClaveArticulo = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numUpCantidad = new System.Windows.Forms.NumericUpDown();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.brnSalir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClaveProveedor
            // 
            this.lblClaveProveedor.AutoSize = true;
            this.lblClaveProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProveedor.Location = new System.Drawing.Point(16, 96);
            this.lblClaveProveedor.Name = "lblClaveProveedor";
            this.lblClaveProveedor.Size = new System.Drawing.Size(110, 16);
            this.lblClaveProveedor.TabIndex = 0;
            this.lblClaveProveedor.Text = "Clave Proveedor";
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.Location = new System.Drawing.Point(19, 113);
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.Size = new System.Drawing.Size(143, 21);
            this.txtClaveProveedor.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtClaveProveedor, "Introduzca la clave del proveedor");
            this.txtClaveProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveProveedor_KeyPress);
            this.txtClaveProveedor.Validated += new System.EventHandler(this.Valida_proveedor);
            // 
            // lblClaveFactura
            // 
            this.lblClaveFactura.AutoSize = true;
            this.lblClaveFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveFactura.Location = new System.Drawing.Point(16, 33);
            this.lblClaveFactura.Name = "lblClaveFactura";
            this.lblClaveFactura.Size = new System.Drawing.Size(91, 16);
            this.lblClaveFactura.TabIndex = 2;
            this.lblClaveFactura.Text = "Clave Factura";
            // 
            // txtClaveFactura
            // 
            this.txtClaveFactura.Location = new System.Drawing.Point(19, 52);
            this.txtClaveFactura.Name = "txtClaveFactura";
            this.txtClaveFactura.Size = new System.Drawing.Size(143, 21);
            this.txtClaveFactura.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtClaveFactura, "Introduzca la clave de la factura");
            this.txtClaveFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveFactura_KeyPress);
            this.txtClaveFactura.Validated += new System.EventHandler(this.Valida_factura);
            // 
            // lblClaveArticulo
            // 
            this.lblClaveArticulo.AutoSize = true;
            this.lblClaveArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveArticulo.Location = new System.Drawing.Point(16, 154);
            this.lblClaveArticulo.Name = "lblClaveArticulo";
            this.lblClaveArticulo.Size = new System.Drawing.Size(90, 16);
            this.lblClaveArticulo.TabIndex = 4;
            this.lblClaveArticulo.Text = "Clave Artículo";
            // 
            // txtClaveArticulo
            // 
            this.txtClaveArticulo.Location = new System.Drawing.Point(19, 171);
            this.txtClaveArticulo.Name = "txtClaveArticulo";
            this.txtClaveArticulo.Size = new System.Drawing.Size(144, 21);
            this.txtClaveArticulo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtClaveArticulo, "Introduzca la clave del artículo");
            this.txtClaveArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveArticulo_KeyPress);
            this.txtClaveArticulo.Validated += new System.EventHandler(this.Valida_articulo);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(16, 211);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(55, 333);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 38);
            this.btnAgregar.TabIndex = 5;
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
            this.btnLimpiar.Location = new System.Drawing.Point(99, 224);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 26);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar campos de texto y selección");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.pictureBox2);
            this.grpDatos.Controls.Add(this.pictureBox1);
            this.grpDatos.Controls.Add(this.btnLimpiar);
            this.grpDatos.Controls.Add(this.numUpCantidad);
            this.grpDatos.Controls.Add(this.lblClaveProveedor);
            this.grpDatos.Controls.Add(this.txtClaveProveedor);
            this.grpDatos.Controls.Add(this.lblClaveFactura);
            this.grpDatos.Controls.Add(this.txtClaveFactura);
            this.grpDatos.Controls.Add(this.lblClaveArticulo);
            this.grpDatos.Controls.Add(this.txtClaveArticulo);
            this.grpDatos.Controls.Add(this.lblCantidad);
            this.grpDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatos.Location = new System.Drawing.Point(12, 23);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(382, 283);
            this.grpDatos.TabIndex = 14;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del detalle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(214, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // numUpCantidad
            // 
            this.numUpCantidad.Location = new System.Drawing.Point(19, 229);
            this.numUpCantidad.Name = "numUpCantidad";
            this.numUpCantidad.ReadOnly = true;
            this.numUpCantidad.Size = new System.Drawing.Size(51, 21);
            this.numUpCantidad.TabIndex = 4;
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
            this.brnSalir.Location = new System.Drawing.Point(226, 333);
            this.brnSalir.Name = "brnSalir";
            this.brnSalir.Size = new System.Drawing.Size(120, 38);
            this.brnSalir.TabIndex = 15;
            this.brnSalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.brnSalir, "Cerrar ventana");
            this.brnSalir.UseVisualStyleBackColor = true;
            this.brnSalir.Click += new System.EventHandler(this.brnRegresar_Click);
            // 
            // frmAgregarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 395);
            this.ControlBox = false;
            this.Controls.Add(this.brnSalir);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmAgregarDetalle";
            this.Text = "Agregar Detalle";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.NumericUpDown numUpCantidad;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button brnSalir;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}