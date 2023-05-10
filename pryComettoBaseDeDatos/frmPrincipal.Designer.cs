namespace pryComettoBaseDeDatos
{
    partial class frmPrincipal
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDesde = new System.Windows.Forms.Label();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.mrcRegistros = new System.Windows.Forms.GroupBox();
            this.mrcFiltros = new System.Windows.Forms.GroupBox();
            this.mrcFiltroPrecio = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            this.mrcRegistros.SuspendLayout();
            this.mrcFiltros.SuspendLayout();
            this.mrcFiltroPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(12, 12);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(254, 56);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Grupo,
            this.Precio});
            this.grdDatos.Location = new System.Drawing.Point(6, 125);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersVisible = false;
            this.grdDatos.Size = new System.Drawing.Size(523, 219);
            this.grdDatos.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Enabled = false;
            this.btnMostrar.Location = new System.Drawing.Point(297, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(254, 56);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(6, 16);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Desde";
            // 
            // nudDesde
            // 
            this.nudDesde.DecimalPlaces = 2;
            this.nudDesde.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDesde.Location = new System.Drawing.Point(50, 14);
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(63, 20);
            this.nudDesde.TabIndex = 5;
            // 
            // nudHasta
            // 
            this.nudHasta.DecimalPlaces = 2;
            this.nudHasta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHasta.Location = new System.Drawing.Point(50, 40);
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(63, 20);
            this.nudHasta.TabIndex = 6;
            // 
            // mrcRegistros
            // 
            this.mrcRegistros.Controls.Add(this.mrcFiltros);
            this.mrcRegistros.Controls.Add(this.grdDatos);
            this.mrcRegistros.Location = new System.Drawing.Point(12, 74);
            this.mrcRegistros.Name = "mrcRegistros";
            this.mrcRegistros.Size = new System.Drawing.Size(539, 352);
            this.mrcRegistros.TabIndex = 7;
            this.mrcRegistros.TabStop = false;
            this.mrcRegistros.Text = "Registros";
            // 
            // mrcFiltros
            // 
            this.mrcFiltros.Controls.Add(this.mrcFiltroPrecio);
            this.mrcFiltros.Location = new System.Drawing.Point(6, 19);
            this.mrcFiltros.Name = "mrcFiltros";
            this.mrcFiltros.Size = new System.Drawing.Size(527, 100);
            this.mrcFiltros.TabIndex = 8;
            this.mrcFiltros.TabStop = false;
            this.mrcFiltros.Text = "Filtros";
            // 
            // mrcFiltroPrecio
            // 
            this.mrcFiltroPrecio.Controls.Add(this.lblHasta);
            this.mrcFiltroPrecio.Controls.Add(this.lblDesde);
            this.mrcFiltroPrecio.Controls.Add(this.nudDesde);
            this.mrcFiltroPrecio.Controls.Add(this.nudHasta);
            this.mrcFiltroPrecio.Location = new System.Drawing.Point(6, 19);
            this.mrcFiltroPrecio.Name = "mrcFiltroPrecio";
            this.mrcFiltroPrecio.Size = new System.Drawing.Size(128, 71);
            this.mrcFiltroPrecio.TabIndex = 9;
            this.mrcFiltroPrecio.TabStop = false;
            this.mrcFiltroPrecio.Text = "Precio";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(9, 42);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 10;
            this.lblHasta.Text = "Hasta";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 433);
            this.Controls.Add(this.mrcRegistros);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnConectar);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros Verduleria";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            this.mrcRegistros.ResumeLayout(false);
            this.mrcFiltros.ResumeLayout(false);
            this.mrcFiltroPrecio.ResumeLayout(false);
            this.mrcFiltroPrecio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.NumericUpDown nudDesde;
        private System.Windows.Forms.NumericUpDown nudHasta;
        private System.Windows.Forms.GroupBox mrcRegistros;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.GroupBox mrcFiltroPrecio;
        private System.Windows.Forms.GroupBox mrcFiltros;
    }
}

