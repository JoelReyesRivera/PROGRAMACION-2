namespace Facturas
{
    partial class frmMostrarDetalles
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClaveFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInformacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveFactura,
            this.ClaveArticulo,
            this.Articulo,
            this.Cantidad,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(33, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClaveFactura
            // 
            this.ClaveFactura.HeaderText = "Clave Factura";
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
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.Name = "Precio";
            this.Precio.Width = 150;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(282, 43);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(281, 20);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "Detalles registrados en el sistema";
            // 
            // frmMostrarDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 298);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMostrarDetalles";
            this.Text = "Mostrando Detalles de Facturas";
            this.Load += new System.EventHandler(this.frmMostrarDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lblInformacion;
    }
}