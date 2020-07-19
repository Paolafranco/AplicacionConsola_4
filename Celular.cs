using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AplicacionDeber
{
    public class Celular : GeneradorProductosTecnologicos, IElectronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public virtual string Color { get; set; }
        public float Precio { get; set; }
        public object NombreProducto { get; private set; }
        public virtual string Eliminar { get; set; }

         void IElectronico.AlmacenInfor1(string boton)
        {
            Console.WriteLine("El Celular Xiaomi está disponible en color rojo");
        }

        public void Cambiar(string boton)
        {
            throw new NotImplementedException();
        }

        //Metodos estaticos, this y sobre carga de metodos
        public override string Prender()
        {
            return $"El Celular {this.NombreProducto}, {this.Modelo}, {this.Marca} está {base.Prender()}";
        }
        public static string Prender(string nombre)
        {
            return $"El Celular está Prendido {nombre}";
        }
        public string Escribir()
        {
            return "";
        }

        public string LLamar()
        {
            return "";
        }
        public string Colgar()
        {
            return "";
        }

        public string Guardar()
        {
            return "";
        }

       

        public Celular() : base()
        {
        }
        public override string Apagar()
        {
            return $"Gracias, El Celular {this.NombreProducto}, {this.Modelo}, {this.Marca} está {base.Apagar()}";
        }
        public static string Apagar(string nombre)
        {
            return $"Los audifonos estan apagados {nombre}";
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

    }
}
