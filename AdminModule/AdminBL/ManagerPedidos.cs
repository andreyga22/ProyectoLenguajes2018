using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdminDAO;
using AdminTO;
namespace AdminBL
{
    public class ManagerPedidos {

        public void EliminarPedidos(BLPedidos pedido)
        {
            new DAOPedidos().EliminarPedido(convert(pedido));
        }

        public BLPedidos ConsultarPedidos(String id)
        {
            return convert(new DAOPedidos().ConsultarPedido(id));
        }

        public void EditarPedidos(BLPedidos pedido)
        {
            new DAOPedidos().EditarPedido(convert(pedido));
        }

        public void InsertarPedidos(BLPedidos pedido)
        {
            new DAOPedidos().InsertarPedido(convert(pedido));
        }

        public List<BLPedidos> listaPedidos()
        {
            List<TOPedidos> listaTO = new DAOPedidos().listaPedidos();
            List<BLPedidos> listaBL = new List<BLPedidos>();

            for (int i = 0; i < listaTO.Count(); i++)
            {
                listaBL.Add(convert(listaTO[i]));
            }

            return listaBL;
        }

        //public List<BLPedidos> listaPedidosFiltrada(String email, String estado, DateTime fechaInicio, DateTime fechaFinal) {
        //    List<TOPedidos> listaTO = new DAOPedidos().listaPedidos();
        //    List<BLPedidos> listaBL = new List<BLPedidos>();

        //    for (int i = 0; i < listaTO.Count(); i++)
        //    {
        //        if ()
        //        {

        //        }
        //        if ()
        //        {

        //        }
        //        if ()
        //        {

        //        }
        //        listaBL.Add(convert(listaTO[i]));
        //    }

        //    return listaBL;
        //}



        public TOPedidos convert(BLPedidos BLPedido)
        {
            TOPedidos pedido = new TOPedidos();
            pedido.codigo = BLPedido.codigo;
            pedido.email = BLPedido.email;
            pedido.estado = BLPedido.estado;
            pedido.fecha = BLPedido.fecha;
            pedido.detalles = convert(BLPedido.detalles);
            return pedido;
        }

        public BLPedidos convert(TOPedidos TOPedido)
        {
            BLPedidos pedido = new BLPedidos();
            pedido.codigo = TOPedido.codigo;
            pedido.email = TOPedido.email;
            pedido.estado = TOPedido.estado;
            pedido.fecha = TOPedido.fecha;
            pedido.detalles = convert(TOPedido.detalles);
            return pedido;
        }

        public List<BLDetallePedido> convert(List<TODetallePedido> lista)
        {
            List<BLDetallePedido> listaN = new List<BLDetallePedido>();

            for (int i = 0; i < lista.Count; i++)
            {
                listaN.Add(new ManagerDetallePedido().convert(lista[i]));
            }

            return listaN;
        }

        public List<TODetallePedido> convert(List<BLDetallePedido> lista)
        {
            List<TODetallePedido> listaN = new List<TODetallePedido>();

            for (int i = 0; i < lista.Count; i++)
            {
                listaN.Add(new ManagerDetallePedido().convert(lista[i]));
            }
           

            return listaN;
        }

    }
}
