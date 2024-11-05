using IngenieriaSoftware.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public class ControlesHelper
    {
        public static List<EtiquetaDTO> ObtenerEtiquetas(Control.ControlCollection controles)
        {
            var etiquetas = new List<EtiquetaDTO>();
            ObtenerEtiquetasRecursivo(controles, etiquetas);
            return etiquetas;
        }

        private static void ObtenerEtiquetasRecursivo(Control.ControlCollection controles, List<EtiquetaDTO> etiquetas)
        {
            // Recorrer todos los controles en el formulario
            foreach (Control c in controles)
            {
                // Comprobar que el Tag sea un entero y el Name no sea nulo o vacío
                if (Convert.ToInt32(c.Tag) is int etiquetaId && !string.IsNullOrEmpty(c.Name))
                {
                    etiquetas.Add(new EtiquetaDTO
                    {
                       // Id = etiquetaId,
                        Nombre = c.Name,
                        Tag = (int)c.Tag
                    });
                }

                // Si el control tiene hijos, recorrerlos recursivamente
                ObtenerEtiquetasRecursivo(c.Controls, etiquetas);
            }
        }

        #region Tagsablecer el Tag de cada control en función de su Nombre

        public static void EstablecerTags(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Método para est
                if (c.HasChildren)
                {
                    EstablecerTags(c);
                }

                c.Tag = c.Name;
            }
        }

        public static void AsignarEtiquetaIdsAControles(Control form, List<EtiquetaDTO> etiquetasBD)
        {
            foreach (Control control in form.Controls)
            {
                // Aquí asumimos que cada control tiene su nombre configurado
                if (!string.IsNullOrEmpty(control.Name))
                {
                    // Busca la etiqueta correspondiente en la lista de etiquetas de la BD
                    EtiquetaDTO etiqueta = etiquetasBD.FirstOrDefault(e => e.Nombre.Equals(control.Name, StringComparison.OrdinalIgnoreCase));
                    if (etiqueta != null)
                    {
                        control.Tag = etiqueta.Tag; // Asignar el etiqueta_id al Tag del control
                    }
                }

                // Llamada recursiva para controles que contienen otros controles
                if (control.HasChildren)
                {
                    AsignarEtiquetaIdsAControles(form, etiquetasBD);
                }
            }
        }

        #endregion Tagsablecer el Tag de cada control en función de su Nombre

  

    }
}