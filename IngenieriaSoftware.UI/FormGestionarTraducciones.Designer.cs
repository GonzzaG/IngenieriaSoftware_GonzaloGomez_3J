﻿namespace IngenieriaSoftware.UI
{
    partial class AgregarIdioma
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
            this.btnAgregarTraduccion = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.txtTraduccion = new System.Windows.Forms.TextBox();
            this.lblTraduccion = new System.Windows.Forms.Label();
            this.lblNuevaTraduccionTitulo = new System.Windows.Forms.Label();
            this.dataGridViewEtiquetasConTraduccion = new System.Windows.Forms.DataGridView();
            this.lblEtiquetasConTraduccion = new System.Windows.Forms.Label();
            this.lblEtiquetasSinTraduccion = new System.Windows.Forms.Label();
            this.dataGridViewEtiquetasSinTraduccion = new System.Windows.Forms.DataGridView();
            this.txtEtiqueta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtiquetasConTraduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtiquetasSinTraduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarTraduccion
            // 
            this.btnAgregarTraduccion.Location = new System.Drawing.Point(104, 315);
            this.btnAgregarTraduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarTraduccion.Name = "btnAgregarTraduccion";
            this.btnAgregarTraduccion.Size = new System.Drawing.Size(168, 55);
            this.btnAgregarTraduccion.TabIndex = 2;
            this.btnAgregarTraduccion.Tag = "56";
            this.btnAgregarTraduccion.Text = "Agregar traducción";
            this.btnAgregarTraduccion.UseVisualStyleBackColor = true;
            this.btnAgregarTraduccion.Click += new System.EventHandler(this.btnAgregarTraduccion_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(101, 119);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(56, 16);
            this.lblEtiqueta.TabIndex = 5;
            this.lblEtiqueta.Tag = "52";
            this.lblEtiqueta.Text = "Etiqueta";
            // 
            // txtTraduccion
            // 
            this.txtTraduccion.Location = new System.Drawing.Point(104, 202);
            this.txtTraduccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTraduccion.Name = "txtTraduccion";
            this.txtTraduccion.Size = new System.Drawing.Size(192, 22);
            this.txtTraduccion.TabIndex = 6;
            this.txtTraduccion.Tag = "55";
            // 
            // lblTraduccion
            // 
            this.lblTraduccion.AutoSize = true;
            this.lblTraduccion.Location = new System.Drawing.Point(101, 183);
            this.lblTraduccion.Name = "lblTraduccion";
            this.lblTraduccion.Size = new System.Drawing.Size(75, 16);
            this.lblTraduccion.TabIndex = 7;
            this.lblTraduccion.Tag = "54";
            this.lblTraduccion.Text = "Traducción";
            // 
            // lblNuevaTraduccionTitulo
            // 
            this.lblNuevaTraduccionTitulo.AutoSize = true;
            this.lblNuevaTraduccionTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaTraduccionTitulo.Location = new System.Drawing.Point(69, 43);
            this.lblNuevaTraduccionTitulo.Name = "lblNuevaTraduccionTitulo";
            this.lblNuevaTraduccionTitulo.Size = new System.Drawing.Size(260, 32);
            this.lblNuevaTraduccionTitulo.TabIndex = 10;
            this.lblNuevaTraduccionTitulo.Tag = "49";
            this.lblNuevaTraduccionTitulo.Text = "Nueva Traducción";
            // 
            // dataGridViewEtiquetasConTraduccion
            // 
            this.dataGridViewEtiquetasConTraduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtiquetasConTraduccion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEtiquetasConTraduccion.Location = new System.Drawing.Point(353, 89);
            this.dataGridViewEtiquetasConTraduccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEtiquetasConTraduccion.MultiSelect = false;
            this.dataGridViewEtiquetasConTraduccion.Name = "dataGridViewEtiquetasConTraduccion";
            this.dataGridViewEtiquetasConTraduccion.RowHeadersVisible = false;
            this.dataGridViewEtiquetasConTraduccion.RowHeadersWidth = 51;
            this.dataGridViewEtiquetasConTraduccion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEtiquetasConTraduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEtiquetasConTraduccion.Size = new System.Drawing.Size(353, 282);
            this.dataGridViewEtiquetasConTraduccion.TabIndex = 11;
            this.dataGridViewEtiquetasConTraduccion.Tag = "66";
            this.dataGridViewEtiquetasConTraduccion.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEtiquetasConTraduccion_RowEnter);
            // 
            // lblEtiquetasConTraduccion
            // 
            this.lblEtiquetasConTraduccion.AutoSize = true;
            this.lblEtiquetasConTraduccion.Location = new System.Drawing.Point(349, 69);
            this.lblEtiquetasConTraduccion.Name = "lblEtiquetasConTraduccion";
            this.lblEtiquetasConTraduccion.Size = new System.Drawing.Size(153, 16);
            this.lblEtiquetasConTraduccion.TabIndex = 12;
            this.lblEtiquetasConTraduccion.Tag = "65";
            this.lblEtiquetasConTraduccion.Text = "Etiquetas con traduccion";
            // 
            // lblEtiquetasSinTraduccion
            // 
            this.lblEtiquetasSinTraduccion.AutoSize = true;
            this.lblEtiquetasSinTraduccion.Location = new System.Drawing.Point(736, 69);
            this.lblEtiquetasSinTraduccion.Name = "lblEtiquetasSinTraduccion";
            this.lblEtiquetasSinTraduccion.Size = new System.Drawing.Size(148, 16);
            this.lblEtiquetasSinTraduccion.TabIndex = 14;
            this.lblEtiquetasSinTraduccion.Tag = "67";
            this.lblEtiquetasSinTraduccion.Text = "Etiquetas sin traduccion";
            // 
            // dataGridViewEtiquetasSinTraduccion
            // 
            this.dataGridViewEtiquetasSinTraduccion.AllowUserToResizeRows = false;
            this.dataGridViewEtiquetasSinTraduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtiquetasSinTraduccion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEtiquetasSinTraduccion.Location = new System.Drawing.Point(740, 89);
            this.dataGridViewEtiquetasSinTraduccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEtiquetasSinTraduccion.MultiSelect = false;
            this.dataGridViewEtiquetasSinTraduccion.Name = "dataGridViewEtiquetasSinTraduccion";
            this.dataGridViewEtiquetasSinTraduccion.RowHeadersVisible = false;
            this.dataGridViewEtiquetasSinTraduccion.RowHeadersWidth = 51;
            this.dataGridViewEtiquetasSinTraduccion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEtiquetasSinTraduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEtiquetasSinTraduccion.Size = new System.Drawing.Size(376, 282);
            this.dataGridViewEtiquetasSinTraduccion.TabIndex = 13;
            this.dataGridViewEtiquetasSinTraduccion.Tag = "68";
            this.dataGridViewEtiquetasSinTraduccion.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEtiquetasSinTraduccion_RowEnter);
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.Enabled = false;
            this.txtEtiqueta.Location = new System.Drawing.Point(104, 138);
            this.txtEtiqueta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.Size = new System.Drawing.Size(192, 22);
            this.txtEtiqueta.TabIndex = 15;
            this.txtEtiqueta.Tag = "55";
            // 
            // AgregarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 577);
            this.Controls.Add(this.txtEtiqueta);
            this.Controls.Add(this.lblEtiquetasSinTraduccion);
            this.Controls.Add(this.dataGridViewEtiquetasSinTraduccion);
            this.Controls.Add(this.lblEtiquetasConTraduccion);
            this.Controls.Add(this.dataGridViewEtiquetasConTraduccion);
            this.Controls.Add(this.lblNuevaTraduccionTitulo);
            this.Controls.Add(this.lblTraduccion);
            this.Controls.Add(this.txtTraduccion);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnAgregarTraduccion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarIdioma";
            this.Tag = "61";
            this.Text = "AgregarTraduccion";
            this.Load += new System.EventHandler(this.AgregarIdioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtiquetasConTraduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtiquetasSinTraduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarTraduccion;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox txtTraduccion;
        private System.Windows.Forms.Label lblTraduccion;
        private System.Windows.Forms.Label lblNuevaTraduccionTitulo;
        private System.Windows.Forms.DataGridView dataGridViewEtiquetasConTraduccion;
        private System.Windows.Forms.Label lblEtiquetasConTraduccion;
        private System.Windows.Forms.Label lblEtiquetasSinTraduccion;
        private System.Windows.Forms.DataGridView dataGridViewEtiquetasSinTraduccion;
        private System.Windows.Forms.TextBox txtEtiqueta;
    }
}