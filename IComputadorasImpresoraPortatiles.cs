using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    interface IComputadorasImpresoraPortatiles
    {
        void Marca(string marca);
        void Modelo(string modelo);
        void Precio(int precio);

        public virtual string Prender()
        {
            return "está prendido";
        }

        public virtual string Apagar()
        {
            return "está apagado";
        }

    }
}
