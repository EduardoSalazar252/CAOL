using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_banco_de_horas
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int id { get; set; }
        [StringLength(255)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime data_cadastro { get; set; }
        [Column(TypeName = "int(11)")]
        public int segundos { get; set; }
        [StringLength(10)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string tipo { get; set; } = null!;
    }
}
