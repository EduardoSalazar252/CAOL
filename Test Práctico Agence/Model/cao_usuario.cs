using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test_Práctico_Agence.Model
{
    [Index("co_usuario", Name = "co_usuario", IsUnique = true)]
    [Index("co_usuario", "no_usuario", "dt_alteracao", Name = "co_usuario_2")]
    [MySqlCharSet("latin1")]
    [MySqlCollation("latin1_swedish_ci")]
    public partial class cao_usuario
    {
        public cao_usuario()
        {
            cao_conhecimentos = new HashSet<cao_conhecimentos>();
            cao_hist_ocorrencias_os = new HashSet<cao_hist_ocorrencias_os>();
            cao_pontos_conhecimento = new HashSet<cao_pontos_conhecimento>();
        }

        [Key]
        [StringLength(20)]
        public string co_usuario { get; set; } = null!;
        [StringLength(50)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string no_usuario { get; set; } = null!;
        [StringLength(14)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string ds_senha { get; set; } = null!;
        [StringLength(20)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? co_usuario_autorizacao { get; set; }
        [Column(TypeName = "bigint(20) unsigned")]
        public ulong? nu_matricula { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_nascimento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_admissao_empresa { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_desligamento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_inclusao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_expiracao { get; set; }
        [StringLength(14)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? nu_cpf { get; set; }
        [StringLength(20)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? nu_rg { get; set; }
        [StringLength(10)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? no_orgao_emissor { get; set; }
        [StringLength(2)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? uf_orgao_emissor { get; set; }
        [StringLength(150)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? ds_endereco { get; set; }
        [StringLength(100)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? no_email { get; set; }
        [StringLength(100)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? no_email_pessoal { get; set; }
        [StringLength(64)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? nu_telefone { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime dt_alteracao { get; set; }
        [StringLength(255)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? url_foto { get; set; }
        [StringLength(80)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? instant_messenger { get; set; }
        [Column(TypeName = "int(10) unsigned")]
        public uint? icq { get; set; }
        [StringLength(50)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? msn { get; set; }
        [StringLength(50)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? yms { get; set; }
        [StringLength(50)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? ds_comp_end { get; set; }
        [StringLength(30)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? ds_bairro { get; set; }
        [StringLength(10)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? nu_cep { get; set; }
        [StringLength(50)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? no_cidade { get; set; }
        [StringLength(2)]
        [MySqlCharSet("utf8")]
        [MySqlCollation("utf8_general_ci")]
        public string? uf_cidade { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? dt_expedicao { get; set; }

        [InverseProperty("co_usuarioNavigation")]
        public virtual ICollection<cao_conhecimentos> cao_conhecimentos { get; set; }
        [InverseProperty("co_usuarioNavigation")]
        public virtual ICollection<cao_hist_ocorrencias_os> cao_hist_ocorrencias_os { get; set; }
        [InverseProperty("co_coordenadorNavigation")]
        public virtual ICollection<cao_pontos_conhecimento> cao_pontos_conhecimento { get; set; }
    }
}
