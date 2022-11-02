using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_diary_report
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_diary_report { get; set; }
        [Column(TypeName = "time")]
        public TimeOnly? hr_gasta { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_atividade { get; set; }
        public string ds_assunto { get; set; } = null!;
        [Column(TypeName = "bigint(20)")]
        public long co_movimento { get; set; }
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong? nu_os { get; set; }
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong? co_sistema { get; set; }
    }
}
