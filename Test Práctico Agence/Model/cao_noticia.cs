using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_noticia
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_noticia { get; set; }
        [StringLength(255)]
        public string assunto { get; set; } = null!;
        [Column(TypeName = "text")]
        public string descricao { get; set; } = null!;
        [StringLength(255)]
        public string foto { get; set; } = null!;
        [StringLength(60)]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime dt_noticia { get; set; }
    }
}
