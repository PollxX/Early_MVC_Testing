﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsEvents.Models;

namespace SportsEvents.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200216144155_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsEvents.Models.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EndDate");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<string>("StartDate");

                    b.HasKey("EventID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("SportsEvents.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Biography");

                    b.Property<string>("DOB");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<string>("KeySkills");

                    b.Property<string>("Name");

                    b.Property<string>("PlaceOfWork");

                    b.Property<string>("Postcode");

                    b.Property<string>("Telephone");

                    b.HasKey("PersonID");

                    b.ToTable("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
