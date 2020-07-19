using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public sealed class Camaras : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public object NombreProducto { get; private set; }



        //Metodos estaticos y sobre carga de metodos
        public override string Prender()
        {
            return $"La Camara {this.NombreProducto}, {this.Modelo}, {this.Marca} está {base.Prender()}";
        }
        public static string Prender(string nombre)
        {
            return $"Los audifonos estan prendidos {nombre}";
        }
        public string Fotografiar()
        {
            return "";
        }

        public string Grabar()
        {
            return "";
        }
        //Constructor
        public Camaras() : base()
        {
        }
        public override string Apagar()
        {
            return $"La Camara {this.NombreProducto}, {this.Modelo}, {this.Marca}está {base.Apagar()}";
        }
        public static string Apagar(string nombre)
        {
            return $"Los audifonos estan apagados {nombre}";
        }
    }
}
