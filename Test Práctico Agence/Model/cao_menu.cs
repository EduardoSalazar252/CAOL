using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_menu
    {
        [Key]
        [Column(TypeName = "tinyint(3) unsigned")]
        public byte co_menu { get; set; }
        [StringLength(255)]
        public string ds_menu { get; set; } = null!;
        [StringLength(255)]
        public string ds_pagina { get; set; } = null!;
        [StringLength(255)]
        public string? ds_imagem { get; set; }
    }
}
