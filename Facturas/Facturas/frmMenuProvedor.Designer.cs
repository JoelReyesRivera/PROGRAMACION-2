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
            this.SuspendLayout();
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(604, 188);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(148, 31);
            this.btnMenuPrincipal.TabIndex = 9;
            this.btnMenuPrincipal.Tag = "";
            this.btnMenuPrincipal.Text = "Menú Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnVerProvedores
            // 
            this.btnVerProvedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProvedores.Location = new System.Drawing.Point(418, 188);
            this.btnVerProvedores.Name = "btnVerProvedores";
            this.btnVerProvedores.Size = new System.Drawing.Size(161, 31);
            this.btnVerProvedores.TabIndex = 8;
            this.btnVerProvedores.Text = "Ver Provedores";
            this.btnVerProvedores.UseVisualStyleBackColor = true;
            // 
            // btnConsultarProvedor
            // 
            this.btnConsultarProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProvedor.Location = new System.Drawing.Point(248, 188);
            this.btnConsultarProvedor.Name = "btnConsultarProvedor";
            this.btnConsultarProvedor.Size = new System.Drawing.Size(138, 31);
            this.btnConsultarProvedor.TabIndex = 7;
            this.btnConsultarProvedor.Text = "Consultar Provedor";
            this.btnConsultarProvedor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProvedor
            // 
            this.btnAgregarProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProvedor.Location = new System.Drawing.Point(70, 188);
            this.btnAgregarProvedor.Name = "btnAgregarProvedor";
            this.btnAgregarProvedor.Size = new System.Drawing.Size(154, 31);
            this.btnAgregarProvedor.TabIndex = 6;
            this.btnAgregarProvedor.Text = "Agregar Provedor";
            this.btnAgregarProvedor.UseVisualStyleBackColor = true;
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
            // frmMenuProvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 288);
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
    }
}