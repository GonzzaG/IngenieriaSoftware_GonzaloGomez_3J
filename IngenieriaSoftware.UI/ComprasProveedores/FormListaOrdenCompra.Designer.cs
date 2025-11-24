namespace IngenieriaSoftware.UI.ComprasProveedores
{
    partial class FormListaOrdenCompra
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
            this.gBListaOrdenCompra = new System.Windows.Forms.GroupBox();
            this.cbEstado = new IngenieriaSoftware.UI.ControlesPersonalizados.Inputs.ComboBoxCustom();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grillaConFiltros = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.gBListaOrdenCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBListaOrdenCompra
            // 
            this.gBListaOrdenCompra.AutoSize = true;
            this.gBListaOrdenCompra.Controls.Add(this.cbEstado);
            this.gBListaOrdenCompra.Controls.Add(this.btnGenerarFactura);
            this.gBListaOrdenCompra.Controls.Add(this.dtpFechaDesde);
            this.gBListaOrdenCompra.Controls.Add(this.lblEstado);
            this.gBListaOrdenCompra.Controls.Add(this.lblFechaDesde);
            this.gBListaOrdenCompra.Controls.Add(this.txtCodigo);
            this.gBListaOrdenCompra.Controls.Add(this.lblCodigo);
            this.gBListaOrdenCompra.Controls.Add(this.btnBuscar);
            this.gBListaOrdenCompra.Controls.Add(this.btnAgregar);
            this.gBListaOrdenCompra.Controls.Add(this.btnLimpiar);
            this.gBListaOrdenCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBListaOrdenCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gBListaOrdenCompra.Location = new System.Drawing.Point(148, 33);
            this.gBListaOrdenCompra.Margin = new System.Windows.Forms.Padding(2);
            this.gBListaOrdenCompra.Name = "gBListaOrdenCompra";
            this.gBListaOrdenCompra.Padding = new System.Windows.Forms.Padding(2);
            this.gBListaOrdenCompra.Size = new System.Drawing.Size(1040, 228);
            this.gBListaOrdenCompra.TabIndex = 1242;
            this.gBListaOrdenCompra.TabStop = false;
            this.gBListaOrdenCompra.Tag = "";
            this.gBListaOrdenCompra.Text = "Orden de compra";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(605, 82);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(189, 30);
            this.cbEstado.TabIndex = 3;
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(132)))), ((int)(((byte)(240)))));
            this.btnGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerarFactura.Location = new System.Drawing.Point(494, 165);
            this.btnGenerarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(143, 37);
            this.btnGenerarFactura.TabIndex = 7;
            this.btnGenerarFactura.Tag = "";
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            this.btnGenerarFactura.Visible = false;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(341, 84);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(189, 28);
            this.dtpFechaDesde.TabIndex = 2;
            this.dtpFechaDesde.Value = new System.DateTime(2025, 11, 22, 0, 0, 0, 0);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstado.Location = new System.Drawing.Point(601, 57);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 21);
            this.lblEstado.TabIndex = 41;
            this.lblEstado.Tag = "";
            this.lblEstado.Text = "Estado";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaDesde.Location = new System.Drawing.Point(337, 57);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(95, 21);
            this.lblFechaDesde.TabIndex = 1245;
            this.lblFechaDesde.Tag = "";
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(80, 83);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(189, 29);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Tag = "";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCodigo.Location = new System.Drawing.Point(76, 60);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(96, 21);
            this.lblCodigo.TabIndex = 1243;
            this.lblCodigo.Tag = "";
            this.lblCodigo.Text = "Num. Orden";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(767, 165);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 37);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Tag = "";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(650, 165);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 37);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Tag = "";
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(883, 165);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 37);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Tag = "";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grillaConFiltros
            // 
            this.grillaConFiltros.BackColor = System.Drawing.Color.Transparent;
            this.grillaConFiltros.Location = new System.Drawing.Point(148, 302);
            this.grillaConFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grillaConFiltros.Name = "grillaConFiltros";
            this.grillaConFiltros.Size = new System.Drawing.Size(1040, 350);
            this.grillaConFiltros.TabIndex = 35;
            this.grillaConFiltros.Tag = "";
            this.grillaConFiltros.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Gigante;
            // 
            // FormListaOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1374, 839);
            this.Controls.Add(this.grillaConFiltros);
            this.Controls.Add(this.gBListaOrdenCompra);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormListaOrdenCompra";
            this.Tag = "";
            this.Text = "Seleccionar";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FormListaOrdenCompra_Scroll);
            this.gBListaOrdenCompra.ResumeLayout(false);
            this.gBListaOrdenCompra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gBListaOrdenCompra;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private ControlesPersonalizados.DataGridViewConFiltros grillaConFiltros;
        private System.Windows.Forms.Button btnGenerarFactura;
        private ControlesPersonalizados.Inputs.ComboBoxCustom cbEstado;
    }
}