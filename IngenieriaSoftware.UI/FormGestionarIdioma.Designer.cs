namespace IngenieriaSoftware.UI
{
    partial class FormGestionarIdioma
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
            this.lblIdiomas = new System.Windows.Forms.Label();
            this.btnAgregarIdioma = new System.Windows.Forms.Button();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnEliminarIdioma = new System.Windows.Forms.Button();
            this.dataGridViewIdiomas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdiomas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdiomas
            // 
            this.lblIdiomas.AutoSize = true;
            this.lblIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdiomas.Location = new System.Drawing.Point(406, 31);
            this.lblIdiomas.Name = "lblIdiomas";
            this.lblIdiomas.Size = new System.Drawing.Size(80, 25);
            this.lblIdiomas.TabIndex = 1;
            this.lblIdiomas.Tag = "48";
            this.lblIdiomas.Text = "Idiomas";
            // 
            // btnAgregarIdioma
            // 
            this.btnAgregarIdioma.BackColor = System.Drawing.Color.Teal;
            this.btnAgregarIdioma.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIdioma.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarIdioma.Location = new System.Drawing.Point(84, 276);
            this.btnAgregarIdioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarIdioma.Name = "btnAgregarIdioma";
            this.btnAgregarIdioma.Size = new System.Drawing.Size(175, 66);
            this.btnAgregarIdioma.TabIndex = 3;
            this.btnAgregarIdioma.Tag = "780";
            this.btnAgregarIdioma.Text = "Agregar idioma";
            this.btnAgregarIdioma.UseVisualStyleBackColor = false;
            this.btnAgregarIdioma.Click += new System.EventHandler(this.btnAgregarIdioma_Click);
            // 
            // txtIdioma
            // 
            this.txtIdioma.BackColor = System.Drawing.Color.Teal;
            this.txtIdioma.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdioma.Location = new System.Drawing.Point(84, 174);
            this.txtIdioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(218, 34);
            this.txtIdioma.TabIndex = 4;
            this.txtIdioma.Tag = "779";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdioma.Location = new System.Drawing.Point(79, 137);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(70, 25);
            this.lblIdioma.TabIndex = 6;
            this.lblIdioma.Tag = "778";
            this.lblIdioma.Text = "Idioma";
            // 
            // btnEliminarIdioma
            // 
            this.btnEliminarIdioma.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarIdioma.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarIdioma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarIdioma.Location = new System.Drawing.Point(487, 431);
            this.btnEliminarIdioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarIdioma.Name = "btnEliminarIdioma";
            this.btnEliminarIdioma.Size = new System.Drawing.Size(187, 51);
            this.btnEliminarIdioma.TabIndex = 7;
            this.btnEliminarIdioma.Tag = "782";
            this.btnEliminarIdioma.Text = "Eliminar idioma";
            this.btnEliminarIdioma.UseVisualStyleBackColor = false;
            this.btnEliminarIdioma.Click += new System.EventHandler(this.btnEliminarIdioma_Click);
            // 
            // dataGridViewIdiomas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewIdiomas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIdiomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIdiomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewIdiomas.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridViewIdiomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewIdiomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIdiomas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewIdiomas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewIdiomas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewIdiomas.EnableHeadersVisualStyles = false;
            this.dataGridViewIdiomas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewIdiomas.Location = new System.Drawing.Point(411, 69);
            this.dataGridViewIdiomas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewIdiomas.MultiSelect = false;
            this.dataGridViewIdiomas.Name = "dataGridViewIdiomas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIdiomas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewIdiomas.RowHeadersVisible = false;
            this.dataGridViewIdiomas.RowHeadersWidth = 51;
            this.dataGridViewIdiomas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewIdiomas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewIdiomas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridViewIdiomas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewIdiomas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewIdiomas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewIdiomas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewIdiomas.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewIdiomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIdiomas.Size = new System.Drawing.Size(263, 339);
            this.dataGridViewIdiomas.TabIndex = 51;
            this.dataGridViewIdiomas.Tag = "166";
            // 
            // FormGestionarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(844, 559);
            this.Controls.Add(this.dataGridViewIdiomas);
            this.Controls.Add(this.btnEliminarIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.btnAgregarIdioma);
            this.Controls.Add(this.lblIdiomas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGestionarIdioma";
            this.Tag = "783";
            this.Text = "GestionarIdioma";
            this.Load += new System.EventHandler(this.FormGestionarIdioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdiomas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdiomas;
        private System.Windows.Forms.Button btnAgregarIdioma;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnEliminarIdioma;
        private System.Windows.Forms.DataGridView dataGridViewIdiomas;
    }
}