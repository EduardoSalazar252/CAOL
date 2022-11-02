using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_os_fase
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_fase { get; set; }
        [StringLength(200)]
        public string? descricao { get; set; }
        [StringLength(200)]
        public string descricao_ingl { get; set; } = null!;
        [Column(TypeName = "int(11)")]
        public int? ordem { get; set; }
    }
}
