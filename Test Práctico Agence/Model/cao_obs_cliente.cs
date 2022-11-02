using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_obs_cliente
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_obs { get; set; }
        [StringLength(250)]
        public string descricao { get; set; } = null!;
        [Column(TypeName = "int(10) unsigned")]
        public uint co_cliente { get; set; }
        [StringLength(30)]
        public string? co_usuario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_obs { get; set; }
    }
}
