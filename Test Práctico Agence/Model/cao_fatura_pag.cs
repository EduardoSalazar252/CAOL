using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_fatura", Name = "co_fatura", IsUnique = true)]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_fatura_pag
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int id_fatura_pag { get; set; }
        [Column(TypeName = "int(11)")]
        public int co_fatura { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_efetuado { get; set; }
        public float valor_pago { get; set; }
    }
}
