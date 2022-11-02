using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    /// <summary>
    /// Descrição da Visita
    /// </summary>
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_complemento
    {
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_complemento { get; set; }
        public string? ds_complemento { get; set; }
    }
}
