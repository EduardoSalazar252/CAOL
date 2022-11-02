using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    /// <summary>
    /// contem informacoes referentes a agendamento, visita, elabora
    /// </summary>
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_diary_report_consultor
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_diary_report_consultor { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_movimento { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_atividade { get; set; }
        [Column(TypeName = "mediumtext")]
        public string ds_empresa { get; set; } = null!;
        [Column(TypeName = "mediumtext")]
        public string ds_assunto { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime dt_agendamento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_agendamento_fim { get; set; }
        [Column(TypeName = "float unsigned")]
        public float vl_fechamento { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long? co_cliente { get; set; }
    }
}
