using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_boleto
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_boleto { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_cliente { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_sistema { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_os { get; set; }
        [StringLength(128)]
        public string valor { get; set; } = null!;
        [StringLength(128)]
        public string vencimento { get; set; } = null!;
        [Column(TypeName = "int(11)")]
        public int status { get; set; }
        [StringLength(255)]
        public string? boleto { get; set; }
        [StringLength(255)]
        public string? linha_dig { get; set; }
        [StringLength(20)]
        public string? parcela { get; set; }
    }
}
