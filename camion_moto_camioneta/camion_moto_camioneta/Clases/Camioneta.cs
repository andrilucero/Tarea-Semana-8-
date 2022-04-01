using System;
namespace camion_moto_camioneta.Clases
{
    internal class Camioneta
    {
        public string Marca { get; }

        public int Modelo { get; }

        public string owner { get; set; }

        public String Color { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;

        public int MAXVELOCIDAD { get; }

        public Camioneta(string _marca, int _modelo, string _color, int maxvel, string luces, string abrirpuerta, string radio)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Encendido = 0;
            MAXVELOCIDAD = maxvel;
            this.velocidad_actual = 0;
        }

        public string acelerar()
        {
            if (Encendido == 0)
            {
                return $"La camioneta esta apagada, asi no se puede usar mijo!";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += 10;
                mensaje = $"Esta es la velocidad de la camioneta {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = "Hey calmala vas muy rapido!!!";
            }

            return mensaje;
        }

        public string acelerar(int AcekerarAkph)
        {
            if (Encendido == 0)
            {
                return $"La camioneta esta apagada mijo!";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += AcekerarAkph;
                mensaje = $"La moto va a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = "Calmado viejo porque ni licencia tenes!";
            }

            return mensaje;
        }

        public int GetVelocidadActual()
        {
            return velocidad_actual;
        }

        public String DameInformacion()
        {
            return $"Soy una camioneta marca {Marca} y mi modelo es {Modelo}";

        }

        public string Luces()
        {


            string mensaje = "";



            mensaje = "Acabas de encender las luces (altas)!";


            Console.WriteLine(mensaje);
            return mensaje;

        }
        public string abrirpuerta()
        {


            string mensaje = "";



            mensaje = "Acabas de abrir la puerta automaticamente!";


            Console.WriteLine(mensaje);
            return mensaje;

        }
        public string radio()
        {


            string mensaje = "";



            mensaje = "Acabas de poner una rolonas en la radio!! WUUU!";


            Console.WriteLine(mensaje);
            return mensaje;

        }
    }
}
    