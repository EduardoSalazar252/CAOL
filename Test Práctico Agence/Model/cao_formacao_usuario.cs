using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_formacao_usuario
    {
        [Key]
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [Key]
        [StringLength(13)]
        public string tp_curso { get; set; } = null!;
        [StringLength(50)]
        public string? ds_curso { get; set; }
        [StringLength(50)]
        public string? ds_instituicao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_conclusao { get; set; }
    }
}
