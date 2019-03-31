namespace Facturas
{
    partial class frmBuscarDetalle
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveFactura = new System.Windows.Forms.TextBox();
            this.dvgBuscaDetalles = new System.Windows.Forms.DataGridView();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.ClaveArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblImporteTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBuscaDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLAVE FACTURA";
            // 
            // txtClaveFactura
            // 
            this.txtClaveFactura.Location = new System.Drawing.Point(239, 44);
            this.txtClaveFactura.Name = "txtClaveFactura";
            this.txtClaveFactura.Size = new System.Drawing.Size(143, 20);
            this.txtClaveFactura.TabIndex = 1;
            this.txtClaveFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveFactura_KeyPress);
            this.txtClaveFactura.Validated += new System.EventHandler(this.Valida_factura);
            // 
            // dvgBuscaDetalles
            // 
            this.dvgBuscaDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBuscaDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveArticulo,
            this.Articulo,
            this.PrecioUnitario,
            this.Cantidad,
            this.ImporteDetalle});
            this.dvgBuscaDetalles.Location = new System.Drawing.Point(29, 128);
            this.dvgBuscaDetalles.Name = "dvgBuscaDetalles";
            this.dvgBuscaDetalles.Size = new System.Drawing.Size(759, 150);
            this.dvgBuscaDetalles.TabIndex = 2;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.Location = new System.Drawing.Point(26, 100);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(156, 16);
            this.lblInformacion.TabIndex = 3;
            this.lblInformacion.Text = "Detalles de la factura";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(433, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(546, 42);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 150;
            // 
            // ImporteDetalle
            // 
            this.ImporteDetalle.HeaderText = "Importe Detalle";
            this.ImporteDetalle.Name = "ImporteDetalle";
            this.ImporteDetalle.Width = 150;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(262, 309);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(0, 16);
            this.lblImporte.TabIndex = 6;
            // 
            // lblImporteTexto
            // 
            this.lblImporteTexto.AutoSize = true;
            this.lblImporteTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteTexto.Location = new System.Drawing.Point(42, 309);
            this.lblImporteTexto.Name = "lblImporteTexto";
            this.lblImporteTexto.Size = new System.Drawing.Size(214, 16);
            this.lblImporteTexto.TabIndex = 7;
            this.lblImporteTexto.Text = "Importe total para la factura: $";
            // 
            // frmBuscarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 346);
            this.Controls.Add(this.lblImporteTexto);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.dvgBuscaDetalles);
            this.Controls.Add(this.txtClaveFactura);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscarDetalle";
            this.Text = "Buscar Detalle de Factura";
            this.Load += new System.EventHandler(this.frmBuscarDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgBuscaDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClaveFactura;
        private System.Windows.Forms.DataGridView dvgBuscaDetalles;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteDetalle;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblImporteTexto;
    }
}