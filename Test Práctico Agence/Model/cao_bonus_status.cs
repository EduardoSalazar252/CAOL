using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_bonus_status
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int id { get; set; }
        [StringLength(128)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime data_solic { get; set; }
        [StringLength(128)]
        public string mes { get; set; } = null!;
        [StringLength(128)]
        public string valor { get; set; } = null!;
        [StringLength(10)]
        public string? is_solic { get; set; }
        [StringLength(10)]
        public string? is_pg { get; set; }
        [StringLength(10)]
        public string? is_horas { get; set; }
    }
}
