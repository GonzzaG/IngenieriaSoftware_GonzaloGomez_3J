namespace IngenieriaSoftware.UI
{
    partial class FormVerComanda
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
            this.btnConfirmarComanda = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.lblComandaGeneral = new System.Windows.Forms.Label();
            this.lblComandaActual = new System.Windows.Forms.Label();
            this.dataGridViewComandaGeneral = new System.Windows.Forms.DataGridView();
            this.dataGridViewComandaActual = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaActual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarComanda
            // 
            this.btnConfirmarComanda.BackColor = System.Drawing.Color.Teal;
            this.btnConfirmarComanda.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarComanda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmarComanda.Location = new System.Drawing.Point(65, 832);
            this.btnConfirmarComanda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmarComanda.Name = "btnConfirmarComanda";
            this.btnConfirmarComanda.Size = new System.Drawing.Size(225, 69);
            this.btnConfirmarComanda.TabIndex = 25;
            this.btnConfirmarComanda.Tag = "102";
            this.btnConfirmarComanda.Text = "Confirmar comanda";
            this.btnConfirmarComanda.UseVisualStyleBackColor = false;
            this.btnConfirmarComanda.Click += new System.EventHandler(this.btnConfirmarComanda_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Teal;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarProducto.Location = new System.Drawing.Point(341, 832);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(225, 69);
            this.btnEliminarProducto.TabIndex = 24;
            this.btnEliminarProducto.Tag = "103";
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // lblComandaGeneral
            // 
            this.lblComandaGeneral.AutoSize = true;
            this.lblComandaGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandaGeneral.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblComandaGeneral.Location = new System.Drawing.Point(55, 28);
            this.lblComandaGeneral.Name = "lblComandaGeneral";
            this.lblComandaGeneral.Size = new System.Drawing.Size(261, 32);
            this.lblComandaGeneral.TabIndex = 23;
            this.lblComandaGeneral.Tag = "100";
            this.lblComandaGeneral.Text = "Comanda General";
            // 
            // lblComandaActual
            // 
            this.lblComandaActual.AutoSize = true;
            this.lblComandaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandaActual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblComandaActual.Location = new System.Drawing.Point(54, 416);
            this.lblComandaActual.Name = "lblComandaActual";
            this.lblComandaActual.Size = new System.Drawing.Size(235, 32);
            this.lblComandaActual.TabIndex = 27;
            this.lblComandaActual.Tag = "105";
            this.lblComandaActual.Text = "Comanda actual";
            // 
            // dataGridViewComandaGeneral
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaGeneral.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewComandaGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComandaGeneral.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewComandaGeneral.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewComandaGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewComandaGeneral.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewComandaGeneral.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandaGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewComandaGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewComandaGeneral.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewComandaGeneral.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandaGeneral.EnableHeadersVisualStyles = false;
            this.dataGridViewComandaGeneral.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewComandaGeneral.Location = new System.Drawing.Point(45, 73);
            this.dataGridViewComandaGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewComandaGeneral.MultiSelect = false;
            this.dataGridViewComandaGeneral.Name = "dataGridViewComandaGeneral";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandaGeneral.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewComandaGeneral.RowHeadersVisible = false;
            this.dataGridViewComandaGeneral.RowHeadersWidth = 51;
            this.dataGridViewComandaGeneral.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaGeneral.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewComandaGeneral.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewComandaGeneral.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewComandaGeneral.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaGeneral.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewComandaGeneral.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaGeneral.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandaGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandaGeneral.Size = new System.Drawing.Size(1265, 317);
            this.dataGridViewComandaGeneral.TabIndex = 28;
            this.dataGridViewComandaGeneral.Tag = "166";
            // 
            // dataGridViewComandaActual
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaActual.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewComandaActual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComandaActual.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewComandaActual.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewComandaActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewComandaActual.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewComandaActual.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandaActual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewComandaActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewComandaActual.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewComandaActual.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandaActual.EnableHeadersVisualStyles = false;
            this.dataGridViewComandaActual.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewComandaActual.Location = new System.Drawing.Point(45, 475);
            this.dataGridViewComandaActual.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewComandaActual.MultiSelect = false;
            this.dataGridViewComandaActual.Name = "dataGridViewComandaActual";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandaActual.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewComandaActual.RowHeadersVisible = false;
            this.dataGridViewComandaActual.RowHeadersWidth = 51;
            this.dataGridViewComandaActual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaActual.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewComandaActual.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewComandaActual.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewComandaActual.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaActual.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewComandaActual.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComandaActual.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComandaActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandaActual.Size = new System.Drawing.Size(1265, 338);
            this.dataGridViewComandaActual.TabIndex = 29;
            this.dataGridViewComandaActual.Tag = "166";
            // 
            // FormVerComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1559, 1001);
            this.Controls.Add(this.dataGridViewComandaActual);
            this.Controls.Add(this.dataGridViewComandaGeneral);
            this.Controls.Add(this.lblComandaActual);
            this.Controls.Add(this.btnConfirmarComanda);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.lblComandaGeneral);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVerComanda";
            this.Tag = "106";
            this.Text = "FormVerComanda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVerComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaActual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmarComanda;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Label lblComandaGeneral;
        private System.Windows.Forms.Label lblComandaActual;
        private System.Windows.Forms.DataGridView dataGridViewComandaGeneral;
        private System.Windows.Forms.DataGridView dataGridViewComandaActual;
    }
}