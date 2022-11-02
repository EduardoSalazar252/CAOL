using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_conhecimento_usuario
    {
        [Key]
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_conhecimento { get; set; }
        [Column(TypeName = "int(10) unsigned")]
        public uint? nv_conhecimento { get; set; }
        [Column(TypeName = "tinyint(3) unsigned")]
        public byte? is_certificado { get; set; }
    }
}
