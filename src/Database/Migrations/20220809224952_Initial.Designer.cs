﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(CmsContext))]
    [Migration("20220809224952_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("cms")
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Cms.Content", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("active");

                    b.Property<string>("Body")
                        .HasColumnType("text");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("NotDefined");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TimestampTz")
                        .HasColumnName("created");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(330)
                        .HasColumnType("varchar");

                    b.Property<string>("MetaRobots")
                        .HasMaxLength(35)
                        .HasColumnType("varchar");

                    b.Property<string>("MetaTitle")
                        .HasMaxLength(65)
                        .HasColumnType("varchar");

                    b.Property<string>("MetaViewPort")
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("TimestampTz")
                        .HasColumnName("modified");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("Draft");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Content", "cms");
                });

            modelBuilder.Entity("Models.Cms.ContentSubject", b =>
                {
                    b.Property<Guid>("ContentId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uuid");

                    b.HasIndex("SubjectId");

                    b.HasIndex("ContentId", "SubjectId")
                        .IsUnique()
                        .HasDatabaseName("ContentSubject_unique_constraint");

                    b.ToTable("ContentSubjects", "cms");
                });

            modelBuilder.Entity("Models.Cms.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true)
                        .HasColumnName("active");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TimestampTz")
                        .HasColumnName("created");

                    b.Property<DateTime>("Modified")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("TimestampTz")
                        .HasColumnName("modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar");

                    b.Property<string>("Permalink")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar");

                    b.Property<string>("SubjectType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name", "SubjectType", "Permalink")
                        .IsUnique();

                    b.ToTable("Subject", "cms");
                });

            modelBuilder.Entity("Models.Cms.ContentSubject", b =>
                {
                    b.HasOne("Models.Cms.Content", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Cms.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");

                    b.Navigation("Subject");
                });
#pragma warning restore 612, 618
        }
    }
}
