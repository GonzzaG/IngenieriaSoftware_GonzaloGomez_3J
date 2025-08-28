namespace IngenieriaSoftware.UI.ControlesPersonalizados
{
    partial class InputNombreFiltro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFiltroNombre.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroNombre.Location = new System.Drawing.Point(-2, -3);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(85, 28);
            this.lblFiltroNombre.TabIndex = 15;
            this.lblFiltroNombre.Tag = "116";
            this.lblFiltroNombre.Text = "Nombre";
            // 
            // txtFiltroCodigo
            // 
            this.txtFiltroNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFiltroNombre.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtFiltroNombre.Location = new System.Drawing.Point(3, 27);
            this.txtFiltroNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroNombre.Name = "txtFiltroCodigo";
            this.txtFiltroNombre.Size = new System.Drawing.Size(251, 34);
            this.txtFiltroNombre.TabIndex = 14;
            this.txtFiltroNombre.Tag = "117";
            // 
            // InputNombreFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblFiltroNombre);
            this.Controls.Add(this.txtFiltroNombre);
            this.Name = "InputNombreFiltro";
            this.Size = new System.Drawing.Size(258, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.TextBox txtFiltroNombre;
    }
}
