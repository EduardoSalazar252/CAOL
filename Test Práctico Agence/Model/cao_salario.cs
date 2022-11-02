using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_salario
    {
        [Key]
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime dt_alteracao { get; set; }
        public float brut_salario { get; set; }
        public float liq_salario { get; set; }
    }
}
