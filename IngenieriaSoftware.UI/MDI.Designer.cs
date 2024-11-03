namespace IngenieriaSoftware.UI
{
    partial class MDI
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
            this.menuStripMDI = new System.Windows.Forms.MenuStrip();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionIdiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarEtiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTraduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutgestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesasToolStripMenuItem,
            this.cobrosToolStripMenuItem,
            this.comandasToolStripMenuItem,
            this.gestionUsuariosToolStripMenuItem,
            this.gestionIdiomasToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.LogOutgestionUsuariosToolStripMenuItem});
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Size = new System.Drawing.Size(1067, 28);
            this.menuStripMDI.TabIndex = 1;
            this.menuStripMDI.Text = "menuStrip1";
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.mesasToolStripMenuItem.Text = "Mesas";
            // 
            // cobrosToolStripMenuItem
            // 
            this.cobrosToolStripMenuItem.Name = "cobrosToolStripMenuItem";
            this.cobrosToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.cobrosToolStripMenuItem.Text = "Cobros";
            // 
            // comandasToolStripMenuItem
            // 
            this.comandasToolStripMenuItem.Name = "comandasToolStripMenuItem";
            this.comandasToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.comandasToolStripMenuItem.Text = "Comandas";
            this.comandasToolStripMenuItem.Click += new System.EventHandler(this.comandasToolStripMenuItem_Click);
            // 
            // gestionUsuariosToolStripMenuItem
            // 
            this.gestionUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.asignarPermisosToolStripMenuItem});
            this.gestionUsuariosToolStripMenuItem.Name = "gestionUsuariosToolStripMenuItem";
            this.gestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.gestionUsuariosToolStripMenuItem.Text = "Gestion Usuarios";
            this.gestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionUsuariosToolStripMenuItem_Click);
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // asignarPermisosToolStripMenuItem
            // 
            this.asignarPermisosToolStripMenuItem.Name = "asignarPermisosToolStripMenuItem";
            this.asignarPermisosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asignarPermisosToolStripMenuItem.Text = "Asignar Permisos";
            this.asignarPermisosToolStripMenuItem.Click += new System.EventHandler(this.asignarPermisosToolStripMenuItem_Click);
            // 
            // gestionIdiomasToolStripMenuItem
            // 
            this.gestionIdiomasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarEtiquetasToolStripMenuItem,
            this.agregarTraduccionToolStripMenuItem});
            this.gestionIdiomasToolStripMenuItem.Name = "gestionIdiomasToolStripMenuItem";
            this.gestionIdiomasToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.gestionIdiomasToolStripMenuItem.Text = "Gestion Idiomas";
            this.gestionIdiomasToolStripMenuItem.Click += new System.EventHandler(this.gestionIdiomasToolStripMenuItem_Click);
            // 
            // actualizarEtiquetasToolStripMenuItem
            // 
            this.actualizarEtiquetasToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.actualizarEtiquetasToolStripMenuItem.Name = "actualizarEtiquetasToolStripMenuItem";
            this.actualizarEtiquetasToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.actualizarEtiquetasToolStripMenuItem.Text = "Actualizar Etiquetas";
            this.actualizarEtiquetasToolStripMenuItem.Click += new System.EventHandler(this.actualizarEtiquetasToolStripMenuItem_Click);
            // 
            // agregarTraduccionToolStripMenuItem
            // 
            this.agregarTraduccionToolStripMenuItem.Name = "agregarTraduccionToolStripMenuItem";
            this.agregarTraduccionToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.agregarTraduccionToolStripMenuItem.Text = "Agregar Traduccion";
            this.agregarTraduccionToolStripMenuItem.Click += new System.EventHandler(this.agregarTraduccionToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // LogOutgestionUsuariosToolStripMenuItem
            // 
            this.LogOutgestionUsuariosToolStripMenuItem.Name = "LogOutgestionUsuariosToolStripMenuItem";
            this.LogOutgestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.LogOutgestionUsuariosToolStripMenuItem.Text = "Cerrar Sesion";
            this.LogOutgestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.LogOutgestionUsuariosToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStripMDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMDI;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDI";
            this.Text = "MDI";
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMDI;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionIdiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutgestionUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarEtiquetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTraduccionToolStripMenuItem;
    }
}