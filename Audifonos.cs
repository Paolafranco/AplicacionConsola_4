using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public sealed class Audifonos : GeneradorProductosTecnologicos
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public object NombreProducto { get; private set; }


        //Metodos estaticos y sobre carga de metodos
        public override string Prender()
        {
            return $"Los Audifonos {this.NombreProducto},{this.Modelo},{this.Marca}están {base.Prender()}";
        }
        public static string Prender(string nombre)
        {
            return $"Los audifonos estan prendidos {nombre}";
        }
        public string Contestar()
        {
            return "";
        }
        public static string Escuchar()
        {
            return "";
        }

        public static string Hablar()
        {
            return "";
        }

        public static string SubirVolumen()
        {
            return "";
        }

        public static string BajarVolumen()
        {
            return "";
        }

        public static string Colgar()
        {
            return "";
        }
        public Audifonos() : base()
        {
        }
        public override string Apagar()
        {
            return $"Gracias, Los Audifonos {this.NombreProducto}, {this.Modelo}, {this.Marca} están {base.Apagar()}";
        }
        public static string Apagar(string nombre)
        {
            return $"Los audifonos estan apagados {nombre}";
        }

    }
}


