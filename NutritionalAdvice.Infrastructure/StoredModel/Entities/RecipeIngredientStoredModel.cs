﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalAdvice.Infrastructure.StoredModel.Entities
{
    [Table("recipeingredient")]
    internal class RecipeIngredientStoredModel
    {
        [Key]
        [Column("Id")]
        public Guid Id { get; set; }

        [Required]
        [Column("Quantity")]
        public double Quantity { get; set; }

        [Required]
        [Column("UnitOfMeasure")]
        [StringLength(10)]
        public string UnitOfMeasure { get; set; }

        [Column("RecipeId")]
        public Guid RecipeId { get; set; }

        [Column("IngredientId")]
        public Guid IngredientId { get; set; }
    }
}