using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_usuario", Name = "co_usuario")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_conhecimentos
    {
        public cao_conhecimentos()
        {
            cao_conhecimentos_fontes = new HashSet<cao_conhecimentos_fontes>();
            cao_pontos_conhecimento = new HashSet<cao_pontos_conhecimento>();
        }

        [Key]
        [Column(TypeName = "int(11)")]
        public int idconhecimento { get; set; }
        [StringLength(100)]
        public string assunto { get; set; } = null!;
        [Column(TypeName = "text")]
        public string conhecimento { get; set; } = null!;
        [Column(TypeName = "tinytext")]
        public string url { get; set; } = null!;
        [Column(TypeName = "text")]
        public string tags { get; set; } = null!;
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime datahora { get; set; }

        [ForeignKey("co_usuario")]
        [InverseProperty("cao_conhecimentos")]
        public virtual cao_usuario co_usuarioNavigation { get; set; } = null!;
        [InverseProperty("idconhecimentoNavigation")]
        public virtual ICollection<cao_conhecimentos_fontes> cao_conhecimentos_fontes { get; set; }
        [InverseProperty("idconhecimentoNavigation")]
        public virtual ICollection<cao_pontos_conhecimento> cao_pontos_conhecimento { get; set; }
    }
}
