using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_movimento_os
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_movimento_os { get; set; }
        [Column(TypeName = "int(11)")]
        public int nu_os { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long co_sistema { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long? co_tipo_movimento { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long? nu_valor { get; set; }
        public string? ds_valor { get; set; }
        [StringLength(30)]
        public string? usuario_obs { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_ini { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_fim { get; set; }
    }
}
