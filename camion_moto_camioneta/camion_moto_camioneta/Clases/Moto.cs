using System;
namespace camion_moto_camioneta.Clases
{
    internal class Moto
    {
        public string Marca { get; }

        public int Modelo { get; }

        public string owner { get; set; }

        public String Color { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;

        public int MAXVELOCIDAD { get; }

        public Moto(string _marca, int _modelo, string _color, int maxvel, string luces, string caballito)
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
                return $"La moto esta apagada, asi no se puede usar mijo!";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += 10;
                mensaje = $"Esta es la velocidad de la moto {velocidad_actual} KPH";
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
                return $"La moto esta apagada mijo!";
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
            return $"Soy un moto marca {Marca} y mi modelo es {Modelo}";

        }

        public string Luces()
        {


            string mensaje = "";



            mensaje = "Acabas de encender las luces (altas)!";


            Console.WriteLine(mensaje);
            return mensaje;

        }
        public string caballito()
        {


            string mensaje = "";



            mensaje = "Levantaste la moto a una llanta!!";


            Console.WriteLine(mensaje);
            return mensaje;

        }
    }
}