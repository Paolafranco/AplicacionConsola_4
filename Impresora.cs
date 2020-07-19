using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public sealed class Impresora :  IComputadorasImpresoraPortatiles, IElectronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public object NombreProducto { get; private set; }

        public Impresora() : base()
        {
        }
        public  string Prender()
        {
            return $"La Impresora {this.NombreProducto}, {this.Modelo}, {this.Marca} está Prendida";
        }
        public static string Prender(string nombre)
        {
            return $"Los audifonos estan prendidos {nombre}";
        }
        public static string Imprimir()
        {
            return "";
        }

        public static string Escanear()
        {
            return "";
        }

        public static string Copiar()
        {
            return "";
        }

        public  string Apagar()
        {
            return $"Gracias, La Impresora {this.NombreProducto}, {this.Modelo}, {this.Marca} está Apagada";
        }
        public static string Apagar(string nombre)
        {
            return $"Los audifonos estan apagados {nombre}";
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

