using System;

namespace compartida.Modelo
{
    public class Equipos
    {
        public String Nombre { get; set; }
        public String Ip { get; set; }

        public Equipos(String Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
