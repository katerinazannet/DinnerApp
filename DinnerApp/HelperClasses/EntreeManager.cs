using DinnerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DinnerApp.HelperClasses
{
    public class EntreeManager
    {
        public static List<Entree> GetAll()
        {
            List<Entree> entrees = new List<Entree>();
            entrees.Add(new Entree()
            {
                ID = 1,
                Name = "Sopa",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient() { Name = "Pasta", Amount = 3, Unit = "Cups"},
                    new Ingredient() {Name = "Tomato Sauce", Amount = 2, Unit = "Cups"},
                    new Ingredient() {Name = "Cumin", Amount = 3, Unit = "Teaspoon"},
                    new Ingredient() {Name = "Beef", Amount = 1, Unit = "Pound"}
                }
            });


            entrees.Add(new Entree()
            {
                ID = 2,
                Name = "Lol",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient() { Name = "Burger", Amount = 3, Unit = "Cups"},
                    new Ingredient() {Name = "Tomato Sauce", Amount = 2, Unit = "Cups"},
                    new Ingredient() {Name = "Cumin", Amount = 3, Unit = "Teaspoon"},
                    new Ingredient() {Name = "Beef", Amount = 1, Unit = "Pound"}
                }
            });
            return entrees;
        }
    }
}