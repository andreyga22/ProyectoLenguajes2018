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

        public List<BLPedidos> listaPedidosCocina()
        {
            List<TOPedidos> listaTO = new DAOPedidos().listaPedidos();
            List<BLPedidos> listaBL = new List<BLPedidos>();

            for (int i = 0; i < listaTO.Count(); i++)
            {
                if (!listaTO[i].estado.Equals("Anulado") && !listaTO[i].estado.Equals("Entregado"))
                {
                    listaBL.Add(convert(listaTO[i]));
                }
                
            }

            return listaBL;
        }

        public String pedidoDetalle(List<BLDetallePedido> lista)
        {
            String lis = "";

            for (int i = 0; i < lista.Count;i++)
            {
                lis += "*-" + lista[i].CANTIDAD_PRODUCTO + " " + lista[i].plato.Nombre + " " + lista[i].plato.Codigo + "<br/>";
            }

            return lis;
        }

        public List<BLPedidos> listaPedidosFiltradaEstado(List<BLPedidos> listaBL, String estado)
        {
            List<BLPedidos> listaBLFill = new List<BLPedidos>();
            for (int i = 0; i < listaBL.Count(); i++)
            {
                
                if (estado != String.Empty && listaBL[i].estado.Equals(estado))
                {
                    listaBLFill.Add(listaBL[i]);
                }
               
            }

            return listaBLFill;
        }

        public List<BLPedidos> listaPedidosFiltradaEmail(List<BLPedidos> listaBL, String email)
        {
            List<BLPedidos> listaBLFill = new List<BLPedidos>();
            for (int i = 0; i < listaBL.Count(); i++)
            {

                if (email != String.Empty && listaBL[i].email.Equals(email))
                {
                    listaBLFill.Add(listaBL[i]);
                }
                
            }

            return listaBLFill;
        }

        public List<BLPedidos> listaPedidosFiltradaFecha(List<BLPedidos> listaBL,DateTime inicio,DateTime fin)
        {
            List<BLPedidos> listaBLFill = new List<BLPedidos>();
            for (int i = 0; i < listaBL.Count(); i++)
            {

                if (inicio != null && fin != null && listaBL[i].fecha.CompareTo(inicio) >= 0 && listaBL[i].fecha.CompareTo(fin) <= 0)
                {
                    listaBLFill.Add(listaBL[i]);
                }

            }

            return listaBLFill;
        }



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
