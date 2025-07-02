namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    partial class FormGestionProveedores
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
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.groupBoxProveedor = new System.Windows.Forms.GroupBox();
            this.checkBoxEsActivo = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblListaProveedores = new System.Windows.Forms.Label();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.groupBoxProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(522, 249);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.Size = new System.Drawing.Size(837, 335);
            this.dgvProveedores.TabIndex = 0;
            this.dgvProveedores.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_RowEnter);
            // 
            // groupBoxProveedor
            // 
            this.groupBoxProveedor.Controls.Add(this.checkBoxEsActivo);
            this.groupBoxProveedor.Controls.Add(this.lblEstado);
            this.groupBoxProveedor.Controls.Add(this.txtTelefono);
            this.groupBoxProveedor.Controls.Add(this.lblTelefono);
            this.groupBoxProveedor.Controls.Add(this.txtRazonSocial);
            this.groupBoxProveedor.Controls.Add(this.lblRazonSocial);
            this.groupBoxProveedor.Controls.Add(this.txtCorreo);
            this.groupBoxProveedor.Controls.Add(this.lblCorreo);
            this.groupBoxProveedor.Controls.Add(this.txtDocumento);
            this.groupBoxProveedor.Controls.Add(this.lblDocumento);
            this.groupBoxProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxProveedor.Location = new System.Drawing.Point(42, 115);
            this.groupBoxProveedor.Name = "groupBoxProveedor";
            this.groupBoxProveedor.Size = new System.Drawing.Size(327, 522);
            this.groupBoxProveedor.TabIndex = 4;
            this.groupBoxProveedor.TabStop = false;
            this.groupBoxProveedor.Text = "Detalle Proveedor";
            // 
            // checkBoxEsActivo
            // 
            this.checkBoxEsActivo.AutoSize = true;
            this.checkBoxEsActivo.Checked = true;
            this.checkBoxEsActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEsActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEsActivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxEsActivo.Location = new System.Drawing.Point(32, 457);
            this.checkBoxEsActivo.Name = "checkBoxEsActivo";
            this.checkBoxEsActivo.Size = new System.Drawing.Size(99, 33);
            this.checkBoxEsActivo.TabIndex = 28;
            this.checkBoxEsActivo.Text = "Activo";
            this.checkBoxEsActivo.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstado.Location = new System.Drawing.Point(27, 426);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(71, 28);
            this.lblEstado.TabIndex = 27;
            this.lblEstado.Tag = "52";
            this.lblEstado.Text = "Estado";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Teal;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(32, 383);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(266, 34);
            this.txtTelefono.TabIndex = 26;
            this.txtTelefono.Tag = "55";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Location = new System.Drawing.Point(27, 353);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(88, 28);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Tag = "52";
            this.lblTelefono.Text = "Telefono";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.Teal;
            this.txtRazonSocial.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(32, 233);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(266, 34);
            this.txtRazonSocial.TabIndex = 24;
            this.txtRazonSocial.Tag = "55";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRazonSocial.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRazonSocial.Location = new System.Drawing.Point(27, 203);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(123, 28);
            this.lblRazonSocial.TabIndex = 23;
            this.lblRazonSocial.Tag = "52";
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Teal;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(32, 308);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(266, 34);
            this.txtCorreo.TabIndex = 20;
            this.txtCorreo.Tag = "55";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCorreo.Location = new System.Drawing.Point(27, 278);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(72, 28);
            this.lblCorreo.TabIndex = 19;
            this.lblCorreo.Tag = "52";
            this.lblCorreo.Text = "Correo";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.Teal;
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(32, 159);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(266, 34);
            this.txtDocumento.TabIndex = 17;
            this.txtDocumento.Tag = "55";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDocumento.Location = new System.Drawing.Point(27, 129);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(115, 28);
            this.lblDocumento.TabIndex = 16;
            this.lblDocumento.Tag = "52";
            this.lblDocumento.Text = "Documento";
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListaProveedores.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProveedores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListaProveedores.Location = new System.Drawing.Point(515, 199);
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(273, 38);
            this.lblListaProveedores.TabIndex = 29;
            this.lblListaProveedores.Tag = "52";
            this.lblListaProveedores.Text = "Lista de Proveedores";
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.Teal;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(522, 651);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(183, 70);
            this.btnAgregarProveedor.TabIndex = 3;
            this.btnAgregarProveedor.Tag = "56";
            this.btnAgregarProveedor.Text = "Guardar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(843, 651);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(183, 70);
            this.btnEliminarProveedor.TabIndex = 30;
            this.btnEliminarProveedor.Tag = "56";
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Orange;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.Location = new System.Drawing.Point(1176, 651);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(183, 70);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Tag = "56";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormGestionProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1835, 830);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.lblListaProveedores);
            this.Controls.Add(this.groupBoxProveedor);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Name = "FormGestionProveedores";
            this.Text = "GestionProveedores";
            this.Load += new System.EventHandler(this.FormGestionProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.groupBoxProveedor.ResumeLayout(false);
            this.groupBoxProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.GroupBox groupBoxProveedor;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblListaProveedores;
        private System.Windows.Forms.CheckBox checkBoxEsActivo;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnModificar;
    }
}