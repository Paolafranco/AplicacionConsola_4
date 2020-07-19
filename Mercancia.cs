using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public abstract class Mercancia : GeneradorProductosTecnologicos
    {
        public virtual string Marca { get; set; }
        public virtual string Modelo { get; set; }
        public virtual string NombreMercancia { get; set; }
        public Cliente Persona { get; set; }
        public ProductosElectronicos Electronicos { get; set; }
      


        public Mercancia() : base()
        {
        }
    }
}