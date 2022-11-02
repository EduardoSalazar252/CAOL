using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_obs_sistema
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_obs { get; set; }
        [Column(TypeName = "text")]
        public string? descricao { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long? co_sistema { get; set; }
        [StringLength(20)]
        public string? co_usuario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_obs { get; set; }
    }
}
