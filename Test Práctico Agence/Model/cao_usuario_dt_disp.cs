using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_usuario_dt_disp
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_dt_disp { get; set; }
        [StringLength(20)]
        public string? co_usuario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_disp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_alt { get; set; }
    }
}
