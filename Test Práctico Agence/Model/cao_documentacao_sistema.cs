using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_documentacao_sistema
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int id { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_sistema { get; set; }
        [Column(TypeName = "text")]
        public string? descricao { get; set; }
        [StringLength(30)]
        public string pasta { get; set; } = null!;
        [Column(TypeName = "int(11)")]
        public int? sub_grupo { get; set; }
        [StringLength(60)]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime dt_doc { get; set; }
        [StringLength(100)]
        public string arquivo { get; set; } = null!;
    }
}
