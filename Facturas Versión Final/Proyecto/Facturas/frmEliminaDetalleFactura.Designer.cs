namespace Facturas
{
    partial class frmEliminaDetalleFactura
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
            this.lvDetalleFactura = new System.Windows.Forms.ListView();
            this.Factura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClaveArticulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Articulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblProv = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtClaveP = new System.Windows.Forms.TextBox();
            this.lblClaveP = new System.Windows.Forms.Label();
            this.lblClaveF = new System.Windows.Forms.Label();
            this.cmbFactura = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDetalleFactura
            // 
            this.lvDetalleFactura.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Factura,
            this.ClaveArticulo,
            this.Articulo,
            this.Cantidad,
            this.Precio});
            this.lvDetalleFactura.Location = new System.Drawing.Point(332, 116);
            this.lvDetalleFactura.Name = "lvDetalleFactura";
            this.lvDetalleFactura.Size = new System.Drawing.Size(483, 190);
            this.lvDetalleFactura.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lvDetalleFactura, "Seleccione un detalle de factura");
            this.lvDetalleFactura.UseCompatibleStateImageBehavior = false;
            this.lvDetalleFactura.View = System.Windows.Forms.View.Details;
            // 
            // Factura
            // 
            this.Factura.Text = "Clave Factura";
            this.Factura.Width = 88;
            // 
            // ClaveArticulo
            // 
            this.ClaveArticulo.Text = "Clave Artículo";
            this.ClaveArticulo.Width = 91;
            // 
            // Articulo
            // 
            this.Articulo.Text = "Artículo";
            this.Articulo.Width = 95;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 97;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio Unitario";
            this.Precio.Width = 104;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(230, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(361, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ELIMINA DETALLE DE FACTURA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblClaveF);
            this.groupBox1.Controls.Add(this.cmbFactura);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la factura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblProv);
            this.groupBox2.Controls.Add(this.txtProveedor);
            this.groupBox2.Controls.Add(this.txtClaveP);
            this.groupBox2.Controls.Add(this.lblClaveP);
            this.groupBox2.Location = new System.Drawing.Point(17, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 144);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos proveedor";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProv.Location = new System.Drawing.Point(16, 29);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(72, 15);
            this.lblProv.TabIndex = 0;
            this.lblProv.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(19, 57);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(165, 21);
            this.txtProveedor.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtProveedor, "Nombre del proveedor");
            // 
            // txtClaveP
            // 
            this.txtClaveP.Location = new System.Drawing.Point(59, 96);
            this.txtClaveP.Name = "txtClaveP";
            this.txtClaveP.ReadOnly = true;
            this.txtClaveP.Size = new System.Drawing.Size(59, 21);
            this.txtClaveP.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtClaveP, "Clave del proveedor");
            // 
            // lblClaveP
            // 
            this.lblClaveP.AutoSize = true;
            this.lblClaveP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveP.Location = new System.Drawing.Point(16, 99);
            this.lblClaveP.Name = "lblClaveP";
            this.lblClaveP.Size = new System.Drawing.Size(42, 15);
            this.lblClaveP.TabIndex = 0;
            this.lblClaveP.Text = "Clave";
            // 
            // lblClaveF
            // 
            this.lblClaveF.AutoSize = true;
            this.lblClaveF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveF.Location = new System.Drawing.Point(14, 35);
            this.lblClaveF.Name = "lblClaveF";
            this.lblClaveF.Size = new System.Drawing.Size(94, 15);
            this.lblClaveF.TabIndex = 0;
            this.lblClaveF.Text = "Clave Factura";
            // 
            // cmbFactura
            // 
            this.cmbFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFactura.FormattingEnabled = true;
            this.cmbFactura.Location = new System.Drawing.Point(17, 61);
            this.cmbFactura.Name = "cmbFactura";
            this.cmbFactura.Size = new System.Drawing.Size(134, 23);
            this.cmbFactura.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbFactura, "Clave de la factura");
            this.cmbFactura.SelectedIndexChanged += new System.EventHandler(this.cmbFactura_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(385, 329);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 34);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar el detalle factura seleccionado");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(550, 329);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 34);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar Ventana");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(699, 329);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 34);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnSalir, "Salir de la ventana");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(492, 89);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(162, 15);
            this.lblDetalle.TabIndex = 0;
            this.lblDetalle.Text = "DETALLES DE LA FACTURA";
            // 
            // frmEliminaDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 384);
            this.ControlBox = false;
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lvDetalleFactura);
            this.Name = "frmEliminaDetalleFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elimina Detalle Factura";
            this.Load += new System.EventHandler(this.frmEliminaDetalleFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDetalleFactura;
        private System.Windows.Forms.ColumnHeader Factura;
        private System.Windows.Forms.ColumnHeader Articulo;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblClaveF;
        private System.Windows.Forms.ComboBox cmbFactura;
        private System.Windows.Forms.TextBox txtClaveP;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label lblClaveP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader ClaveArticulo;
    }
}