using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_tipo_usuario", "co_sistema", Name = "co_tipo_usuario")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class tipo_usuario
    {
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_tipo_usuario { get; set; }
        [StringLength(32)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string ds_tipo_usuario { get; set; } = null!;
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_sistema { get; set; }
    }
}
