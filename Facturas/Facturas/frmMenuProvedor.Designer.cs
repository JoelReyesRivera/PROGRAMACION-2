namespace Facturas
{
    partial class frmMenuProvedor
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
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnVerProvedores = new System.Windows.Forms.Button();
            this.btnConsultarProvedor = new System.Windows.Forms.Button();
            this.btnAgregarProvedor = new System.Windows.Forms.Button();
            this.lblMenuProvedor = new System.Windows.Forms.Label();
            this.btnPagoProveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(680, 241);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(108, 35);
            this.btnMenuPrincipal.TabIndex = 9;
            this.btnMenuPrincipal.Tag = "";
            this.btnMenuPrincipal.Text = "Regresar";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnVerProvedores
            // 
            this.btnVerProvedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProvedores.Location = new System.Drawing.Point(370, 167);
            this.btnVerProvedores.Name = "btnVerProvedores";
            this.btnVerProvedores.Size = new System.Drawing.Size(161, 31);
            this.btnVerProvedores.TabIndex = 8;
            this.btnVerProvedores.Text = "Ver Provedores";
            this.btnVerProvedores.UseVisualStyleBackColor = true;
            this.btnVerProvedores.Click += new System.EventHandler(this.btnVerProvedores_Click);
            // 
            // btnConsultarProvedor
            // 
            this.btnConsultarProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProvedor.Location = new System.Drawing.Point(205, 167);
            this.btnConsultarProvedor.Name = "btnConsultarProvedor";
            this.btnConsultarProvedor.Size = new System.Drawing.Size(138, 31);
            this.btnConsultarProvedor.TabIndex = 7;
            this.btnConsultarProvedor.Text = "Consultar Provedor";
            this.btnConsultarProvedor.UseVisualStyleBackColor = true;
            this.btnConsultarProvedor.Click += new System.EventHandler(this.btnConsultarProvedor_Click);
            // 
            // btnAgregarProvedor
            // 
            this.btnAgregarProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProvedor.Location = new System.Drawing.Point(16, 167);
            this.btnAgregarProvedor.Name = "btnAgregarProvedor";
            this.btnAgregarProvedor.Size = new System.Drawing.Size(154, 31);
            this.btnAgregarProvedor.TabIndex = 6;
            this.btnAgregarProvedor.Text = "Agregar Provedor";
            this.btnAgregarProvedor.UseVisualStyleBackColor = true;
            this.btnAgregarProvedor.Click += new System.EventHandler(this.btnAgregarProvedor_Click);
            // 
            // lblMenuProvedor
            // 
            this.lblMenuProvedor.AutoSize = true;
            this.lblMenuProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuProvedor.Location = new System.Drawing.Point(195, 40);
            this.lblMenuProvedor.Name = "lblMenuProvedor";
            this.lblMenuProvedor.Size = new System.Drawing.Size(405, 55);
            this.lblMenuProvedor.TabIndex = 5;
            this.lblMenuProvedor.Text = "Menú Provedores";
            // 
            // btnPagoProveedores
            // 
            this.btnPagoProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoProveedores.Location = new System.Drawing.Point(559, 167);
            this.btnPagoProveedores.Name = "btnPagoProveedores";
            this.btnPagoProveedores.Size = new System.Drawing.Size(206, 31);
            this.btnPagoProveedores.TabIndex = 10;
            this.btnPagoProveedores.Text = "Realizar Pago Proveedor";
            this.btnPagoProveedores.UseVisualStyleBackColor = true;
            this.btnPagoProveedores.Click += new System.EventHandler(this.btnPagoProveedores_Click);
            // 
            // frmMenuProvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 288);
            this.Controls.Add(this.btnPagoProveedores);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnVerProvedores);
            this.Controls.Add(this.btnConsultarProvedor);
            this.Controls.Add(this.btnAgregarProvedor);
            this.Controls.Add(this.lblMenuProvedor);
            this.Name = "frmMenuProvedor";
            this.Text = "Menú Provedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnVerProvedores;
        private System.Windows.Forms.Button btnConsultarProvedor;
        private System.Windows.Forms.Button btnAgregarProvedor;
        private System.Windows.Forms.Label lblMenuProvedor;
        private System.Windows.Forms.Button btnPagoProveedores;
    }
}