namespace Facturas
{
    partial class frmMostrarFacturas
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
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.ClaveFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFacturas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveFactura,
            this.ClaveProveedor,
            this.Proveedor,
            this.Importe,
            this.Fecha});
            this.dgvFacturas.Location = new System.Drawing.Point(31, 74);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(790, 173);
            this.dgvFacturas.TabIndex = 0;
            // 
            // ClaveFactura
            // 
            this.ClaveFactura.HeaderText = "Clave Factura";
            this.ClaveFactura.Name = "ClaveFactura";
            this.ClaveFactura.Width = 150;
            // 
            // ClaveProveedor
            // 
            this.ClaveProveedor.HeaderText = "Clave Proveedor";
            this.ClaveProveedor.Name = "ClaveProveedor";
            this.ClaveProveedor.Width = 150;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Width = 150;
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
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturas.Location = new System.Drawing.Point(295, 33);
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(286, 20);
            this.lblFacturas.TabIndex = 1;
            this.lblFacturas.Text = "Facturas registradas en el sistema";
            // 
            // frmMostrarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 312);
            this.Controls.Add(this.lblFacturas);
            this.Controls.Add(this.dgvFacturas);
            this.Name = "frmMostrarFacturas";
            this.Text = "Mostrando Facturas";
            this.Load += new System.EventHandler(this.frmMostrarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label lblFacturas;
    }
}