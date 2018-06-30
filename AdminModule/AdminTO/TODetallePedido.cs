using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminTO
{
    public class TODetallePedido
    {

        public int CODIGO_PEDIDO { get; set; }
        public int CODIGO_PLATO { get; set; }
        public int CANTIDAD_PRODUCTO { get; set; }
        public TOPlato plato { get; set; }
        public TODetallePedido()
        {

        }

    }
}
