﻿// <auto-generated />
using System;
using CareMiApi4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace CareMiApi4.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241028212709_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CareMiApi4.Models.AgendamentoExame", b =>
                {
                    b.Property<int>("CdAgendamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CdAgendamento"));

                    b.Property<string>("DsNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("DsObservacao")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("NVARCHAR2(250)");

                    b.Property<DateTime>("DtAgendamento")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("DtEnvio")
                        .HasColumnType("DATE");

                    b.Property<int?>("MedicoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<long>("NrCPF")
                        .HasColumnType("NUMBER(11)");

                    b.Property<long>("NrRG")
                        .HasColumnType("NUMBER(15)");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CdAgendamento");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("t_cm4_agendamento_exame");
                });

            modelBuilder.Entity("CareMiApi4.Models.Carteirinha", b =>
                {
                    b.Property<int>("CdCarteirinha")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CdCarteirinha"));

                    b.Property<string>("DsAcomodacao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("DsCarencia")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("DATE");

                    b.Property<string>("NmEmpresa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("NmPaciente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("NmPlanoSaude")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<long>("NrCns")
                        .HasColumnType("NUMBER(15)");

                    b.Property<int?>("PacienteCdPaciente")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CdCarteirinha");

                    b.HasIndex("PacienteCdPaciente")
                        .IsUnique()
                        .HasFilter("\"PacienteCdPaciente\" IS NOT NULL");

                    b.ToTable("t_cm4_carteirinha");
                });

            modelBuilder.Entity("CareMiApi4.Models.Exame", b =>
                {
                    b.Property<int>("CdExame")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CdExame"));

                    b.Property<int?>("AgendamentoExameId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("DsExame")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<DateTime>("DtExame")
                        .HasColumnType("DATE");

                    b.HasKey("CdExame");

                    b.HasIndex("AgendamentoExameId");

                    b.ToTable("t_cm4_exame");
                });

            modelBuilder.Entity("CareMiApi4.Models.Login", b =>
                {
                    b.Property<int>("CdLogin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CdLogin"));

                    b.Property<string>("DsSenha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<int>("FgAtivo")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("NrCpf")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("NVARCHAR2(15)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CdLogin");

                    b.HasIndex("UsuarioId")
                        .IsUnique()
                        .HasFilter("\"UsuarioId\" IS NOT NULL");

                    b.ToTable("t_cm4_login");
                });

            modelBuilder.Entity("CareMiApi4.Models.Medico", b =>
                {
                    b.Property<int>("CdMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CdMedico"));

                    b.Property<string>("DsCrm")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("NVARCHAR2(15)");

                    b.Property<string>("DsEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("DsEspecializacao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVARCHAR2(200)");

                    b.Property<string>("NmMedico")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<int>("NrCelular")
                        .HasColumnType("NUMBER(9)");

                    b.HasKey("CdMedico");

                    b.ToTable("t_cm4_medico");
                });

            modelBuilder.Entity("CareMiApi4.Models.Paciente", b =>
                {
                    b.Property<int>("CdPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CdPaciente"));

                    b.Property<string>("FlSexoBiologico")
                        .IsRequired()
                        .HasColumnType("CHAR(1)");

                    b.Property<string>("NmGrupoSanguineo")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("NVARCHAR2(6)");

                    b.Property<string>("NmPaciente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<byte>("NrAltura")
                        .HasColumnType("NUMBER(4)");

                    b.Property<int>("NrPeso")
                        .HasColumnType("NUMBER(6)");

                    b.Property<int?>("UsuarioCdUsuario")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("CdPaciente");

                    b.HasIndex("UsuarioCdUsuario")
                        .IsUnique()
                        .HasFilter("\"UsuarioCdUsuario\" IS NOT NULL");

                    b.ToTable("t_cm4_paciente");
                });

            modelBuilder.Entity("CareMiApi4.Models.PacientePlanoSaude", b =>
                {
                    b.Property<int>("PacienteId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("PlanoSaudeId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("CdPlanoPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CdPlanoPaciente"));

                    b.Property<DateTime>("DtFim")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("DtInicio")
                        .HasColumnType("DATE");

                    b.Property<long>("NrCarteira")
                        .HasColumnType("NUMBER(15)");

                    b.Property<int?>("PacienteCdPaciente")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("PlanoSaudeCdPlanoSaude")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("PacienteId", "PlanoSaudeId");

                    b.HasIndex("PacienteCdPaciente");

                    b.HasIndex("PlanoSaudeCdPlanoSaude");

                    b.HasIndex("PlanoSaudeId");

                    b.ToTable("t_cm4_paciente_plano_saude");
                });

            modelBuilder.Entity("CareMiApi4.Models.PlanoSaude", b =>
                {
                    b.Property<int>("CdPlanoSaude")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CdPlanoSaude"));

                    b.Property<string>("DsRazaoSocial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("DATE");

                    b.Property<int>("FgAtivo")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("NmContato")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("NmFantasia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<long>("NrCnpj")
                        .HasColumnType("NUMBER(14)");

                    b.Property<int>("NrTelefone")
                        .HasColumnType("NUMBER(8)");

                    b.HasKey("CdPlanoSaude");

                    b.ToTable("t_cm4_plano_saude");
                });

            modelBuilder.Entity("CareMiApi4.Models.ResultadoExame", b =>
                {
                    b.Property<int>("CdResultado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CdResultado"));

                    b.Property<string>("DsObservacoes")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("DsResultado")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("NVARCHAR2(500)");

                    b.Property<short>("NrColesterolHDL")
                        .HasColumnType("NUMBER(5)");

                    b.Property<short>("NrColesterolLDL")
                        .HasColumnType("NUMBER(5)");

                    b.Property<short>("NrColesterolTotal")
                        .HasColumnType("NUMBER(5)");

                    b.Property<decimal>("NrCreatinina")
                        .HasColumnType("NUMBER(5, 2)");

                    b.Property<short>("NrGlobulosBrancos")
                        .HasColumnType("NUMBER(5)");

                    b.Property<short>("NrGlobulosVermelhos")
                        .HasColumnType("NUMBER(5)");

                    b.Property<short>("NrHemoglobinaGlicada")
                        .HasColumnType("NUMBER(5)");

                    b.Property<short>("NrHormônioTireostimulanteTSH")
                        .HasColumnType("NUMBER(5)");

                    b.Property<short>("NrPlaquetas")
                        .HasColumnType("NUMBER(5)");

                    b.Property<short>("NrTriglicerides")
                        .HasColumnType("NUMBER(5)");

                    b.Property<int?>("TExameCdExame")
                        .HasColumnType("NUMBER(10)");

                    b.Property<decimal>("VrResultado")
                        .HasColumnType("NUMBER(5, 2)");

                    b.HasKey("CdResultado");

                    b.HasIndex("TExameCdExame")
                        .IsUnique()
                        .HasFilter("\"TExameCdExame\" IS NOT NULL");

                    b.ToTable("t_cm4_resultado_exame");

                    b.HasData(
                        new
                        {
                            CdResultado = 1,
                            DsObservacoes = "Tudo dentro dos parâmetros",
                            DsResultado = "Normal",
                            NrColesterolHDL = (short)60,
                            NrColesterolLDL = (short)100,
                            NrColesterolTotal = (short)180,
                            NrCreatinina = 1m,
                            NrGlobulosBrancos = (short)6000,
                            NrGlobulosVermelhos = (short)4500,
                            NrHemoglobinaGlicada = (short)5,
                            NrHormônioTireostimulanteTSH = (short)2,
                            NrPlaquetas = (short)-12144,
                            NrTriglicerides = (short)140,
                            VrResultado = 120.5m
                        },
                        new
                        {
                            CdResultado = 2,
                            DsObservacoes = "Colesterol elevado",
                            DsResultado = "Alto",
                            NrColesterolHDL = (short)50,
                            NrColesterolLDL = (short)160,
                            NrColesterolTotal = (short)240,
                            NrCreatinina = 1.2m,
                            NrGlobulosBrancos = (short)6100,
                            NrGlobulosVermelhos = (short)4700,
                            NrHemoglobinaGlicada = (short)6,
                            NrHormônioTireostimulanteTSH = (short)3,
                            NrPlaquetas = (short)-7144,
                            NrTriglicerides = (short)200,
                            VrResultado = 220.8m
                        },
                        new
                        {
                            CdResultado = 3,
                            DsObservacoes = "Anemia detectada",
                            DsResultado = "Baixo",
                            NrColesterolHDL = (short)70,
                            NrColesterolLDL = (short)80,
                            NrColesterolTotal = (short)150,
                            NrCreatinina = 0.8m,
                            NrGlobulosBrancos = (short)5500,
                            NrGlobulosVermelhos = (short)3800,
                            NrHemoglobinaGlicada = (short)4,
                            NrHormônioTireostimulanteTSH = (short)1,
                            NrPlaquetas = (short)-32144,
                            NrTriglicerides = (short)130,
                            VrResultado = 90.3m
                        },
                        new
                        {
                            CdResultado = 4,
                            DsObservacoes = "Nível elevado de glicose",
                            DsResultado = "Pré-diabetes",
                            NrColesterolHDL = (short)55,
                            NrColesterolLDL = (short)105,
                            NrColesterolTotal = (short)190,
                            NrCreatinina = 1m,
                            NrGlobulosBrancos = (short)5900,
                            NrGlobulosVermelhos = (short)4200,
                            NrHemoglobinaGlicada = (short)6,
                            NrHormônioTireostimulanteTSH = (short)2,
                            NrPlaquetas = (short)-17144,
                            NrTriglicerides = (short)150,
                            VrResultado = 140.0m
                        },
                        new
                        {
                            CdResultado = 5,
                            DsObservacoes = "Pressão arterial acima do normal",
                            DsResultado = "Hipertensão",
                            NrColesterolHDL = (short)65,
                            NrColesterolLDL = (short)120,
                            NrColesterolTotal = (short)200,
                            NrCreatinina = 1.1m,
                            NrGlobulosBrancos = (short)6000,
                            NrGlobulosVermelhos = (short)4600,
                            NrHemoglobinaGlicada = (short)5,
                            NrHormônioTireostimulanteTSH = (short)2,
                            NrPlaquetas = (short)-2144,
                            NrTriglicerides = (short)170,
                            VrResultado = 160.0m
                        },
                        new
                        {
                            CdResultado = 6,
                            DsObservacoes = "Nível de hemoglobina abaixo do ideal",
                            DsResultado = "Anemia leve",
                            NrColesterolHDL = (short)60,
                            NrColesterolLDL = (short)75,
                            NrColesterolTotal = (short)155,
                            NrCreatinina = 0.9m,
                            NrGlobulosBrancos = (short)5600,
                            NrGlobulosVermelhos = (short)3500,
                            NrHemoglobinaGlicada = (short)4,
                            NrHormônioTireostimulanteTSH = (short)1,
                            NrPlaquetas = (short)-27144,
                            NrTriglicerides = (short)125,
                            VrResultado = 85.0m
                        },
                        new
                        {
                            CdResultado = 7,
                            DsObservacoes = "Glicose elevada",
                            DsResultado = "Diabetes",
                            NrColesterolHDL = (short)40,
                            NrColesterolLDL = (short)170,
                            NrColesterolTotal = (short)250,
                            NrCreatinina = 1.3m,
                            NrGlobulosBrancos = (short)6000,
                            NrGlobulosVermelhos = (short)4400,
                            NrHemoglobinaGlicada = (short)8,
                            NrHormônioTireostimulanteTSH = (short)3,
                            NrPlaquetas = (short)-14144,
                            NrTriglicerides = (short)220,
                            VrResultado = 240.0m
                        },
                        new
                        {
                            CdResultado = 8,
                            DsObservacoes = "Nível elevado de TSH",
                            DsResultado = "Hipotireoidismo",
                            NrColesterolHDL = (short)58,
                            NrColesterolLDL = (short)110,
                            NrColesterolTotal = (short)210,
                            NrCreatinina = 1.0m,
                            NrGlobulosBrancos = (short)5700,
                            NrGlobulosVermelhos = (short)4300,
                            NrHemoglobinaGlicada = (short)5,
                            NrHormônioTireostimulanteTSH = (short)5,
                            NrPlaquetas = (short)-22144,
                            NrTriglicerides = (short)160,
                            VrResultado = 105.3m
                        },
                        new
                        {
                            CdResultado = 9,
                            DsObservacoes = "Recomenda-se dieta para redução de colesterol",
                            DsResultado = "Colesterol alto",
                            NrColesterolHDL = (short)50,
                            NrColesterolLDL = (short)150,
                            NrColesterolTotal = (short)230,
                            NrCreatinina = 1.1m,
                            NrGlobulosBrancos = (short)6100,
                            NrGlobulosVermelhos = (short)4500,
                            NrHemoglobinaGlicada = (short)5,
                            NrHormônioTireostimulanteTSH = (short)2,
                            NrPlaquetas = (short)-17144,
                            NrTriglicerides = (short)190,
                            VrResultado = 195.4m
                        },
                        new
                        {
                            CdResultado = 10,
                            DsObservacoes = "Necessário acompanhamento médico urgente",
                            DsResultado = "Anemia severa",
                            NrColesterolHDL = (short)65,
                            NrColesterolLDL = (short)60,
                            NrColesterolTotal = (short)140,
                            NrCreatinina = 0.7m,
                            NrGlobulosBrancos = (short)5200,
                            NrGlobulosVermelhos = (short)3000,
                            NrHemoglobinaGlicada = (short)3,
                            NrHormônioTireostimulanteTSH = (short)1,
                            NrPlaquetas = (short)23392,
                            NrTriglicerides = (short)110,
                            VrResultado = 70.2m
                        });
                });

            modelBuilder.Entity("CareMiApi4.Models.Usuario", b =>
                {
                    b.Property<int>("CdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CdUsuario"));

                    b.Property<string>("DsEstadoCivil")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("DsNacionalidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("DsProfissao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<DateTime>("DtCadastro")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("DtNascimento")
                        .HasColumnType("DATE");

                    b.Property<int>("FgAtivo")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("NmUsuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR2(20)");

                    b.Property<string>("NrCpf")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("NVARCHAR2(15)");

                    b.Property<string>("NrRg")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("NVARCHAR2(15)");

                    b.Property<string>("NrTelefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("NVARCHAR2(15)");

                    b.HasKey("CdUsuario");

                    b.ToTable("t_cm4_usuario");
                });

            modelBuilder.Entity("CareMiApi4.Models.AgendamentoExame", b =>
                {
                    b.HasOne("CareMiApi4.Models.Medico", "Medico")
                        .WithMany("AgendamentoExame")
                        .HasForeignKey("MedicoId");

                    b.HasOne("CareMiApi4.Models.Paciente", "Paciente")
                        .WithMany("AgendamentoExame")
                        .HasForeignKey("PacienteId");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("CareMiApi4.Models.Carteirinha", b =>
                {
                    b.HasOne("CareMiApi4.Models.Paciente", "Paciente")
                        .WithOne("Carteirinha")
                        .HasForeignKey("CareMiApi4.Models.Carteirinha", "PacienteCdPaciente");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("CareMiApi4.Models.Exame", b =>
                {
                    b.HasOne("CareMiApi4.Models.AgendamentoExame", "AgendamentoExame")
                        .WithMany("Exame")
                        .HasForeignKey("AgendamentoExameId");

                    b.Navigation("AgendamentoExame");
                });

            modelBuilder.Entity("CareMiApi4.Models.Login", b =>
                {
                    b.HasOne("CareMiApi4.Models.Usuario", "Usuario")
                        .WithOne("Login")
                        .HasForeignKey("CareMiApi4.Models.Login", "UsuarioId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CareMiApi4.Models.Paciente", b =>
                {
                    b.HasOne("CareMiApi4.Models.Usuario", "Usuario")
                        .WithOne("Paciente")
                        .HasForeignKey("CareMiApi4.Models.Paciente", "UsuarioCdUsuario");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CareMiApi4.Models.PacientePlanoSaude", b =>
                {
                    b.HasOne("CareMiApi4.Models.Paciente", null)
                        .WithMany("PacientePlanosSaude")
                        .HasForeignKey("PacienteCdPaciente");

                    b.HasOne("CareMiApi4.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CareMiApi4.Models.PlanoSaude", null)
                        .WithMany("PacientePlanosSaude")
                        .HasForeignKey("PlanoSaudeCdPlanoSaude");

                    b.HasOne("CareMiApi4.Models.PlanoSaude", "PlanoSaude")
                        .WithMany()
                        .HasForeignKey("PlanoSaudeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("PlanoSaude");
                });

            modelBuilder.Entity("CareMiApi4.Models.ResultadoExame", b =>
                {
                    b.HasOne("CareMiApi4.Models.Exame", "Exame")
                        .WithOne("ResultadoExame")
                        .HasForeignKey("CareMiApi4.Models.ResultadoExame", "TExameCdExame");

                    b.Navigation("Exame");
                });

            modelBuilder.Entity("CareMiApi4.Models.AgendamentoExame", b =>
                {
                    b.Navigation("Exame");
                });

            modelBuilder.Entity("CareMiApi4.Models.Exame", b =>
                {
                    b.Navigation("ResultadoExame");
                });

            modelBuilder.Entity("CareMiApi4.Models.Medico", b =>
                {
                    b.Navigation("AgendamentoExame");
                });

            modelBuilder.Entity("CareMiApi4.Models.Paciente", b =>
                {
                    b.Navigation("AgendamentoExame");

                    b.Navigation("Carteirinha");

                    b.Navigation("PacientePlanosSaude");
                });

            modelBuilder.Entity("CareMiApi4.Models.PlanoSaude", b =>
                {
                    b.Navigation("PacientePlanosSaude");
                });

            modelBuilder.Entity("CareMiApi4.Models.Usuario", b =>
                {
                    b.Navigation("Login");

                    b.Navigation("Paciente");
                });
#pragma warning restore 612, 618
        }
    }
}
