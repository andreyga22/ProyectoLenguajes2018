using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminBL
{
    [Serializable]
    public class BLPedidos
    {
        public DateTime fecha { get; set; }
        public String estado { get; set; }
        public int codigo { get; set; }
        public String email { get; set; }
        public List<BLDetallePedido> detalles { get; set; } = new List<BLDetallePedido>();

        public BLPedidos()
        {

        }

    }
}
