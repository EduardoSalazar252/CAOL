using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_atividade
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_atividade { get; set; }
        [StringLength(30)]
        public string ds_atividade { get; set; } = null!;
        [Column(TypeName = "bigint(20)")]
        public long co_tipo_usuario { get; set; }
    }
}
