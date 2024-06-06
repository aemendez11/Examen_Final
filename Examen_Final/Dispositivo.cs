namespace Examen_Final
{
    public class Dispositivo
    {
        public string Serie_Num{ get; set; }
        public string Marca{ get; set; }
        public string Modelo { get; set; }

        public Dispositivo()
        { 
            Serie_Num=string.Empty;
            Marca=string.Empty;
            Modelo=string.Empty;
        }
    }
}
