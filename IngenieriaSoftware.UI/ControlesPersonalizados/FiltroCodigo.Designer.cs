namespace IngenieriaSoftware.UI.ControlesPersonalizados
{
    partial class InputFiltroCodigo
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
            this.lblFiltroCodigo = new System.Windows.Forms.Label();
            this.txtFiltroCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFiltroCodigo
            // 
            this.lblFiltroCodigo.AutoSize = true;
            this.lblFiltroCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFiltroCodigo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroCodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroCodigo.Location = new System.Drawing.Point(-2, 0);
            this.lblFiltroCodigo.Name = "lblFiltroCodigo";
            this.lblFiltroCodigo.Size = new System.Drawing.Size(77, 28);
            this.lblFiltroCodigo.TabIndex = 17;
            this.lblFiltroCodigo.Tag = "116";
            this.lblFiltroCodigo.Text = "Numero";
            // 
            // txtFiltroCodigo
            // 
            this.txtFiltroCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFiltroCodigo.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtFiltroCodigo.Location = new System.Drawing.Point(3, 30);
            this.txtFiltroCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroCodigo.Name = "txtFiltroCodigo";
            this.txtFiltroCodigo.Size = new System.Drawing.Size(251, 34);
            this.txtFiltroCodigo.TabIndex = 16;
            this.txtFiltroCodigo.Tag = "117";
            // 
            // InputFiltroCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtFiltroCodigo);
            this.Controls.Add(this.lblFiltroCodigo);
            this.Name = "InputFiltroCodigo";
            this.Size = new System.Drawing.Size(259, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltroCodigo;
        private System.Windows.Forms.TextBox txtFiltroCodigo;
    }
}
