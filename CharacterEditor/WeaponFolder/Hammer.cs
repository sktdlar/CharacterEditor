using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor.WeaponFolder
{
    internal class Hammer : IWeapon
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
        public bool IsShield { get; set; }
        public int Vitality { get; set; }
        public Hammer(string name, int type)
        {
            Name = name;
            TypeOfWeapon = type;
            IsDual = false;
            IsMagicCrit = false;
            IsShield = true;
            CritChance = 10;
            CritDamage = 250;
            if (TypeOfWeapon == 0)
            {
                PDamage = 15;
                Strenght = 10;
                Health = 10;
            }
            else if (TypeOfWeapon == 1)
            {
                PDamage = 17;
                Strenght = 12;
                Health = 12;
                Dexterity = 7;
                Inteligence = 7;
            }
            else if (TypeOfWeapon == 2)
            {
                PDamage = 20;
                Strenght = 20;
                Dexterity = 10;
                Inteligence = 10;
                Health = 15;
                Armor = 5;
                Vitality = 5;
            }
        }
    }
}
