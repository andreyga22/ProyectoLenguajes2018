using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdminBL {
    public class BLPlato {

        public BLPlato() { }

        public BLPlato(string nombre, string descripcion, double precio, string fotografia, int codigo, Boolean estado) {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Fotografia = fotografia;
            Codigo = codigo;
            Estado = estado;
        }

        public BLPlato(int codigo) {
            Nombre = "";
            Descripcion = "";
            Precio = 0;
            Fotografia = "";
            Codigo = codigo;
            Estado = false;
        }

        public BLPlato(string nombre, string descripcion, double precio, string fotografia, Boolean estado) {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Fotografia = fotografia;
            Estado = estado;
        }

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
        public string Fotografia {
            get {
                return fotografia;
            }
            set {
                if (!value.Equals("")) {
                    this.fotografia = value;
                }
            }
        }
        public int Codigo {
            get {
                return codigo;
            }
            set {
                if (!(value <= 0)) {
                    this.codigo = value;
                }
            }
        }
        public Boolean Estado{
            get {
                return estado;
            }
            set {
                estado = value;
            }
        }

        
    }
}
