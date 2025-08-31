namespace IngenieriaSoftware.UI.ComprasProveedores
{
    partial class ModalSeleccionProdutosOrdenCompra
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
            this.inputNombreFiltro1 = new IngenieriaSoftware.UI.ControlesPersonalizados.InputNombreFiltro();
            this.lblSeleccioneProductos = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblCant = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConFiltros1
            // 
            this.dataGridViewConFiltros1.BackColor = System.Drawing.Color.Transparent;
            this.dataGridViewConFiltros1.Location = new System.Drawing.Point(74, 135);
            this.dataGridViewConFiltros1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewConFiltros1.Name = "dataGridViewConFiltros1";
            this.dataGridViewConFiltros1.Size = new System.Drawing.Size(646, 448);
            this.dataGridViewConFiltros1.TabIndex = 0;
            this.dataGridViewConFiltros1.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Mediano;
            // 
            // inputNombreFiltro1
            // 
            this.inputNombreFiltro1.BackColor = System.Drawing.Color.Transparent;
            this.inputNombreFiltro1.Location = new System.Drawing.Point(74, 86);
            this.inputNombreFiltro1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNombreFiltro1.Name = "inputNombreFiltro1";
            this.inputNombreFiltro1.Size = new System.Drawing.Size(194, 55);
            this.inputNombreFiltro1.TabIndex = 1;
            this.inputNombreFiltro1.Texto = "";
            // 
            // lblSeleccioneProductos
            // 
            this.lblSeleccioneProductos.AutoSize = true;
            this.lblSeleccioneProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSeleccioneProductos.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.lblSeleccioneProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSeleccioneProductos.Location = new System.Drawing.Point(69, 28);
            this.lblSeleccioneProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccioneProductos.Name = "lblSeleccioneProductos";
            this.lblSeleccioneProductos.Size = new System.Drawing.Size(271, 30);
            this.lblSeleccioneProductos.TabIndex = 69;
            this.lblSeleccioneProductos.Tag = "116";
            this.lblSeleccioneProductos.Text = "Núm. de orden de compra";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Teal;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProducto.Location = new System.Drawing.Point(74, 587);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(197, 37);
            this.btnAgregarProducto.TabIndex = 70;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numericUpDown1.Location = new System.Drawing.Point(418, 182);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 32);
            this.numericUpDown1.TabIndex = 72;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCant.Font = new System.Drawing.Font("Segoe UI Symbol", 8F);
            this.lblCant.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCant.Location = new System.Drawing.Point(415, 166);
            this.lblCant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(34, 13);
            this.lblCant.TabIndex = 73;
            this.lblCant.Tag = "116";
            this.lblCant.Text = "Cant.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(511, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 37);
            this.button1.TabIndex = 71;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ModalSeleccionProdutosOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(874, 683);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblSeleccioneProductos);
            this.Controls.Add(this.inputNombreFiltro1);
            this.Controls.Add(this.dataGridViewConFiltros1);
            this.Name = "ModalSeleccionProdutosOrdenCompra";
            this.Text = "FormSeleccionProdutosOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.DataGridViewConFiltros dataGridViewConFiltros1;
        private ControlesPersonalizados.InputNombreFiltro inputNombreFiltro1;
        private System.Windows.Forms.Label lblSeleccioneProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Button button1;
    }
}