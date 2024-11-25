namespace IngenieriaSoftware.UI
{
    partial class FormMDI
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
            this.menuStripMDI = new System.Windows.Forms.MenuStrip();
            this.mesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandasCocinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandasAEntregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionIdiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarEtiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTraduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutgestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxIdiomas = new System.Windows.Forms.ComboBox();
            this.lblIdiomaActual = new System.Windows.Forms.Label();
            this.toolTipNotificacion = new System.Windows.Forms.ToolTip(this.components);
            this.asignarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gestionarPermisosToolStripMenuItem,
            this.gestionUsuariosToolStripMenuItem,
            this.gestionIdiomasToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.LogOutgestionUsuariosToolStripMenuItem});
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripMDI.Size = new System.Drawing.Size(1612, 28);
            this.menuStripMDI.TabIndex = 1;
            this.menuStripMDI.Tag = "1";
            this.menuStripMDI.Text = "menuStrip1";
            // 
            // mesasToolStripMenuItem
            // 
            this.mesasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarMesasToolStripMenuItem,
            this.aBMMesasToolStripMenuItem});
            this.mesasToolStripMenuItem.Name = "mesasToolStripMenuItem";
            this.mesasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.mesasToolStripMenuItem.Tag = "3";
            this.mesasToolStripMenuItem.Text = "Mesas";
            this.mesasToolStripMenuItem.Click += new System.EventHandler(this.mesasToolStripMenuItem_Click);
            // 
            // gestionarMesasToolStripMenuItem
            // 
            this.gestionarMesasToolStripMenuItem.Name = "gestionarMesasToolStripMenuItem";
            this.gestionarMesasToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.gestionarMesasToolStripMenuItem.Tag = "161";
            this.gestionarMesasToolStripMenuItem.Text = "Gestionar Mesas";
            this.gestionarMesasToolStripMenuItem.Click += new System.EventHandler(this.gestionarMesasToolStripMenuItem_Click);
            // 
            // aBMMesasToolStripMenuItem
            // 
            this.aBMMesasToolStripMenuItem.Name = "aBMMesasToolStripMenuItem";
            this.aBMMesasToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.aBMMesasToolStripMenuItem.Tag = "162";
            this.aBMMesasToolStripMenuItem.Text = "ABM Mesas";
            this.aBMMesasToolStripMenuItem.Click += new System.EventHandler(this.aBMMesasToolStripMenuItem_Click);
            // 
            // cobrosToolStripMenuItem
            // 
            this.cobrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarFacturarToolStripMenuItem,
            this.fToolStripMenuItem});
            this.cobrosToolStripMenuItem.Name = "cobrosToolStripMenuItem";
            this.cobrosToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.cobrosToolStripMenuItem.Tag = "4";
            this.cobrosToolStripMenuItem.Text = "Cobros";
            // 
            // generarFacturarToolStripMenuItem
            // 
            this.generarFacturarToolStripMenuItem.Name = "generarFacturarToolStripMenuItem";
            this.generarFacturarToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.generarFacturarToolStripMenuItem.Tag = "380";
            this.generarFacturarToolStripMenuItem.Text = "Generar Facturas";
            this.generarFacturarToolStripMenuItem.Click += new System.EventHandler(this.generarFacturarToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.fToolStripMenuItem.Tag = "163";
            this.fToolStripMenuItem.Text = "Ver Facturas";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // comandasToolStripMenuItem
            // 
            this.comandasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandasCocinaToolStripMenuItem,
            this.comandasAEntregarToolStripMenuItem});
            this.comandasToolStripMenuItem.Name = "comandasToolStripMenuItem";
            this.comandasToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.comandasToolStripMenuItem.Tag = "5";
            this.comandasToolStripMenuItem.Text = "Comandas";
            this.comandasToolStripMenuItem.Click += new System.EventHandler(this.comandasToolStripMenuItem_Click);
            // 
            // comandasCocinaToolStripMenuItem
            // 
            this.comandasCocinaToolStripMenuItem.Name = "comandasCocinaToolStripMenuItem";
            this.comandasCocinaToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.comandasCocinaToolStripMenuItem.Tag = "164";
            this.comandasCocinaToolStripMenuItem.Text = "Comandas Cocina";
            this.comandasCocinaToolStripMenuItem.Click += new System.EventHandler(this.comandasCocinaToolStripMenuItem_Click);
            // 
            // comandasAEntregarToolStripMenuItem
            // 
            this.comandasAEntregarToolStripMenuItem.Name = "comandasAEntregarToolStripMenuItem";
            this.comandasAEntregarToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.comandasAEntregarToolStripMenuItem.Tag = "566";
            this.comandasAEntregarToolStripMenuItem.Text = "Comandas a entregar";
            this.comandasAEntregarToolStripMenuItem.Click += new System.EventHandler(this.comandasAEntregarToolStripMenuItem_Click);
            // 
            // gestionarPermisosToolStripMenuItem
            // 
            this.gestionarPermisosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarPermisosToolStripMenuItem,
            this.gestionPermisosToolStripMenuItem,
            this.asignarRolToolStripMenuItem});
            this.gestionarPermisosToolStripMenuItem.Name = "gestionarPermisosToolStripMenuItem";
            this.gestionarPermisosToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.gestionarPermisosToolStripMenuItem.Text = "Gestionar Permisos";
            // 
            // asignarPermisosToolStripMenuItem
            // 
            this.asignarPermisosToolStripMenuItem.Name = "asignarPermisosToolStripMenuItem";
            this.asignarPermisosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asignarPermisosToolStripMenuItem.Tag = "385";
            this.asignarPermisosToolStripMenuItem.Text = "Asignar Permisos";
            this.asignarPermisosToolStripMenuItem.Click += new System.EventHandler(this.asignarPermisosToolStripMenuItem1_Click);
            // 
            // gestionPermisosToolStripMenuItem
            // 
            this.gestionPermisosToolStripMenuItem.Name = "gestionPermisosToolStripMenuItem";
            this.gestionPermisosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestionPermisosToolStripMenuItem.Text = "Gestion Roles";
            this.gestionPermisosToolStripMenuItem.Click += new System.EventHandler(this.gestionPermisosToolStripMenuItem_Click);
            // 
            // gestionUsuariosToolStripMenuItem
            // 
            this.gestionUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem});
            this.gestionUsuariosToolStripMenuItem.Name = "gestionUsuariosToolStripMenuItem";
            this.gestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.gestionUsuariosToolStripMenuItem.Tag = "6";
            this.gestionUsuariosToolStripMenuItem.Text = "Gestion Usuarios";
            this.gestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionUsuariosToolStripMenuItem_Click);
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registrarUsuarioToolStripMenuItem.Tag = "7";
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            this.registrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarUsuarioToolStripMenuItem.Tag = "8";
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // gestionIdiomasToolStripMenuItem
            // 
            this.gestionIdiomasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarEtiquetasToolStripMenuItem,
            this.agregarTraduccionToolStripMenuItem});
            this.gestionIdiomasToolStripMenuItem.Name = "gestionIdiomasToolStripMenuItem";
            this.gestionIdiomasToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.gestionIdiomasToolStripMenuItem.Tag = "10";
            this.gestionIdiomasToolStripMenuItem.Text = "Gestion Idiomas";
            this.gestionIdiomasToolStripMenuItem.Click += new System.EventHandler(this.gestionIdiomasToolStripMenuItem_Click);
            // 
            // actualizarEtiquetasToolStripMenuItem
            // 
            this.actualizarEtiquetasToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.actualizarEtiquetasToolStripMenuItem.Name = "actualizarEtiquetasToolStripMenuItem";
            this.actualizarEtiquetasToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.actualizarEtiquetasToolStripMenuItem.Tag = "11";
            this.actualizarEtiquetasToolStripMenuItem.Text = "Actualizar Etiquetas";
            this.actualizarEtiquetasToolStripMenuItem.Click += new System.EventHandler(this.actualizarEtiquetasToolStripMenuItem_Click);
            // 
            // agregarTraduccionToolStripMenuItem
            // 
            this.agregarTraduccionToolStripMenuItem.Name = "agregarTraduccionToolStripMenuItem";
            this.agregarTraduccionToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.agregarTraduccionToolStripMenuItem.Tag = "12";
            this.agregarTraduccionToolStripMenuItem.Text = "Agregar Traduccion";
            this.agregarTraduccionToolStripMenuItem.Click += new System.EventHandler(this.agregarTraduccionToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.estadisticasToolStripMenuItem.Tag = "13";
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // LogOutgestionUsuariosToolStripMenuItem
            // 
            this.LogOutgestionUsuariosToolStripMenuItem.Name = "LogOutgestionUsuariosToolStripMenuItem";
            this.LogOutgestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.LogOutgestionUsuariosToolStripMenuItem.Tag = "14";
            this.LogOutgestionUsuariosToolStripMenuItem.Text = "Cerrar Sesion";
            this.LogOutgestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.LogOutgestionUsuariosToolStripMenuItem_Click);
            // 
            // comboBoxIdiomas
            // 
            this.comboBoxIdiomas.FormattingEnabled = true;
            this.comboBoxIdiomas.Location = new System.Drawing.Point(1268, 4);
            this.comboBoxIdiomas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxIdiomas.Name = "comboBoxIdiomas";
            this.comboBoxIdiomas.Size = new System.Drawing.Size(208, 24);
            this.comboBoxIdiomas.TabIndex = 7;
            this.comboBoxIdiomas.Tag = "62";
            this.comboBoxIdiomas.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdiomas_SelectedIndexChanged_1);
            // 
            // lblIdiomaActual
            // 
            this.lblIdiomaActual.AutoSize = true;
            this.lblIdiomaActual.Location = new System.Drawing.Point(1129, 7);
            this.lblIdiomaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdiomaActual.Name = "lblIdiomaActual";
            this.lblIdiomaActual.Size = new System.Drawing.Size(88, 16);
            this.lblIdiomaActual.TabIndex = 9;
            this.lblIdiomaActual.Tag = "69";
            this.lblIdiomaActual.Text = "Idioma Actual";
            // 
            // asignarRolToolStripMenuItem
            // 
            this.asignarRolToolStripMenuItem.Name = "asignarRolToolStripMenuItem";
            this.asignarRolToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asignarRolToolStripMenuItem.Text = "Asignar Rol";
            this.asignarRolToolStripMenuItem.Click += new System.EventHandler(this.asignarRolToolStripMenuItem_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 785);
            this.Controls.Add(this.lblIdiomaActual);
            this.Controls.Add(this.comboBoxIdiomas);
            this.Controls.Add(this.menuStripMDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMDI;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMDI";
            this.Tag = "2";
            this.Text = "MDI";
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMDI;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionIdiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutgestionUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarEtiquetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTraduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrosToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxIdiomas;
        private System.Windows.Forms.Label lblIdiomaActual;
        private System.Windows.Forms.ToolStripMenuItem gestionarMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandasCocinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandasAEntregarToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipNotificacion;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarRolToolStripMenuItem;
    }
}