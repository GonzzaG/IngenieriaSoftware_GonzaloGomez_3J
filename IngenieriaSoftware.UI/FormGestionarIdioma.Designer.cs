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
            this.dataGridViewIdiomas = new System.Windows.Forms.DataGridView();
            this.lblIdiomas = new System.Windows.Forms.Label();
            this.btnAgregarIdioma = new System.Windows.Forms.Button();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnEliminarIdioma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdiomas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIdiomas
            // 
            this.dataGridViewIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIdiomas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewIdiomas.Location = new System.Drawing.Point(308, 54);
            this.dataGridViewIdiomas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewIdiomas.MultiSelect = false;
            this.dataGridViewIdiomas.Name = "dataGridViewIdiomas";
            this.dataGridViewIdiomas.RowHeadersWidth = 51;
            this.dataGridViewIdiomas.RowTemplate.Height = 24;
            this.dataGridViewIdiomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIdiomas.Size = new System.Drawing.Size(196, 278);
            this.dataGridViewIdiomas.TabIndex = 0;
            this.dataGridViewIdiomas.Tag = "781";
            // 
            // lblIdiomas
            // 
            this.lblIdiomas.AutoSize = true;
            this.lblIdiomas.Location = new System.Drawing.Point(306, 39);
            this.lblIdiomas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdiomas.Name = "lblIdiomas";
            this.lblIdiomas.Size = new System.Drawing.Size(43, 13);
            this.lblIdiomas.TabIndex = 1;
            this.lblIdiomas.Tag = "48";
            this.lblIdiomas.Text = "Idiomas";
            // 
            // btnAgregarIdioma
            // 
            this.btnAgregarIdioma.Location = new System.Drawing.Point(63, 223);
            this.btnAgregarIdioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarIdioma.Name = "btnAgregarIdioma";
            this.btnAgregarIdioma.Size = new System.Drawing.Size(131, 54);
            this.btnAgregarIdioma.TabIndex = 3;
            this.btnAgregarIdioma.Tag = "780";
            this.btnAgregarIdioma.Text = "Agregar idioma";
            this.btnAgregarIdioma.UseVisualStyleBackColor = true;
            this.btnAgregarIdioma.Click += new System.EventHandler(this.btnAgregarIdioma_Click);
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(63, 141);
            this.txtIdioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(132, 20);
            this.txtIdioma.TabIndex = 4;
            this.txtIdioma.Tag = "779";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(61, 125);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 6;
            this.lblIdioma.Tag = "778";
            this.lblIdioma.Text = "Idioma";
            // 
            // btnEliminarIdioma
            // 
            this.btnEliminarIdioma.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarIdioma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarIdioma.Location = new System.Drawing.Point(374, 336);
            this.btnEliminarIdioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarIdioma.Name = "btnEliminarIdioma";
            this.btnEliminarIdioma.Size = new System.Drawing.Size(131, 44);
            this.btnEliminarIdioma.TabIndex = 7;
            this.btnEliminarIdioma.Tag = "782";
            this.btnEliminarIdioma.Text = "Eliminar idioma";
            this.btnEliminarIdioma.UseVisualStyleBackColor = false;
            this.btnEliminarIdioma.Click += new System.EventHandler(this.btnEliminarIdioma_Click);
            // 
            // FormGestionarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 454);
            this.Controls.Add(this.btnEliminarIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.btnAgregarIdioma);
            this.Controls.Add(this.lblIdiomas);
            this.Controls.Add(this.dataGridViewIdiomas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGestionarIdioma";
            this.Tag = "783";
            this.Text = "GestionarIdioma";
            this.Load += new System.EventHandler(this.FormGestionarIdioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdiomas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIdiomas;
        private System.Windows.Forms.Label lblIdiomas;
        private System.Windows.Forms.Button btnAgregarIdioma;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnEliminarIdioma;
    }
}