using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_pagamento", Name = "nu_os")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_pagamento
    {
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_pagamento { get; set; }
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [StringLength(2)]
        public string tp_pagamento { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime dt_pagamento { get; set; }
        public float vl_pagamento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_referencia_pagamento { get; set; }
    }
}
