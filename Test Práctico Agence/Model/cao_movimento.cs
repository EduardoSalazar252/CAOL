using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_movimento", Name = "co_movimento")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_movimento
    {
        [Key]
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong co_movimento { get; set; }
        [StringLength(50)]
        public string co_usuario { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime dt_entrada { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_saida_almoco { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_volta_almoco { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_saida { get; set; }
        [Column(TypeName = "tinyint(3) unsigned")]
        public byte is_encerrado { get; set; }
    }
}
