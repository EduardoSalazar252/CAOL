using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_cliente
    {
        [Key]
        [Column(TypeName = "int(10) unsigned")]
        public uint co_cliente { get; set; }
        [StringLength(50)]
        public string? no_razao { get; set; }
        [StringLength(50)]
        public string? no_fantasia { get; set; }
        [StringLength(30)]
        public string? no_contato { get; set; }
        [StringLength(15)]
        public string? nu_telefone { get; set; }
        [StringLength(6)]
        public string? nu_ramal { get; set; }
        [StringLength(18)]
        public string? nu_cnpj { get; set; }
        [StringLength(150)]
        public string? ds_endereco { get; set; }
        [Column(TypeName = "int(11)")]
        public int? nu_numero { get; set; }
        [StringLength(150)]
        public string? ds_complemento { get; set; }
        [StringLength(50)]
        public string no_bairro { get; set; } = null!;
        [StringLength(10)]
        public string? nu_cep { get; set; }
        [StringLength(50)]
        public string? no_pais { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long? co_ramo { get; set; }
        [Column(TypeName = "bigint(20)")]
        public long co_cidade { get; set; }
        [Column(TypeName = "int(10) unsigned")]
        public uint? co_status { get; set; }
        [StringLength(50)]
        public string? ds_site { get; set; }
        [StringLength(50)]
        public string? ds_email { get; set; }
        [StringLength(50)]
        public string? ds_cargo_contato { get; set; }
        [StringLength(2)]
        public string? tp_cliente { get; set; }
        [StringLength(100)]
        public string? ds_referencia { get; set; }
        [Column(TypeName = "int(10) unsigned")]
        public uint? co_complemento_status { get; set; }
        [StringLength(15)]
        public string? nu_fax { get; set; }
        [StringLength(10)]
        public string? ddd2 { get; set; }
        [StringLength(20)]
        public string? telefone2 { get; set; }
    }
}
