using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Empresa : GeneradorProductosTecnologicos
    {
        public string Nombre { get; set; }


        public Empresa() : base()
        { }

        public Empresa(int id) : base(id)
        { }

        public Empresa(string id) : base(id)
        { }

        public Celular RealizarCell(string modelo)
        {
            return new Celular()
            {
                Marca = Nombre,
                Modelo = modelo
            };
        }
        public Teclado RealizarTeclado(string modelo)
        {
            // TODO : Materias primas?
            // TODO : Desperdicios?

            return new Teclado()
            {
                Marca = Nombre,
                Modelo = modelo
            };
        }

        public Computadora RealizarCompu(string marca, string modelo, int precio)
        {
            return new Computadora { Marca = marca, Modelo = modelo, Precio = precio };
        }
       
            
        public Mouse RealizarMouse(string marca, string modelo, int precio)
        {

            return new Mouse { Marca = marca, Modelo = modelo, Precio = precio };
        }
        public DiscoDuro RealizarDiscoDuro(string marca, string modelo, int precio)
        {

            return new DiscoDuro { Marca = marca, Modelo = modelo, Precio = precio };
        }
        public TarjetaDeMemoria RealizarTarjetaDeMemoria(string marca, string modelo, int precio)
        {

            return new TarjetaDeMemoria { Marca = marca, Modelo = modelo, Precio = precio };
        }
        public Tablet RealizarTablet(string marca, string modelo, int precio)
        {

            return new Tablet { Marca = marca, Modelo = modelo, Precio = precio };
        }
        public Parlantes RealizarParlantes(string marca, string modelo, int precio)
        {

            return new Parlantes { Marca = marca, Modelo = modelo, Precio = precio };
        }
        public Impresora RealizarImpresora(string marca, string modelo, int precio)
        {

            return new Impresora { Marca = marca, Modelo = modelo, Precio = precio };
        }
        public Camaras RealizarCamaras(string marca, string modelo, int precio)
        {

            return new Camaras { Marca = marca, Modelo = modelo, Precio = precio };
        }
        public Audifonos RealizarAudifonos(string marca, string modelo, int precio)
        {

            return new Audifonos { Marca = marca, Modelo = modelo, Precio = precio };
        }
        
    }
}
