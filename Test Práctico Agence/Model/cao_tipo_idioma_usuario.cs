using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_tipo_idioma_usuario
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_idioma { get; set; }
        [StringLength(13)]
        public string? ds_idioma { get; set; }
    }
}
