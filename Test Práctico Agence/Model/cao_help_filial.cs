using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_filial", Name = "filialId")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_help_filial
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_filial { get; set; }
        [StringLength(70)]
        public string no_filial { get; set; } = null!;
        [Column(TypeName = "int(11)")]
        public int co_cliente { get; set; }
        [StringLength(2)]
        public string estado { get; set; } = null!;
    }
}
