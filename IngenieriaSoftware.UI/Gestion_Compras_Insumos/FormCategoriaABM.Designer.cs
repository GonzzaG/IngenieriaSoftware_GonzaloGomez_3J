namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    partial class FormCategoriaABM
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
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblCategoriaTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.lblEliminarCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDocumento.Location = new System.Drawing.Point(94, 80);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(68, 21);
            this.lblDocumento.TabIndex = 17;
            this.lblDocumento.Tag = "";
            this.lblDocumento.Text = "Nombre";
            // 
            // lblCategoriaTitulo
            // 
            this.lblCategoriaTitulo.AutoSize = true;
            this.lblCategoriaTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoriaTitulo.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategoriaTitulo.Location = new System.Drawing.Point(92, 24);
            this.lblCategoriaTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriaTitulo.Name = "lblCategoriaTitulo";
            this.lblCategoriaTitulo.Size = new System.Drawing.Size(175, 30);
            this.lblCategoriaTitulo.TabIndex = 36;
            this.lblCategoriaTitulo.Tag = "";
            this.lblCategoriaTitulo.Text = "Nueva Categoria";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Teal;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(98, 105);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 29);
            this.txtNombre.TabIndex = 37;
            this.txtNombre.Tag = "";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Teal;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(508, 102);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(200, 30);
            this.cbCategoria.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(644, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 39;
            this.label1.Tag = "";
            this.label1.Text = "Nombre";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(98, 158);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(137, 57);
            this.btnAgregarCategoria.TabIndex = 40;
            this.btnAgregarCategoria.Tag = "";
            this.btnAgregarCategoria.Text = "Guardar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(570, 158);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(137, 57);
            this.btnEliminarCategoria.TabIndex = 41;
            this.btnEliminarCategoria.Tag = "";
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            // 
            // lblEliminarCategoria
            // 
            this.lblEliminarCategoria.AutoSize = true;
            this.lblEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEliminarCategoria.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarCategoria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEliminarCategoria.Location = new System.Drawing.Point(541, 24);
            this.lblEliminarCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEliminarCategoria.Name = "lblEliminarCategoria";
            this.lblEliminarCategoria.Size = new System.Drawing.Size(189, 30);
            this.lblEliminarCategoria.TabIndex = 42;
            this.lblEliminarCategoria.Tag = "";
            this.lblEliminarCategoria.Text = "Eliminar Categoria";
            // 
            // FormCategoriaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(750, 270);
            this.Controls.Add(this.lblEliminarCategoria);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCategoriaTitulo);
            this.Controls.Add(this.lblDocumento);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCategoriaABM";
            this.Text = "FormCategoriaABM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblCategoriaTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Label lblEliminarCategoria;
    }
}