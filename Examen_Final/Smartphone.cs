namespace Examen_Final
{
    public class Smartphone:Dispositivo
    {
        public string Sistema_Op {  get; set; }
        public int Num_cam {  get; set; }

        public Smartphone()
        {
            Sistema_Op = string.Empty;
            Num_cam = 0;
        }
    }
}
