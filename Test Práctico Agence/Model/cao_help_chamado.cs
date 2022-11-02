using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_chamado", Name = "co_chamado")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_help_chamado
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_chamado { get; set; }
        [Column(TypeName = "text")]
        public string ds_chamado { get; set; } = null!;
        [Column(TypeName = "text")]
        public string? ds_solucao { get; set; }
        [Column(TypeName = "tinyint(4)")]
        public sbyte co_status { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_motivo { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_tela { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_autor { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_filial { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long co_sistema { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_chamado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_solucao { get; set; }
    }
}
