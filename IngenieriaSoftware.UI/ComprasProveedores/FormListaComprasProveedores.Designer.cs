namespace IngenieriaSoftware.UI.ComprasProveedores
{
    partial class FormListaComprasProveedores
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grillaConFiltros = new ControlesPersonalizados.DataGridViewConFiltros();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(109, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compras";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(622, 151);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 45);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(734, 151);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 45);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(846, 151);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 45);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // grillaConFiltros
            // 
            this.grillaConFiltros.BackColor = System.Drawing.Color.Transparent;
            this.grillaConFiltros.Location = new System.Drawing.Point(104, 202);
            this.grillaConFiltros.Name = "grillaConFiltros";
            this.grillaConFiltros.Size = new System.Drawing.Size(867, 550);
            this.grillaConFiltros.TabIndex = 0;
            // 
            // FormListaComprasProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1432, 821);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grillaConFiltros);
            this.Name = "FormListaComprasProveedores";
            this.Text = "FormListaComprasProveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.DataGridViewConFiltros grillaConFiltros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}