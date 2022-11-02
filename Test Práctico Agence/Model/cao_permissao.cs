using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Keyless]
    [Index("co_usuario", Name = "co_usuario")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_permissao
    {
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "enum('0','1')")]
        public string permissao_intervalo { get; set; } = null!;
        [Column(TypeName = "enum('0','1')")]
        public string permissao_hora_extra { get; set; } = null!;

        [ForeignKey("co_usuario")]
        public virtual cao_usuario co_usuarioNavigation { get; set; } = null!;
    }
}
