namespace IngenieriaSoftware.UI
{
    partial class FormGestionarMesas
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
            this.dataGridViewMesas = new System.Windows.Forms.DataGridView();
            this.lblMesas = new System.Windows.Forms.Label();
            this.btnAsignarMesa = new System.Windows.Forms.Button();
            this.btnRealizarComanda = new System.Windows.Forms.Button();
            this.btnCerrarMesa = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMesas
            // 
            this.dataGridViewMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewMesas.Location = new System.Drawing.Point(48, 68);
            this.dataGridViewMesas.MultiSelect = false;
            this.dataGridViewMesas.Name = "dataGridViewMesas";
            this.dataGridViewMesas.RowHeadersVisible = false;
            this.dataGridViewMesas.RowHeadersWidth = 51;
            this.dataGridViewMesas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMesas.Size = new System.Drawing.Size(379, 401);
            this.dataGridViewMesas.TabIndex = 12;
            this.dataGridViewMesas.Tag = "166";
            // 
            // lblMesas
            // 
            this.lblMesas.AutoSize = true;
            this.lblMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesas.Location = new System.Drawing.Point(58, 30);
            this.lblMesas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesas.Name = "lblMesas";
            this.lblMesas.Size = new System.Drawing.Size(81, 26);
            this.lblMesas.TabIndex = 13;
            this.lblMesas.Tag = "167";
            this.lblMesas.Text = "Mesas";
            // 
            // btnAsignarMesa
            // 
            this.btnAsignarMesa.Location = new System.Drawing.Point(489, 68);
            this.btnAsignarMesa.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarMesa.Name = "btnAsignarMesa";
            this.btnAsignarMesa.Size = new System.Drawing.Size(162, 45);
            this.btnAsignarMesa.TabIndex = 14;
            this.btnAsignarMesa.Tag = "168";
            this.btnAsignarMesa.Text = "Asignar Mesa";
            this.btnAsignarMesa.UseVisualStyleBackColor = true;
            this.btnAsignarMesa.Click += new System.EventHandler(this.btnAsignarMesa_Click);
            // 
            // btnRealizarComanda
            // 
            this.btnRealizarComanda.Location = new System.Drawing.Point(489, 117);
            this.btnRealizarComanda.Margin = new System.Windows.Forms.Padding(2);
            this.btnRealizarComanda.Name = "btnRealizarComanda";
            this.btnRealizarComanda.Size = new System.Drawing.Size(162, 45);
            this.btnRealizarComanda.TabIndex = 15;
            this.btnRealizarComanda.Tag = "169";
            this.btnRealizarComanda.Text = "Realizar Comanda";
            this.btnRealizarComanda.UseVisualStyleBackColor = true;
            this.btnRealizarComanda.Click += new System.EventHandler(this.btnRealizarComanda_Click);
            // 
            // btnCerrarMesa
            // 
            this.btnCerrarMesa.Location = new System.Drawing.Point(489, 414);
            this.btnCerrarMesa.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarMesa.Name = "btnCerrarMesa";
            this.btnCerrarMesa.Size = new System.Drawing.Size(162, 45);
            this.btnCerrarMesa.TabIndex = 16;
            this.btnCerrarMesa.Tag = "170";
            this.btnCerrarMesa.Text = "Cerrar mesa";
            this.btnCerrarMesa.UseVisualStyleBackColor = true;
            this.btnCerrarMesa.Click += new System.EventHandler(this.btnSolicitarCuenta_Click);
            // 
            // FormGestionarMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 524);
            this.Controls.Add(this.btnCerrarMesa);
            this.Controls.Add(this.btnRealizarComanda);
            this.Controls.Add(this.btnAsignarMesa);
            this.Controls.Add(this.lblMesas);
            this.Controls.Add(this.dataGridViewMesas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGestionarMesas";
            this.Tag = "172";
            this.Text = "FormGestionarMesas";
            this.Load += new System.EventHandler(this.FormGestionarMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMesas;
        private System.Windows.Forms.Label lblMesas;
        private System.Windows.Forms.Button btnAsignarMesa;
        private System.Windows.Forms.Button btnRealizarComanda;
        private System.Windows.Forms.Button btnCerrarMesa;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}