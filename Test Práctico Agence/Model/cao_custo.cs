using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_custo
    {
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_custo { get; set; }
        [Column(TypeName = "tinyint(4)")]
        public sbyte co_tipo_custo { get; set; }
        [StringLength(100)]
        public string descricao { get; set; } = null!;
        [Column(TypeName = "tinyint(4)")]
        public sbyte co_escritorio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_compra { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_pagamento { get; set; }
        [Column(TypeName = "text")]
        public string? co_boleto { get; set; }
        public float valor { get; set; }
        [StringLength(5)]
        public string? parcela { get; set; }
        [Column(TypeName = "tinyint(4)")]
        public sbyte? pag { get; set; }
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_custo_high { get; set; }
    }
}
