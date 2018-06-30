using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdminTO;
using AdminDAO;

namespace AdminBL {
    public class ManejadorPlatos {
        public Boolean insertarPlato(BLPlato plato) {
            //try {
                return new DAOPlato().agregarPlato(convert(plato));
            //} catch (Exception ex) {
            //    throw ex;
            //}
        }



        public TOPlato convert(BLPlato blPlato) {
           return new TOPlato(blPlato.Nombre, blPlato.Descripcion, blPlato.Precio,blPlato.Fotografia, blPlato.Codigo, blPlato.Estado);
            
        }

        public BLPlato convert(TOPlato toPlato) {
            return new BLPlato(toPlato.Nombre, toPlato.Descripcion, toPlato.Precio, toPlato.Fotografia, toPlato.Codigo, toPlato.Estado);

        }

        public BLPlato buscarPlato(int cod) {
            return convert(new DAOPlato().buscarPlato(new TOPlato(cod)));
        }

        public Boolean borrarPlato(int cod) {
            return new DAOPlato().borrarPlato(Convert.ToInt32( cod));
        }

        public List<BLPlato> listaPlatos() {
            DAOPlato dao = new DAOPlato();
            List<TOPlato> listaTO = dao.listaPlatos();
            List<BLPlato> listaBL = new List<BLPlato>();
            foreach (TOPlato plato in listaTO) {
                listaBL.Add(convert(plato));
            }
            return listaBL;
        }
    }
}
