using IngenieriaSoftware.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.ControlesPersonalizados.panelCustom
{
    public partial class PanelNoResultado : UserControl
    {
        public PanelNoResultado()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
                InicializarPanelAviso();
            
        }

        /// <summary>
        /// Inicializa el panel
        /// </summary>
        private void InicializarPanelAviso()
        {
            panelAviso = new Panel();
            panelAviso.Size = new Size(220, 60);
            this.Size = new Size(225, 65);
            // Color celeste claro con opacidad
            panelAviso.BackColor = Color.FromArgb(200, 173, 216, 230); // alfa + RGB

            panelAviso.Visible = false;

            // Bordes redondeados
            int radius = 10;
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(panelAviso.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(panelAviso.Width - radius, panelAviso.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, panelAviso.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                panelAviso.Region = new Region(path);
            }

            // Centrar panel dentro del control
            panelAviso.Left = (this.ClientSize.Width - panelAviso.Width) / 2;
            panelAviso.Top = (this.ClientSize.Height - panelAviso.Height) / 2;

            // Label con mensaje
            Label lblMensaje = new Label();
            lblMensaje.Text = "No se encontraron\nresultados.";
            lblMensaje.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.ForeColor = Color.FromArgb(0, 0, 139); // Azul oscuro
            lblMensaje.Dock = DockStyle.Fill;

            panelAviso.Controls.Add(lblMensaje);
            this.Controls.Add(panelAviso);

            MostrarNoResultado(false);
        }
    


        /// <summary>
        /// Metodo que muestra u oculta el mensaje de que no hubo resultados segun el parametro.
        ///     <example>
        ///         Se utiliza en la grillas cuando se quiere mostrar u ocultar el mensaje, segun llegue o no resultados 
        ///     </example>
        /// </summary>
        /// <param name="mostrar"></param>
        public void MostrarNoResultado(bool mostrar)
        {
            panelAviso.Visible = mostrar;

            if (mostrar)
            {
                this.BringToFront();
                panelAviso.BringToFront();
            }
            else
            {
                this.SendToBack();
                panelAviso.SendToBack();
            }
        }

    }
}
