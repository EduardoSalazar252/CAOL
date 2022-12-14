using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_categorias_ombudsman
    {
        public cao_categorias_ombudsman()
        {
            cao_ombudsman = new HashSet<cao_ombudsman>();
        }

        [Key]
        [Column(TypeName = "tinyint(4)")]
        public sbyte idcategoria { get; set; }
        [StringLength(100)]
        public string descricao { get; set; } = null!;

        [InverseProperty("idcategoriaNavigation")]
        public virtual ICollection<cao_ombudsman> cao_ombudsman { get; set; }
    }
}
