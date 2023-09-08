//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }

            Console.WriteLine($"Costo total {GetCostoTotal()}");
        }

        public double GetCostosInsumo()
        {
            double costoInsumos = 0;
            foreach (Step step in this.steps)
            {
                costoInsumos += step.CostoInsumos();
            }
            return costoInsumos;
        }

        public double GetCostoEquipamiento()
        {
            double costoEquipamientos = 0;
            foreach (Step step in this.steps)
            {
                costoEquipamientos += step.CostoEquipamiento();
            }
            return costoEquipamientos;
        }

        public double GetCostoTotal()
        {
            return this.GetCostosInsumo() + this.GetCostoEquipamiento();
        }
    }
}

// Recipe es la clase experta porque conoce todos los pasos de la receta y por lo tanto puede calcular el costo total
// sabiendo que cada paso conoce su costo.