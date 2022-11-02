using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_cliente_contato
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_cliente { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_contato { get; set; }
        [Column(TypeName = "int(10) unsigned")]
        public uint? fg_agendado { get; set; }
        [Column(TypeName = "time")]
        public TimeOnly? hr_ini { get; set; }
        [Column(TypeName = "time")]
        public TimeOnly? hr_end { get; set; }
    }
}
