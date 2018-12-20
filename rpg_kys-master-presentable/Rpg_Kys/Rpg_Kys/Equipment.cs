using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Equipment
    {
        public string Name;
        public string Description;
        public int Weight;

        public Equipment(string name, string description, int weight)
        {
            Name = name;
            Description = description;
            Weight = weight;
        }

        public virtual void PickUp_Object()
        {
            Player p = new Player(Name);
            Console.WriteLine("Vous rammassez: " + Name);
            List<Equipment> Inventaire = p.GetList();
            Inventaire.Add(this);
            
        }

        public virtual void Use_Object()
        {
            Console.WriteLine("Vous utilisez: " + Name);
        }
    }
}
