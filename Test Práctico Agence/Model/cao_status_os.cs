using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_status_os
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_status_atual { get; set; }
        [StringLength(50)]
        public string ds_status { get; set; } = null!;
    }
}
