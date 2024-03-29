﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ticketApp.Models;

namespace ticketApp.Migrations
{
    [DbContext(typeof(TicketSystemContext))]
    [Migration("20190710114029_CommentingSystem")]
    partial class CommentingSystem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
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

                    b.Property<string>("Comments");

                    b.Property<DateTime>("DateSubmitted");

                    b.Property<DateTime>("Deadline");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2147483647);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsArchived");

                    b.Property<string>("SprintList")
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
