namespace Facturas
{
    partial class frmMenuFacturaDetalle
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
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFacturas
            // 
            this.btnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.Location = new System.Drawing.Point(47, 121);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(111, 33);
            this.btnFacturas.TabIndex = 0;
            this.btnFacturas.Text = "Menú Facturas";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.Location = new System.Drawing.Point(190, 121);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(111, 32);
            this.btnDetalles.TabIndex = 1;
            this.btnDetalles.Text = "Menú Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menú Factura - Detalle";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(334, 122);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(111, 32);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu Principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmMenuFacturaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 204);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnFacturas);
            this.Name = "frmMenuFacturaDetalle";
            this.Text = "Menú factura detalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
    }
}