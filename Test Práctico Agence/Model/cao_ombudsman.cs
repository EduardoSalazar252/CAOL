using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_escritorio", Name = "co_escritorio")]
    [Index("idcategoria", Name = "idcategoria")]
    [Index("idtipo", Name = "idtipo")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_ombudsman
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int id { get; set; }
        [Column(TypeName = "tinyint(4)")]
        public sbyte idtipo { get; set; }
        [Column(TypeName = "tinyint(4)")]
        public sbyte idcategoria { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime data { get; set; }
        [Column(TypeName = "text")]
        public string comentario { get; set; } = null!;
        [Column(TypeName = "tinyint(4)")]
        public sbyte co_escritorio { get; set; }

        [ForeignKey("idcategoria")]
        [InverseProperty("cao_ombudsman")]
        public virtual cao_categorias_ombudsman idcategoriaNavigation { get; set; } = null!;
        [ForeignKey("idtipo")]
        [InverseProperty("cao_ombudsman")]
        public virtual cao_tipo_ombudsman idtipoNavigation { get; set; } = null!;
    }
}
