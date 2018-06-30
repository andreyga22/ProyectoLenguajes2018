using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdminTO;
using AdminBL;
namespace AdminBL
{
    public class ManagerDetallePedido
    {
        public TODetallePedido convert(BLDetallePedido BLPedidoD)
        {
            TODetallePedido pedidoD = new TODetallePedido();
            pedidoD.CANTIDAD_PRODUCTO = BLPedidoD.CANTIDAD_PRODUCTO;
            pedidoD.CODIGO_PEDIDO = BLPedidoD.CODIGO_PEDIDO;
            pedidoD.CODIGO_PLATO = BLPedidoD.CODIGO_PLATO;
            pedidoD.plato = new ManejadorPlatos().convert(BLPedidoD.plato);
            return pedidoD;
        }

        public BLDetallePedido convert(TODetallePedido TOPedidoD)
        {
            BLDetallePedido pedidoD = new BLDetallePedido();
            pedidoD.CANTIDAD_PRODUCTO = TOPedidoD.CANTIDAD_PRODUCTO;
            pedidoD.CODIGO_PEDIDO = TOPedidoD.CODIGO_PEDIDO;
            pedidoD.CODIGO_PLATO = TOPedidoD.CODIGO_PLATO;
            pedidoD.plato = new ManejadorPlatos().convert(TOPedidoD.plato);

            return pedidoD;
        }

    }
}
