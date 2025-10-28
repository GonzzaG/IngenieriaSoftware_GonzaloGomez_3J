namespace IngenieriaSoftware.UI.ComprasProveedores
{
    partial class FormAutorizacionOrdenCompra
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
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grillaConFiltros = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.gBListaOrdenCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBListaOrdenCompra
            // 
            this.gBListaOrdenCompra.AutoSize = true;
            this.gBListaOrdenCompra.Controls.Add(this.dtpFechaDesde);
            this.gBListaOrdenCompra.Controls.Add(this.lblFechaDesde);
            this.gBListaOrdenCompra.Controls.Add(this.txtCodigo);
            this.gBListaOrdenCompra.Controls.Add(this.lblCodigo);
            this.gBListaOrdenCompra.Controls.Add(this.btnBuscar);
            this.gBListaOrdenCompra.Controls.Add(this.btnLimpiar);
            this.gBListaOrdenCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBListaOrdenCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gBListaOrdenCompra.Location = new System.Drawing.Point(197, 50);
            this.gBListaOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBListaOrdenCompra.Name = "gBListaOrdenCompra";
            this.gBListaOrdenCompra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBListaOrdenCompra.Size = new System.Drawing.Size(1387, 281);
            this.gBListaOrdenCompra.TabIndex = 36;
            this.gBListaOrdenCompra.TabStop = false;
            this.gBListaOrdenCompra.Tag = "1285";
            this.gBListaOrdenCompra.Text = "Orden de compra";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(455, 102);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 34);
            this.dtpFechaDesde.TabIndex = 43;
            this.dtpFechaDesde.Tag = "1289";
            this.dtpFechaDesde.Value = new System.DateTime(2025, 9, 16, 23, 18, 0, 0);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaDesde.Location = new System.Drawing.Point(449, 70);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(119, 28);
            this.lblFechaDesde.TabIndex = 39;
            this.lblFechaDesde.Tag = "1288";
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(107, 102);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(251, 34);
            this.txtCodigo.TabIndex = 35;
            this.txtCodigo.Tag = "1287";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCodigo.Location = new System.Drawing.Point(101, 74);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(180, 28);
            this.lblCodigo.TabIndex = 36;
            this.lblCodigo.Tag = "1286";
            this.lblCodigo.Text = "NumOrdenCompra";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(1005, 203);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 46);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Tag = "1290";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(1177, 203);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(137, 46);
            this.btnLimpiar.TabIndex = 37;
            this.btnLimpiar.Tag = "1291";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(1332, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 63);
            this.button1.TabIndex = 45;
            this.button1.Tag = "1293";
            this.button1.Text = "Detalles";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // grillaConFiltros
            // 
            this.grillaConFiltros.BackColor = System.Drawing.Color.Transparent;
            this.grillaConFiltros.Location = new System.Drawing.Point(197, 473);
            this.grillaConFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaConFiltros.Name = "grillaConFiltros";
            this.grillaConFiltros.Size = new System.Drawing.Size(1355, 599);
            this.grillaConFiltros.TabIndex = 37;
            this.grillaConFiltros.Tag = "1294";
            this.grillaConFiltros.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Grande;
            // 
            // FormAutorizacionOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grillaConFiltros);
            this.Controls.Add(this.gBListaOrdenCompra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAutorizacionOrdenCompra";
            this.Tag = "1292";
            this.Text = "FormAutorizacionOrdenCompra";
            this.Load += new System.EventHandler(this.FormAutorizacionOrdenCompra_Load);
            this.gBListaOrdenCompra.ResumeLayout(false);
            this.gBListaOrdenCompra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.DataGridViewConFiltros grillaConFiltros;
        private System.Windows.Forms.GroupBox gBListaOrdenCompra;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
    }
}