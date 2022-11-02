using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_usuario", "co_tipo_usuario", "co_sistema", "dt_atualizacao", Name = "co_usuario")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class permissao_sistema
    {
        [Key]
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_tipo_usuario { get; set; }
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_sistema { get; set; }
        [StringLength(1)]
        public string in_ativo { get; set; } = null!;
        [StringLength(20)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? co_usuario_atualizacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_atualizacao { get; set; }
    }
}
