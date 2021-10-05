using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clientes.Models
    {
    public class Cliente
        {
          public long ClienteID { get; set; }
          public string Nome { get; set; }
          public string endereco { get; set; }
        }
    }