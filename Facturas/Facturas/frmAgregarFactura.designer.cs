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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarFactura));
            this.lblClaveFactura = new System.Windows.Forms.Label();
            this.txtClaveFactura = new System.Windows.Forms.TextBox();
            this.lblClaveProveedor = new System.Windows.Forms.Label();
            this.txtClaveProveedor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.txtClaveProveedor.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(82, 218);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Location = new System.Drawing.Point(202, 218);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
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
            this.pictureBox1.Location = new System.Drawing.Point(214, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 268);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmAgregarFactura";
            this.Text = "Agregar nueva factura";
            this.Load += new System.EventHandler(this.frmAgregarFactura_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}

