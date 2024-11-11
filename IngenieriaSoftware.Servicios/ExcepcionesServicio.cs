using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.Servicios
{  
    public class ExcepcionesServicio
    {
        public IEnumerable<Type> ObtenerEtiquetas()
        {
            var excepcionesTipos = Assembly.GetExecutingAssembly()
              .GetTypes()
              .Where(t => t.IsSubclassOf(typeof(ExcepcionTraducible)) && !t.IsAbstract);
            return excepcionesTipos;
        }
    }
    [TagAtributo(200)]
    public class FalloCredencialesException : ExcepcionTraducible
    {
        public FalloCredencialesException() : base(200, "FalloCredencialesException") { }
    }

    [TagAtributo(201)]
    public class UsuarioNoEncontradoException : ExcepcionTraducible
    {
        public UsuarioNoEncontradoException() : base(201, "UsuarioNoEncontradoException") { }
    }

    [TagAtributo(202)]
    public class CredencialesCorrectasException : ExcepcionTraducible
    {
        public CredencialesCorrectasException() : base(202, "CredencialesCorrectasException") { }
    }
    [TagAtributo(203)]
    public class guaguExcepction : ExcepcionTraducible
    {
        public guaguExcepction() : base(203, "guaguExcepction") { }
    }
    [TagAtributo(204)]
    public class MesaNoDisponibleException : ExcepcionTraducible
    {
        public MesaNoDisponibleException() : base(204, "Esta mesa no se encuentra disponible.") { }
    }
    [TagAtributo(205)]
    public class MesaAsignadaException : ExcepcionTraducible
    {
        public MesaAsignadaException() : base(205, "Mesa asignada correctamente.") { }
    }
}
