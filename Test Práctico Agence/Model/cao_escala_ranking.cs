using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_escala_ranking
    {
        public cao_escala_ranking()
        {
            cao_pontos_conhecimento = new HashSet<cao_pontos_conhecimento>();
        }

        [Key]
        [Column(TypeName = "tinyint(4)")]
        public sbyte idescala { get; set; }
        [Column(TypeName = "tinyint(4)")]
        public sbyte qtd_visual { get; set; }
        [Column(TypeName = "int(11)")]
        public int pontuacao { get; set; }

        [InverseProperty("pontuacaoNavigation")]
        public virtual ICollection<cao_pontos_conhecimento> cao_pontos_conhecimento { get; set; }
    }
}
