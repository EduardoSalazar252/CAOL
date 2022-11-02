using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    /// <summary>
    /// Banco de horas dos usuários...
    /// </summary>
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_banco_horas
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_banc_horas { get; set; }
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [StringLength(7)]
        public string periodo { get; set; } = null!;
        [Column(TypeName = "int(11)")]
        public int min_mes { get; set; }
        [Column(TypeName = "int(11)")]
        public int min_ferias { get; set; }
        [Column(TypeName = "int(11)")]
        public int min_pago { get; set; }
        [Column(TypeName = "int(11)")]
        public int min_total { get; set; }
    }
}
