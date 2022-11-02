using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_coordenador", Name = "co_coordenador")]
    [Index("idconhecimento", Name = "idconhecimento")]
    [Index("pontuacao", "co_coordenador", "idconhecimento", Name = "pontuacao")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_pontos_conhecimento
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int idpontos { get; set; }
        [Column(TypeName = "tinyint(4)")]
        public sbyte pontuacao { get; set; }
        [StringLength(50)]
        public string co_coordenador { get; set; } = null!;
        [Column(TypeName = "int(11)")]
        public int idconhecimento { get; set; }

        [ForeignKey("co_coordenador")]
        [InverseProperty("cao_pontos_conhecimento")]
        public virtual cao_usuario co_coordenadorNavigation { get; set; } = null!;
        [ForeignKey("idconhecimento")]
        [InverseProperty("cao_pontos_conhecimento")]
        public virtual cao_conhecimentos idconhecimentoNavigation { get; set; } = null!;
        [ForeignKey("pontuacao")]
        [InverseProperty("cao_pontos_conhecimento")]
        public virtual cao_escala_ranking pontuacaoNavigation { get; set; } = null!;
    }
}
