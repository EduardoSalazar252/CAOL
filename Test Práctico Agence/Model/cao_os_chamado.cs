using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_os_chamado
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_chamado { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_sistema { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_os { get; set; }
        [StringLength(255)]
        public string ds_chamado { get; set; } = null!;
        [Column(TypeName = "int(11)")]
        public int co_tipo { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_prioridade { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_item { get; set; }
        [Column(TypeName = "text")]
        public string descricao { get; set; } = null!;
        [Column(TypeName = "text")]
        public string ds_solucao { get; set; } = null!;
        [StringLength(30)]
        public string tempo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime dt_chamado { get; set; }
        [Column(TypeName = "int(11)")]
        public int status { get; set; }
        [StringLength(255)]
        public string co_usuario { get; set; } = null!;
        [StringLength(255)]
        public string co_analista { get; set; } = null!;
        [StringLength(255)]
        public string? email { get; set; }
    }
}
