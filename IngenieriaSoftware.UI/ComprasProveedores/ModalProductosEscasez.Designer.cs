namespace IngenieriaSoftware.UI.ComprasProveedores
{
    partial class ModalProductosEscasez
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
            this.dgvProductosEscasez = new IngenieriaSoftware.UI.ControlesPersonalizados.DataGridViewConFiltros();
            this.lblProductosEscasez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dgvProductosEscasez
            // 
            this.dgvProductosEscasez.BackColor = System.Drawing.Color.Transparent;
            this.dgvProductosEscasez.Location = new System.Drawing.Point(27, 112);
            this.dgvProductosEscasez.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosEscasez.Name = "dgvProductosEscasez";
            this.dgvProductosEscasez.Size = new System.Drawing.Size(678, 282);
            this.dgvProductosEscasez.TabIndex = 0;
            this.dgvProductosEscasez.TamanoGrilla = IngenieriaSoftware.UI.ControlesPersonalizados.grillaCustom.ModoTamanoGrilla.Pequeño;
            // 
            // lblProductosEscasez
            // 
            this.lblProductosEscasez.AutoSize = true;
            this.lblProductosEscasez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductosEscasez.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosEscasez.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductosEscasez.Location = new System.Drawing.Point(20, 53);
            this.lblProductosEscasez.Name = "lblProductosEscasez";
            this.lblProductosEscasez.Size = new System.Drawing.Size(287, 37);
            this.lblProductosEscasez.TabIndex = 90;
            this.lblProductosEscasez.Tag = "";
            this.lblProductosEscasez.Text = "Productos en escasez";
            // 
            // ModalProductosEscasez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProductosEscasez);
            this.Controls.Add(this.dgvProductosEscasez);
            this.Name = "ModalProductosEscasez";
            this.Text = "ModalProductosEscasez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.DataGridViewConFiltros dgvProductosEscasez;
        private System.Windows.Forms.Label lblProductosEscasez;
    }
}