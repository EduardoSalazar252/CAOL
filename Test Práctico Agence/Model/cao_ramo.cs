using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    /// <summary>
    /// Ramo de atividade de Clientes
    /// </summary>
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_ramo
    {
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_ramo { get; set; }
        [StringLength(60)]
        public string ds_ramo { get; set; } = null!;
    }
}
