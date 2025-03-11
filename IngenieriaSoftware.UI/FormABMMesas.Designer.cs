namespace IngenieriaSoftware.UI
{
    partial class FormABMMesas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminarMesa = new System.Windows.Forms.Button();
            this.btnNuevaMesa = new System.Windows.Forms.Button();
            this.lblMesas = new System.Windows.Forms.Label();
            this.btnModificarMesa = new System.Windows.Forms.Button();
            this.dataGridViewMesas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarMesa
            // 
            this.btnEliminarMesa.BackColor = System.Drawing.Color.Teal;
            this.btnEliminarMesa.Enabled = false;
            this.btnEliminarMesa.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarMesa.Location = new System.Drawing.Point(936, 354);
            this.btnEliminarMesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarMesa.Name = "btnEliminarMesa";
            this.btnEliminarMesa.Size = new System.Drawing.Size(233, 61);
            this.btnEliminarMesa.TabIndex = 19;
            this.btnEliminarMesa.Tag = "301";
            this.btnEliminarMesa.Text = "Eliminar Mesa";
            this.btnEliminarMesa.UseVisualStyleBackColor = false;
            this.btnEliminarMesa.Visible = false;
            this.btnEliminarMesa.Click += new System.EventHandler(this.btnEliminarMesa_Click);
            // 
            // btnNuevaMesa
            // 
            this.btnNuevaMesa.BackColor = System.Drawing.Color.Teal;
            this.btnNuevaMesa.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaMesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevaMesa.Location = new System.Drawing.Point(936, 160);
            this.btnNuevaMesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaMesa.Name = "btnNuevaMesa";
            this.btnNuevaMesa.Size = new System.Drawing.Size(233, 61);
            this.btnNuevaMesa.TabIndex = 18;
            this.btnNuevaMesa.Tag = "300";
            this.btnNuevaMesa.Text = "Nueva Mesa";
            this.btnNuevaMesa.UseVisualStyleBackColor = false;
            this.btnNuevaMesa.Click += new System.EventHandler(this.btnGuardarMesa_Click);
            // 
            // lblMesas
            // 
            this.lblMesas.AutoSize = true;
            this.lblMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesas.ForeColor = System.Drawing.Color.White;
            this.lblMesas.Location = new System.Drawing.Point(77, 32);
            this.lblMesas.Name = "lblMesas";
            this.lblMesas.Size = new System.Drawing.Size(102, 32);
            this.lblMesas.TabIndex = 17;
            this.lblMesas.Tag = "198";
            this.lblMesas.Text = "Mesas";
            // 
            // btnModificarMesa
            // 
            this.btnModificarMesa.BackColor = System.Drawing.Color.Teal;
            this.btnModificarMesa.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarMesa.Location = new System.Drawing.Point(936, 252);
            this.btnModificarMesa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarMesa.Name = "btnModificarMesa";
            this.btnModificarMesa.Size = new System.Drawing.Size(233, 61);
            this.btnModificarMesa.TabIndex = 20;
            this.btnModificarMesa.Tag = "302";
            this.btnModificarMesa.Text = "Modificar Mesa";
            this.btnModificarMesa.UseVisualStyleBackColor = false;
            this.btnModificarMesa.Click += new System.EventHandler(this.btnModificarMesa_Click);
            // 
            // dataGridViewMesas
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMesas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMesas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewMesas.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewMesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMesas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewMesas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMesas.EnableHeadersVisualStyles = false;
            this.dataGridViewMesas.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewMesas.Location = new System.Drawing.Point(83, 118);
            this.dataGridViewMesas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMesas.MultiSelect = false;
            this.dataGridViewMesas.Name = "dataGridViewMesas";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMesas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewMesas.RowHeadersVisible = false;
            this.dataGridViewMesas.RowHeadersWidth = 51;
            this.dataGridViewMesas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMesas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewMesas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewMesas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMesas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMesas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewMesas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMesas.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMesas.Size = new System.Drawing.Size(686, 349);
            this.dataGridViewMesas.TabIndex = 21;
            this.dataGridViewMesas.Tag = "166";
            // 
            // FormABMMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1235, 624);
            this.Controls.Add(this.dataGridViewMesas);
            this.Controls.Add(this.btnModificarMesa);
            this.Controls.Add(this.btnEliminarMesa);
            this.Controls.Add(this.btnNuevaMesa);
            this.Controls.Add(this.lblMesas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormABMMesas";
            this.Tag = "303";
            this.Text = "ABM Mesas";
            this.Load += new System.EventHandler(this.FormABMMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarMesa;
        private System.Windows.Forms.Button btnNuevaMesa;
        private System.Windows.Forms.Label lblMesas;
        private System.Windows.Forms.Button btnModificarMesa;
        private System.Windows.Forms.DataGridView dataGridViewMesas;
    }
}