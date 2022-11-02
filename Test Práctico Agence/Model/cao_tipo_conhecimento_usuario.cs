using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_conhecimento", Name = "co_conhecimento")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_tipo_conhecimento_usuario
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_conhecimento { get; set; }
        [StringLength(20)]
        public string? ds_conhecimento { get; set; }
        [Column(TypeName = "int(10) unsigned")]
        public uint co_sistema { get; set; }
    }
}
