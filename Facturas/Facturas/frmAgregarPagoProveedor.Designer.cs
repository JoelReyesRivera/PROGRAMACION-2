namespace Facturas
{
    partial class frmAgregarPagoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarPagoProveedor));
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblImporteSaldoActual = new System.Windows.Forms.Label();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.btnRealizarPago = new System.Windows.Forms.Button();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.errorProviderProveedores = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpProveedor = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProveedores)).BeginInit();
            this.grpProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(14, 56);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(129, 22);
            this.txtClave.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtClave, "Clave del proveedor");
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            this.txtClave.Validated += new System.EventHandler(this.txtClave_Validated);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(11, 31);
            this.lblClave.Name = "lblClave";
<<<<<<< HEAD
            this.lblClave.Size = new System.Drawing.Size(110, 16);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave Proveedor";
=======
            this.lblClave.Size = new System.Drawing.Size(132, 16);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave del Proveedor";
>>>>>>> master
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
<<<<<<< HEAD
            this.pictureBox1.Location = new System.Drawing.Point(327, 24);
=======
            this.pictureBox1.Location = new System.Drawing.Point(350, 42);
>>>>>>> master
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblImporteSaldoActual
            // 
            this.lblImporteSaldoActual.AutoSize = true;
<<<<<<< HEAD
            this.lblImporteSaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteSaldoActual.Location = new System.Drawing.Point(137, 217);
            this.lblImporteSaldoActual.Name = "lblImporteSaldoActual";
            this.lblImporteSaldoActual.Size = new System.Drawing.Size(22, 16);
=======
            this.lblImporteSaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteSaldoActual.Location = new System.Drawing.Point(193, 212);
            this.lblImporteSaldoActual.Name = "lblImporteSaldoActual";
            this.lblImporteSaldoActual.Size = new System.Drawing.Size(24, 16);
>>>>>>> master
            this.lblImporteSaldoActual.TabIndex = 0;
            this.lblImporteSaldoActual.Text = "$0";
            this.toolTip1.SetToolTip(this.lblImporteSaldoActual, "Saldo Actual");
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
<<<<<<< HEAD
            this.lblSaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoActual.Location = new System.Drawing.Point(14, 217);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(90, 16);
=======
            this.lblSaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoActual.Location = new System.Drawing.Point(84, 212);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(104, 16);
>>>>>>> master
            this.lblSaldoActual.TabIndex = 0;
            this.lblSaldoActual.Text = "Saldo Actual :";
            // 
            // btnRealizarPago
            // 
            this.btnRealizarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRealizarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPago.Location = new System.Drawing.Point(63, 289);
            this.btnRealizarPago.Name = "btnRealizarPago";
            this.btnRealizarPago.Size = new System.Drawing.Size(122, 35);
            this.btnRealizarPago.TabIndex = 3;
            this.btnRealizarPago.Text = "Realizar Pago";
            this.toolTip1.SetToolTip(this.btnRealizarPago, "Concretar pago");
            this.btnRealizarPago.UseVisualStyleBackColor = true;
            this.btnRealizarPago.Click += new System.EventHandler(this.btnRealizarPago_Click);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(11, 148);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(107, 16);
            this.lblImporte.TabIndex = 0;
            this.lblImporte.Text = "Importe a Pagar:";
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(14, 176);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(104, 22);
            this.txtImporte.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtImporte, "Importe que se pagará");
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            this.txtImporte.Validated += new System.EventHandler(this.txtImporte_Validated);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(229, 289);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 35);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar Ventana");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(396, 289);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 36);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalir, "Salir de la ventana");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(11, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(14, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(156, 22);
<<<<<<< HEAD
            this.txtNombre.TabIndex = 1;
=======
            this.txtNombre.TabIndex = 0;
>>>>>>> master
            this.toolTip1.SetToolTip(this.txtNombre, "Nombre del proveedor");
            // 
            // btnBuscar
            // 
<<<<<<< HEAD
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(176, 52);
=======
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(191, 52);
>>>>>>> master
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 30);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Ver Proveedor";
            this.toolTip1.SetToolTip(this.btnBuscar, "Ver Proveedor");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // errorProviderProveedores
            // 
            this.errorProviderProveedores.ContainerControl = this;
            // 
            // grpProveedor
            // 
<<<<<<< HEAD
            this.grpProveedor.BackColor = System.Drawing.Color.Transparent;
=======
>>>>>>> master
            this.grpProveedor.Controls.Add(this.btnBuscar);
            this.grpProveedor.Controls.Add(this.lblImporte);
            this.grpProveedor.Controls.Add(this.txtImporte);
            this.grpProveedor.Controls.Add(this.lblSaldoActual);
            this.grpProveedor.Controls.Add(this.lblImporteSaldoActual);
            this.grpProveedor.Controls.Add(this.lblNombre);
            this.grpProveedor.Controls.Add(this.txtNombre);
            this.grpProveedor.Controls.Add(this.lblClave);
            this.grpProveedor.Controls.Add(this.txtClave);
<<<<<<< HEAD
            this.grpProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProveedor.Location = new System.Drawing.Point(12, 12);
            this.grpProveedor.Name = "grpProveedor";
            this.grpProveedor.Size = new System.Drawing.Size(309, 248);
            this.grpProveedor.TabIndex = 0;
            this.grpProveedor.TabStop = false;
            this.grpProveedor.Text = "Pago proveedor";
=======
            this.grpProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProveedor.Location = new System.Drawing.Point(15, 15);
            this.grpProveedor.Name = "grpProveedor";
            this.grpProveedor.Size = new System.Drawing.Size(318, 248);
            this.grpProveedor.TabIndex = 0;
            this.grpProveedor.TabStop = false;
            this.grpProveedor.Text = "Pago Proveedor";
>>>>>>> master
            // 
            // frmAgregarPagoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 337);
=======
            this.ClientSize = new System.Drawing.Size(581, 351);
>>>>>>> master
            this.ControlBox = false;
            this.Controls.Add(this.grpProveedor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRealizarPago);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAgregarPagoProveedor";
            this.Text = "Pago Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProveedores)).EndInit();
            this.grpProveedor.ResumeLayout(false);
            this.grpProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblImporteSaldoActual;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.Button btnRealizarPago;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider errorProviderProveedores;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grpProveedor;
    }
}