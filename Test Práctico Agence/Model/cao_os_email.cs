using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_os_email
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_email { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_os { get; set; }
        [StringLength(200)]
        public string? email { get; set; }
        [StringLength(20)]
        public string? senha { get; set; }
        [StringLength(255)]
        public string nome { get; set; } = null!;
        [Column(TypeName = "int(11)")]
        public int co_cliente { get; set; }
        [Column(TypeName = "int(11)")]
        public int ativo { get; set; }
        [StringLength(20)]
        public string? ddd { get; set; }
        [StringLength(40)]
        public string? tel { get; set; }
        [StringLength(80)]
        public string? cargo { get; set; }
    }
}
