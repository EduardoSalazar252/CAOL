using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_log_chamado
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int id { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_chamado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_chamado { get; set; }
        [StringLength(128)]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "int(11)")]
        public int co_daily { get; set; }
    }
}
