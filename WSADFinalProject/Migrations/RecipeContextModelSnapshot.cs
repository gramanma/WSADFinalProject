﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WSADFinalProject.Models;

namespace WSADFinalProject.Migrations
{
    [DbContext(typeof(RecipeContext))]
    partial class RecipeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WSADFinalProject.Models.Ingredient", b =>
                {
                    b.Property<int>("ingredientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ingredientName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ingredientID");

                    b.ToTable("ingredients");
                });

            modelBuilder.Entity("WSADFinalProject.Models.Recipe", b =>
                {
                    b.Property<int>("recipeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ingredients")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Servings")
                        .HasColumnType("int");

                    b.Property<string>("recipeCookTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("recipeDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("recipeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("recipePrepTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("recipeID");

                    b.ToTable("recipes");

                    b.HasData(
                        new
                        {
                            recipeID = 1,
                            Ingredients = "Flour, sugar...",
                            Method = "step 1: Preheat the oven to 170C...",
                            Servings = 12,
                            recipeCookTime = "30 min",
                            recipeDesc = "baking, cake, chocolate",
                            recipeName = "Chocolate Cake",
                            recipePrepTime = "15 min"
                        },
                        new
                        {
                            recipeID = 2,
                            Ingredients = "Cheese...",
                            Method = "step 1: turn on grill...",
                            Servings = 1,
                            recipeCookTime = "5 min",
                            recipeDesc = "grilling, burger, cheese",
                            recipeName = "Cheese Burger",
                            recipePrepTime = "5 min"
                        });
                });

            modelBuilder.Entity("WSADFinalProject.Models.RecipeIngredient", b =>
                {
                    b.Property<int>("recipeId")
                        .HasColumnType("int");

                    b.Property<int>("ingredientId")
                        .HasColumnType("int");

                    b.HasKey("recipeId", "ingredientId");

                    b.HasIndex("ingredientId");

                    b.ToTable("recipeIngredients");
                });

            modelBuilder.Entity("WSADFinalProject.Models.RecipeIngredient", b =>
                {
                    b.HasOne("WSADFinalProject.Models.Ingredient", "ingredient")
                        .WithMany("recipeIngredients")
                        .HasForeignKey("ingredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WSADFinalProject.Models.Recipe", "recipe")
                        .WithMany("recipeIngredients")
                        .HasForeignKey("recipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
