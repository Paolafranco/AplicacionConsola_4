using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public sealed class Tablet : GeneradorProductosTecnologicos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public object NombreProducto { get; private set; }


        //Metodos estaticos y sobre carga de metodos
        public override string Prender()
        {
            return $"La Tablet{this.NombreProducto}, {this.Modelo}, {this.Marca} está {base.Prender()}";
        }
        public static string Prender(string nombre)
        {
            return $"La Tablet está prendida {nombre}";
        }
        public string Escribir()
        {
            return "";
        }
        public string Guardar()
        {
            return "";
        }

        public string Jugar()
        {
            return "";
        }

        public string Eliminar()
        {
            return "";
        }

        public string LLamar()
        {
            return "";
        }

        public string Contestar()
        {
            return "";
        }

        public string Colgar()
        {
            return "";
        }
        public Tablet() : base()
        {
        }
        public override string Apagar()
        {
            return $"Gracias, La Tablet{this.NombreProducto},{this.Modelo},{this.Marca} está {base.Apagar()}";
        }
        public static string Apagar(string nombre)
        {
            return $"La Tablet está apagados {nombre}";
        }

    }
}

