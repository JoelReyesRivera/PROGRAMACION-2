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
            this.components = new System.ComponentModel.Container();
            this.lblMenuInventario = new System.Windows.Forms.Label();
            this.btnAgregaArticulo = new System.Windows.Forms.Button();
            this.lblConsultarArticulo = new System.Windows.Forms.Button();
            this.btnVerArticulos = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.toolTipMostrar = new System.Windows.Forms.ToolTip(this.components);
            this.btnModificaArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuInventario
            // 
            this.lblMenuInventario.AutoSize = true;
            this.lblMenuInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuInventario.Location = new System.Drawing.Point(141, 67);
            this.lblMenuInventario.Name = "lblMenuInventario";
            this.lblMenuInventario.Size = new System.Drawing.Size(369, 55);
            this.lblMenuInventario.TabIndex = 0;
            this.lblMenuInventario.Text = "Menú Inventario";
            // 
            // btnAgregaArticulo
            // 
            this.btnAgregaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaArticulo.Location = new System.Drawing.Point(26, 196);
            this.btnAgregaArticulo.Name = "btnAgregaArticulo";
            this.btnAgregaArticulo.Size = new System.Drawing.Size(139, 45);
            this.btnAgregaArticulo.TabIndex = 1;
            this.btnAgregaArticulo.Text = "Agrega Articulo";
            this.toolTipMostrar.SetToolTip(this.btnAgregaArticulo, "Agregar un Articulo al sistema");
            this.btnAgregaArticulo.UseVisualStyleBackColor = true;
            this.btnAgregaArticulo.Click += new System.EventHandler(this.btnAgregaArticulo_Click);
            // 
            // lblConsultarArticulo
            // 
            this.lblConsultarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarArticulo.Location = new System.Drawing.Point(202, 196);
            this.lblConsultarArticulo.Name = "lblConsultarArticulo";
            this.lblConsultarArticulo.Size = new System.Drawing.Size(139, 45);
            this.lblConsultarArticulo.TabIndex = 2;
            this.lblConsultarArticulo.Text = "Consultar Articulo";
            this.toolTipMostrar.SetToolTip(this.lblConsultarArticulo, "Consultar un Articulo");
            this.lblConsultarArticulo.UseVisualStyleBackColor = true;
            this.lblConsultarArticulo.Click += new System.EventHandler(this.lblConsultarArticulo_Click);
            // 
            // btnVerArticulos
            // 
            this.btnVerArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerArticulos.Location = new System.Drawing.Point(371, 196);
            this.btnVerArticulos.Name = "btnVerArticulos";
            this.btnVerArticulos.Size = new System.Drawing.Size(139, 45);
            this.btnVerArticulos.TabIndex = 3;
            this.btnVerArticulos.Text = "Ver Articulos";
            this.toolTipMostrar.SetToolTip(this.btnVerArticulos, "Ver todos los Articulos en el sistema");
            this.btnVerArticulos.UseVisualStyleBackColor = true;
            this.btnVerArticulos.Click += new System.EventHandler(this.btnVerArticulos_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(266, 277);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(139, 45);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.toolTipMostrar.SetToolTip(this.btnRegresar, "Salir de la ventana");
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnModificaArticulo
            // 
            this.btnModificaArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaArticulo.Location = new System.Drawing.Point(543, 196);
            this.btnModificaArticulo.Name = "btnModificaArticulo";
            this.btnModificaArticulo.Size = new System.Drawing.Size(139, 45);
            this.btnModificaArticulo.TabIndex = 4;
            this.btnModificaArticulo.Text = "Modifica Articulo";
            this.btnModificaArticulo.UseVisualStyleBackColor = true;
            this.btnModificaArticulo.Click += new System.EventHandler(this.btnModificaArticulo_Click);
            // 
            // frmMenuInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 394);
            this.Controls.Add(this.btnModificaArticulo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnVerArticulos);
            this.Controls.Add(this.lblConsultarArticulo);
            this.Controls.Add(this.btnAgregaArticulo);
            this.Controls.Add(this.lblMenuInventario);
            this.Name = "frmMenuInventario";
            this.Text = "Menú Inventario";
            this.Load += new System.EventHandler(this.frmMenuInventario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuInventario;
        private System.Windows.Forms.Button btnAgregaArticulo;
        private System.Windows.Forms.Button lblConsultarArticulo;
        private System.Windows.Forms.Button btnVerArticulos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ToolTip toolTipMostrar;
        private System.Windows.Forms.Button btnModificaArticulo;
    }
}