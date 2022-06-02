﻿// <auto-generated />
using System;
using GMTVendorEvaluationWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GMTVendorEvaluationWebApp.Migrations
{
    [DbContext(typeof(EvaluationContext))]
    [Migration("20220602215301_percentagetest")]
    partial class percentagetest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.Criteria", b =>
                {
                    b.Property<int>("criteriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("criteria_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("criteriaID");

                    b.ToTable("Criteria");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.Department", b =>
                {
                    b.Property<int>("departmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("department_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("departmentID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.Evaluation", b =>
                {
                    b.Property<int>("evaluationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("criteriaID")
                        .HasColumnType("int");

                    b.Property<bool>("departmental_evaluation")
                        .HasColumnType("bit");

                    b.Property<int>("product_serviceID")
                        .HasColumnType("int");

                    b.HasKey("evaluationID");

                    b.HasIndex("criteriaID");

                    b.HasIndex("product_serviceID");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.Product_Service", b =>
                {
                    b.Property<int>("product_serviceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_delivered")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Evaluated")
                        .HasColumnType("bit");

                    b.Property<double>("Percentage")
                        .HasColumnType("float");

                    b.Property<int>("departmentID")
                        .HasColumnType("int");

                    b.Property<bool>("departmental_evaluation")
                        .HasColumnType("bit");

                    b.Property<string>("product_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vendorID")
                        .HasColumnType("int");

                    b.HasKey("product_serviceID");

                    b.HasIndex("departmentID");

                    b.HasIndex("vendorID");

                    b.ToTable("Product_Service");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.UserRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.Vendor", b =>
                {
                    b.Property<int>("vendorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("company_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("company_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_person")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type_of_business")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("vendorID");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.ViewModels.VendorEvaluation", b =>
                {
                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfProducts")
                        .HasColumnType("int");

                    b.Property<int>("NumberofDepartments")
                        .HasColumnType("int");

                    b.Property<int>("NumberofVendors")
                        .HasColumnType("int");

                    b.Property<double>("Percentage")
                        .HasColumnType("float");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("vendor_id")
                        .HasColumnType("int");

                    b.ToTable("VendorEvaluations");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.Evaluation", b =>
                {
                    b.HasOne("GMTVendorEvaluationWebApp.Models.Criteria", "Criteria")
                        .WithMany("Evaluations")
                        .HasForeignKey("criteriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GMTVendorEvaluationWebApp.Models.Product_Service", "Product_Service")
                        .WithMany("Evaluations")
                        .HasForeignKey("product_serviceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Criteria");

                    b.Navigation("Product_Service");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.Product_Service", b =>
                {
                    b.HasOne("GMTVendorEvaluationWebApp.Models.Department", "Department")
                        .WithMany("Products_Services")
                        .HasForeignKey("departmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GMTVendorEvaluationWebApp.Models.Vendor", "Vendor")
                        .WithMany("Products_Services")
                        .HasForeignKey("vendorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.Criteria", b =>
                {
                    b.Navigation("Evaluations");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.Department", b =>
                {
                    b.Navigation("Products_Services");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.Product_Service", b =>
                {
                    b.Navigation("Evaluations");
                });

            modelBuilder.Entity("GMTVendorEvaluationWebApp.Models.Vendor", b =>
                {
                    b.Navigation("Products_Services");
                });
#pragma warning restore 612, 618
        }
    }
}
