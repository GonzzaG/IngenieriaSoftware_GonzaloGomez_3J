using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Adaptadores
{
    public class ExcepcionesIdiomaAdaptador : ExcepcionTraducible ,IIdiomaObservador
    {
        //private readonly IdiomaSujeto _idiomaSujeto;

        public int Tag { get; set; }

        public ExcepcionesIdiomaAdaptador(int tag, string name) : base(tag, name)
        {
            Tag = tag;
         //   this.HelpLink = ObtenerMensajeTraducido();
        }

        public void Actualizar(string nuevoTexto)
        {
            if(IdiomaData.TagTraducciones.TryGetValue(this.Tag.ToString(), out var traduccion))
            {
                this.HelpLink = traduccion;
            }
        }

        public string ObtenerMensajeTraducido()
        {
            if(IdiomaData.TagTraducciones == null) { return this.Message; }
            if (IdiomaData.TagTraducciones.TryGetValue(this.Tag.ToString(), out string traduccion))
            {
                this.HelpLink = traduccion;
            }
            return this.HelpLink;
        }
    }
}


