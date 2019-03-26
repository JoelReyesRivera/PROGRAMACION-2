namespace Facturas
{
    partial class frmMenuInventario
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
            this.lblMenuInventario = new System.Windows.Forms.Label();
            this.btnAgregaArticulo = new System.Windows.Forms.Button();
            this.btnVerArticulos = new System.Windows.Forms.Button();
            this.btnConsultaArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuInventario
            // 
            this.lblMenuInventario.AutoSize = true;
            this.lblMenuInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuInventario.Location = new System.Drawing.Point(176, 125);
            this.lblMenuInventario.Name = "lblMenuInventario";
            this.lblMenuInventario.Size = new System.Drawing.Size(369, 55);
            this.lblMenuInventario.TabIndex = 0;
            this.lblMenuInventario.Text = "Menú Inventario";
            // 
            // btnAgregaArticulo
            // 
            this.btnAgregaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaArticulo.Location = new System.Drawing.Point(72, 279);
            this.btnAgregaArticulo.Name = "btnAgregaArticulo";
            this.btnAgregaArticulo.Size = new System.Drawing.Size(142, 42);
            this.btnAgregaArticulo.TabIndex = 1;
            this.btnAgregaArticulo.Text = "Agrega Articulo";
            this.btnAgregaArticulo.UseVisualStyleBackColor = true;
            // 
            // btnVerArticulos
            // 
            this.btnVerArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerArticulos.Location = new System.Drawing.Point(524, 279);
            this.btnVerArticulos.Name = "btnVerArticulos";
            this.btnVerArticulos.Size = new System.Drawing.Size(142, 42);
            this.btnVerArticulos.TabIndex = 2;
            this.btnVerArticulos.Text = "Ver Articulos";
            this.btnVerArticulos.UseVisualStyleBackColor = true;
            // 
            // btnConsultaArticulo
            // 
            this.btnConsultaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaArticulo.Location = new System.Drawing.Point(293, 279);
            this.btnConsultaArticulo.Name = "btnConsultaArticulo";
            this.btnConsultaArticulo.Size = new System.Drawing.Size(142, 42);
            this.btnConsultaArticulo.TabIndex = 3;
            this.btnConsultaArticulo.Text = "Consultar Articulo ";
            this.btnConsultaArticulo.UseVisualStyleBackColor = true;
            // 
            // frmMenuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 408);
            this.Controls.Add(this.btnConsultaArticulo);
            this.Controls.Add(this.btnVerArticulos);
            this.Controls.Add(this.btnAgregaArticulo);
            this.Controls.Add(this.lblMenuInventario);
            this.Name = "frmMenuInventario";
            this.Text = "Menú Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuInventario;
        private System.Windows.Forms.Button btnAgregaArticulo;
        private System.Windows.Forms.Button btnVerArticulos;
        private System.Windows.Forms.Button btnConsultaArticulo;
    }
}