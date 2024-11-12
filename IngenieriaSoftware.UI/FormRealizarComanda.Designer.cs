namespace IngenieriaSoftware.UI
{
    partial class FormRealizarComanda
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
            this.btnVerComanda = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerComanda
            // 
            this.btnVerComanda.Location = new System.Drawing.Point(256, 424);
            this.btnVerComanda.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerComanda.Name = "btnVerComanda";
            this.btnVerComanda.Size = new System.Drawing.Size(162, 45);
            this.btnVerComanda.TabIndex = 25;
            this.btnVerComanda.Tag = "74";
            this.btnVerComanda.Text = "Ver comanda";
            this.btnVerComanda.UseVisualStyleBackColor = true;
            this.btnVerComanda.Click += new System.EventHandler(this.btnVerComanda_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(58, 424);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(162, 45);
            this.btnAgregarProducto.TabIndex = 24;
            this.btnAgregarProducto.Tag = "72";
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductos.Location = new System.Drawing.Point(65, 31);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(119, 26);
            this.lblProductos.TabIndex = 23;
            this.lblProductos.Tag = "70";
            this.lblProductos.Text = "Productos";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProductos.Location = new System.Drawing.Point(58, 73);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(822, 325);
            this.dataGridViewProductos.TabIndex = 22;
            this.dataGridViewProductos.Tag = "71";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMesa.Location = new System.Drawing.Point(342, 31);
            this.lblMesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(76, 26);
            this.lblMesa.TabIndex = 26;
            this.lblMesa.Tag = "70";
            this.lblMesa.Text = "Mesa:";
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNumeroMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMesa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumeroMesa.Location = new System.Drawing.Point(422, 31);
            this.lblNumeroMesa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(25, 26);
            this.lblNumeroMesa.TabIndex = 27;
            this.lblNumeroMesa.Tag = "70";
            this.lblNumeroMesa.Text = "0";
            // 
            // FormRealizarComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 563);
            this.Controls.Add(this.lblNumeroMesa);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.btnVerComanda);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.dataGridViewProductos);
            this.Name = "FormRealizarComanda";
            this.Text = "FormRealizarComanda";
            this.Load += new System.EventHandler(this.FormRealizarComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerComanda;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblNumeroMesa;
    }
}