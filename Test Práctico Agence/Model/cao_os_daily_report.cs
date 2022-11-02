using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_os_daily_report
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_daily { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_os { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_fase { get; set; }
        [StringLength(50)]
        public string? co_usuario { get; set; }
        [Column(TypeName = "text")]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? ds_assunto { get; set; }
        [Column(TypeName = "time")]
        public TimeOnly? tempo_gasto { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? data { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_status_atual { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_chamado { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_atividade { get; set; }
    }
}
