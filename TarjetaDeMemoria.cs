using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public  class TarjetaDeMemoria : IElectronico
    {
        private string v;
        public string Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public virtual string Memoria { get; set; }


        public TarjetaDeMemoria() : base()
        {
        }

        public TarjetaDeMemoria(string v)
        {
            this.v = v;
        }

        public void Guardar(bool boton)
        {
            if (boton)
                Console.WriteLine("Tiene 64Gb");
            else
                Console.WriteLine("No tiene suficiente memoria para guardar");
        }

        public void Almacenar(bool boton)
        {
            if (boton)
                Console.WriteLine("Si Almacena");
            else
                Console.WriteLine("No Almacena");
        }

        public void Recibir(string boton)
        {
            throw new NotImplementedException();
        }

        public void Cambiar(string boton)
        {
            throw new NotImplementedException();
        }

        public void AlmacenInfor1(string boton)
        {
            throw new NotImplementedException();
        }
    }
}


