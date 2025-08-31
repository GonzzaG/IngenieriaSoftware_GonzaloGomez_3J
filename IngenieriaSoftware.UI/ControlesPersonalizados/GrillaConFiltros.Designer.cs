namespace IngenieriaSoftware.UI.ControlesPersonalizados
{
    partial class DataGridViewConFiltros
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.panelNoResultadoProducto = new IngenieriaSoftware.UI.ControlesPersonalizados.panelCustom.PanelNoResultado();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(2, 85);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(632, 352);
            this.dgv.TabIndex = 0;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Black;
            this.btnAnterior.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnterior.Location = new System.Drawing.Point(2, 45);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(36, 36);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Ant.";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Black;
            this.btnSiguiente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSiguiente.Location = new System.Drawing.Point(43, 45);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(0);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(36, 36);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Sig.";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPagina.Location = new System.Drawing.Point(91, 54);
            this.lblPagina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(80, 26);
            this.lblPagina.TabIndex = 4;
            this.lblPagina.Text = "Pagina";
            // 
            // panelNoResultadoProducto
            // 
            this.panelNoResultadoProducto.BackColor = System.Drawing.Color.Transparent;
            this.panelNoResultadoProducto.Location = new System.Drawing.Point(14, 97);
            this.panelNoResultadoProducto.Name = "panelNoResultadoProducto";
            this.panelNoResultadoProducto.Size = new System.Drawing.Size(209, 48);
            this.panelNoResultadoProducto.TabIndex = 43;
            // 
            // DataGridViewConFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelNoResultadoProducto);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DataGridViewConFiltros";
            this.Size = new System.Drawing.Size(646, 448);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblPagina;
        private panelCustom.PanelNoResultado panelNoResultadoProducto;
    }
}
