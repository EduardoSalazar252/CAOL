using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_os_prazo
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_prazo { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_os { get; set; }
        [Column(TypeName = "int(10) unsigned")]
        public uint? co_fase { get; set; }
        [Column(TypeName = "int(11)")]
        public int? total_analista { get; set; }
        [Column(TypeName = "int(11)")]
        public int? total_hora { get; set; }
    }
}
