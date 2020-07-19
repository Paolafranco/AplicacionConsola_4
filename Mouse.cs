using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public sealed class Mouse : GeneradorProductosTecnologicos
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }


        public Mouse() : base()
        {
        }

        public string MoverIzquierdo(string nombre)
        {
            return "Gracias Paola, por su compra";
        }
        public string MoverIzquierdo(int nombre)
        {
            return "";
        }


        public static string Subir()
        {
            return "Tu compra se ha guardado exitosamente";
        }
        public static string Bajar()
        {
            return "";
        }

    }
}

