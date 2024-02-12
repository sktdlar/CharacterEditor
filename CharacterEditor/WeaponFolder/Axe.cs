using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor.WeaponFolder
{
    internal class Axe : IWeapon
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
        public bool IsDual { get; set; }
        public int Vitality { get; set; }
        public bool IsShield { get; set; }
        
        public Axe(string name, int type)
        {
            Name = name;
            TypeOfWeapon = type;
            IsDual = false;
            IsMagicCrit = false;
            IsShield = true;
            CritChance = 20;
            CritDamage = 170;
            if (TypeOfWeapon == 0)
            {
                PDamage = 15;
                Strenght = 15;
            }
            else if (TypeOfWeapon == 1)
            {
                PDamage = 17;
                Strenght = 17;
                Dexterity = 7;
                Health = 5;

            }
            else if (TypeOfWeapon == 2)
            {
                PDamage = 20;
                Strenght = 20;
                Dexterity = 10;
                Health = 7;
                Armor = 5;
                Vitality = 5;
            }
        }
    }
}
