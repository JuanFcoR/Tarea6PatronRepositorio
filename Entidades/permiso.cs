﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class permiso
    {
        [Key]
        public int idpermiso { get; set; }
        public string descripcion { get; set; }
        public string funcionalidad { get; set; }
    }
}
