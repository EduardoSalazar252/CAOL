using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_fatura
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_fatura { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_cliente { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_sistema { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_os { get; set; }
        [Column(TypeName = "int(11)")]
        public int num_nf { get; set; }
        public float total { get; set; }
        public float valor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime data_emissao { get; set; }
        [Column(TypeName = "text")]
        public string corpo_nf { get; set; } = null!;
        public float comissao_cn { get; set; }
        public float total_imp_inc { get; set; }
    }
}
