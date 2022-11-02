using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Keyless]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_feriados
    {
        [Column(TypeName = "tinyint(3) unsigned")]
        public byte? dia { get; set; }
        [Column(TypeName = "tinyint(3) unsigned")]
        public byte? mes { get; set; }
        [Column(TypeName = "int(11)")]
        public int? ano { get; set; }
    }
}
