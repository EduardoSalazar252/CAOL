using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_valor_descanso
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int id { get; set; }
        [StringLength(40)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string co_usuario { get; set; } = null!;
        [StringLength(50)]
        public string segundos { get; set; } = null!;
        [StringLength(50)]
        public string mes_referencia { get; set; } = null!;
    }
}
