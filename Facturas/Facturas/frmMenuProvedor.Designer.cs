namespace Facturas
{
    partial class frmMenuProvedor
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
            this.lblMenuProvedor = new System.Windows.Forms.Label();
            this.btnAgregarProvedor = new System.Windows.Forms.Button();
            this.btnConsultarProvedor = new System.Windows.Forms.Button();
            this.btnVerProvedores = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuProvedor
            // 
            this.lblMenuProvedor.AutoSize = true;
            this.lblMenuProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuProvedor.Location = new System.Drawing.Point(186, 102);
            this.lblMenuProvedor.Name = "lblMenuProvedor";
            this.lblMenuProvedor.Size = new System.Drawing.Size(405, 55);
            this.lblMenuProvedor.TabIndex = 0;
            this.lblMenuProvedor.Text = "Menú Provedores";
            // 
            // btnAgregarProvedor
            // 
            this.btnAgregarProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProvedor.Location = new System.Drawing.Point(42, 338);
            this.btnAgregarProvedor.Name = "btnAgregarProvedor";
            this.btnAgregarProvedor.Size = new System.Drawing.Size(154, 31);
            this.btnAgregarProvedor.TabIndex = 1;
            this.btnAgregarProvedor.Text = "Agregar Provedor";
            this.btnAgregarProvedor.UseVisualStyleBackColor = true;
            this.btnAgregarProvedor.Click += new System.EventHandler(this.btnAgregarProvedor_Click);
            // 
            // btnConsultarProvedor
            // 
            this.btnConsultarProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProvedor.Location = new System.Drawing.Point(220, 338);
            this.btnConsultarProvedor.Name = "btnConsultarProvedor";
            this.btnConsultarProvedor.Size = new System.Drawing.Size(138, 31);
            this.btnConsultarProvedor.TabIndex = 2;
            this.btnConsultarProvedor.Text = "Consultar Provedor";
            this.btnConsultarProvedor.UseVisualStyleBackColor = true;
            // 
            // btnVerProvedores
            // 
            this.btnVerProvedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProvedores.Location = new System.Drawing.Point(390, 338);
            this.btnVerProvedores.Name = "btnVerProvedores";
            this.btnVerProvedores.Size = new System.Drawing.Size(161, 31);
            this.btnVerProvedores.TabIndex = 3;
            this.btnVerProvedores.Text = "Ver Provedores";
            this.btnVerProvedores.UseVisualStyleBackColor = true;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(576, 338);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(148, 31);
            this.btnMenuPrincipal.TabIndex = 4;
            this.btnMenuPrincipal.Tag = "";
            this.btnMenuPrincipal.Text = "Menú Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // frmMenuProvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnVerProvedores);
            this.Controls.Add(this.btnConsultarProvedor);
            this.Controls.Add(this.btnAgregarProvedor);
            this.Controls.Add(this.lblMenuProvedor);
            this.Name = "frmMenuProvedor";
            this.Text = "Menú Provedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuProvedor;
        private System.Windows.Forms.Button btnAgregarProvedor;
        private System.Windows.Forms.Button btnConsultarProvedor;
        private System.Windows.Forms.Button btnVerProvedores;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}

