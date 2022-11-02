using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_atividade_report
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int id { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_cliente { get; set; }
        [StringLength(30)]
        public string? inicio { get; set; }
        [StringLength(30)]
        public string? fim { get; set; }
        [StringLength(50)]
        public string? lembrete { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_atividade { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_os { get; set; }
        [StringLength(60)]
        public string? assunto { get; set; }
        [Column(TypeName = "text")]
        public string? conteudo { get; set; }
        [StringLength(20)]
        public string status { get; set; } = null!;
        [StringLength(30)]
        public string? tempo { get; set; }
        [StringLength(50)]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime data_ativ { get; set; }
        [Column(TypeName = "text")]
        public string retorno { get; set; } = null!;
        [Column(TypeName = "int(11)")]
        public int? co_fase { get; set; }
    }
}
