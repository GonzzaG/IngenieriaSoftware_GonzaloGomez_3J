﻿namespace IngenieriaSoftware.UI
{
    partial class GestionarIdioma
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
            this.dataGridViewIdiomas.Location = new System.Drawing.Point(495, 63);
            this.dataGridViewIdiomas.Name = "dataGridViewIdiomas";
            this.dataGridViewIdiomas.RowHeadersWidth = 51;
            this.dataGridViewIdiomas.RowTemplate.Height = 24;
            this.dataGridViewIdiomas.Size = new System.Drawing.Size(318, 342);
            this.dataGridViewIdiomas.TabIndex = 0;
            // 
            // lblIdiomas
            // 
            this.lblIdiomas.AutoSize = true;
            this.lblIdiomas.Location = new System.Drawing.Point(492, 44);
            this.lblIdiomas.Name = "lblIdiomas";
            this.lblIdiomas.Size = new System.Drawing.Size(55, 16);
            this.lblIdiomas.TabIndex = 1;
            this.lblIdiomas.Text = "Idiomas";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(70, 93);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(199, 24);
            this.comboBoxUsuario.TabIndex = 2;
            // 
            // btnAgregarIdioma
            // 
            this.btnAgregarIdioma.Location = new System.Drawing.Point(84, 309);
            this.btnAgregarIdioma.Name = "btnAgregarIdioma";
            this.btnAgregarIdioma.Size = new System.Drawing.Size(149, 78);
            this.btnAgregarIdioma.TabIndex = 3;
            this.btnAgregarIdioma.Text = "Agregar idioma";
            this.btnAgregarIdioma.UseVisualStyleBackColor = true;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(72, 196);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(175, 22);
            this.txtIdioma.TabIndex = 4;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(67, 74);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(69, 177);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(48, 16);
            this.lblIdioma.TabIndex = 6;
            this.lblIdioma.Text = "Idioma";
            // 
            // GestionarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 559);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.btnAgregarIdioma);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.lblIdiomas);
            this.Controls.Add(this.dataGridViewIdiomas);
            this.Name = "GestionarIdioma";
            this.Text = "GestionarIdioma";
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