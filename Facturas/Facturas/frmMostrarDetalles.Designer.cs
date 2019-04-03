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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarDetalles));
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ClaveFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveFactura,
            this.ClaveArticulo,
            this.Articulo,
            this.Precio,
            this.Cantidad,
            this.Importe});
            this.dgvDetalles.Location = new System.Drawing.Point(23, 79);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(943, 150);
            this.dgvDetalles.TabIndex = 0;
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
            this.Articulo.HeaderText = "Descripcion";
            this.Articulo.Name = "Articulo";
            this.Articulo.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.Name = "Precio";
            this.Precio.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 150;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "ImporteDetalle";
            this.Importe.Name = "Importe";
            this.Importe.Width = 150;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(273, 34);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(426, 24);
            this.lblInformacion.TabIndex = 0;
            this.lblInformacion.Text = "DETALLES REGISTRADOS EN EL SISTEMA";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(869, 244);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 38);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalir, "Cerrar ventana");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(835, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMostrarDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 299);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.dgvDetalles);
            this.Name = "frmMostrarDetalles";
            this.Text = "Mostrando Detalles de Facturas";
            this.Load += new System.EventHandler(this.frmMostrarDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}