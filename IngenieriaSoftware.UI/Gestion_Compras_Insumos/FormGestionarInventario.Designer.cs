namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    partial class FormGestionarInventario
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
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.filtroNombreProducto = new IngenieriaSoftware.UI.ControlesPersonalizados.InputNombreFiltro();
            this.cbcTipo = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.ComboBoxCustom();
            this.btnRegistrarMerma = new System.Windows.Forms.Button();
            this.btnAlertaEscasez = new System.Windows.Forms.Button();
            this.btnRecibirProductos = new System.Windows.Forms.Button();
            this.lblDetalleOrden = new System.Windows.Forms.Label();
            this.btnCancelarRecepcion = new System.Windows.Forms.Button();
            this.dgvOrdenDetalle = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.dgvProductoInventario = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListaProductos.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListaProductos.Location = new System.Drawing.Point(91, 47);
            this.lblListaProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(234, 37);
            this.lblListaProductos.TabIndex = 48;
            this.lblListaProductos.Tag = "";
            this.lblListaProductos.Text = "Lista de Productos";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTipo.Location = new System.Drawing.Point(58, 34);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(40, 21);
            this.lblTipo.TabIndex = 50;
            this.lblTipo.Tag = "";
            this.lblTipo.Text = "Tipo";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.filtroNombreProducto);
            this.gbFiltros.Controls.Add(this.lblTipo);
            this.gbFiltros.Controls.Add(this.cbcTipo);
            this.gbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbFiltros.Location = new System.Drawing.Point(574, 47);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(540, 118);
            this.gbFiltros.TabIndex = 51;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // filtroNombreProducto
            // 
            this.filtroNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.filtroNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroNombreProducto.Location = new System.Drawing.Point(297, 34);
            this.filtroNombreProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filtroNombreProducto.Name = "filtroNombreProducto";
            this.filtroNombreProducto.Size = new System.Drawing.Size(237, 67);
            this.filtroNombreProducto.TabIndex = 47;
            this.filtroNombreProducto.Texto = "";
            // 
            // cbcTipo
            // 
            this.cbcTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcTipo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcTipo.FormattingEnabled = true;
            this.cbcTipo.Location = new System.Drawing.Point(62, 58);
            this.cbcTipo.Name = "cbcTipo";
            this.cbcTipo.Size = new System.Drawing.Size(172, 28);
            this.cbcTipo.TabIndex = 49;
            this.cbcTipo.SelectedIndexChanged += new System.EventHandler(this.cbcTipo_SelectedIndexChanged);
            // 
            // btnRegistrarMerma
            // 
            this.btnRegistrarMerma.BackColor = System.Drawing.Color.Maroon;
            this.btnRegistrarMerma.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMerma.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrarMerma.Location = new System.Drawing.Point(977, 599);
            this.btnRegistrarMerma.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarMerma.Name = "btnRegistrarMerma";
            this.btnRegistrarMerma.Size = new System.Drawing.Size(137, 57);
            this.btnRegistrarMerma.TabIndex = 53;
            this.btnRegistrarMerma.Tag = "";
            this.btnRegistrarMerma.Text = "Merma";
            this.btnRegistrarMerma.UseVisualStyleBackColor = false;
            this.btnRegistrarMerma.Click += new System.EventHandler(this.btnRegistrarMerma_Click);
            // 
            // btnAlertaEscasez
            // 
            this.btnAlertaEscasez.BackColor = System.Drawing.Color.Orange;
            this.btnAlertaEscasez.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaEscasez.ForeColor = System.Drawing.Color.Black;
            this.btnAlertaEscasez.Location = new System.Drawing.Point(783, 599);
            this.btnAlertaEscasez.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlertaEscasez.Name = "btnAlertaEscasez";
            this.btnAlertaEscasez.Size = new System.Drawing.Size(137, 57);
            this.btnAlertaEscasez.TabIndex = 52;
            this.btnAlertaEscasez.Tag = "";
            this.btnAlertaEscasez.Text = "Escasez";
            this.btnAlertaEscasez.UseVisualStyleBackColor = false;
            this.btnAlertaEscasez.Click += new System.EventHandler(this.btnAlertaEscasez_Click);
            // 
            // btnRecibirProductos
            // 
            this.btnRecibirProductos.BackColor = System.Drawing.Color.MistyRose;
            this.btnRecibirProductos.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibirProductos.ForeColor = System.Drawing.Color.Black;
            this.btnRecibirProductos.Location = new System.Drawing.Point(923, 170);
            this.btnRecibirProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecibirProductos.Name = "btnRecibirProductos";
            this.btnRecibirProductos.Size = new System.Drawing.Size(191, 37);
            this.btnRecibirProductos.TabIndex = 51;
            this.btnRecibirProductos.Tag = "";
            this.btnRecibirProductos.Text = "Recibir Productos";
            this.btnRecibirProductos.UseVisualStyleBackColor = false;
            this.btnRecibirProductos.Click += new System.EventHandler(this.btnRecibirProductos_Click);
            // 
            // lblDetalleOrden
            // 
            this.lblDetalleOrden.AutoSize = true;
            this.lblDetalleOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDetalleOrden.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleOrden.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDetalleOrden.Location = new System.Drawing.Point(1198, 177);
            this.lblDetalleOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalleOrden.Name = "lblDetalleOrden";
            this.lblDetalleOrden.Size = new System.Drawing.Size(148, 30);
            this.lblDetalleOrden.TabIndex = 55;
            this.lblDetalleOrden.Tag = "";
            this.lblDetalleOrden.Text = "Detalle Orden ";
            this.lblDetalleOrden.Visible = false;
            // 
            // btnCancelarRecepcion
            // 
            this.btnCancelarRecepcion.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelarRecepcion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRecepcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelarRecepcion.Location = new System.Drawing.Point(768, 170);
            this.btnCancelarRecepcion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarRecepcion.Name = "btnCancelarRecepcion";
            this.btnCancelarRecepcion.Size = new System.Drawing.Size(137, 37);
            this.btnCancelarRecepcion.TabIndex = 56;
            this.btnCancelarRecepcion.Tag = "";
            this.btnCancelarRecepcion.Text = "Cancelar";
            this.btnCancelarRecepcion.UseVisualStyleBackColor = false;
            this.btnCancelarRecepcion.Visible = false;
            this.btnCancelarRecepcion.Click += new System.EventHandler(this.btnCancelarRecepcion_Click);
            // 
            // dgvOrdenDetalle
            // 
            this.dgvOrdenDetalle.BackColor = System.Drawing.Color.Transparent;
            this.dgvOrdenDetalle.Location = new System.Drawing.Point(1203, 220);
            this.dgvOrdenDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrdenDetalle.Name = "dgvOrdenDetalle";
            this.dgvOrdenDetalle.Size = new System.Drawing.Size(678, 282);
            this.dgvOrdenDetalle.TabIndex = 54;
            this.dgvOrdenDetalle.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Pequeño;
            this.dgvOrdenDetalle.Visible = false;
            // 
            // dgvProductoInventario
            // 
            this.dgvProductoInventario.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductoInventario.Location = new System.Drawing.Point(138, 220);
            this.dgvProductoInventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProductoInventario.Name = "dgvProductoInventario";
            this.dgvProductoInventario.Size = new System.Drawing.Size(976, 282);
            this.dgvProductoInventario.TabIndex = 0;
            this.dgvProductoInventario.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Grande;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Teal;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProducto.Location = new System.Drawing.Point(138, 599);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(176, 57);
            this.btnAgregarProducto.TabIndex = 58;
            this.btnAgregarProducto.Tag = "";
            this.btnAgregarProducto.Text = "Agregar productos";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // FormGestionarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1525, 744);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnCancelarRecepcion);
            this.Controls.Add(this.lblDetalleOrden);
            this.Controls.Add(this.dgvOrdenDetalle);
            this.Controls.Add(this.btnRegistrarMerma);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.btnAlertaEscasez);
            this.Controls.Add(this.btnRecibirProductos);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.dgvProductoInventario);
            this.Name = "FormGestionarInventario";
            this.Text = "FormGestionInventario";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.DataGridViewConFiltros dgvProductoInventario;
        private ControlesPersonalizados.InputNombreFiltro filtroNombreProducto;
        private System.Windows.Forms.Label lblListaProductos;
        private ControlesPersonalizados.Inputs.ComboBoxCustom cbcTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnRegistrarMerma;
        private System.Windows.Forms.Button btnAlertaEscasez;
        private System.Windows.Forms.Button btnRecibirProductos;
        private ControlesPersonalizados.DataGridViewConFiltros dgvOrdenDetalle;
        private System.Windows.Forms.Label lblDetalleOrden;
        private System.Windows.Forms.Button btnCancelarRecepcion;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}