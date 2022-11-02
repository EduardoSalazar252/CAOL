using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_atividade_consultor
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_atividade { get; set; }
        [StringLength(50)]
        public string ds_atividade { get; set; } = null!;
        [StringLength(1)]
        public string? ativo { get; set; }
    }
}
