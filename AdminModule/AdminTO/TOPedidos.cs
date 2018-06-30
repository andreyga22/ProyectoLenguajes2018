using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminTO
{
   public class TOPedidos
    {
        public DateTime fecha { get; set; }
        public String estado { get; set; }
        public int codigo { get; set; }
        public String email { get; set; }
        public List<TODetallePedido> detalles { get; set; }

        public TOPedidos()
        {

        }
    }
}
