using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_agendamento
    {
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_agendamento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_hr_inicio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_hr_fim { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long co_status_agendamento { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long co_diary_report_consultor { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long co_complemento { get; set; }
    }
}
