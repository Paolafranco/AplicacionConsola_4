using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    interface IElectronico
    {
        void Guardar(bool boton);
        void Almacenar(bool boton);
        void Recibir(string boton);
        void Cambiar(string boton);
        void AlmacenInfor1(string boton);
    }
}
