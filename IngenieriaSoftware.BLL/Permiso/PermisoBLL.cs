﻿using IngenieriaSoftware.BEL;
using IngenieriaSoftware.DAL;
using IngenieriaSoftware.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngenieriaSoftware.BLL
{
    public class PermisoBLL 
    {
        private readonly Dictionary<int, List<Permiso>> _permisosPorUsuario = new Dictionary<int, List<Permiso>>();
    }

    
}
