using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class TagAtributo:Attribute
    {
        public int Tag { get; }

        public TagAtributo(int tag)
        {
            Tag = tag;
        }
    }
}
