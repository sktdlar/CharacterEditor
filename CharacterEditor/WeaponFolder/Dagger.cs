using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor.Weapon
{
    internal class Dagger : IWeapon
    {
        public string Name { get; set; }
        public int TypeOfWeapon { get; set; }
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int Mana { get; set; }
        public int Inteligence { get; set; }
        public bool IsMagicCrit { get; set; }
        public int CritChance { get; set; }
        public int CritDamage { get; set; }
        public int Armor { get; set; }
        public bool IsDouble { get; set; }
        public int Health { get; set; }
        public int Dexterity { get; set; }
        public int Strenght { get; set; }
        public bool IsDual { get;set; }
        public int Vitality { get; set; }
        public bool IsShield { get; set; }

        public Dagger(string name, int type)
        {
            Name = name;
            TypeOfWeapon = type;
            IsDual = true;
            IsMagicCrit = false;
            CritChance = 60;
            CritDamage = 70;
            if (TypeOfWeapon == 0)
            {
                PDamage = 5;
                Dexterity = 10;
            }
            else if (TypeOfWeapon == 1)
            {
                PDamage = 7;
                Dexterity = 13;
                Health = 5;
                Vitality = 5;
            }
            else if (TypeOfWeapon == 2)
            {
                PDamage = 10;
                Dexterity = 15;
                Health = 10;
                Vitality = 10;
                Armor = 5;
                Strenght = 5;
            }
        }
    }
}
