using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_os_item_menu
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int co_item { get; set; }
        [StringLength(255)]
        public string ds_item { get; set; } = null!;
        [Column(TypeName = "int(11)")]
        public int co_sistema { get; set; }
    }
}
