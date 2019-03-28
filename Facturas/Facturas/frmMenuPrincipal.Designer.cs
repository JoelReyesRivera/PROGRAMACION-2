namespace Facturas
{
    partial class frmMenuPrincipal
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
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnMenuProvedor = new System.Windows.Forms.Button();
            this.btnMenuFactura = new System.Windows.Forms.Button();
            this.toolTipMostrar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.Location = new System.Drawing.Point(142, 110);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(341, 55);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "Menú Principal";
            // 
            // btnArticulo
            // 
            this.btnArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulo.Location = new System.Drawing.Point(26, 245);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(171, 55);
            this.btnArticulo.TabIndex = 1;
            this.btnArticulo.Text = "Menú Articulo";
            this.toolTipMostrar.SetToolTip(this.btnArticulo, "Ir al menú de Articulos");
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // btnMenuProvedor
            // 
            this.btnMenuProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuProvedor.Location = new System.Drawing.Point(438, 245);
            this.btnMenuProvedor.Name = "btnMenuProvedor";
            this.btnMenuProvedor.Size = new System.Drawing.Size(171, 55);
            this.btnMenuProvedor.TabIndex = 2;
            this.btnMenuProvedor.Text = "Menú Provedor";
            this.toolTipMostrar.SetToolTip(this.btnMenuProvedor, "Ir al menú de Provedores");
            this.btnMenuProvedor.UseVisualStyleBackColor = true;
            this.btnMenuProvedor.Click += new System.EventHandler(this.btnMenuProvedor_Click);
            // 
            // btnMenuFactura
            // 
            this.btnMenuFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuFactura.Location = new System.Drawing.Point(233, 245);
            this.btnMenuFactura.Name = "btnMenuFactura";
            this.btnMenuFactura.Size = new System.Drawing.Size(171, 55);
            this.btnMenuFactura.TabIndex = 3;
            this.btnMenuFactura.Text = "Menú Factura";
            this.toolTipMostrar.SetToolTip(this.btnMenuFactura, "Ir al menú de Facturas");
            this.btnMenuFactura.UseVisualStyleBackColor = true;
            this.btnMenuFactura.Click += new System.EventHandler(this.btnMenuFactura_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 417);
            this.Controls.Add(this.btnMenuFactura);
            this.Controls.Add(this.btnMenuProvedor);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Button btnMenuProvedor;
        private System.Windows.Forms.Button btnMenuFactura;
        private System.Windows.Forms.ToolTip toolTipMostrar;
    }
}