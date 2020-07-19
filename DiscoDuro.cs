using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
   
    public class DiscoDuro 
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public virtual string Memoria { get; set; }
        public virtual string Color { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }


        public string Almacenar(string nombre)
        {
            return "";
        }

        public string GuardaInfor()
        {
            return "";
        }

        public string Registrar()
        {
            return "";
        }

        public string EliminaInfor()
        {
            return "";
        }

        public DiscoDuro() : base()
        {
        }

        public DiscoDuro(string identificarCadena) : base()
        {
        }
    }
}

