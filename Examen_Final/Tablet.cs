namespace Examen_Final
{
    public class Tablet:Dispositivo
    {
        public int Tamano { get; set; }
        public string Soporte { get; set; }

        public Tablet()
        {
            Tamano = 0;
            Soporte = string.Empty;
        }
    }
}
