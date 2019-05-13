﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ticketApp.Models;

namespace ticketApp.Migrations
{
    [DbContext(typeof(TicketSystemContext))]
    partial class TicketSystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ticketApp.Models.Ticket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("AppointedTo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Attachments");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("DateSubmitted");

                    b.Property<DateTime>("Deadline");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2147483647);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("OurSprintList")
                        .IsRequired();

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
