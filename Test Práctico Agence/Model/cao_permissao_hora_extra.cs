using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_permissao_hora_extra
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int id_permissao { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long co_movimento { get; set; }
    }
}
