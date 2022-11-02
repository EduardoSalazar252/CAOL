using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_bonus
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int bon_categoria { get; set; }
        [Key]
        [Column(TypeName = "int(11)")]
        public int bon_inicio { get; set; }
        [Key]
        [Column(TypeName = "int(11)")]
        public int bon_fim { get; set; }
        public float? bon_valor_sem { get; set; }
        public float? bon_valor_fimsem { get; set; }
    }
}
