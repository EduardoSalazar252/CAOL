using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_servico
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_servico { get; set; }
        [StringLength(50)]
        public string ds_servico { get; set; } = null!;
    }
}
