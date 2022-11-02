using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_usuario", Name = "co_usuario")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_dr_ativ_comp
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int id_ativ_comp { get; set; }
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime data { get; set; }
        [Column(TypeName = "text")]
        public string assunto { get; set; } = null!;
        [Column(TypeName = "time")]
        public TimeOnly tempo_gasto { get; set; }
    }
}
