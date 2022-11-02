using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_cidade
    {
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_cidade { get; set; }
        [StringLength(30)]
        public string no_cidade { get; set; } = null!;
        [Column(TypeName = "bigint(20)")]
        public long co_uf { get; set; }
    }
}
