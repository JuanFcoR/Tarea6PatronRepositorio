﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6JuanFcoR.Entidades
{
    public class tipopersona
    {
        [Key]
        public int idtipopersona { get; set; }
        public string nombre { get; set; }
    }
}
