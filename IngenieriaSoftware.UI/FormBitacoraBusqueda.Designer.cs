namespace IngenieriaSoftware.UI
{
    partial class FormBitacoraBusqueda
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
            this.btnBuscarRegistros = new System.Windows.Forms.Button();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.checkBoxBuscarPorArea = new System.Windows.Forms.CheckBox();
            this.dataGridViewBitacora = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarRegistros
            // 
            this.btnBuscarRegistros.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarRegistros.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRegistros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarRegistros.Location = new System.Drawing.Point(877, 88);
            this.btnBuscarRegistros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarRegistros.Name = "btnBuscarRegistros";
            this.btnBuscarRegistros.Size = new System.Drawing.Size(234, 70);
            this.btnBuscarRegistros.TabIndex = 3;
            this.btnBuscarRegistros.Tag = "1212";
            this.btnBuscarRegistros.Text = "Buscar";
            this.btnBuscarRegistros.UseVisualStyleBackColor = false;
            this.btnBuscarRegistros.Click += new System.EventHandler(this.btnBuscarRegistros_Click);
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.Checked = false;
            this.desdeDateTimePicker.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeDateTimePicker.Location = new System.Drawing.Point(86, 106);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(181, 38);
            this.desdeDateTimePicker.TabIndex = 4;
            this.desdeDateTimePicker.Value = new System.DateTime(2025, 4, 21, 1, 49, 32, 0);
            this.desdeDateTimePicker.ValueChanged += new System.EventHandler(this.desdeDateTimePicker_ValueChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDesde.Location = new System.Drawing.Point(124, 64);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(71, 28);
            this.lblDesde.TabIndex = 11;
            this.lblDesde.Tag = "1209";
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHasta.Location = new System.Drawing.Point(342, 64);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(66, 28);
            this.lblHasta.TabIndex = 13;
            this.lblHasta.Tag = "1210";
            this.lblHasta.Text = "Hasta";
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaDateTimePicker.Location = new System.Drawing.Point(347, 106);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(181, 38);
            this.hastaDateTimePicker.TabIndex = 12;
            this.hastaDateTimePicker.Value = new System.DateTime(2025, 4, 21, 1, 49, 44, 0);
            this.hastaDateTimePicker.ValueChanged += new System.EventHandler(this.hastaDateTimePicker_ValueChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblArea.Location = new System.Drawing.Point(591, 64);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(56, 28);
            this.lblArea.TabIndex = 14;
            this.lblArea.Tag = "1211";
            this.lblArea.Text = "Area";
            // 
            // txtModulo
            // 
            this.txtModulo.BackColor = System.Drawing.Color.DarkGray;
            this.txtModulo.Enabled = false;
            this.txtModulo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModulo.Location = new System.Drawing.Point(596, 106);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(173, 34);
            this.txtModulo.TabIndex = 15;
            // 
            // checkBoxBuscarPorArea
            // 
            this.checkBoxBuscarPorArea.AutoSize = true;
            this.checkBoxBuscarPorArea.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBuscarPorArea.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxBuscarPorArea.Location = new System.Drawing.Point(596, 146);
            this.checkBoxBuscarPorArea.Name = "checkBoxBuscarPorArea";
            this.checkBoxBuscarPorArea.Size = new System.Drawing.Size(177, 32);
            this.checkBoxBuscarPorArea.TabIndex = 16;
            this.checkBoxBuscarPorArea.Tag = "1213";
            this.checkBoxBuscarPorArea.Text = "Buscar por area?";
            this.checkBoxBuscarPorArea.UseVisualStyleBackColor = true;
            this.checkBoxBuscarPorArea.CheckedChanged += new System.EventHandler(this.checkBoxBuscarPorModulo_CheckedChanged);
            // 
            // dataGridViewBitacora
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewBitacora.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewBitacora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewBitacora.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewBitacora.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBitacora.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBitacora.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBitacora.EnableHeadersVisualStyles = false;
            this.dataGridViewBitacora.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewBitacora.Location = new System.Drawing.Point(75, 228);
            this.dataGridViewBitacora.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBitacora.MultiSelect = false;
            this.dataGridViewBitacora.Name = "dataGridViewBitacora";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBitacora.RowHeadersVisible = false;
            this.dataGridViewBitacora.RowHeadersWidth = 51;
            this.dataGridViewBitacora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewBitacora.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBitacora.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewBitacora.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewBitacora.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewBitacora.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewBitacora.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewBitacora.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBitacora.Size = new System.Drawing.Size(1610, 471);
            this.dataGridViewBitacora.TabIndex = 31;
            this.dataGridViewBitacora.Tag = "1214";
            // 
            // FormBitacoraBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1924, 868);
            this.Controls.Add(this.dataGridViewBitacora);
            this.Controls.Add(this.checkBoxBuscarPorArea);
            this.Controls.Add(this.txtModulo);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.hastaDateTimePicker);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.desdeDateTimePicker);
            this.Controls.Add(this.btnBuscarRegistros);
            this.Name = "FormBitacoraBusqueda";
            this.Tag = "1215";
            this.Text = "FormBitacoraBusqueda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarRegistros;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.CheckBox checkBoxBuscarPorArea;
        private System.Windows.Forms.DataGridView dataGridViewBitacora;
    }
}