﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Suncity.Web.Context;

namespace suncity.web.Migrations
{
    [DbContext(typeof(SuncityContext))]
    [Migration("20190927225339_UpdateReportsSchema")]
    partial class UpdateReportsSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Suncity.Web.Models.Questionnaire", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressRegistrationId");

                    b.Property<int?>("AddressResidenceId");

                    b.Property<bool>("AgreedToMakeReports");

                    b.Property<bool>("AgreedToShareMedia");

                    b.Property<bool>("AgreedWithLiabilities");

                    b.Property<bool>("ConsentProcessingPersonalData");

                    b.Property<int?>("ContactsId");

                    b.Property<Guid?>("EmploymentId");

                    b.Property<string>("Hobbies");

                    b.Property<bool>("IsRussianCitizenship");

                    b.Property<string>("MaritalStatusState");

                    b.Property<string>("ProgrammInformationSource");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressRegistrationId");

                    b.HasIndex("AddressResidenceId");

                    b.HasIndex("ContactsId");

                    b.HasIndex("EmploymentId");

                    b.HasIndex("MaritalStatusState");

                    b.ToTable("Questionnaires");
                });

            modelBuilder.Entity("Suncity.Web.Models.Report", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalComment");

                    b.Property<string>("AssessTheMoodOfTheChildBeforeAndAfterTheMeeting");

                    b.Property<Guid?>("ChildId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("DescribeYourMoodAfterTheMeeting");

                    b.Property<int>("Duration");

                    b.Property<Guid?>("MentorId");

                    b.Property<string>("Questions");

                    b.Property<bool>("Status");

                    b.Property<string>("TargetForNextMeeting");

                    b.Property<string>("WhatDidYouEndUpDoing");

                    b.Property<string>("WhatDidYouPlanToDoAtTheMeeting");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("MentorId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("suncity.web.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Street");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("suncity.web.Models.User.Contacts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("suncity.web.Models.User.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EducationLevel");

                    b.Property<string>("EducationalInstitution");

                    b.Property<Guid?>("QuestionnaireId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionnaireId");

                    b.ToTable("Education");
                });

            modelBuilder.Entity("suncity.web.Models.User.Employment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyPhoneNumber");

                    b.Property<string>("Position");

                    b.Property<string>("Responsibilities");

                    b.Property<string>("WorkSchedule");

                    b.HasKey("Id");

                    b.ToTable("Employment");
                });

            modelBuilder.Entity("suncity.web.Models.User.MaritalStatus", b =>
                {
                    b.Property<string>("State")
                        .ValueGeneratedOnAdd();

                    b.HasKey("State");

                    b.ToTable("MaritalStatus");
                });

            modelBuilder.Entity("suncity.web.Models.User.SunCityUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email");

                    b.Property<DateTime>("LastLogon");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<DateTime>("Registered");

                    b.Property<string>("Surname");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Suncity.Web.Models.Questionnaire", b =>
                {
                    b.HasOne("suncity.web.Models.Address", "AddressRegistration")
                        .WithMany()
                        .HasForeignKey("AddressRegistrationId");

                    b.HasOne("suncity.web.Models.Address", "AddressResidence")
                        .WithMany()
                        .HasForeignKey("AddressResidenceId");

                    b.HasOne("suncity.web.Models.User.Contacts", "Contacts")
                        .WithMany()
                        .HasForeignKey("ContactsId");

                    b.HasOne("suncity.web.Models.User.Employment", "Employment")
                        .WithMany()
                        .HasForeignKey("EmploymentId");

                    b.HasOne("suncity.web.Models.User.MaritalStatus", "MaritalStatus")
                        .WithMany()
                        .HasForeignKey("MaritalStatusState");
                });

            modelBuilder.Entity("Suncity.Web.Models.Report", b =>
                {
                    b.HasOne("suncity.web.Models.User.SunCityUser", "Child")
                        .WithMany()
                        .HasForeignKey("ChildId");

                    b.HasOne("suncity.web.Models.User.SunCityUser", "Mentor")
                        .WithMany()
                        .HasForeignKey("MentorId");
                });

            modelBuilder.Entity("suncity.web.Models.User.Education", b =>
                {
                    b.HasOne("Suncity.Web.Models.Questionnaire")
                        .WithMany("Education")
                        .HasForeignKey("QuestionnaireId");
                });
#pragma warning restore 612, 618
        }
    }
}
