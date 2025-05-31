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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnComandaEnPreparacion = new System.Windows.Forms.Button();
            this.lblComandas = new System.Windows.Forms.Label();
            this.lblProductosComanda = new System.Windows.Forms.Label();
            this.btnComandaLista = new System.Windows.Forms.Button();
            this.dataGridViewComandasPendientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewComandaProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComandaEnPreparacion
            // 
            this.btnComandaEnPreparacion.BackColor = System.Drawing.Color.Teal;
            this.btnComandaEnPreparacion.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandaEnPreparacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnComandaEnPreparacion.Location = new System.Drawing.Point(51, 487);
            this.btnComandaEnPreparacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComandaEnPreparacion.Name = "btnComandaEnPreparacion";
            this.btnComandaEnPreparacion.Size = new System.Drawing.Size(216, 93);
            this.btnComandaEnPreparacion.TabIndex = 28;
            this.btnComandaEnPreparacion.Tag = "184";
            this.btnComandaEnPreparacion.Text = "Marcar en preparacion";
            this.btnComandaEnPreparacion.UseVisualStyleBackColor = false;
            this.btnComandaEnPreparacion.Click += new System.EventHandler(this.btnComandaEnPreparacion_Click);
            // 
            // lblComandas
            // 
            this.lblComandas.AutoSize = true;
            this.lblComandas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblComandas.Location = new System.Drawing.Point(44, 33);
            this.lblComandas.Name = "lblComandas";
            this.lblComandas.Size = new System.Drawing.Size(318, 32);
            this.lblComandas.TabIndex = 27;
            this.lblComandas.Tag = "180";
            this.lblComandas.Text = "Comandas pendientes";
            // 
            // lblProductosComanda
            // 
            this.lblProductosComanda.AutoSize = true;
            this.lblProductosComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosComanda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductosComanda.Location = new System.Drawing.Point(1057, 33);
            this.lblProductosComanda.Name = "lblProductosComanda";
            this.lblProductosComanda.Size = new System.Drawing.Size(358, 32);
            this.lblProductosComanda.TabIndex = 30;
            this.lblProductosComanda.Tag = "181";
            this.lblProductosComanda.Text = "Productos de la comanda";
            // 
            // btnComandaLista
            // 
            this.btnComandaLista.BackColor = System.Drawing.Color.Teal;
            this.btnComandaLista.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComandaLista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnComandaLista.Location = new System.Drawing.Point(1542, 487);
            this.btnComandaLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComandaLista.Name = "btnComandaLista";
            this.btnComandaLista.Size = new System.Drawing.Size(216, 70);
            this.btnComandaLista.TabIndex = 31;
            this.btnComandaLista.Tag = "185";
            this.btnComandaLista.Text = "Comanda lista";
            this.btnComandaLista.UseVisualStyleBackColor = false;
            this.btnComandaLista.Click += new System.EventHandler(this.btnComandaLista_Click);
            // 
            // dataGridViewComandasPendientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandasPendientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewComandasPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewComandasPendientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewComandasPendientes.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewComandasPendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewComandasPendientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandasPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewComandasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewComandasPendientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewComandasPendientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandasPendientes.EnableHeadersVisualStyles = false;
            this.dataGridViewComandasPendientes.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewComandasPendientes.Location = new System.Drawing.Point(50, 90);
            this.dataGridViewComandasPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewComandasPendientes.MultiSelect = false;
            this.dataGridViewComandasPendientes.Name = "dataGridViewComandasPendientes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandasPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewComandasPendientes.RowHeadersVisible = false;
            this.dataGridViewComandasPendientes.RowHeadersWidth = 51;
            this.dataGridViewComandasPendientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandasPendientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewComandasPendientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewComandasPendientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewComandasPendientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandasPendientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewComandasPendientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandasPendientes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandasPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandasPendientes.Size = new System.Drawing.Size(667, 366);
            this.dataGridViewComandasPendientes.TabIndex = 32;
            this.dataGridViewComandasPendientes.Tag = "166";
            this.dataGridViewComandasPendientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComandasPendientes_RowEnter_1);
            // 
            // dataGridViewComandaProductos
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewComandaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewComandaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewComandaProductos.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewComandaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewComandaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewComandaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewComandaProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewComandaProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandaProductos.EnableHeadersVisualStyles = false;
            this.dataGridViewComandaProductos.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewComandaProductos.Location = new System.Drawing.Point(725, 90);
            this.dataGridViewComandaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewComandaProductos.MultiSelect = false;
            this.dataGridViewComandaProductos.Name = "dataGridViewComandaProductos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewComandaProductos.RowHeadersVisible = false;
            this.dataGridViewComandaProductos.RowHeadersWidth = 51;
            this.dataGridViewComandaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaProductos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewComandaProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewComandaProductos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewComandaProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewComandaProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaProductos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandaProductos.Size = new System.Drawing.Size(1033, 366);
            this.dataGridViewComandaProductos.TabIndex = 33;
            this.dataGridViewComandaProductos.Tag = "166";
            // 
            // FormGestionarComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1771, 655);
            this.Controls.Add(this.dataGridViewComandaProductos);
            this.Controls.Add(this.dataGridViewComandasPendientes);
            this.Controls.Add(this.btnComandaLista);
            this.Controls.Add(this.lblProductosComanda);
            this.Controls.Add(this.btnComandaEnPreparacion);
            this.Controls.Add(this.lblComandas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGestionarComandas";
            this.Tag = "186";
            this.Text = "FormGestionarComandas";
            this.Load += new System.EventHandler(this.FormGestionarComandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandasPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComandaEnPreparacion;
        private System.Windows.Forms.Label lblComandas;
        private System.Windows.Forms.Label lblProductosComanda;
        private System.Windows.Forms.Button btnComandaLista;
        private System.Windows.Forms.DataGridView dataGridViewComandasPendientes;
        private System.Windows.Forms.DataGridView dataGridViewComandaProductos;
    }
}