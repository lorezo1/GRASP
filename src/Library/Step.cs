//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        public double CostoInsumos()
        {
            return this.Quantity * this.Input.UnitCost;
        }

        public double CostoEquipamiento()
        {
            return this.Time / 60 * this.Equipment.HourlyCost;
        }
    }

    // Por expert se agrega CostoInsumos y CostoEquipamiento porque la clase steps es la clase experta
    // y tiene toda la información necesaria para obtener esos costos. 
}