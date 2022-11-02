using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_movimento_justificativa", Name = "co_movimento_justificativa")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_movimento_justificativa
    {
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_movimento_justificativa { get; set; }
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_movimento { get; set; }
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong nu_os { get; set; }
        public string ds_justificativa { get; set; } = null!;
    }
}
