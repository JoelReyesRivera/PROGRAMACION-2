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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.toolTipMostrar = new System.Windows.Forms.ToolTip(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.menuArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArticuloToolStripMenuItem,
            this.menúProveedorToolStripMenuItem,
            this.menúFacturaToolStripMenuItem,
            this.menúDetallesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(604, 24);
            this.msMenu.TabIndex = 4;
            this.msMenu.Text = "menuStrip1";
            // 
            // menuArticuloToolStripMenuItem
            // 
            this.menuArticuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.menuArticuloToolStripMenuItem.Name = "menuArticuloToolStripMenuItem";
            this.menuArticuloToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.menuArticuloToolStripMenuItem.Text = "Menú Artículo";
            // 
            // agregaToolStripMenuItem
            // 
            this.agregaToolStripMenuItem.Name = "agregaToolStripMenuItem";
            this.agregaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.agregaToolStripMenuItem.Text = "Agrega";
            this.agregaToolStripMenuItem.Click += new System.EventHandler(this.agregaToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaIndividualToolStripMenuItem,
            this.consultarTodosToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // consultaIndividualToolStripMenuItem
            // 
            this.consultaIndividualToolStripMenuItem.Name = "consultaIndividualToolStripMenuItem";
            this.consultaIndividualToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.consultaIndividualToolStripMenuItem.Text = "Individual";
            this.consultaIndividualToolStripMenuItem.Click += new System.EventHandler(this.consultaIndividualToolStripMenuItem_Click);
            // 
            // consultarTodosToolStripMenuItem
            // 
            this.consultarTodosToolStripMenuItem.Name = "consultarTodosToolStripMenuItem";
            this.consultarTodosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.consultarTodosToolStripMenuItem.Text = "Todos";
            this.consultarTodosToolStripMenuItem.Click += new System.EventHandler(this.consultarTodosToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.modificaToolStripMenuItem.Text = "Modifica existencia";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // menúProveedorToolStripMenuItem
            // 
            this.menúProveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregaToolStripMenuItem1,
            this.consultaToolStripMenuItem1,
            this.pagoToolStripMenuItem});
            this.menúProveedorToolStripMenuItem.Name = "menúProveedorToolStripMenuItem";
            this.menúProveedorToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.menúProveedorToolStripMenuItem.Text = "Menú Proveedor";
            // 
            // agregaToolStripMenuItem1
            // 
            this.agregaToolStripMenuItem1.Name = "agregaToolStripMenuItem1";
            this.agregaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.agregaToolStripMenuItem1.Text = "Agrega";
            this.agregaToolStripMenuItem1.Click += new System.EventHandler(this.agregaToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem1,
            this.todosToolStripMenuItem1});
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            // 
            // individualToolStripMenuItem1
            // 
            this.individualToolStripMenuItem1.Name = "individualToolStripMenuItem1";
            this.individualToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.individualToolStripMenuItem1.Text = "Individual";
            this.individualToolStripMenuItem1.Click += new System.EventHandler(this.individualToolStripMenuItem1_Click);
            // 
            // todosToolStripMenuItem1
            // 
            this.todosToolStripMenuItem1.Name = "todosToolStripMenuItem1";
            this.todosToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.todosToolStripMenuItem1.Text = "Todos";
            this.todosToolStripMenuItem1.Click += new System.EventHandler(this.todosToolStripMenuItem1_Click);
            // 
            // pagoToolStripMenuItem
            // 
            this.pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            this.pagoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pagoToolStripMenuItem.Text = "Pago";
            this.pagoToolStripMenuItem.Click += new System.EventHandler(this.pagoToolStripMenuItem_Click);
            // 
            // menúFacturaToolStripMenuItem
            // 
            this.menúFacturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menúFacturaToolStripMenuItem.Name = "menúFacturaToolStripMenuItem";
            this.menúFacturaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.menúFacturaToolStripMenuItem.Text = "Menú Factura";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarPorProveedorToolStripMenuItem,
            this.consultarIndividualToolStripMenuItem,
            this.consultarTodasToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // consultarPorProveedorToolStripMenuItem
            // 
            this.consultarPorProveedorToolStripMenuItem.Name = "consultarPorProveedorToolStripMenuItem";
            this.consultarPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.consultarPorProveedorToolStripMenuItem.Text = "Por proveedor";
            this.consultarPorProveedorToolStripMenuItem.Click += new System.EventHandler(this.consultarPorProveedorToolStripMenuItem_Click);
            // 
            // consultarIndividualToolStripMenuItem
            // 
            this.consultarIndividualToolStripMenuItem.Name = "consultarIndividualToolStripMenuItem";
            this.consultarIndividualToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.consultarIndividualToolStripMenuItem.Text = "Individual";
            this.consultarIndividualToolStripMenuItem.Click += new System.EventHandler(this.consultarIndividualToolStripMenuItem_Click);
            // 
            // consultarTodasToolStripMenuItem
            // 
            this.consultarTodasToolStripMenuItem.Name = "consultarTodasToolStripMenuItem";
            this.consultarTodasToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.consultarTodasToolStripMenuItem.Text = "Todos";
            this.consultarTodasToolStripMenuItem.Click += new System.EventHandler(this.consultarTodasToolStripMenuItem_Click);
            // 
            // menúDetallesToolStripMenuItem
            // 
            this.menúDetallesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.consultarToolStripMenuItem1});
            this.menúDetallesToolStripMenuItem.Name = "menúDetallesToolStripMenuItem";
            this.menúDetallesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.menúDetallesToolStripMenuItem.Text = "Menú Detalles";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem,
            this.todosToolStripMenuItem});
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // individualToolStripMenuItem
            // 
            this.individualToolStripMenuItem.Name = "individualToolStripMenuItem";
            this.individualToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.individualToolStripMenuItem.Text = "Individual";
            this.individualToolStripMenuItem.Click += new System.EventHandler(this.individualToolStripMenuItem_Click);
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abOutToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // abOutToolStripMenuItem
            // 
            this.abOutToolStripMenuItem.Name = "abOutToolStripMenuItem";
            this.abOutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.abOutToolStripMenuItem.Text = "Acerca de";
            this.abOutToolStripMenuItem.Click += new System.EventHandler(this.abOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(604, 295);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmMenuPrincipal";
            this.Opacity = 0.95D;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipMostrar;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem menuArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúDetallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abOutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}