using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_motivo", Name = "co_motivo", IsUnique = true)]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_help_motivo_chamado
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_motivo { get; set; }
        [StringLength(70)]
        public string ds_motivo { get; set; } = null!;
    }
}
