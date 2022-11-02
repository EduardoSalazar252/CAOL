using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_sistema", Name = "co_sistema")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_tipo_sistema_usuario
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_sistema { get; set; }
        [StringLength(40)]
        public string? ds_sistema { get; set; }
    }
}
