﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutritionalAdvice.Infrastructure.StoredModel;

namespace NutritionalAdvice.Infrastructure.Migrations
{
    [DbContext(typeof(StoredDbContext))]
    partial class StoredDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("NutritionalAdvice.Infrastructure.StoredModel.Entities.IngredientStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<string>("Benefits")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("Benefits");

                    b.Property<string>("DishCategory")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("DishCategory");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Name");

                    b.Property<string>("Variety")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Variety");

                    b.HasKey("Id");

                    b.ToTable("ingredient");
                });

            modelBuilder.Entity("NutritionalAdvice.Infrastructure.StoredModel.Entities.MealPlanStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<int>("DailyCalories")
                        .HasColumnType("int")
                        .HasColumnName("DailyCalories");

                    b.Property<double>("DailyCarbohydrates")
                        .HasColumnType("double")
                        .HasColumnName("DailyCarbohydrates");

                    b.Property<double>("DailyFats")
                        .HasColumnType("double")
                        .HasColumnName("DailyFats");

                    b.Property<double>("DailyProtein")
                        .HasColumnType("double")
                        .HasColumnName("DailyProtein");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Description");

                    b.Property<string>("Goal")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Goal");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<Guid>("NutritionistId")
                        .HasColumnType("char(36)")
                        .HasColumnName("NutritionistId");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("char(36)")
                        .HasColumnName("PatientId");

                    b.HasKey("Id");

                    b.ToTable("mealplan");
                });

            modelBuilder.Entity("NutritionalAdvice.Infrastructure.StoredModel.Entities.MealTimeStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<Guid>("MealPlanId")
                        .HasColumnType("char(36)")
                        .HasColumnName("MealPlanId");

                    b.Property<Guid?>("MealPlanStoredModelId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Number")
                        .HasColumnType("int")
                        .HasColumnName("Number");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("char(36)")
                        .HasColumnName("RecipeId");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.HasIndex("MealPlanStoredModelId");

                    b.ToTable("mealtime");
                });

            modelBuilder.Entity("NutritionalAdvice.Infrastructure.StoredModel.Entities.RecipeIngredientStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("char(36)")
                        .HasColumnName("IngredientId");

                    b.Property<double>("Quantity")
                        .HasColumnType("double")
                        .HasColumnName("Quantity");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("char(36)")
                        .HasColumnName("RecipeId");

                    b.Property<Guid?>("RecipeStoredModelId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UnitOfMeasure")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("UnitOfMeasure");

                    b.HasKey("Id");

                    b.HasIndex("RecipeStoredModelId");

                    b.ToTable("recipeingredient");
                });

            modelBuilder.Entity("NutritionalAdvice.Infrastructure.StoredModel.Entities.RecipeStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<int>("CookingTime")
                        .HasColumnType("int")
                        .HasColumnName("CookingTime");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Description");

                    b.Property<string>("Instructions")
                        .HasColumnType("longtext")
                        .HasColumnName("Instructions");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Name");

                    b.Property<int>("Portions")
                        .HasColumnType("int")
                        .HasColumnName("Portions");

                    b.Property<int>("PreparationTime")
                        .HasColumnType("int")
                        .HasColumnName("PreparationTime");

                    b.HasKey("Id");

                    b.ToTable("recipe");
                });

            modelBuilder.Entity("NutritionalAdvice.Infrastructure.StoredModel.Entities.MealTimeStoredModel", b =>
                {
                    b.HasOne("NutritionalAdvice.Infrastructure.StoredModel.Entities.MealPlanStoredModel", null)
                        .WithMany("MealTime")
                        .HasForeignKey("MealPlanStoredModelId");
                });

            modelBuilder.Entity("NutritionalAdvice.Infrastructure.StoredModel.Entities.RecipeIngredientStoredModel", b =>
                {
                    b.HasOne("NutritionalAdvice.Infrastructure.StoredModel.Entities.RecipeStoredModel", null)
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeStoredModelId");
                });

            modelBuilder.Entity("NutritionalAdvice.Infrastructure.StoredModel.Entities.MealPlanStoredModel", b =>
                {
                    b.Navigation("MealTime");
                });

            modelBuilder.Entity("NutritionalAdvice.Infrastructure.StoredModel.Entities.RecipeStoredModel", b =>
                {
                    b.Navigation("RecipeIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
