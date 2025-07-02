using IngenieriaSoftware.BEL.Proveedor;
using IngenieriaSoftware.DAL.Proveedores;
using System;
using System.Collections.Generic;

namespace IngenieriaSoftware.BLL.Proveedores
{
    public class ProveedorBussiness
    {
        ProveedorDataAccess _proveedorRepository;
        public ProveedorBussiness()
        {
            _proveedorRepository = new ProveedorDataAccess();
        }
        public List<Proveedor> GetAll()
        {
            var proveedores = _proveedorRepository.GetAll();

            return proveedores;
        }
        public Proveedor GetById(int proveedorId)
        {
            var proveedor = _proveedorRepository.GetById(proveedorId);

            return proveedor;
        }

        /// <summary>
        /// Realiza un update o un insert, dependiendo de si tiene un Id asignado o no
        /// </summary>
        /// <param name="proveedor"></param>
        /// <returns></returns>
        public int Save(Proveedor proveedor)
        {
            if (proveedor == null)
                throw new Exception("El proveedor no puede ser nulo");

            int output = _proveedorRepository.Save(proveedor);

            return output;
        }

        public void DeleteById(int Id)
        {
            if (Id == 0) throw new Exception("El proveedor no es valido");
            _proveedorRepository.DeleteById(Id);
        }
    }
}
