﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DimDim.Infra.Data;

namespace DimDim.Web.Migrations
{
    [DbContext(typeof(DimDimDbContext))]
    partial class DimDimDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DimDim.Model.Despesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("Data");

                    b.Property<string>("Descricao");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Despesas");
                });
        }
    }
}
