using System;

namespace IngenieriaSoftware.Abstracciones
{
    public class VerificableAttribute : Attribute
    {
        private string _prefix;

        public VerificableAttribute(string prefix)
        {
            _prefix = prefix;
        }

        public string Prefix
        { get { return _prefix; } }
    }
}