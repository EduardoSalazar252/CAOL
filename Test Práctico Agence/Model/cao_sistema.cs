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
    public partial class cao_sistema
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_sistema { get; set; }
        [Column(TypeName = "int(10) unsigned")]
        public uint? co_cliente { get; set; }
        [StringLength(50)]
        public string? co_usuario { get; set; }
        [Column(TypeName = "int(10) unsigned")]
        public uint? co_arquitetura { get; set; }
        [StringLength(200)]
        public string? no_sistema { get; set; }
        [Column(TypeName = "text")]
        public string? ds_sistema_resumo { get; set; }
        [Column(TypeName = "text")]
        public string? ds_caracteristica { get; set; }
        [Column(TypeName = "text")]
        public string? ds_requisito { get; set; }
        [StringLength(100)]
        public string? no_diretoria_solic { get; set; }
        [StringLength(5)]
        public string? ddd_telefone_solic { get; set; }
        [StringLength(20)]
        public string? nu_telefone_solic { get; set; }
        [StringLength(100)]
        public string? no_usuario_solic { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_solicitacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_entrega { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_email { get; set; }
    }
}
