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
    public partial class cao_horario_almoco
    {
        [StringLength(255)]
        public string co_usuario { get; set; } = null!;
        [StringLength(128)]
        public string almoco_saida_hora { get; set; } = null!;
        [StringLength(128)]
        public string almoco_volta_hora { get; set; } = null!;
    }
}
