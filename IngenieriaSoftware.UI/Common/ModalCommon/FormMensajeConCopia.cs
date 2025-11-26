using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;     

namespace IngenieriaSoftware.UI.Common.ModalCommon
{
    public partial class FormMensajeConCopia : Form
    {
        private Timer fadeTimer;
        private string Path;

        public FormMensajeConCopia(string path)
        {
            InitializeComponent();
            Path = path;
            txtContenido.Text = "Archivo exportado en:\r\n" + path;

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;

            // Fade start
            this.Opacity = 0;

            // Timer fade-in
            fadeTimer = new Timer();
            fadeTimer.Interval = 15;
            fadeTimer.Tick += FadeTimer_Tick;

            // Asociar eventos que el Designer no agregó
            this.Shown += FormMensajeConCopia_Shown;
            btnCerrar.Click += BtnCerrar_Click;
            btnCopiar.Click += BtnCopiar_Click;

            ConfigModal();

        }

        private void ConfigModal()
        {
            txtContenido.TabStop = false;
            txtContenido.Cursor = Cursors.Default;
            txtContenido.ShortcutsEnabled = false;
            txtContenido.Enabled = false;
            txtContenido.Enabled = false;
            txtContenido.BackColor = Color.FromArgb(0, 64, 64);
            txtContenido.ForeColor = Color.WhiteSmoke;
        }

        private void FormMensajeConCopia_Shown(object sender, EventArgs e)
        {
            // Aplicar bordes redondeados cuando ya hay tamaño real
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.07;
            else
                fadeTimer.Stop();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Path);

            btnCopiar.Text = "✔ Copiado";
            btnCopiar.BackColor = Color.DarkGreen;

            var t = new Timer();
            t.Interval = 1200;
            t.Tick += (s, _) =>
            {
                btnCopiar.Text = "Copiar";
                btnCopiar.BackColor = SystemColors.HotTrack;
                t.Stop();
            };
            t.Start();
        }

        // --- Bordes Redondeados ---
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Grosor del borde
            int borderThickness = 2;

            // Color del borde
            Color borderColor = Color.White;

            // Rectángulo del borde
            Rectangle rect = new Rectangle(
                0,
                0,
                this.Width - 1,
                this.Height - 1
            );

            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                pen.Alignment = PenAlignment.Inset;

                // Si querés que siga el redondeado del formulario
                int radius = 20;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
