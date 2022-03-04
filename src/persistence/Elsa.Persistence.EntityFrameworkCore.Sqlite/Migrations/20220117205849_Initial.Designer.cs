﻿// <auto-generated />
using System;
using Elsa.Persistence.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elsa.Persistence.EntityFrameworkCore.Sqlite.Migrations
{
    [DbContext(typeof(ElsaDbContext))]
    [Migration("20220117205849_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("Elsa.Persistence.Entities.WorkflowBookmark", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityInstanceId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CallbackMethodName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorrelationId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Hash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Payload")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowDefinitionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId")
                        .HasDatabaseName("IX_WorkflowBookmark_ActivityId");

                    b.HasIndex("CorrelationId")
                        .HasDatabaseName("IX_WorkflowBookmark_CorrelationId");

                    b.HasIndex("Hash")
                        .HasDatabaseName("IX_WorkflowBookmark_Hash");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowBookmark_Name");

                    b.HasIndex("WorkflowDefinitionId")
                        .HasDatabaseName("IX_WorkflowBookmark_WorkflowDefinitionId");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_WorkflowBookmark_WorkflowInstanceId");

                    b.ToTable("WorkflowBookmarks");
                });

            modelBuilder.Entity("Elsa.Persistence.Entities.WorkflowDefinition", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLatest")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IsLatest")
                        .HasDatabaseName("IX_WorkflowDefinition_IsLatest");

                    b.HasIndex("IsPublished")
                        .HasDatabaseName("IX_WorkflowDefinition_IsPublished");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowDefinition_Name");

                    b.HasIndex("Version")
                        .HasDatabaseName("IX_WorkflowDefinition_Version");

                    b.HasIndex("DefinitionId", "Version")
                        .IsUnique()
                        .HasDatabaseName("IX_WorkflowDefinition_DefinitionId_Version");

                    b.ToTable("WorkflowDefinitions");
                });

            modelBuilder.Entity("Elsa.Persistence.Entities.WorkflowExecutionLogRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EventName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<string>("PayloadData")
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityId");

                    b.HasIndex("ActivityType")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_ActivityType");

                    b.HasIndex("EventName")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_EventName");

                    b.HasIndex("Timestamp")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_Timestamp");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_WorkflowExecutionLogRecord_WorkflowInstanceId");

                    b.ToTable("WorkflowExecutionLogRecords");
                });

            modelBuilder.Entity("Elsa.Persistence.Entities.WorkflowInstance", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CancelledAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorrelationId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FaultedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FinishedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastExecutedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WorkflowStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CorrelationId")
                        .HasDatabaseName("IX_WorkflowInstance_CorrelationId");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("IX_WorkflowInstance_CreatedAt");

                    b.HasIndex("DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_DefinitionId");

                    b.HasIndex("FaultedAt")
                        .HasDatabaseName("IX_WorkflowInstance_FaultedAt");

                    b.HasIndex("FinishedAt")
                        .HasDatabaseName("IX_WorkflowInstance_FinishedAt");

                    b.HasIndex("LastExecutedAt")
                        .HasDatabaseName("IX_WorkflowInstance_LastExecutedAt");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowInstance_Name");

                    b.HasIndex("WorkflowStatus")
                        .HasDatabaseName("IX_WorkflowInstance_WorkflowStatus");

                    b.HasIndex("WorkflowStatus", "DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_WorkflowStatus_DefinitionId");

                    b.HasIndex("WorkflowStatus", "DefinitionId", "Version")
                        .HasDatabaseName("IX_WorkflowInstance_WorkflowStatus_DefinitionId_Version");

                    b.ToTable("WorkflowInstances");
                });

            modelBuilder.Entity("Elsa.Persistence.Entities.WorkflowTrigger", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Payload")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkflowDefinitionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Hash")
                        .HasDatabaseName("IX_WorkflowTrigger_Hash");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowTrigger_Name");

                    b.HasIndex("WorkflowDefinitionId")
                        .HasDatabaseName("IX_WorkflowTrigger_WorkflowDefinitionId");

                    b.ToTable("WorkflowTriggers");
                });
#pragma warning restore 612, 618
        }
    }
}