using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_uf
    {
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_uf { get; set; }
        [StringLength(5)]
        public string ds_uf { get; set; } = null!;
    }
}
