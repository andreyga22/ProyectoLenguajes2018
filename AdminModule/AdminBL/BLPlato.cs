using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminBL {
    public class BLPlato {
        private string nombre;
        private string descripcion;
        private double precio;
        private string fotografia;
        private int codigo;
        private Boolean estado;

        public string Nombre {
            get {
                return nombre;
            }
            set {
                if (!value.Equals("")) {
                    this.nombre = value;
                }
            }
        }
        public string Descripcion {
            get {
                return descripcion;
            }
            set {
                if (!value.Equals("")) {
                    this.descripcion = value;
                }
            }
        }
        public double Precio {
            get {
                return precio;
            }
            set {
                if (!(value <= 0)) {
                    this.precio = value;
                }
            }
        }
        //public string Nombre {
        //    get {
        //        return nombre;
        //    }
        //    set {
        //        if (!value.Equals("")) {
        //            this.nombre = value;
        //        }
        //    }
        //}
        //public string Nombre {
        //    get {
        //        return nombre;
        //    }
        //    set {
        //        if (!value.Equals("")) {
        //            this.nombre = value;
        //        }
        //    }
        //}
        //public string Nombre {
        //    get {
        //        return nombre;
        //    }
        //    set {
        //        if (!value.Equals("")) {
        //            this.nombre = value;
        //        }
        //    }
        //}
    }
}
