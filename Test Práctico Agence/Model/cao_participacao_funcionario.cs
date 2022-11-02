using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_participacao_funcionario
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_part_funcionario { get; set; }
        [Column(TypeName = "float unsigned")]
        public float pc_participacao { get; set; }
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "tinyint(3) unsigned")]
        public byte co_escritorio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_referencia { get; set; }
    }
}
