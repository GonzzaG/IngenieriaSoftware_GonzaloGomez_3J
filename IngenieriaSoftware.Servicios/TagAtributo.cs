using System;

namespace IngenieriaSoftware.Servicios
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class TagAtributo : Attribute
    {
        public int Tag { get; }

        public TagAtributo(int tag)
        {
            Tag = tag;
        }
    }
}