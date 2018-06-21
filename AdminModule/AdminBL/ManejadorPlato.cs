using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdminDAO;
using AdminTO;

namespace AdminBL {
    public class ManejadorPlato {
        public Boolean insertarPlato(BLPlato plato) {
            try {
                DAOPlato dao = new DAOPlato();
                TOPlato to = new TOPlato(plato.Nombre, plato.Descripcion, plato.Precio, plato.Fotografia, plato.Estado);
                return dao.agregarPlato(to);
            } catch (Exception ex) {
                throw ex;
            }
            
        }
    }
}
