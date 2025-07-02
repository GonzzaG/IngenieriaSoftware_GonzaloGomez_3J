namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    partial class FormOrdenCompraFactura
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
            this.iBBuscarProveedores = new FontAwesome.Sharp.IconButton();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.checkBoxEsActivo = new System.Windows.Forms.CheckBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.groupBoxProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProveedor
            // 
            this.groupBoxProveedor.Controls.Add(this.iBBuscarProveedores);
            this.groupBoxProveedor.Controls.Add(this.txtDocumento);
            this.groupBoxProveedor.Controls.Add(this.lblDocumento);
            this.groupBoxProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxProveedor.Location = new System.Drawing.Point(79, 37);
            this.groupBoxProveedor.Name = "groupBoxProveedor";
            this.groupBoxProveedor.Size = new System.Drawing.Size(1121, 174);
            this.groupBoxProveedor.TabIndex = 5;
            this.groupBoxProveedor.TabStop = false;
            this.groupBoxProveedor.Text = "Seleccionar Proveedor";
            // 
            // iBBuscarProveedores
            // 
            this.iBBuscarProveedores.BackColor = System.Drawing.Color.Orange;
            this.iBBuscarProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBBuscarProveedores.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iBBuscarProveedores.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iBBuscarProveedores.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iBBuscarProveedores.IconSize = 24;
            this.iBBuscarProveedores.Location = new System.Drawing.Point(327, 69);
            this.iBBuscarProveedores.Name = "iBBuscarProveedores";
            this.iBBuscarProveedores.Size = new System.Drawing.Size(62, 54);
            this.iBBuscarProveedores.TabIndex = 33;
            this.iBBuscarProveedores.UseVisualStyleBackColor = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.Teal;
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(32, 76);
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
            this.lblDocumento.Location = new System.Drawing.Point(27, 46);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(115, 28);
            this.lblDocumento.TabIndex = 16;
            this.lblDocumento.Tag = "52";
            this.lblDocumento.Text = "Documento";
            // 
            // checkBoxEsActivo
            // 
            this.checkBoxEsActivo.AutoSize = true;
            this.checkBoxEsActivo.Checked = true;
            this.checkBoxEsActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEsActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEsActivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxEsActivo.Location = new System.Drawing.Point(1018, 273);
            this.checkBoxEsActivo.Name = "checkBoxEsActivo";
            this.checkBoxEsActivo.Size = new System.Drawing.Size(99, 33);
            this.checkBoxEsActivo.TabIndex = 28;
            this.checkBoxEsActivo.Text = "Activo";
            this.checkBoxEsActivo.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Teal;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(839, 332);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(266, 34);
            this.txtTelefono.TabIndex = 26;
            this.txtTelefono.Tag = "55";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRazonSocial.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRazonSocial.Location = new System.Drawing.Point(1013, 242);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(123, 28);
            this.lblRazonSocial.TabIndex = 23;
            this.lblRazonSocial.Tag = "52";
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Teal;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(839, 396);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(266, 37);
            this.cbCategoria.TabIndex = 30;
            // 
            // FormOrdenCompraFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1449, 814);
            this.Controls.Add(this.groupBoxProveedor);
            this.Controls.Add(this.checkBoxEsActivo);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblRazonSocial);
            this.Name = "FormOrdenCompraFactura";
            this.Text = "FormOrdenCompraFactura";
            this.groupBoxProveedor.ResumeLayout(false);
            this.groupBoxProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProveedor;
        private System.Windows.Forms.CheckBox checkBoxEsActivo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private FontAwesome.Sharp.IconButton iBBuscarProveedores;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}