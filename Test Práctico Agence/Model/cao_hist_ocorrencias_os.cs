using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_os", Name = "co_os")]
    [Index("co_usuario", Name = "co_usuario")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_hist_ocorrencias_os
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int idocorrencia { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_os { get; set; }
        [StringLength(20)]
        public string? co_usuario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? data { get; set; }
        [Column(TypeName = "enum('Interna','Externa')")]
        public string tipo { get; set; } = null!;
        [Column(TypeName = "text")]
        public string descricao { get; set; } = null!;
        [StringLength(50)]
        public string responsavel { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? data_fechamento { get; set; }

        [ForeignKey("co_os")]
        [InverseProperty("cao_hist_ocorrencias_os")]
        public virtual cao_os? co_osNavigation { get; set; }
        [ForeignKey("co_usuario")]
        [InverseProperty("cao_hist_ocorrencias_os")]
        public virtual cao_usuario? co_usuarioNavigation { get; set; }
    }
}
