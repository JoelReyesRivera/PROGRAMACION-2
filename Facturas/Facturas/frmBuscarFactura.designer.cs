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
            this.grpInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClaveFactura
            // 
            this.lblClaveFactura.AutoSize = true;
            this.lblClaveFactura.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveFactura.Location = new System.Drawing.Point(53, 45);
            this.lblClaveFactura.Name = "lblClaveFactura";
            this.lblClaveFactura.Size = new System.Drawing.Size(95, 14);
            this.lblClaveFactura.TabIndex = 0;
            this.lblClaveFactura.Text = "CLAVE FACTURA";
            // 
            // txtClaveFactura
            // 
            this.txtClaveFactura.Location = new System.Drawing.Point(153, 42);
            this.txtClaveFactura.Name = "txtClaveFactura";
            this.txtClaveFactura.Size = new System.Drawing.Size(124, 20);
            this.txtClaveFactura.TabIndex = 1;
            // 
            // lblClaveProveedor
            // 
            this.lblClaveProveedor.AutoSize = true;
            this.lblClaveProveedor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProveedor.Location = new System.Drawing.Point(29, 35);
            this.lblClaveProveedor.Name = "lblClaveProveedor";
            this.lblClaveProveedor.Size = new System.Drawing.Size(92, 14);
            this.lblClaveProveedor.TabIndex = 3;
            this.lblClaveProveedor.Text = "Clave proveedor";
            // 
            // txtClaveProveedor
            // 
            this.txtClaveProveedor.Location = new System.Drawing.Point(130, 35);
            this.txtClaveProveedor.Name = "txtClaveProveedor";
            this.txtClaveProveedor.ReadOnly = true;
            this.txtClaveProveedor.Size = new System.Drawing.Size(114, 20);
            this.txtClaveProveedor.TabIndex = 4;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(29, 79);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(61, 14);
            this.lblProveedor.TabIndex = 5;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(32, 119);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(48, 14);
            this.lblImporte.TabIndex = 6;
            this.lblImporte.Text = "Importe";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(32, 158);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 14);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(130, 76);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(114, 20);
            this.txtProveedor.TabIndex = 8;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(130, 116);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(114, 20);
            this.txtImporte.TabIndex = 9;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(130, 158);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(114, 20);
            this.txtFecha.TabIndex = 10;
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.txtClaveProveedor);
            this.grpInformacion.Controls.Add(this.txtFecha);
            this.grpInformacion.Controls.Add(this.lblClaveProveedor);
            this.grpInformacion.Controls.Add(this.txtImporte);
            this.grpInformacion.Controls.Add(this.lblProveedor);
            this.grpInformacion.Controls.Add(this.txtProveedor);
            this.grpInformacion.Controls.Add(this.lblImporte);
            this.grpInformacion.Controls.Add(this.lblFecha);
            this.grpInformacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpInformacion.Location = new System.Drawing.Point(24, 96);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(279, 194);
            this.grpInformacion.TabIndex = 11;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Información de la factura";
            // 
            // frmBuscarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 326);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.txtClaveFactura);
            this.Controls.Add(this.lblClaveFactura);
            this.Name = "frmBuscarFactura";
            this.Text = "Buscar factura";
            this.Load += new System.EventHandler(this.frmBuscarFactura_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
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
    }
}