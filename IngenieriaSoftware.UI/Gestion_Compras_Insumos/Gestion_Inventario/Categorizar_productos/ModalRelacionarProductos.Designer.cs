namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos.Gestion_Inventario.Categorizar_productos
{
    partial class ModalRelacionarProductos
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
            this.lblProductosInventario = new System.Windows.Forms.Label();
            this.lblProductosRelacionados = new System.Windows.Forms.Label();
            this.btnComenzarRelacion = new System.Windows.Forms.Button();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnQuitarRelacion = new System.Windows.Forms.Button();
            this.filtroNombreProducto = new IngenieriaSoftware.UI.ControlesPersonalizados.InputNombreFiltro();
            this.dgvProductosRelacionados = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.dgvProductosInventario = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.SuspendLayout();
            // 
            // lblProductosInventario
            // 
            this.lblProductosInventario.AutoSize = true;
            this.lblProductosInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductosInventario.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosInventario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductosInventario.Location = new System.Drawing.Point(52, 120);
            this.lblProductosInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductosInventario.Name = "lblProductosInventario";
            this.lblProductosInventario.Size = new System.Drawing.Size(262, 37);
            this.lblProductosInventario.TabIndex = 54;
            this.lblProductosInventario.Tag = "";
            this.lblProductosInventario.Text = "Productos Inventario";
            // 
            // lblProductosRelacionados
            // 
            this.lblProductosRelacionados.AutoSize = true;
            this.lblProductosRelacionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductosRelacionados.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosRelacionados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductosRelacionados.Location = new System.Drawing.Point(673, 120);
            this.lblProductosRelacionados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductosRelacionados.Name = "lblProductosRelacionados";
            this.lblProductosRelacionados.Size = new System.Drawing.Size(175, 37);
            this.lblProductosRelacionados.TabIndex = 56;
            this.lblProductosRelacionados.Tag = "";
            this.lblProductosRelacionados.Text = "Relacionados";
            // 
            // btnComenzarRelacion
            // 
            this.btnComenzarRelacion.BackColor = System.Drawing.Color.Orange;
            this.btnComenzarRelacion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzarRelacion.ForeColor = System.Drawing.Color.Black;
            this.btnComenzarRelacion.Location = new System.Drawing.Point(454, 489);
            this.btnComenzarRelacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnComenzarRelacion.Name = "btnComenzarRelacion";
            this.btnComenzarRelacion.Size = new System.Drawing.Size(172, 65);
            this.btnComenzarRelacion.TabIndex = 58;
            this.btnComenzarRelacion.Tag = "";
            this.btnComenzarRelacion.Text = "Relacionar";
            this.btnComenzarRelacion.UseVisualStyleBackColor = false;
            this.btnComenzarRelacion.Click += new System.EventHandler(this.btnComenzarRelacion_Click);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreProducto.Location = new System.Drawing.Point(52, 53);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(138, 37);
            this.lblNombreProducto.TabIndex = 60;
            this.lblNombreProducto.Tag = "";
            this.lblNombreProducto.Text = "Producto: ";
            // 
            // btnQuitarRelacion
            // 
            this.btnQuitarRelacion.BackColor = System.Drawing.Color.Maroon;
            this.btnQuitarRelacion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarRelacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitarRelacion.Location = new System.Drawing.Point(680, 182);
            this.btnQuitarRelacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarRelacion.Name = "btnQuitarRelacion";
            this.btnQuitarRelacion.Size = new System.Drawing.Size(172, 43);
            this.btnQuitarRelacion.TabIndex = 61;
            this.btnQuitarRelacion.Tag = "";
            this.btnQuitarRelacion.Text = "Quitar relacion";
            this.btnQuitarRelacion.UseVisualStyleBackColor = false;
            this.btnQuitarRelacion.Click += new System.EventHandler(this.btnQuitarRelacion_Click);
            // 
            // filtroNombreProducto
            // 
            this.filtroNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.filtroNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroNombreProducto.Location = new System.Drawing.Point(59, 169);
            this.filtroNombreProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filtroNombreProducto.Name = "filtroNombreProducto";
            this.filtroNombreProducto.Size = new System.Drawing.Size(209, 56);
            this.filtroNombreProducto.TabIndex = 59;
            this.filtroNombreProducto.Texto = "";
            // 
            // dgvProductosRelacionados
            // 
            this.dgvProductosRelacionados.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosRelacionados.Location = new System.Drawing.Point(680, 248);
            this.dgvProductosRelacionados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosRelacionados.Name = "dgvProductosRelacionados";
            this.dgvProductosRelacionados.Size = new System.Drawing.Size(678, 282);
            this.dgvProductosRelacionados.TabIndex = 57;
            this.dgvProductosRelacionados.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Pequeño;
            // 
            // dgvProductosInventario
            // 
            this.dgvProductosInventario.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosInventario.Location = new System.Drawing.Point(59, 248);
            this.dgvProductosInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosInventario.Name = "dgvProductosInventario";
            this.dgvProductosInventario.Size = new System.Drawing.Size(678, 282);
            this.dgvProductosInventario.TabIndex = 55;
            this.dgvProductosInventario.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Pequeño;
            // 
            // ModalRelacionarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1286, 817);
            this.Controls.Add(this.btnQuitarRelacion);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.filtroNombreProducto);
            this.Controls.Add(this.btnComenzarRelacion);
            this.Controls.Add(this.dgvProductosRelacionados);
            this.Controls.Add(this.lblProductosRelacionados);
            this.Controls.Add(this.dgvProductosInventario);
            this.Controls.Add(this.lblProductosInventario);
            this.Name = "ModalRelacionarProductos";
            this.Text = "ModalRelacionarProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosInventario;
        private System.Windows.Forms.Label lblProductosInventario;
        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosRelacionados;
        private System.Windows.Forms.Label lblProductosRelacionados;
        private System.Windows.Forms.Button btnComenzarRelacion;
        private ControlesPersonalizados.InputNombreFiltro filtroNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnQuitarRelacion;
    }
}