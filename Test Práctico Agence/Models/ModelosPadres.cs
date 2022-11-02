using System.ComponentModel.DataAnnotations;

namespace Test_Práctico_Agence.Models
{
    public class ModelosPadres { }

    public class Info_Usuario
    {
        public string Usuario_co { get; set; }

        public string Usuario_no { get; set; }
    }

    public class Info_Mes
    {
        public int Mes_Numero { get; set; }

        public string? Mes_Sigla { get; set; }

        public string? Mes_Nombre { get; set; }

    }

    public class Info_Periodos
    {
        public DateTime Periodo_Inicio { get; set; }

        public DateTime Periodo_Fin { get; set; }
    }

    public class Info_Monetario
    {
        public DateTime Monetario_Fecha { get; set; }

        public float Monetario_Recetaliquida { get; set; }

        public float Monetario_Comision { get; set; }
    }

    public class Info_Periodo
    {
        public string Periodo_Mes { get; set; }

        public float Periodo_Recetaliquida { get; set; }

        public float Periodo_Comision { get; set; }

        public float Periodo_Lucro { get; set; }

    }
    public class Data_Periodo
    {
        public int D_mes { get; set; }

        public int D_year { get; set; }
    }

    public class Info_Pie
    {
        public string Pie_Nombre { get; set; }

        public float Pie_Receta { get; set; }
    }
}
