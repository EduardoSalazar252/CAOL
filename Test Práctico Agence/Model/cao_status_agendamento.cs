using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_status_agendamento
    {
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_status_agendamento { get; set; }
        [StringLength(20)]
        public string ds_status_agendamento { get; set; } = null!;
    }
}
