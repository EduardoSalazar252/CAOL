using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_os_analista
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_analista { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_os { get; set; }
        [StringLength(50)]
        public string? co_usuario { get; set; }
    }
}
