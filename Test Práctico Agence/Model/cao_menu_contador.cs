using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_menu_contador
    {
        [Key]
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [Key]
        [Column(TypeName = "tinyint(3) unsigned")]
        public byte co_menu { get; set; }
        [Column(TypeName = "tinyint(4)")]
        public sbyte nu_pontos { get; set; }
        [Column(TypeName = "tinyint(3) unsigned")]
        public byte in_processado { get; set; }
    }
}
