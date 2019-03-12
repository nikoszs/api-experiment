﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bookings.api.Contexts;

namespace bookings.api.Migrations
{
    [DbContext(typeof(FlightBookingContext))]
    [Migration("20190312212914_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api.Entities.Booking", b =>
                {
                    b.Property<Guid>("BookingId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("FlightId");

                    b.Property<Guid>("PassengerId");

                    b.HasKey("BookingId");

                    b.HasIndex("FlightId");

                    b.HasIndex("PassengerId");

                    b.ToTable("Booking");

                    b.HasData(
                        new { BookingId = new Guid("1b9e4b3a-998e-4455-a140-8e08d2aec327"), FlightId = new Guid("27340d4a-4e2a-40aa-9397-4846f113ff0a"), PassengerId = new Guid("79a20e84-9884-435e-9d9b-d289f86ba417") },
                        new { BookingId = new Guid("cb407a2d-80df-41a7-882b-6466e66fc0f9"), FlightId = new Guid("27340d4a-4e2a-40aa-9397-4846f113ff0a"), PassengerId = new Guid("1a932098-0370-4daa-afb4-dc9efbf8489a") },
                        new { BookingId = new Guid("0eb96b73-7e26-4142-a45c-212fc1f4f34a"), FlightId = new Guid("d53eee6f-e184-45c7-aa14-e2f1bba458f7"), PassengerId = new Guid("1a932098-0370-4daa-afb4-dc9efbf8489a") },
                        new { BookingId = new Guid("0c5a45b3-2f08-4ef9-8c07-ce52bcdb1519"), FlightId = new Guid("79e640fb-9f34-4a68-93c7-ed331760c88b"), PassengerId = new Guid("6c01b522-8ccc-4d3a-ba80-bdecba3ccf11") },
                        new { BookingId = new Guid("82966a83-94ee-4c5a-be2c-f78e35f91b90"), FlightId = new Guid("79e640fb-9f34-4a68-93c7-ed331760c88b"), PassengerId = new Guid("d40b35dd-09d5-4409-8c6e-b7e7efd3be6d") }
                    );
                });

            modelBuilder.Entity("api.Entities.Flight", b =>
                {
                    b.Property<Guid>("FlightId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AircraftIcao24")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Callsign")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("DepartureAirport")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("Date");

                    b.Property<TimeSpan>("DepartureTime")
                        .HasColumnType("Time");

                    b.Property<string>("DestinationAirport")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DestinationDate")
                        .HasColumnType("Date");

                    b.Property<TimeSpan>("DestinationTime")
                        .HasColumnType("Time");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("FlightId");

                    b.ToTable("Flight");

                    b.HasData(
                        new { FlightId = new Guid("27340d4a-4e2a-40aa-9397-4846f113ff0a"), AircraftIcao24 = "406f74", Callsign = "BAW39", DepartureAirport = "London Heathrow International Airport", DepartureDate = new DateTime(2019, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), DepartureTime = new TimeSpan(0, 16, 25, 0, 0), DestinationAirport = "Los Angeles International Airport", DestinationDate = new DateTime(2019, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), DestinationTime = new TimeSpan(0, 10, 25, 0, 0), FlightNumber = "BA39" },
                        new { FlightId = new Guid("d53eee6f-e184-45c7-aa14-e2f1bba458f7"), AircraftIcao24 = "4ca4e6", Callsign = "RYR61LP", DepartureAirport = "Lisbon International Airport", DepartureDate = new DateTime(2019, 2, 17, 0, 0, 0, 0, DateTimeKind.Utc), DepartureTime = new TimeSpan(0, 18, 55, 0, 0), DestinationAirport = "Rome - Ciampino International Airport", DestinationDate = new DateTime(2019, 2, 17, 0, 0, 0, 0, DateTimeKind.Utc), DestinationTime = new TimeSpan(0, 22, 55, 0, 0), FlightNumber = "FR2693" },
                        new { FlightId = new Guid("79e640fb-9f34-4a68-93c7-ed331760c88b"), AircraftIcao24 = "00b205", Callsign = "SAA041", DepartureAirport = "Victoria Falls Airport", DepartureDate = new DateTime(2019, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), DepartureTime = new TimeSpan(0, 13, 25, 0, 0), DestinationAirport = "Johannesburg OR Tambo International Airport", DestinationDate = new DateTime(2019, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), DestinationTime = new TimeSpan(0, 15, 5, 0, 0), FlightNumber = "SA41" }
                    );
                });

            modelBuilder.Entity("api.Entities.Passenger", b =>
                {
                    b.Property<Guid>("PassengerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age")
                        .HasMaxLength(150);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("PassengerId");

                    b.ToTable("Passenger");

                    b.HasData(
                        new { PassengerId = new Guid("79a20e84-9884-435e-9d9b-d289f86ba417"), Age = 44, Email = "jeffrey.torres64@example.com", Firstname = "Jeffrey", Lastname = "Torres", Mobile = "(928)-196-2012" },
                        new { PassengerId = new Guid("1a932098-0370-4daa-afb4-dc9efbf8489a"), Age = 38, Email = "sergio.fowler60@example.com", Firstname = "Sergio", Lastname = "Fowler", Mobile = "(718)-504-4291" },
                        new { PassengerId = new Guid("6c01b522-8ccc-4d3a-ba80-bdecba3ccf11"), Age = 30, Email = "v.fisher88@example.com", Firstname = "Victoria", Lastname = "Fisher", Mobile = "(322)-572-2823" },
                        new { PassengerId = new Guid("d40b35dd-09d5-4409-8c6e-b7e7efd3be6d"), Age = 41, Email = "doris.watkins59@example.com", Firstname = "Doris", Lastname = "Watkins", Mobile = "(559)-767-4133" }
                    );
                });

            modelBuilder.Entity("api.Entities.Booking", b =>
                {
                    b.HasOne("api.Entities.Flight", "Flight")
                        .WithMany("Bookings")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("api.Entities.Passenger", "Passenger")
                        .WithMany("Bookings")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
