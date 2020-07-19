using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Teclado : GeneradorProductosTecnologicos
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }

        //Metodos abtractos, y metodos selllados
        public virtual void Escribir(string nombre)
        {
        }

        public abstract class Computadora : Teclado
        {
            public abstract override void Escribir(string nombre);
        }

        public class F : Computadora
        {
            public override void Escribir(string nombre)
            {
            }
        }
        //Metodos
        public string Borrar()
        {
            return "Si, todo esta bien muchas gracias";
        }

        public string Enumerar()
        {
            return "";
        }

        public string CapturaPantalla()
        {
            return "";
        }
        public Teclado() : base()
        {
        }

    }
}
