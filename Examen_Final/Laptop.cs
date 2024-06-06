using System.Globalization;

namespace Examen_Final
{
    public class Laptop:Dispositivo
    {
        public int Memoria_ram {  get; set; }
        public int Capacidad { get; set; }

        public Laptop() 
        {
            Memoria_ram = 0;
            Capacidad = 0;
        }
    }
}
