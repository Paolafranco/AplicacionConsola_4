using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacionDeber
{
    public class Cliente : GeneradorProductosTecnologicos
    {
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }


        public string NombreCli2 { get; set; }
        public string ApellidoCli2 { get; set; }


        public Cliente() : base()
        {

        }
        public Cliente(string nombre, string apellido) : base()
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        
        private Celular celular;
        public Celular Celular
        {
            get { return celular; }
            set
            {
                celular = value;
            }
        }
        

        private Computadora computadora;
        public Computadora Computadora
        {
            get { return computadora; }
            set
            {
                computadora = value;
            }
        }

        private Teclado teclado;
        public Teclado Teclado
        {
            get { return teclado; }
            set
            {
                teclado = value;
            }
        }
        private Mouse mouse;
        public Mouse Mouse
        {
            get { return mouse; }
            set
            {
                mouse = value;
            }
        }
        private DiscoDuro discoDuro;
        public DiscoDuro DiscoDuro
        {
            get { return discoDuro; }
            set
            {
                discoDuro = value;
            }
        }
        private TarjetaDeMemoria tarjetaDeMemoria;
        public TarjetaDeMemoria TarjetaDeMemoria
        {
            get { return tarjetaDeMemoria; }
            set
            {
                tarjetaDeMemoria = value;
            }
        }
        private Tablet tablet;
        public Tablet Tablet
        {
            get { return tablet; }
            set
            {
                tablet = value;
            }
        }
        private Parlantes parlantes;
        public Parlantes Parlantes
        {
            get { return parlantes; }
            set
            {
                parlantes = value;
            }
        }
        private Impresora impresora;
        public Impresora Impresora
        {
            get { return impresora; }
            set
            {
                impresora = value;
            }
        }
        private Camaras camaras;
        public Camaras Camaras
        {
            get { return camaras; }
            set
            {
                camaras = value;
            }
        }
        private Audifonos audifonos;
        public Audifonos Audifonos
        {
            get { return audifonos; }
            set
            {
                audifonos = value;
            }
        }


        //Metodos
        public string Saludar(Cliente comprador)
        {
            return $"Hola, me llamo {NombreCli2} {Apellido} soy tu ascesora.";
        }
        public string OfrecerProductos(Cliente comprador)
        {
            return $"Gracias, {Nombre} {Apellido} desea solo los productos que estan en caja o en que más le puedo ayudar?";
        }
        public string IndicarTablet()
        {
            return $"Una Tablet, Modelo: {Tablet.Modelo} y su id es {Computadora.Id}";
        }
        public string IndicarParlantes()
        {
            return $"Un Parlante, Modelo: {Parlantes.Modelo} y su id es {Computadora.Id}";
        }
        public string IndicarImpresora()
        {
            return $"Una Impresora, Modelo: {Impresora.Modelo} y su id es {Computadora.Id}";
        }
        public string IndicarCamaras()
        {
            return $"Una Camara, Modelo: {Camaras.Modelo} y su id es {Computadora.Id}";
        }
        public string IndicarAudifonos()
        {
            return $"Un Audifono, Modelo: {Audifonos.Modelo} y su id es {Computadora.Id}";
        }

        public string Pedir(string Cliente, ProductosElectronicos productosElectronicos)
        {
            return $"Si, Me interesa llevarme tambien estos productos pero quisiera probar la Computadora: {Computadora.Marca}, el Celular: {Celular.Modelo} y la Tablet:{Tablet.Marca}, por favor";
        }

    }
}
    


