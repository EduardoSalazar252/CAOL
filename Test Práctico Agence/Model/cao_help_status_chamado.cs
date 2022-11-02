using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_status", Name = "co_status", IsUnique = true)]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_help_status_chamado
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_status { get; set; }
        [StringLength(50)]
        public string ds_status { get; set; } = null!;
    }
}
