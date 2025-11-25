namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario.Categorizar_productos
{
    partial class FormRelacionarConsumoProductos
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
            this.lblProductosVenta = new System.Windows.Forms.Label();
            this.lblProductosInventario = new System.Windows.Forms.Label();
            this.dgvProductosVenta = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.filtroNombreProducto = new IngenieriaSoftware.UI.ControlesPersonalizados.InputNombreFiltro();
            this.btnRelacionarProductos = new System.Windows.Forms.Button();
            this.dgvProductosInventario = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.btnComenzarRelacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductosVenta
            // 
            this.lblProductosVenta.AutoSize = true;
            this.lblProductosVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductosVenta.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductosVenta.Location = new System.Drawing.Point(100, 93);
            this.lblProductosVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductosVenta.Name = "lblProductosVenta";
            this.lblProductosVenta.Size = new System.Drawing.Size(212, 37);
            this.lblProductosVenta.TabIndex = 49;
            this.lblProductosVenta.Tag = "";
            this.lblProductosVenta.Text = "Productos Venta";
            // 
            // lblProductosInventario
            // 
            this.lblProductosInventario.AutoSize = true;
            this.lblProductosInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductosInventario.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosInventario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductosInventario.Location = new System.Drawing.Point(717, 93);
            this.lblProductosInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductosInventario.Name = "lblProductosInventario";
            this.lblProductosInventario.Size = new System.Drawing.Size(262, 37);
            this.lblProductosInventario.TabIndex = 50;
            this.lblProductosInventario.Tag = "";
            this.lblProductosInventario.Text = "Productos Inventario";
            // 
            // dgvProductosVenta
            // 
            this.dgvProductosVenta.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosVenta.Location = new System.Drawing.Point(56, 228);
            this.dgvProductosVenta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosVenta.Name = "dgvProductosVenta";
            this.dgvProductosVenta.Size = new System.Drawing.Size(470, 282);
            this.dgvProductosVenta.TabIndex = 51;
            this.dgvProductosVenta.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Pequeño;
            // 
            // filtroNombreProducto
            // 
            this.filtroNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.filtroNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroNombreProducto.Location = new System.Drawing.Point(396, 168);
            this.filtroNombreProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filtroNombreProducto.Name = "filtroNombreProducto";
            this.filtroNombreProducto.Size = new System.Drawing.Size(237, 56);
            this.filtroNombreProducto.TabIndex = 47;
            this.filtroNombreProducto.Texto = "";
            // 
            // btnRelacionarProductos
            // 
            this.btnRelacionarProductos.BackColor = System.Drawing.Color.MistyRose;
            this.btnRelacionarProductos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelacionarProductos.ForeColor = System.Drawing.Color.Black;
            this.btnRelacionarProductos.Location = new System.Drawing.Point(431, 556);
            this.btnRelacionarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnRelacionarProductos.Name = "btnRelacionarProductos";
            this.btnRelacionarProductos.Size = new System.Drawing.Size(172, 65);
            this.btnRelacionarProductos.TabIndex = 52;
            this.btnRelacionarProductos.Tag = "";
            this.btnRelacionarProductos.Text = "Relacionar";
            this.btnRelacionarProductos.UseVisualStyleBackColor = false;
            this.btnRelacionarProductos.Click += new System.EventHandler(this.btnRecibirProductos_Click);
            // 
            // dgvProductosInventario
            // 
            this.dgvProductosInventario.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosInventario.Location = new System.Drawing.Point(711, 228);
            this.dgvProductosInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosInventario.Name = "dgvProductosInventario";
            this.dgvProductosInventario.Size = new System.Drawing.Size(389, 282);
            this.dgvProductosInventario.TabIndex = 53;
            this.dgvProductosInventario.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Pequeño;
            // 
            // btnComenzarRelacion
            // 
            this.btnComenzarRelacion.BackColor = System.Drawing.Color.MistyRose;
            this.btnComenzarRelacion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzarRelacion.ForeColor = System.Drawing.Color.Black;
            this.btnComenzarRelacion.Location = new System.Drawing.Point(431, 445);
            this.btnComenzarRelacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnComenzarRelacion.Name = "btnComenzarRelacion";
            this.btnComenzarRelacion.Size = new System.Drawing.Size(172, 65);
            this.btnComenzarRelacion.TabIndex = 54;
            this.btnComenzarRelacion.Tag = "";
            this.btnComenzarRelacion.Text = "Relacionar";
            this.btnComenzarRelacion.UseVisualStyleBackColor = false;
            this.btnComenzarRelacion.Click += new System.EventHandler(this.btnComenzarRelacion_Click);
            // 
            // FormRelacionarConsumoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1244, 790);
            this.Controls.Add(this.btnComenzarRelacion);
            this.Controls.Add(this.dgvProductosInventario);
            this.Controls.Add(this.btnRelacionarProductos);
            this.Controls.Add(this.filtroNombreProducto);
            this.Controls.Add(this.dgvProductosVenta);
            this.Controls.Add(this.lblProductosInventario);
            this.Controls.Add(this.lblProductosVenta);
            this.Name = "FormRelacionarConsumoProductos";
            this.Text = "FormCategorizarProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductosVenta;
        private System.Windows.Forms.Label lblProductosInventario;
        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosVenta;
        private ControlesPersonalizados.InputNombreFiltro filtroNombreProducto;
        private System.Windows.Forms.Button btnRelacionarProductos;
        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosInventario;
        private System.Windows.Forms.Button btnComenzarRelacion;
    }
}