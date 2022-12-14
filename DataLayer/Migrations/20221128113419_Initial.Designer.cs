// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(appDbContext))]
    [Migration("20221128113419_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataLayer.Model.Partie", b =>
                {
                    b.Property<int>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Guid"));

                    b.Property<string>("GrillePartie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TirageId")
                        .HasColumnType("int");

                    b.HasKey("Guid");

                    b.HasIndex("TirageId");

                    b.ToTable("Partie");
                });

            modelBuilder.Entity("DataLayer.Model.Tirage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CagnotteTirage")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateHeureTirage")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResultatTirage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tirage");
                });

            modelBuilder.Entity("DataLayer.Model.Partie", b =>
                {
                    b.HasOne("DataLayer.Model.Tirage", "Tirage")
                        .WithMany("Partie")
                        .HasForeignKey("TirageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tirage");
                });

            modelBuilder.Entity("DataLayer.Model.Tirage", b =>
                {
                    b.Navigation("Partie");
                });
#pragma warning restore 612, 618
        }
    }
}
