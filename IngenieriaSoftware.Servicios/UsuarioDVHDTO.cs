using IngenieriaSoftware.Abstracciones;
using IngenieriaSoftware.BEL;

namespace IngenieriaSoftware.Servicios
{
    public class UsuarioDVHDTO : IEntity, IVerificable
    {
        public string DVH { get; set; }
        public int Id { get; set; }

        public string getNombreTabla()
        {
            return TablesName.Usuario;
        }

        public bool VerificarIntegridad(string dvhBD)
        {
            return DVH == dvhBD;
        }
    }
}