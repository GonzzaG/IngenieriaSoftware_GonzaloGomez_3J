namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    partial class FormGestionInventario
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
            this.dataGridViewConFiltros1 = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.filtroNombreProducto = new IngenieriaSoftware.UI.ControlesPersonalizados.InputNombreFiltro();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataGridViewConFiltros1
            // 
            this.dataGridViewConFiltros1.BackColor = System.Drawing.Color.Transparent;
            this.dataGridViewConFiltros1.Location = new System.Drawing.Point(98, 243);
            this.dataGridViewConFiltros1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewConFiltros1.Name = "dataGridViewConFiltros1";
            this.dataGridViewConFiltros1.Size = new System.Drawing.Size(1016, 282);
            this.dataGridViewConFiltros1.TabIndex = 0;
            this.dataGridViewConFiltros1.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Grande;
            // 
            // filtroNombreProducto
            // 
            this.filtroNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.filtroNombreProducto.Location = new System.Drawing.Point(920, 140);
            this.filtroNombreProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filtroNombreProducto.Name = "filtroNombreProducto";
            this.filtroNombreProducto.Size = new System.Drawing.Size(194, 47);
            this.filtroNombreProducto.TabIndex = 47;
            this.filtroNombreProducto.Texto = "";
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListaProductos.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListaProductos.Location = new System.Drawing.Point(93, 85);
            this.lblListaProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(189, 30);
            this.lblListaProductos.TabIndex = 48;
            this.lblListaProductos.Tag = "";
            this.lblListaProductos.Text = "Lista de Productos";
            // 
            // FormGestionInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.filtroNombreProducto);
            this.Controls.Add(this.dataGridViewConFiltros1);
            this.Name = "FormGestionInventario";
            this.Text = "FormGestionInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.DataGridViewConFiltros dataGridViewConFiltros1;
        private ControlesPersonalizados.InputNombreFiltro filtroNombreProducto;
        private System.Windows.Forms.Label lblListaProductos;
    }
}