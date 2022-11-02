using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_tipo_custo
    {
        [Key]
        [Column(TypeName = "tinyint(3) unsigned")]
        public byte co_tipo_custo { get; set; }
        [StringLength(30)]
        public string descricao { get; set; } = null!;
    }
}
