using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_os
    {
        public cao_os()
        {
            cao_hist_ocorrencias_os = new HashSet<cao_hist_ocorrencias_os>();
        }

        [Key]
        [Column(TypeName = "int(11)")]
        public int co_os { get; set; }
        [Column(TypeName = "int(11)")]
        public int? nu_os { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_sistema { get; set; }
        [StringLength(50)]
        public string? co_usuario { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_arquitetura { get; set; }
        [StringLength(200)]
        public string? ds_os { get; set; }
        [StringLength(200)]
        public string? ds_caracteristica { get; set; }
        [StringLength(200)]
        public string? ds_requisito { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_inicio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_fim { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_status { get; set; }
        [StringLength(50)]
        public string? diretoria_sol { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_sol { get; set; }
        [StringLength(20)]
        public string? nu_tel_sol { get; set; }
        [StringLength(5)]
        public string? ddd_tel_sol { get; set; }
        [StringLength(20)]
        public string? nu_tel_sol2 { get; set; }
        [StringLength(5)]
        public string? ddd_tel_sol2 { get; set; }
        [StringLength(50)]
        public string? usuario_sol { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_imp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_garantia { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_email { get; set; }
        [Column(TypeName = "int(11)")]
        public int? co_os_prospect_rel { get; set; }

        [InverseProperty("co_osNavigation")]
        public virtual ICollection<cao_hist_ocorrencias_os> cao_hist_ocorrencias_os { get; set; }
    }
}
