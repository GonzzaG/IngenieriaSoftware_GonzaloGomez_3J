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
            this.btnComenzarRelacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroNombreProducto = new IngenieriaSoftware.UI.ControlesPersonalizados.InputNombreFiltro();
            this.dgvProductosVenta = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.dgvProductosRelacionados = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.SuspendLayout();
            // 
            // lblProductosVenta
            // 
            this.lblProductosVenta.AutoSize = true;
            this.lblProductosVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductosVenta.Font = new System.Drawing.Font("Segoe UI Symbol", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosVenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductosVenta.Location = new System.Drawing.Point(49, 35);
            this.lblProductosVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductosVenta.Name = "lblProductosVenta";
            this.lblProductosVenta.Size = new System.Drawing.Size(294, 50);
            this.lblProductosVenta.TabIndex = 49;
            this.lblProductosVenta.Tag = "";
            this.lblProductosVenta.Text = "Productos Venta";
            // 
            // btnComenzarRelacion
            // 
            this.btnComenzarRelacion.BackColor = System.Drawing.Color.MistyRose;
            this.btnComenzarRelacion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzarRelacion.ForeColor = System.Drawing.Color.Black;
            this.btnComenzarRelacion.Location = new System.Drawing.Point(72, 491);
            this.btnComenzarRelacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnComenzarRelacion.Name = "btnComenzarRelacion";
            this.btnComenzarRelacion.Size = new System.Drawing.Size(172, 65);
            this.btnComenzarRelacion.TabIndex = 54;
            this.btnComenzarRelacion.Tag = "";
            this.btnComenzarRelacion.Text = "Relacionar";
            this.btnComenzarRelacion.UseVisualStyleBackColor = false;
            this.btnComenzarRelacion.Click += new System.EventHandler(this.btnComenzarRelacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(65, 572);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 37);
            this.label1.TabIndex = 55;
            this.label1.Tag = "";
            this.label1.Text = "Seleccione un producto para relacionar";
            // 
            // filtroNombreProducto
            // 
            this.filtroNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.filtroNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroNombreProducto.Location = new System.Drawing.Point(283, 108);
            this.filtroNombreProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filtroNombreProducto.Name = "filtroNombreProducto";
            this.filtroNombreProducto.Size = new System.Drawing.Size(237, 56);
            this.filtroNombreProducto.TabIndex = 47;
            this.filtroNombreProducto.Texto = "";
            // 
            // dgvProductosVenta
            // 
            this.dgvProductosVenta.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosVenta.Location = new System.Drawing.Point(56, 168);
            this.dgvProductosVenta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosVenta.Name = "dgvProductosVenta";
            this.dgvProductosVenta.Size = new System.Drawing.Size(678, 282);
            this.dgvProductosVenta.TabIndex = 51;
            this.dgvProductosVenta.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Pequeño;
            // 
            // dgvProductosRelacionados
            // 
            this.dgvProductosRelacionados.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosRelacionados.Location = new System.Drawing.Point(606, 168);
            this.dgvProductosRelacionados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosRelacionados.Name = "dgvProductosRelacionados";
            this.dgvProductosRelacionados.Size = new System.Drawing.Size(678, 282);
            this.dgvProductosRelacionados.TabIndex = 56;
            this.dgvProductosRelacionados.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Pequeño;
            // 
            // FormRelacionarConsumoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1391, 790);
            this.Controls.Add(this.dgvProductosRelacionados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComenzarRelacion);
            this.Controls.Add(this.filtroNombreProducto);
            this.Controls.Add(this.dgvProductosVenta);
            this.Controls.Add(this.lblProductosVenta);
            this.Name = "FormRelacionarConsumoProductos";
            this.Text = "FormCategorizarProductos";
            this.Load += new System.EventHandler(this.FormRelacionarConsumoProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductosVenta;
        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosVenta;
        private ControlesPersonalizados.InputNombreFiltro filtroNombreProducto;
        private System.Windows.Forms.Button btnComenzarRelacion;
        private System.Windows.Forms.Label label1;
        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosRelacionados;
    }
}