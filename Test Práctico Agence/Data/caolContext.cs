using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Test_Práctico_Agence.Model;

namespace Test_Práctico_Agence.Data
{
    public partial class caolContext : DbContext
    {
        public caolContext()
        {
        }

        public caolContext(DbContextOptions<caolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<cao_acompanhamento_sistema> cao_acompanhamento_sistema { get; set; } = null!;
        public virtual DbSet<cao_agendamento> cao_agendamento { get; set; } = null!;
        public virtual DbSet<cao_arquitetura_os> cao_arquitetura_os { get; set; } = null!;
        public virtual DbSet<cao_atividade> cao_atividade { get; set; } = null!;
        public virtual DbSet<cao_atividade_consultor> cao_atividade_consultor { get; set; } = null!;
        public virtual DbSet<cao_atividade_report> cao_atividade_report { get; set; } = null!;
        public virtual DbSet<cao_atividade_teste> cao_atividade_teste { get; set; } = null!;
        public virtual DbSet<cao_aviso> cao_aviso { get; set; } = null!;
        public virtual DbSet<cao_banco_de_horas> cao_banco_de_horas { get; set; } = null!;
        public virtual DbSet<cao_banco_horas> cao_banco_horas { get; set; } = null!;
        public virtual DbSet<cao_boleto> cao_boleto { get; set; } = null!;
        public virtual DbSet<cao_bonus> cao_bonus { get; set; } = null!;
        public virtual DbSet<cao_bonus_status> cao_bonus_status { get; set; } = null!;
        public virtual DbSet<cao_categorias_ombudsman> cao_categorias_ombudsman { get; set; } = null!;
        public virtual DbSet<cao_cidade> cao_cidade { get; set; } = null!;
        public virtual DbSet<cao_cliente> cao_cliente { get; set; } = null!;
        public virtual DbSet<cao_cliente_contato> cao_cliente_contato { get; set; } = null!;
        public virtual DbSet<cao_comissao> cao_comissao { get; set; } = null!;
        public virtual DbSet<cao_complemento> cao_complemento { get; set; } = null!;
        public virtual DbSet<cao_conhecimento_usuario> cao_conhecimento_usuario { get; set; } = null!;
        public virtual DbSet<cao_conhecimentos> cao_conhecimentos { get; set; } = null!;
        public virtual DbSet<cao_conhecimentos_fontes> cao_conhecimentos_fontes { get; set; } = null!;
        public virtual DbSet<cao_custo> cao_custo { get; set; } = null!;
        public virtual DbSet<cao_diary_report> cao_diary_report { get; set; } = null!;
        public virtual DbSet<cao_diary_report_consultor> cao_diary_report_consultor { get; set; } = null!;
        public virtual DbSet<cao_documentacao_casos_uso> cao_documentacao_casos_uso { get; set; } = null!;
        public virtual DbSet<cao_documentacao_outros> cao_documentacao_outros { get; set; } = null!;
        public virtual DbSet<cao_documentacao_sistema> cao_documentacao_sistema { get; set; } = null!;
        public virtual DbSet<cao_dr_ativ_comp> cao_dr_ativ_comp { get; set; } = null!;
        public virtual DbSet<cao_escala_ranking> cao_escala_ranking { get; set; } = null!;
        public virtual DbSet<cao_escritorio> cao_escritorio { get; set; } = null!;
        public virtual DbSet<cao_fatura> cao_fatura { get; set; } = null!;
        public virtual DbSet<cao_fatura_pag> cao_fatura_pag { get; set; } = null!;
        public virtual DbSet<cao_feriados> cao_feriados { get; set; } = null!;
        public virtual DbSet<cao_formacao_idioma_usuario> cao_formacao_idioma_usuario { get; set; } = null!;
        public virtual DbSet<cao_formacao_usuario> cao_formacao_usuario { get; set; } = null!;
        public virtual DbSet<cao_help_autor> cao_help_autor { get; set; } = null!;
        public virtual DbSet<cao_help_chamado> cao_help_chamado { get; set; } = null!;
        public virtual DbSet<cao_help_filial> cao_help_filial { get; set; } = null!;
        public virtual DbSet<cao_help_motivo_chamado> cao_help_motivo_chamado { get; set; } = null!;
        public virtual DbSet<cao_help_status_chamado> cao_help_status_chamado { get; set; } = null!;
        public virtual DbSet<cao_help_tela_chamado> cao_help_tela_chamado { get; set; } = null!;
        public virtual DbSet<cao_hist_ocorrencias_os> cao_hist_ocorrencias_os { get; set; } = null!;
        public virtual DbSet<cao_horario_almoco> cao_horario_almoco { get; set; } = null!;
        public virtual DbSet<cao_log_chamado> cao_log_chamado { get; set; } = null!;
        public virtual DbSet<cao_menu> cao_menu { get; set; } = null!;
        public virtual DbSet<cao_menu_contador> cao_menu_contador { get; set; } = null!;
        public virtual DbSet<cao_movimento> cao_movimento { get; set; } = null!;
        public virtual DbSet<cao_movimento_justificativa> cao_movimento_justificativa { get; set; } = null!;
        public virtual DbSet<cao_movimento_os> cao_movimento_os { get; set; } = null!;
        public virtual DbSet<cao_noticia> cao_noticia { get; set; } = null!;
        public virtual DbSet<cao_obs_cliente> cao_obs_cliente { get; set; } = null!;
        public virtual DbSet<cao_obs_sistema> cao_obs_sistema { get; set; } = null!;
        public virtual DbSet<cao_ombudsman> cao_ombudsman { get; set; } = null!;
        public virtual DbSet<cao_os> cao_os { get; set; } = null!;
        public virtual DbSet<cao_os_analista> cao_os_analista { get; set; } = null!;
        public virtual DbSet<cao_os_chamado> cao_os_chamado { get; set; } = null!;
        public virtual DbSet<cao_os_daily_report> cao_os_daily_report { get; set; } = null!;
        public virtual DbSet<cao_os_email> cao_os_email { get; set; } = null!;
        public virtual DbSet<cao_os_fase> cao_os_fase { get; set; } = null!;
        public virtual DbSet<cao_os_item_menu> cao_os_item_menu { get; set; } = null!;
        public virtual DbSet<cao_os_obs> cao_os_obs { get; set; } = null!;
        public virtual DbSet<cao_os_obs_chamado> cao_os_obs_chamado { get; set; } = null!;
        public virtual DbSet<cao_os_prazo> cao_os_prazo { get; set; } = null!;
        public virtual DbSet<cao_os_status> cao_os_status { get; set; } = null!;
        public virtual DbSet<cao_pagamento> cao_pagamento { get; set; } = null!;
        public virtual DbSet<cao_participacao_funcionario> cao_participacao_funcionario { get; set; } = null!;
        public virtual DbSet<cao_permissao> cao_permissao { get; set; } = null!;
        public virtual DbSet<cao_permissao_hora_extra> cao_permissao_hora_extra { get; set; } = null!;
        public virtual DbSet<cao_pontos_conhecimento> cao_pontos_conhecimento { get; set; } = null!;
        public virtual DbSet<cao_ramo> cao_ramo { get; set; } = null!;
        public virtual DbSet<cao_rel_email_os> cao_rel_email_os { get; set; } = null!;
        public virtual DbSet<cao_salario> cao_salario { get; set; } = null!;
        public virtual DbSet<cao_salario_pag> cao_salario_pag { get; set; } = null!;
        public virtual DbSet<cao_servico> cao_servico { get; set; } = null!;
        public virtual DbSet<cao_sistema> cao_sistema { get; set; } = null!;
        public virtual DbSet<cao_sistema_obs> cao_sistema_obs { get; set; } = null!;
        public virtual DbSet<cao_status_agendamento> cao_status_agendamento { get; set; } = null!;
        public virtual DbSet<cao_status_cliente> cao_status_cliente { get; set; } = null!;
        public virtual DbSet<cao_status_cliente_complemento> cao_status_cliente_complemento { get; set; } = null!;
        public virtual DbSet<cao_status_os> cao_status_os { get; set; } = null!;
        public virtual DbSet<cao_temp_import> cao_temp_import { get; set; } = null!;
        public virtual DbSet<cao_tipo_conhecimento_usuario> cao_tipo_conhecimento_usuario { get; set; } = null!;
        public virtual DbSet<cao_tipo_custo> cao_tipo_custo { get; set; } = null!;
        public virtual DbSet<cao_tipo_idioma_usuario> cao_tipo_idioma_usuario { get; set; } = null!;
        public virtual DbSet<cao_tipo_ombudsman> cao_tipo_ombudsman { get; set; } = null!;
        public virtual DbSet<cao_tipo_sistema_usuario> cao_tipo_sistema_usuario { get; set; } = null!;
        public virtual DbSet<cao_uf> cao_uf { get; set; } = null!;
        public virtual DbSet<cao_usuario> cao_usuario { get; set; } = null!;
        public virtual DbSet<cao_usuario_dt_disp> cao_usuario_dt_disp { get; set; } = null!;
        public virtual DbSet<cao_valor_descanso> cao_valor_descanso { get; set; } = null!;
        public virtual DbSet<permissao_sistema> permissao_sistema { get; set; } = null!;
        public virtual DbSet<tipo_usuario> tipo_usuario { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<cao_acompanhamento_sistema>(entity =>
            {
                entity.HasKey(e => e.co_acompanhamento)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_sistema).HasDefaultValueSql("'0'");

                entity.Property(e => e.status).IsFixedLength();
            });

            modelBuilder.Entity<cao_agendamento>(entity =>
            {
                entity.HasKey(e => e.co_agendamento)
                    .HasName("PRIMARY");

                entity.Property(e => e.dt_hr_inicio).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_arquitetura_os>(entity =>
            {
                entity.HasKey(e => e.co_arquitetura)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_arquitetura).ValueGeneratedNever();

                entity.Property(e => e.ds_arquitetura).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_atividade>(entity =>
            {
                entity.HasKey(e => e.co_atividade)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_atividade).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_atividade_consultor>(entity =>
            {
                entity.HasKey(e => e.co_atividade)
                    .HasName("PRIMARY");

                entity.Property(e => e.ativo).IsFixedLength();

                entity.Property(e => e.ds_atividade).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_atividade_report>(entity =>
            {
                entity.Property(e => e.co_fase).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.data_ativ).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.status).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_atividade_teste>(entity =>
            {
                entity.HasKey(e => e.co_atividade)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_atividade).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_aviso>(entity =>
            {
                entity.HasKey(e => e.co_aviso)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<cao_banco_de_horas>(entity =>
            {
                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.data_cadastro).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.tipo).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_banco_horas>(entity =>
            {
                entity.HasKey(e => e.co_banc_horas)
                    .HasName("PRIMARY");

                entity.HasComment("Banco de horas dos usuários...");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.periodo).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_boleto>(entity =>
            {
                entity.HasKey(e => e.co_boleto)
                    .HasName("PRIMARY");

                entity.Property(e => e.valor).HasDefaultValueSql("''");

                entity.Property(e => e.vencimento).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_bonus>(entity =>
            {
                entity.HasKey(e => new { e.bon_categoria, e.bon_inicio, e.bon_fim })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
            });

            modelBuilder.Entity<cao_bonus_status>(entity =>
            {
                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.data_solic).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.mes).HasDefaultValueSql("''");

                entity.Property(e => e.valor).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_categorias_ombudsman>(entity =>
            {
                entity.HasKey(e => e.idcategoria)
                    .HasName("PRIMARY");

                entity.Property(e => e.descricao).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_cidade>(entity =>
            {
                entity.HasKey(e => e.co_cidade)
                    .HasName("PRIMARY");

                entity.Property(e => e.no_cidade).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_cliente>(entity =>
            {
                entity.HasKey(e => e.co_cliente)
                    .HasName("PRIMARY");

                entity.Property(e => e.no_bairro).HasDefaultValueSql("''");

                entity.Property(e => e.tp_cliente).IsFixedLength();
            });

            modelBuilder.Entity<cao_cliente_contato>(entity =>
            {
                entity.HasKey(e => e.co_cliente)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_cliente).ValueGeneratedNever();

                entity.Property(e => e.dt_contato).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.fg_agendado).HasDefaultValueSql("'0'");

                entity.Property(e => e.hr_end).HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.hr_ini).HasDefaultValueSql("'00:00:00'");
            });

            modelBuilder.Entity<cao_comissao>(entity =>
            {
                entity.HasKey(e => e.co_comissao)
                    .HasName("PRIMARY");

                entity.Property(e => e.dt_efetuado).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_complemento>(entity =>
            {
                entity.HasKey(e => e.co_complemento)
                    .HasName("PRIMARY");

                entity.HasComment("Descrição da Visita");
            });

            modelBuilder.Entity<cao_conhecimento_usuario>(entity =>
            {
                entity.HasKey(e => new { e.co_usuario, e.co_conhecimento })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_conhecimentos>(entity =>
            {
                entity.HasKey(e => e.idconhecimento)
                    .HasName("PRIMARY");

                entity.Property(e => e.assunto).HasDefaultValueSql("''");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.datahora).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.HasOne(d => d.co_usuarioNavigation)
                    .WithMany(p => p.cao_conhecimentos)
                    .HasForeignKey(d => d.co_usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_conhecimentos_ibfk_1");
            });

            modelBuilder.Entity<cao_conhecimentos_fontes>(entity =>
            {
                entity.HasKey(e => e.idfonte)
                    .HasName("PRIMARY");

                entity.Property(e => e.arquivo).HasDefaultValueSql("''");

                entity.Property(e => e.caminho).HasDefaultValueSql("''");

                entity.Property(e => e.datahora).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.HasOne(d => d.idconhecimentoNavigation)
                    .WithMany(p => p.cao_conhecimentos_fontes)
                    .HasForeignKey(d => d.idconhecimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_conhecimentos_fontes_ibfk_1");
            });

            modelBuilder.Entity<cao_custo>(entity =>
            {
                entity.HasKey(e => e.co_custo)
                    .HasName("PRIMARY");

                entity.Property(e => e.descricao).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<cao_diary_report>(entity =>
            {
                entity.HasKey(e => e.co_diary_report)
                    .HasName("PRIMARY");

                entity.Property(e => e.hr_gasta).HasDefaultValueSql("'00:00:00'");
            });

            modelBuilder.Entity<cao_diary_report_consultor>(entity =>
            {
                entity.HasKey(e => e.co_diary_report_consultor)
                    .HasName("PRIMARY");

                entity.HasComment("contem informacoes referentes a agendamento, visita, elabora");

                entity.Property(e => e.dt_agendamento).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_documentacao_casos_uso>(entity =>
            {
                entity.Property(e => e.nome).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_documentacao_outros>(entity =>
            {
                entity.Property(e => e.nome).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_documentacao_sistema>(entity =>
            {
                entity.Property(e => e.arquivo).HasDefaultValueSql("''");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.dt_doc).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.pasta).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_dr_ativ_comp>(entity =>
            {
                entity.HasKey(e => e.id_ativ_comp)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.data).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.tempo_gasto).HasDefaultValueSql("'00:00:00'");
            });

            modelBuilder.Entity<cao_escala_ranking>(entity =>
            {
                entity.HasKey(e => e.idescala)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<cao_escritorio>(entity =>
            {
                entity.HasKey(e => e.co_escritorio)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_escritorio).ValueGeneratedOnAdd();

                entity.Property(e => e.local)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<cao_fatura>(entity =>
            {
                entity.HasKey(e => e.co_fatura)
                    .HasName("PRIMARY");

                entity.Property(e => e.data_emissao).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_fatura_pag>(entity =>
            {
                entity.HasKey(e => e.id_fatura_pag)
                    .HasName("PRIMARY");

                entity.Property(e => e.dt_efetuado).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_feriados>(entity =>
            {
                entity.Property(e => e.ano).HasDefaultValueSql("'0'");

                entity.Property(e => e.dia).HasDefaultValueSql("'0'");

                entity.Property(e => e.mes).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<cao_formacao_idioma_usuario>(entity =>
            {
                entity.HasKey(e => new { e.co_usuario, e.co_idioma })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_formacao_usuario>(entity =>
            {
                entity.HasKey(e => new { e.co_usuario, e.tp_curso })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.tp_curso).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_help_autor>(entity =>
            {
                entity.HasKey(e => e.co_autor)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_funcao).HasDefaultValueSql("''");

                entity.Property(e => e.no_autor).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<cao_help_chamado>(entity =>
            {
                entity.HasKey(e => e.co_chamado)
                    .HasName("PRIMARY");

                entity.Property(e => e.dt_chamado).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_help_filial>(entity =>
            {
                entity.HasKey(e => e.co_filial)
                    .HasName("PRIMARY");

                entity.Property(e => e.estado)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.no_filial).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_help_motivo_chamado>(entity =>
            {
                entity.HasKey(e => e.co_motivo)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_motivo).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<cao_help_status_chamado>(entity =>
            {
                entity.HasKey(e => e.co_status)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_status).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<cao_help_tela_chamado>(entity =>
            {
                entity.HasKey(e => e.co_tela)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_tela).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_hist_ocorrencias_os>(entity =>
            {
                entity.HasKey(e => e.idocorrencia)
                    .HasName("PRIMARY");

                entity.Property(e => e.responsavel).HasDefaultValueSql("''");

                entity.Property(e => e.tipo).HasDefaultValueSql("'Interna'");

                entity.HasOne(d => d.co_osNavigation)
                    .WithMany(p => p.cao_hist_ocorrencias_os)
                    .HasForeignKey(d => d.co_os)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("cao_hist_ocorrencias_os_ibfk_2");

                entity.HasOne(d => d.co_usuarioNavigation)
                    .WithMany(p => p.cao_hist_ocorrencias_os)
                    .HasForeignKey(d => d.co_usuario)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("cao_hist_ocorrencias_os_ibfk_1");
            });

            modelBuilder.Entity<cao_horario_almoco>(entity =>
            {
                entity.Property(e => e.almoco_saida_hora).HasDefaultValueSql("'0'");

                entity.Property(e => e.almoco_volta_hora).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_log_chamado>(entity =>
            {
                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.dt_chamado).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_menu>(entity =>
            {
                entity.HasKey(e => e.co_menu)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_menu).ValueGeneratedOnAdd();

                entity.Property(e => e.ds_menu).HasDefaultValueSql("''");

                entity.Property(e => e.ds_pagina).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_menu_contador>(entity =>
            {
                entity.HasKey(e => new { e.co_usuario, e.co_menu })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_movimento>(entity =>
            {
                entity.HasKey(e => e.co_movimento)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.dt_entrada).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.dt_saida).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.dt_saida_almoco).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.dt_volta_almoco).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_movimento_justificativa>(entity =>
            {
                entity.HasKey(e => e.co_movimento_justificativa)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<cao_movimento_os>(entity =>
            {
                entity.HasKey(e => e.co_movimento_os)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<cao_noticia>(entity =>
            {
                entity.HasKey(e => e.co_noticia)
                    .HasName("PRIMARY");

                entity.Property(e => e.assunto).HasDefaultValueSql("''");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.dt_noticia).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.foto).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_obs_cliente>(entity =>
            {
                entity.HasKey(e => e.co_obs)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.descricao).HasDefaultValueSql("''");

                entity.Property(e => e.dt_obs).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_obs_sistema>(entity =>
            {
                entity.HasKey(e => e.co_obs)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<cao_ombudsman>(entity =>
            {
                entity.Property(e => e.data).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.HasOne(d => d.idcategoriaNavigation)
                    .WithMany(p => p.cao_ombudsman)
                    .HasForeignKey(d => d.idcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_ombudsman_ibfk_2");

                entity.HasOne(d => d.idtipoNavigation)
                    .WithMany(p => p.cao_ombudsman)
                    .HasForeignKey(d => d.idtipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_ombudsman_ibfk_1");
            });

            modelBuilder.Entity<cao_os>(entity =>
            {
                entity.HasKey(e => e.co_os)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_arquitetura).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_sistema).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_status).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("'0'");

                entity.Property(e => e.diretoria_sol).HasDefaultValueSql("'0'");

                entity.Property(e => e.ds_caracteristica).HasDefaultValueSql("'0'");

                entity.Property(e => e.ds_os).HasDefaultValueSql("'0'");

                entity.Property(e => e.nu_tel_sol).HasDefaultValueSql("'0'");

                entity.Property(e => e.usuario_sol).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<cao_os_analista>(entity =>
            {
                entity.HasKey(e => e.co_analista)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_os).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<cao_os_chamado>(entity =>
            {
                entity.HasKey(e => e.co_chamado)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_analista).HasDefaultValueSql("''");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.ds_chamado).HasDefaultValueSql("''");

                entity.Property(e => e.dt_chamado).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.tempo).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_os_daily_report>(entity =>
            {
                entity.HasKey(e => e.co_daily)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_fase).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_os).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<cao_os_email>(entity =>
            {
                entity.HasKey(e => e.co_email)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_os).HasDefaultValueSql("'0'");

                entity.Property(e => e.email).HasDefaultValueSql("'0'");

                entity.Property(e => e.nome).HasDefaultValueSql("''");

                entity.Property(e => e.senha).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<cao_os_fase>(entity =>
            {
                entity.HasKey(e => e.co_fase)
                    .HasName("PRIMARY");

                entity.Property(e => e.descricao).HasDefaultValueSql("'0'");

                entity.Property(e => e.descricao_ingl).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_os_item_menu>(entity =>
            {
                entity.HasKey(e => e.co_item)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_item).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_os_obs>(entity =>
            {
                entity.HasKey(e => e.co_obs)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_os).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("'0'");

                entity.Property(e => e.dt_obs).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_os_obs_chamado>(entity =>
            {
                entity.HasKey(e => e.co_obs)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_chamado).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("'0'");

                entity.Property(e => e.dt_obs).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_os_prazo>(entity =>
            {
                entity.HasKey(e => e.co_prazo)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_fase).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_os).HasDefaultValueSql("'0'");

                entity.Property(e => e.total_analista).HasDefaultValueSql("'0'");

                entity.Property(e => e.total_hora).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<cao_os_status>(entity =>
            {
                entity.HasKey(e => e.co_status_atual)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_status)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<cao_pagamento>(entity =>
            {
                entity.HasKey(e => e.co_pagamento)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.dt_pagamento).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.dt_referencia_pagamento).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.tp_pagamento)
                    .HasDefaultValueSql("'0'")
                    .IsFixedLength();
            });

            modelBuilder.Entity<cao_participacao_funcionario>(entity =>
            {
                entity.HasKey(e => e.co_part_funcionario)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.dt_referencia).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_permissao>(entity =>
            {
                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.permissao_hora_extra).HasDefaultValueSql("'0'");

                entity.Property(e => e.permissao_intervalo).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.co_usuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.co_usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_permissao_ibfk_1");
            });

            modelBuilder.Entity<cao_permissao_hora_extra>(entity =>
            {
                entity.HasKey(e => e.id_permissao)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<cao_pontos_conhecimento>(entity =>
            {
                entity.HasKey(e => e.idpontos)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_coordenador).HasDefaultValueSql("''");

                entity.HasOne(d => d.co_coordenadorNavigation)
                    .WithMany(p => p.cao_pontos_conhecimento)
                    .HasForeignKey(d => d.co_coordenador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_pontos_conhecimento_ibfk_2");

                entity.HasOne(d => d.idconhecimentoNavigation)
                    .WithMany(p => p.cao_pontos_conhecimento)
                    .HasForeignKey(d => d.idconhecimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_pontos_conhecimento_ibfk_3");

                entity.HasOne(d => d.pontuacaoNavigation)
                    .WithMany(p => p.cao_pontos_conhecimento)
                    .HasForeignKey(d => d.pontuacao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_pontos_conhecimento_ibfk_1");
            });

            modelBuilder.Entity<cao_ramo>(entity =>
            {
                entity.HasKey(e => e.co_ramo)
                    .HasName("PRIMARY");

                entity.HasComment("Ramo de atividade de Clientes");

                entity.Property(e => e.ds_ramo).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_salario>(entity =>
            {
                entity.HasKey(e => new { e.co_usuario, e.dt_alteracao })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.dt_alteracao).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_salario_pag>(entity =>
            {
                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.dt_efetuado).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.id_pagamento).ValueGeneratedOnAdd();

                entity.Property(e => e.status).HasDefaultValueSql("'Pendente'");

                entity.HasOne(d => d.co_usuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.co_usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cao_salario_pag_ibfk_1");
            });

            modelBuilder.Entity<cao_servico>(entity =>
            {
                entity.HasKey(e => e.co_servico)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_servico).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_sistema>(entity =>
            {
                entity.HasKey(e => e.co_sistema)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_arquitetura).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_cliente).HasDefaultValueSql("'0'");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<cao_sistema_obs>(entity =>
            {
                entity.HasKey(e => e.co_obs)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<cao_status_agendamento>(entity =>
            {
                entity.HasKey(e => e.co_status_agendamento)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_status_agendamento).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_status_cliente>(entity =>
            {
                entity.HasKey(e => e.co_status)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_status).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_status_cliente_complemento>(entity =>
            {
                entity.HasKey(e => e.co_complemento_status)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_status).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_status_os>(entity =>
            {
                entity.HasKey(e => e.co_status_atual)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_status).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_temp_import>(entity =>
            {
                entity.HasKey(e => e.codigo)
                    .HasName("PRIMARY");

                entity.Property(e => e.descricao).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_tipo_conhecimento_usuario>(entity =>
            {
                entity.HasKey(e => e.co_conhecimento)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<cao_tipo_custo>(entity =>
            {
                entity.HasKey(e => e.co_tipo_custo)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_tipo_custo).ValueGeneratedOnAdd();

                entity.Property(e => e.descricao).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_tipo_idioma_usuario>(entity =>
            {
                entity.HasKey(e => e.co_idioma)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<cao_tipo_ombudsman>(entity =>
            {
                entity.HasKey(e => e.idtipo)
                    .HasName("PRIMARY");

                entity.Property(e => e.descricao).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_tipo_sistema_usuario>(entity =>
            {
                entity.HasKey(e => e.co_sistema)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<cao_uf>(entity =>
            {
                entity.HasKey(e => e.co_uf)
                    .HasName("PRIMARY");

                entity.Property(e => e.ds_uf)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<cao_usuario>(entity =>
            {
                entity.HasKey(e => e.co_usuario)
                    .HasName("PRIMARY");

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.ds_senha).HasDefaultValueSql("''");

                entity.Property(e => e.dt_admissao_empresa).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.dt_alteracao).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.dt_expiracao).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.dt_inclusao).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.dt_nascimento).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.no_usuario).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<cao_usuario_dt_disp>(entity =>
            {
                entity.HasKey(e => e.co_dt_disp)
                    .HasName("PRIMARY");

                entity.Property(e => e.dt_alt).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.dt_disp).HasDefaultValueSql("'1000-01-01 00:00:00'");
            });

            modelBuilder.Entity<cao_valor_descanso>(entity =>
            {
                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.mes_referencia).HasDefaultValueSql("''");

                entity.Property(e => e.segundos).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<permissao_sistema>(entity =>
            {
                entity.HasKey(e => new { e.co_usuario, e.co_tipo_usuario, e.co_sistema })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.Property(e => e.co_usuario).HasDefaultValueSql("''");

                entity.Property(e => e.dt_atualizacao).HasDefaultValueSql("'1000-01-01 00:00:00'");

                entity.Property(e => e.in_ativo)
                    .HasDefaultValueSql("'S'")
                    .IsFixedLength();
            });

            modelBuilder.Entity<tipo_usuario>(entity =>
            {
                entity.HasKey(e => new { e.co_tipo_usuario, e.co_sistema })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.Property(e => e.ds_tipo_usuario).HasDefaultValueSql("''");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
