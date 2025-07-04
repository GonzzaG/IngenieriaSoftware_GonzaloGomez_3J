﻿using IngenieriaSoftware.Servicios;
using IngenieriaSoftware.Servicios.Interfaces;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IngenieriaSoftware.UI
{
    public class ControlIdiomaAdaptador : IIdiomaObservador
    {
        private readonly Control _control;

        public int Tag { get; set; }
        public string Name { get; set; }

        public ControlIdiomaAdaptador(Control control)
        {
            _control = control;
            Tag = int.Parse(control.Tag?.ToString() ?? "0"); // Asume que el Tag del control contiene el ID de traducción
        }

        public void Actualizar(string nuevoTexto)
        {
            if (Regex.IsMatch(_control.Name, @"(comboBox|txt)", RegexOptions.IgnoreCase))
            {
                if (Regex.IsMatch(_control.Name, @"(Idioma)", RegexOptions.IgnoreCase))
                {
                    _control.Text = IdiomaData.IdiomaActual.Nombre;
                }
            }
            else
            {
                _control.Text = nuevoTexto;
            }
        }
    }
}