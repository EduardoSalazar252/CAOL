using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_escritorio
    {
        [Key]
        [Column(TypeName = "tinyint(3) unsigned")]
        public byte co_escritorio { get; set; }
        [StringLength(2)]
        public string local { get; set; } = null!;
    }
}
