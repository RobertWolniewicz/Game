global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;

namespace Game.Entity
{
    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Level { get; set; }
        public int? GoldCost { get; set; }
        public int? MaterialsCost { get; set; }
        public int? HumanCost { get; set; }
        public int? FoodCost { get; set; }
        public int? GoldAdd { get; set; }
        public int? MaterialsAdd { get; set; }
        public int? HumanAdd { get; set; }
        public int? FoodAdd { get; set; }
        public string? Nextlevel { get; set; }
        public double? GoldModificator { get; set; }
        public double? MaterialsModificator { get; set; }
        public double? HumanModificator { get; set; }
        public double? FoodModificator { get; set; }
        public string? Requirement1 { get; set; }
        public int? ValueRequirement1 { get; set; }
        public string? Requirement2 { get; set; }
        public int? ValueRequirement2 { get; set; }
        public string? Requirement3 { get; set; }
        public int? ValueRequirement3 { get; set; }


        public override string ToString()
        {
            return Name;
        }

    }
}
