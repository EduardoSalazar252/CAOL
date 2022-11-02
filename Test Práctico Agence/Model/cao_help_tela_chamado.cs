using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_help_tela_chamado
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_tela { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_cliente { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_sistema { get; set; }
        [StringLength(200)]
        public string ds_tela { get; set; } = null!;
    }
}
