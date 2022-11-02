namespace Test_Práctico_Agence.Models
{
    public class ModelosHijos { }

    public class Data_Usuario
    {
        public Info_Usuario D_usuario { get; set; }

        public float D_custofijo { get; set; }

        public List<Info_Periodo> D_monetario { get; set; }
    }
}
