using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Keyless]
    [Index("id_pagamento", Name = "id_pagamento")]
    [Index("co_usuario", "dt_efetuado", Name = "unico", IsUnique = true)]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_salario_pag
    {
        [Column(TypeName = "int(11)")]
        public int id_pagamento { get; set; }
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime dt_efetuado { get; set; }
        [Column(TypeName = "enum('Autorizado','Pago','Pendente')")]
        public string status { get; set; } = null!;
        [Column(TypeName = "text")]
        public string? observacao { get; set; }

        [ForeignKey("co_usuario")]
        public virtual cao_usuario co_usuarioNavigation { get; set; } = null!;
    }
}
