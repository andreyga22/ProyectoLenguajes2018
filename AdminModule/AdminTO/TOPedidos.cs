using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminDAO
{
   public class TOPedidos
    {
        public DateTime fecha { get; set; }
        public String estado { get; set; }
        public int codigo { get; set; }
        public String email { get; set; }

        public TOPedidos()
        {

        }
    }
}
