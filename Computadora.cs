using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public  class Computadora : IComputadorasImpresoraPortatiles, IElectronico
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public object NombreProducto { get; private set; }

        public Computadora() : base()
        {
        }


        //Metodos estaticos y sobre carga de metodos
        public  string Prender()
        {
            return $"La Computadora {this.NombreProducto}, {this.Modelo}, {this.Marca} está Prendida";
        }
        public static string Prender(string nombre)
        {
            return $"Los audifonos estan prendidos {nombre}";
        }
        //Metodos abtractos, y metodos selllados
        public virtual void Escribir(string nombre)
        {
        }

        public abstract class Teclado : Computadora
        {
            public abstract override void Escribir(string nombre);
        }

        public class F : Teclado
        {
            public override void Escribir(string nombre)
            {
            }
        }


        public void Guardar(bool boton)
        {
            throw new NotImplementedException();
        }

        public void Almacenar(bool boton)
        {
            throw new NotImplementedException();
        }

        public void Recibir(string boton)
        {
            throw new NotImplementedException();
        }

        public string Eliminar()
        {
            return "";
        }


        public  string Apagar()
        {
            return $"Gracias, La Computadora {this.NombreProducto}, {this.Modelo}, {this.Marca} está Apagada";
        }
        public static string Apagar(string nombre)
        {
            return $"La computadora estan apagados {nombre}";
        }

        void IComputadorasImpresoraPortatiles.Marca(string marca)
        {
            throw new NotImplementedException();
        }

        void IComputadorasImpresoraPortatiles.Modelo(string modelo)
        {
            throw new NotImplementedException();
        }

        void IComputadorasImpresoraPortatiles.Precio(int precio)
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
