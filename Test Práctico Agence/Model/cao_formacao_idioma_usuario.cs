using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_formacao_idioma_usuario
    {
        [Key]
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_idioma { get; set; }
        [Column(TypeName = "int(11)")]
        public int? nv_leitura { get; set; }
        [Column(TypeName = "int(11)")]
        public int? nv_escrita { get; set; }
        [Column(TypeName = "int(11)")]
        public int? nv_fala { get; set; }
    }
}
