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
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvFiltrosProveedores = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.lblListaProveedores = new System.Windows.Forms.Label();
            this.inputNombreFiltroNombre = new IngenieriaSoftware.UI.ControlesPersonalizados.InputNombreFiltro();
            this.groupBoxProveedor.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBoxProveedor.Location = new System.Drawing.Point(154, 135);
            this.groupBoxProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProveedor.Name = "groupBoxProveedor";
            this.groupBoxProveedor.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProveedor.Size = new System.Drawing.Size(245, 424);
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
            this.checkBoxEsActivo.Location = new System.Drawing.Point(24, 371);
            this.checkBoxEsActivo.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEsActivo.Name = "checkBoxEsActivo";
            this.checkBoxEsActivo.Size = new System.Drawing.Size(80, 28);
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
            this.lblEstado.Location = new System.Drawing.Point(20, 346);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 21);
            this.lblEstado.TabIndex = 27;
            this.lblEstado.Tag = "52";
            this.lblEstado.Text = "Estado";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Teal;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTelefono.Location = new System.Drawing.Point(24, 311);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 29);
            this.txtTelefono.TabIndex = 26;
            this.txtTelefono.Tag = "55";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Location = new System.Drawing.Point(20, 287);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 21);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Tag = "52";
            this.lblTelefono.Text = "Telefono";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.Teal;
            this.txtRazonSocial.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRazonSocial.Location = new System.Drawing.Point(24, 189);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(200, 29);
            this.txtRazonSocial.TabIndex = 24;
            this.txtRazonSocial.Tag = "55";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRazonSocial.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRazonSocial.Location = new System.Drawing.Point(20, 165);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(98, 21);
            this.lblRazonSocial.TabIndex = 23;
            this.lblRazonSocial.Tag = "52";
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Teal;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCorreo.Location = new System.Drawing.Point(24, 250);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 29);
            this.txtCorreo.TabIndex = 20;
            this.txtCorreo.Tag = "55";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCorreo.Location = new System.Drawing.Point(20, 226);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(58, 21);
            this.lblCorreo.TabIndex = 19;
            this.lblCorreo.Tag = "52";
            this.lblCorreo.Text = "Correo";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.Teal;
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtDocumento.Location = new System.Drawing.Point(24, 129);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(200, 29);
            this.txtDocumento.TabIndex = 17;
            this.txtDocumento.Tag = "55";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDocumento.Location = new System.Drawing.Point(20, 105);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(91, 21);
            this.lblDocumento.TabIndex = 16;
            this.lblDocumento.Tag = "52";
            this.lblDocumento.Text = "Documento";
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.Teal;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(514, 559);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(137, 57);
            this.btnAgregarProveedor.TabIndex = 3;
            this.btnAgregarProveedor.Tag = "";
            this.btnAgregarProveedor.Text = "Registrar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(763, 559);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(137, 57);
            this.btnEliminarProveedor.TabIndex = 30;
            this.btnEliminarProveedor.Tag = "";
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Orange;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificar.Location = new System.Drawing.Point(1015, 559);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(137, 57);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Tag = "";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvFiltrosProveedores
            // 
            this.dgvFiltrosProveedores.BackColor = System.Drawing.Color.Transparent;
            this.dgvFiltrosProveedores.Location = new System.Drawing.Point(514, 99);
            this.dgvFiltrosProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFiltrosProveedores.Name = "dgvFiltrosProveedores";
            this.dgvFiltrosProveedores.Size = new System.Drawing.Size(649, 447);
            this.dgvFiltrosProveedores.TabIndex = 32;
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListaProveedores.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProveedores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListaProveedores.Location = new System.Drawing.Point(937, 144);
            this.lblListaProveedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(215, 30);
            this.lblListaProveedores.TabIndex = 33;
            this.lblListaProveedores.Tag = "52";
            this.lblListaProveedores.Text = "Lista de Proveedores";
            // 
            // inputNombreFiltroNombre
            // 
            this.inputNombreFiltroNombre.BackColor = System.Drawing.Color.Transparent;
            this.inputNombreFiltroNombre.Location = new System.Drawing.Point(514, 40);
            this.inputNombreFiltroNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNombreFiltroNombre.Name = "inputNombreFiltroNombre";
            this.inputNombreFiltroNombre.Size = new System.Drawing.Size(194, 55);
            this.inputNombreFiltroNombre.TabIndex = 34;
            this.inputNombreFiltroNombre.Texto = "";
            // 
            // FormGestionProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1445, 729);
            this.Controls.Add(this.inputNombreFiltroNombre);
            this.Controls.Add(this.lblListaProveedores);
            this.Controls.Add(this.dgvFiltrosProveedores);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.groupBoxProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGestionProveedores";
            this.Text = "GestionProveedores";
            this.Load += new System.EventHandler(this.FormGestionProveedores_Load);
            this.groupBoxProveedor.ResumeLayout(false);
            this.groupBoxProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.CheckBox checkBoxEsActivo;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnModificar;
        private ControlesPersonalizados.DataGridViewConFiltros dgvFiltrosProveedores;
        private System.Windows.Forms.Label lblListaProveedores;
        private ControlesPersonalizados.InputNombreFiltro inputNombreFiltroNombre;
    }
}