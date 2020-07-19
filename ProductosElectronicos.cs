using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public  class ProductosElectronicos : Mercancia
    {
        public virtual string Nombre { get; set; }
        //Herencia
        public ProductosElectronicos() : base()
    {
        
    }
        //Metodos
        public virtual string Encendido()
        {
            return $"Encendida";
        }
        public virtual string Apagado()
        {
            return $"Apagado";
        }
    }
}
