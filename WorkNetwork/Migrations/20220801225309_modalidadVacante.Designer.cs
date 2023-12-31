﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkNetwork.Data;

#nullable disable

namespace WorkNetwork.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220801225309_modalidadVacante")]
    partial class modalidadVacante
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WorkNetwork.Models.Empresa", b =>
                {
                    b.Property<int>("EmpresaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpresaID"), 1L, 1);

                    b.Property<int>("CUIT")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("LocalidadID")
                        .HasColumnType("int");

                    b.Property<int?>("NumeroDeDocumento")
                        .HasColumnType("int");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RubroID")
                        .HasColumnType("int");

                    b.Property<int>("Telefono1")
                        .HasColumnType("int");

                    b.Property<int?>("Telefono2")
                        .HasColumnType("int");

                    b.Property<int>("TipoEmpresa")
                        .HasColumnType("int");

                    b.HasKey("EmpresaID");

                    b.HasIndex("LocalidadID");

                    b.HasIndex("RubroID");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("WorkNetwork.Models.Localidad", b =>
                {
                    b.Property<int>("LocalidadID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocalidadID"), 1L, 1);

                    b.Property<int>("CP")
                        .HasColumnType("int");

                    b.Property<string>("NombreLocalidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinciaID")
                        .HasColumnType("int");

                    b.HasKey("LocalidadID");

                    b.HasIndex("ProvinciaID");

                    b.ToTable("Localidad");
                });

            modelBuilder.Entity("WorkNetwork.Models.Pais", b =>
                {
                    b.Property<int>("PaisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaisID"), 1L, 1);

                    b.Property<string>("NombrePais")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaisID");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("WorkNetwork.Models.Persona", b =>
                {
                    b.Property<int>("PersonaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonaID"), 1L, 1);

                    b.Property<string>("ApellidoPersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CantidadHijos")
                        .HasColumnType("int");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DomicilioPersona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("LocalidadID")
                        .HasColumnType("int");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroDocumento")
                        .HasColumnType("int");

                    b.Property<int>("SituacionLaboral")
                        .HasColumnType("int");

                    b.Property<int>("Telefono1")
                        .HasColumnType("int");

                    b.Property<int?>("Telefono2")
                        .HasColumnType("int");

                    b.Property<int>("TipoDocumento")
                        .HasColumnType("int");

                    b.Property<string>("TituloAcademico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonaID");

                    b.HasIndex("LocalidadID");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("WorkNetwork.Models.PersonaVacante", b =>
                {
                    b.Property<int>("PersonaVacanteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonaVacanteID"), 1L, 1);

                    b.Property<int>("EmpresaID")
                        .HasColumnType("int");

                    b.Property<bool>("NotificacionVista")
                        .HasColumnType("bit");

                    b.Property<int>("PersonaID")
                        .HasColumnType("int");

                    b.Property<int>("VacanteID")
                        .HasColumnType("int");

                    b.HasKey("PersonaVacanteID");

                    b.ToTable("PersonaVacante");
                });

            modelBuilder.Entity("WorkNetwork.Models.Provincia", b =>
                {
                    b.Property<int>("ProvinciaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProvinciaID"), 1L, 1);

                    b.Property<string>("NombreProvincia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaisID")
                        .HasColumnType("int");

                    b.HasKey("ProvinciaID");

                    b.HasIndex("PaisID");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("WorkNetwork.Models.Rubro", b =>
                {
                    b.Property<int>("RubroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RubroID"), 1L, 1);

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("NombreRubro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RubroID");

                    b.ToTable("Rubro");
                });

            modelBuilder.Entity("WorkNetwork.Models.Vacante", b =>
                {
                    b.Property<int>("VacanteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VacanteID"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpresaID")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienciaRequerida")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaDeFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Idiomas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Imagen")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("LocalidadID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VacanteID");

                    b.HasIndex("EmpresaID");

                    b.ToTable("Vacante");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkNetwork.Models.Empresa", b =>
                {
                    b.HasOne("WorkNetwork.Models.Localidad", "Localidad")
                        .WithMany("Empresas")
                        .HasForeignKey("LocalidadID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WorkNetwork.Models.Rubro", "Rubro")
                        .WithMany("Empresas")
                        .HasForeignKey("RubroID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Localidad");

                    b.Navigation("Rubro");
                });

            modelBuilder.Entity("WorkNetwork.Models.Localidad", b =>
                {
                    b.HasOne("WorkNetwork.Models.Provincia", "Provincia")
                        .WithMany("Localidades")
                        .HasForeignKey("ProvinciaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("WorkNetwork.Models.Persona", b =>
                {
                    b.HasOne("WorkNetwork.Models.Localidad", "Localidad")
                        .WithMany("Personas")
                        .HasForeignKey("LocalidadID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Localidad");
                });

            modelBuilder.Entity("WorkNetwork.Models.Provincia", b =>
                {
                    b.HasOne("WorkNetwork.Models.Pais", "Pais")
                        .WithMany("Provincias")
                        .HasForeignKey("PaisID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("WorkNetwork.Models.Vacante", b =>
                {
                    b.HasOne("WorkNetwork.Models.Empresa", "Empresa")
                        .WithMany("Vacantes")
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("WorkNetwork.Models.Empresa", b =>
                {
                    b.Navigation("Vacantes");
                });

            modelBuilder.Entity("WorkNetwork.Models.Localidad", b =>
                {
                    b.Navigation("Empresas");

                    b.Navigation("Personas");
                });

            modelBuilder.Entity("WorkNetwork.Models.Pais", b =>
                {
                    b.Navigation("Provincias");
                });

            modelBuilder.Entity("WorkNetwork.Models.Provincia", b =>
                {
                    b.Navigation("Localidades");
                });

            modelBuilder.Entity("WorkNetwork.Models.Rubro", b =>
                {
                    b.Navigation("Empresas");
                });
#pragma warning restore 612, 618
        }
    }
}
