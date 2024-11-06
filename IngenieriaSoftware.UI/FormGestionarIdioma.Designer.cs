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
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.btnAgregarIdioma = new System.Windows.Forms.Button();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdiomas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIdiomas
            // 
            this.dataGridViewIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIdiomas.Location = new System.Drawing.Point(371, 51);
            this.dataGridViewIdiomas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewIdiomas.Name = "dataGridViewIdiomas";
            this.dataGridViewIdiomas.RowHeadersWidth = 51;
            this.dataGridViewIdiomas.RowTemplate.Height = 24;
            this.dataGridViewIdiomas.Size = new System.Drawing.Size(238, 278);
            this.dataGridViewIdiomas.TabIndex = 0;
            this.dataGridViewIdiomas.Tag = "47";
            // 
            // lblIdiomas
            // 
            this.lblIdiomas.AutoSize = true;
            this.lblIdiomas.Location = new System.Drawing.Point(369, 36);
            this.lblIdiomas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdiomas.Name = "lblIdiomas";
            this.lblIdiomas.Size = new System.Drawing.Size(43, 13);
            this.lblIdiomas.TabIndex = 1;
            this.lblIdiomas.Tag = "48";
            this.lblIdiomas.Text = "Idiomas";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.DisplayMember = "comboBoxUsuario";
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(52, 76);
            this.comboBoxUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(150, 21);
            this.comboBoxUsuario.TabIndex = 2;
            this.comboBoxUsuario.Tag = "42";
            // 
            // btnAgregarIdioma
            // 
            this.btnAgregarIdioma.Location = new System.Drawing.Point(63, 251);
            this.btnAgregarIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarIdioma.Name = "btnAgregarIdioma";
            this.btnAgregarIdioma.Size = new System.Drawing.Size(112, 63);
            this.btnAgregarIdioma.TabIndex = 3;
            this.btnAgregarIdioma.Tag = "46";
            this.btnAgregarIdioma.Text = "Agregar idioma";
            this.btnAgregarIdioma.UseVisualStyleBackColor = true;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(54, 159);
            this.txtIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(132, 20);
            this.txtIdioma.TabIndex = 4;
            this.txtIdioma.Tag = "45";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(50, 60);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Tag = "43";
            this.lblUsuario.Text = "Usuario";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(52, 144);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 6;
            this.lblIdioma.Tag = "44";
            this.lblIdioma.Text = "Idioma";
            // 
            // FormGestionarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 454);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.btnAgregarIdioma);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.lblIdiomas);
            this.Controls.Add(this.dataGridViewIdiomas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGestionarIdioma";
            this.Tag = "41";
            this.Text = "GestionarIdioma";
            this.Load += new System.EventHandler(this.FormGestionarIdioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIdiomas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIdiomas;
        private System.Windows.Forms.Label lblIdiomas;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.Button btnAgregarIdioma;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIdioma;
    }
}