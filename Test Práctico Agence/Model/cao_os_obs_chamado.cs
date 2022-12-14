using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_os_obs_chamado
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_obs { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_chamado { get; set; }
        [StringLength(80)]
        public string? co_usuario { get; set; }
        [Column(TypeName = "text")]
        public string? descricao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_obs { get; set; }
        [StringLength(255)]
        public string? email { get; set; }
        [StringLength(255)]
        public string? arquivo_obs { get; set; }
    }
}
