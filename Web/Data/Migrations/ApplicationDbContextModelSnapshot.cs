﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Data;

namespace Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Web.Models.Domain.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Street");

                    b.Property<string>("StreetHeight");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Web.Models.Domain.Client", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AddressId");

                    b.Property<string>("BusinessName");

                    b.Property<string>("Cuit");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Web.Models.Domain.Dock", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Occupied");

                    b.HasKey("Id");

                    b.ToTable("Dock");
                });

            modelBuilder.Entity("Web.Models.Domain.Driver", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Dni");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("Web.Models.Domain.DriverPermit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("DriverId");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<long>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("VehicleId");

                    b.ToTable("DriverPermit");
                });

            modelBuilder.Entity("Web.Models.Domain.Entry", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("DriverId");

                    b.Property<DateTime>("EntryDate");

                    b.Property<DateTime>("ExitDate");

                    b.Property<long>("RemittanceId");

                    b.Property<long>("TrailerId");

                    b.Property<long>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("RemittanceId");

                    b.HasIndex("TrailerId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Entry");
                });

            modelBuilder.Entity("Web.Models.Domain.Merchandise", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BoxHeight");

                    b.Property<double>("BoxLength");

                    b.Property<double>("BoxWeight");

                    b.Property<double>("BoxWidth");

                    b.Property<string>("Description");

                    b.Property<string>("ExternCode");

                    b.Property<long>("RemittanceId");

                    b.Property<int>("TotalBoxes");

                    b.HasKey("Id");

                    b.HasIndex("RemittanceId");

                    b.ToTable("Merchandise");
                });

            modelBuilder.Entity("Web.Models.Domain.MerchandiseInsurance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CoverageType");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<string>("InsuranceBusinessName");

                    b.Property<string>("InsuredMerchandise");

                    b.Property<int>("PolicyNumber");

                    b.Property<long>("RemittanceId");

                    b.Property<string>("SafetyMeasures");

                    b.HasKey("Id");

                    b.HasIndex("RemittanceId");

                    b.ToTable("MerchandiseInsurance");
                });

            modelBuilder.Entity("Web.Models.Domain.OperationState", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("DockId");

                    b.Property<long>("EntryId");

                    b.Property<string>("MerchandiseState");

                    b.Property<long>("RemittanceId");

                    b.Property<string>("RemittanceState");

                    b.HasKey("Id");

                    b.HasIndex("DockId");

                    b.HasIndex("EntryId");

                    b.HasIndex("RemittanceId");

                    b.ToTable("OperationState");
                });

            modelBuilder.Entity("Web.Models.Domain.Pallet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AmountOfBoxes");

                    b.Property<DateTime>("EntryTimestamp");

                    b.Property<DateTime>("ExitTimestamp");

                    b.Property<double>("Height");

                    b.Property<long>("MerchandiseId");

                    b.Property<string>("State");

                    b.Property<long>("WarehouseLocationId");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("MerchandiseId");

                    b.HasIndex("WarehouseLocationId");

                    b.ToTable("Pallet");
                });

            modelBuilder.Entity("Web.Models.Domain.RTO", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CertifiedBy");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<long>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("RTO");
                });

            modelBuilder.Entity("Web.Models.Domain.RUTA", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<long>("ClientId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<long>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("VehicleId");

                    b.ToTable("RUTA");
                });

            modelBuilder.Entity("Web.Models.Domain.Remittance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ClientId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("DeliveryType");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Remittance");
                });

            modelBuilder.Entity("Web.Models.Domain.Trailer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LicensePlate");

                    b.Property<long>("TrailerInsuranceId");

                    b.HasKey("Id");

                    b.HasIndex("TrailerInsuranceId");

                    b.ToTable("Trailer");
                });

            modelBuilder.Entity("Web.Models.Domain.TrailerInsurance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<string>("InsuranceBusinessName");

                    b.Property<int>("PolicyNumber");

                    b.HasKey("Id");

                    b.ToTable("TrailerInsurance");
                });

            modelBuilder.Entity("Web.Models.Domain.Vehicle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("LicensePlate");

                    b.Property<string>("Model");

                    b.Property<string>("Type");

                    b.Property<long>("VehicleInsuranceId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleInsuranceId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("Web.Models.Domain.VehicleInsurance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<string>("InsuranceBusinessName");

                    b.Property<int>("PolicyNumber");

                    b.HasKey("Id");

                    b.ToTable("VehicleInsurance");
                });

            modelBuilder.Entity("Web.Models.Domain.WarehouseLocation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Aisle");

                    b.Property<string>("Level");

                    b.Property<string>("Position");

                    b.Property<string>("Section");

                    b.HasKey("Id");

                    b.ToTable("WarehouseLocation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.Client", b =>
                {
                    b.HasOne("Web.Models.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.DriverPermit", b =>
                {
                    b.HasOne("Web.Models.Domain.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Web.Models.Domain.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.Entry", b =>
                {
                    b.HasOne("Web.Models.Domain.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Web.Models.Domain.Remittance", "Remittance")
                        .WithMany()
                        .HasForeignKey("RemittanceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Web.Models.Domain.Trailer", "Trailer")
                        .WithMany()
                        .HasForeignKey("TrailerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Web.Models.Domain.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.Merchandise", b =>
                {
                    b.HasOne("Web.Models.Domain.Remittance", "Remittance")
                        .WithMany("Merchandise")
                        .HasForeignKey("RemittanceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.MerchandiseInsurance", b =>
                {
                    b.HasOne("Web.Models.Domain.Remittance", "Remittance")
                        .WithMany()
                        .HasForeignKey("RemittanceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.OperationState", b =>
                {
                    b.HasOne("Web.Models.Domain.Dock", "Dock")
                        .WithMany()
                        .HasForeignKey("DockId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Web.Models.Domain.Entry", "Entry")
                        .WithMany()
                        .HasForeignKey("EntryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Web.Models.Domain.Remittance", "Remittance")
                        .WithMany()
                        .HasForeignKey("RemittanceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.Pallet", b =>
                {
                    b.HasOne("Web.Models.Domain.Merchandise", "Merchandise")
                        .WithMany()
                        .HasForeignKey("MerchandiseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Web.Models.Domain.WarehouseLocation", "WarehouseLocation")
                        .WithMany()
                        .HasForeignKey("WarehouseLocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.RTO", b =>
                {
                    b.HasOne("Web.Models.Domain.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.RUTA", b =>
                {
                    b.HasOne("Web.Models.Domain.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Web.Models.Domain.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.Remittance", b =>
                {
                    b.HasOne("Web.Models.Domain.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.Trailer", b =>
                {
                    b.HasOne("Web.Models.Domain.TrailerInsurance", "Insurance")
                        .WithMany()
                        .HasForeignKey("TrailerInsuranceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Web.Models.Domain.Vehicle", b =>
                {
                    b.HasOne("Web.Models.Domain.VehicleInsurance", "Insurance")
                        .WithMany()
                        .HasForeignKey("VehicleInsuranceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
