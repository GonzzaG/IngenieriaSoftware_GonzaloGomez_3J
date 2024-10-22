namespace IngenieriaSoftware.UI
{
    partial class GestionUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.usuarioBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBLLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(107, 85);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(189, 21);
            this.comboBoxCategorias.TabIndex = 0;
            this.comboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // usuarioBLLBindingSource
            // 
            this.usuarioBLLBindingSource.DataSource = typeof(IngenieriaSoftware.BLL.UsuarioBLL);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.comboBoxCategorias);
            this.Name = "GestionUsuarios";
            this.Text = "GestionUsuarios";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBLLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.BindingSource usuarioBLLBindingSource;
    }
}