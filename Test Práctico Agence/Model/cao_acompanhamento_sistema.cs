using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_acompanhamento_sistema
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_acompanhamento { get; set; }
        [StringLength(40)]
        public string? email { get; set; }
        [StringLength(20)]
        public string? senha { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long? co_sistema { get; set; }
        [StringLength(2)]
        public string? status { get; set; }
    }
}
