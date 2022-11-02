using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("idconhecimento", Name = "idconhecimento")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_conhecimentos_fontes
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int idfonte { get; set; }
        [Column(TypeName = "int(11)")]
        public int idconhecimento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime datahora { get; set; }
        [StringLength(50)]
        public string arquivo { get; set; } = null!;
        [StringLength(50)]
        public string caminho { get; set; } = null!;

        [ForeignKey("idconhecimento")]
        [InverseProperty("cao_conhecimentos_fontes")]
        public virtual cao_conhecimentos idconhecimentoNavigation { get; set; } = null!;
    }
}
