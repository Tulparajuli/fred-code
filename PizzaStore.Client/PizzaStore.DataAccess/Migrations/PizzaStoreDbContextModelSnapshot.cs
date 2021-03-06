﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PizzaStore.DataAccess;
using System;

namespace PizzaStore.DataAccess.Migrations
{
    [DbContext(typeof(PizzaStoreDbContext))]
    partial class PizzaStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaStore.DataAccess.Models.Pizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Active");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Name");

                    b.HasKey("PizzaId");

                    b.ToTable("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
