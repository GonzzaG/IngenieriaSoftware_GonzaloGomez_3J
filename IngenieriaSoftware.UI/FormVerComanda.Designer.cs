namespace IngenieriaSoftware.UI
{
    partial class FormVerComanda
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
            this.btnConfirmarComanda = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.lblComandaGeneral = new System.Windows.Forms.Label();
            this.dataGridViewComandaGeneral = new System.Windows.Forms.DataGridView();
            this.lblComandaActual = new System.Windows.Forms.Label();
            this.dataGridViewComandaActual = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaActual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarComanda
            // 
            this.btnConfirmarComanda.Location = new System.Drawing.Point(504, 83);
            this.btnConfirmarComanda.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarComanda.Name = "btnConfirmarComanda";
            this.btnConfirmarComanda.Size = new System.Drawing.Size(162, 45);
            this.btnConfirmarComanda.TabIndex = 25;
            this.btnConfirmarComanda.Tag = "102";
            this.btnConfirmarComanda.Text = "Confirmar comanda";
            this.btnConfirmarComanda.UseVisualStyleBackColor = true;
            this.btnConfirmarComanda.Click += new System.EventHandler(this.btnConfirmarComanda_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(504, 220);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(162, 45);
            this.btnEliminarProducto.TabIndex = 24;
            this.btnEliminarProducto.Tag = "103";
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // lblComandaGeneral
            // 
            this.lblComandaGeneral.AutoSize = true;
            this.lblComandaGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandaGeneral.Location = new System.Drawing.Point(41, 23);
            this.lblComandaGeneral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComandaGeneral.Name = "lblComandaGeneral";
            this.lblComandaGeneral.Size = new System.Drawing.Size(205, 26);
            this.lblComandaGeneral.TabIndex = 23;
            this.lblComandaGeneral.Tag = "100";
            this.lblComandaGeneral.Text = "Comanda General";
            // 
            // dataGridViewComandaGeneral
            // 
            this.dataGridViewComandaGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandaGeneral.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandaGeneral.Location = new System.Drawing.Point(34, 69);
            this.dataGridViewComandaGeneral.MultiSelect = false;
            this.dataGridViewComandaGeneral.Name = "dataGridViewComandaGeneral";
            this.dataGridViewComandaGeneral.RowHeadersVisible = false;
            this.dataGridViewComandaGeneral.RowHeadersWidth = 51;
            this.dataGridViewComandaGeneral.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewComandaGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandaGeneral.Size = new System.Drawing.Size(391, 401);
            this.dataGridViewComandaGeneral.TabIndex = 22;
            this.dataGridViewComandaGeneral.Tag = "101";
            // 
            // lblComandaActual
            // 
            this.lblComandaActual.AutoSize = true;
            this.lblComandaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandaActual.Location = new System.Drawing.Point(748, 23);
            this.lblComandaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComandaActual.Name = "lblComandaActual";
            this.lblComandaActual.Size = new System.Drawing.Size(185, 26);
            this.lblComandaActual.TabIndex = 27;
            this.lblComandaActual.Tag = "105";
            this.lblComandaActual.Text = "Comanda actual";
            // 
            // dataGridViewComandaActual
            // 
            this.dataGridViewComandaActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandaActual.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandaActual.Location = new System.Drawing.Point(743, 69);
            this.dataGridViewComandaActual.MultiSelect = false;
            this.dataGridViewComandaActual.Name = "dataGridViewComandaActual";
            this.dataGridViewComandaActual.RowHeadersVisible = false;
            this.dataGridViewComandaActual.RowHeadersWidth = 51;
            this.dataGridViewComandaActual.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewComandaActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandaActual.Size = new System.Drawing.Size(391, 401);
            this.dataGridViewComandaActual.TabIndex = 26;
            this.dataGridViewComandaActual.Tag = "104";
            // 
            // FormVerComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 518);
            this.Controls.Add(this.lblComandaActual);
            this.Controls.Add(this.dataGridViewComandaActual);
            this.Controls.Add(this.btnConfirmarComanda);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.lblComandaGeneral);
            this.Controls.Add(this.dataGridViewComandaGeneral);
            this.Name = "FormVerComanda";
            this.Tag = "106";
            this.Text = "FormVerComanda";
            this.Load += new System.EventHandler(this.FormVerComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaActual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmarComanda;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Label lblComandaGeneral;
        private System.Windows.Forms.DataGridView dataGridViewComandaGeneral;
        private System.Windows.Forms.Label lblComandaActual;
        private System.Windows.Forms.DataGridView dataGridViewComandaActual;
    }
}