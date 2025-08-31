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
            panelAviso.Size = new Size(300, 80);

            // Color celeste claro con opacidad
            panelAviso.BackColor = Color.FromArgb(200, 173, 216, 230); // 200 = alfa, RGB celeste claro

            panelAviso.Visible = false;

            // Bordes redondeados
            int radius = 15;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // esquina superior izquierda
            path.AddArc(panelAviso.Width - radius, 0, radius, radius, 270, 90); // superior derecha
            path.AddArc(panelAviso.Width - radius, panelAviso.Height - radius, radius, radius, 0, 90); // inferior derecha
            path.AddArc(0, panelAviso.Height - radius, radius, radius, 90, 90); // inferior izquierda
            path.CloseAllFigures();
            panelAviso.Region = new Region(path);

            // Centrar panel
            panelAviso.Left = (this.ClientSize.Width - panelAviso.Width) / 2;
            panelAviso.Top = (this.ClientSize.Height - panelAviso.Height) / 2;

            // Label con mensaje
            Label lblMensaje = new Label();
            lblMensaje.Text = "No se encontraron resultados.";
            lblMensaje.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;

            // Letras azul oscuro
            lblMensaje.ForeColor = Color.FromArgb(0, 0, 139); // RGB azul oscuro
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
