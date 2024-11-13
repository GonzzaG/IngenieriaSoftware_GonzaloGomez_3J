namespace IngenieriaSoftware.UI
{
    partial class FormGestionarComandas
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
            this.btnComandaEnPreparacion = new System.Windows.Forms.Button();
            this.lblComandas = new System.Windows.Forms.Label();
            this.dataGridViewComandasPendientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewComandaProductos = new System.Windows.Forms.DataGridView();
            this.lblProductosComanda = new System.Windows.Forms.Label();
            this.btnPedidoListo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComandaEnPreparacion
            // 
            this.btnComandaEnPreparacion.Location = new System.Drawing.Point(38, 396);
            this.btnComandaEnPreparacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnComandaEnPreparacion.Name = "btnComandaEnPreparacion";
            this.btnComandaEnPreparacion.Size = new System.Drawing.Size(162, 45);
            this.btnComandaEnPreparacion.TabIndex = 28;
            this.btnComandaEnPreparacion.Tag = "74";
            this.btnComandaEnPreparacion.Text = "Marcar en preparacion";
            this.btnComandaEnPreparacion.UseVisualStyleBackColor = true;
            this.btnComandaEnPreparacion.Click += new System.EventHandler(this.btnComandaEnPreparacion_Click);
            // 
            // lblComandas
            // 
            this.lblComandas.AutoSize = true;
            this.lblComandas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandas.Location = new System.Drawing.Point(33, 27);
            this.lblComandas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComandas.Name = "lblComandas";
            this.lblComandas.Size = new System.Drawing.Size(249, 26);
            this.lblComandas.TabIndex = 27;
            this.lblComandas.Tag = "70";
            this.lblComandas.Text = "Comandas pendientes";
            // 
            // dataGridViewComandasPendientes
            // 
            this.dataGridViewComandasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandasPendientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandasPendientes.Location = new System.Drawing.Point(38, 73);
            this.dataGridViewComandasPendientes.MultiSelect = false;
            this.dataGridViewComandasPendientes.Name = "dataGridViewComandasPendientes";
            this.dataGridViewComandasPendientes.RowHeadersVisible = false;
            this.dataGridViewComandasPendientes.RowHeadersWidth = 51;
            this.dataGridViewComandasPendientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewComandasPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandasPendientes.Size = new System.Drawing.Size(334, 297);
            this.dataGridViewComandasPendientes.TabIndex = 26;
            this.dataGridViewComandasPendientes.Tag = "71";
            this.dataGridViewComandasPendientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComandasPendientes_RowEnter);
            // 
            // dataGridViewComandaProductos
            // 
            this.dataGridViewComandaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandaProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandaProductos.Location = new System.Drawing.Point(436, 73);
            this.dataGridViewComandaProductos.MultiSelect = false;
            this.dataGridViewComandaProductos.Name = "dataGridViewComandaProductos";
            this.dataGridViewComandaProductos.RowHeadersVisible = false;
            this.dataGridViewComandaProductos.RowHeadersWidth = 51;
            this.dataGridViewComandaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewComandaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandaProductos.Size = new System.Drawing.Size(512, 297);
            this.dataGridViewComandaProductos.TabIndex = 29;
            this.dataGridViewComandaProductos.Tag = "71";
            // 
            // lblProductosComanda
            // 
            this.lblProductosComanda.AutoSize = true;
            this.lblProductosComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosComanda.Location = new System.Drawing.Point(666, 27);
            this.lblProductosComanda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductosComanda.Name = "lblProductosComanda";
            this.lblProductosComanda.Size = new System.Drawing.Size(282, 26);
            this.lblProductosComanda.TabIndex = 30;
            this.lblProductosComanda.Tag = "70";
            this.lblProductosComanda.Text = "Productos de la comanda";
            // 
            // btnPedidoListo
            // 
            this.btnPedidoListo.Location = new System.Drawing.Point(786, 396);
            this.btnPedidoListo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPedidoListo.Name = "btnPedidoListo";
            this.btnPedidoListo.Size = new System.Drawing.Size(162, 45);
            this.btnPedidoListo.TabIndex = 31;
            this.btnPedidoListo.Tag = "74";
            this.btnPedidoListo.Text = "Pedido listo";
            this.btnPedidoListo.UseVisualStyleBackColor = true;
            // 
            // FormGestionarComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 532);
            this.Controls.Add(this.btnPedidoListo);
            this.Controls.Add(this.lblProductosComanda);
            this.Controls.Add(this.dataGridViewComandaProductos);
            this.Controls.Add(this.btnComandaEnPreparacion);
            this.Controls.Add(this.lblComandas);
            this.Controls.Add(this.dataGridViewComandasPendientes);
            this.Name = "FormGestionarComandas";
            this.Text = "FormGestionarComandas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComandaEnPreparacion;
        private System.Windows.Forms.Label lblComandas;
        private System.Windows.Forms.DataGridView dataGridViewComandasPendientes;
        private System.Windows.Forms.DataGridView dataGridViewComandaProductos;
        private System.Windows.Forms.Label lblProductosComanda;
        private System.Windows.Forms.Button btnPedidoListo;
    }
}