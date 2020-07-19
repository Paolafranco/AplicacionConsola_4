using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public abstract class GeneradorProductosTecnologicos
    {
        readonly Random random = new Random();

        public int Id { get; set; }
        public GeneradorProductosTecnologicos()
        {
            Id = random.Next();
        }

        public GeneradorProductosTecnologicos(int identificar)
        {
            Id = identificar;
        }

        public GeneradorProductosTecnologicos(string identificarCadena)
        {
            Id = Convert.ToInt32(identificarCadena);
        }

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

