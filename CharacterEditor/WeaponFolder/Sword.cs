using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor.WeaponFolder
{
    internal class Sword : IWeapon
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

        public Sword(string name, int type)
        {
            Name = name;
            TypeOfWeapon = type;
            IsDual = false;
            IsMagicCrit = false;
            CritChance = 35;
            CritDamage = 150;
            IsShield = true;
            if (TypeOfWeapon == 0)
            {
                PDamage = 10;
                Dexterity = 5;
                Strenght = 5;
            }
            else if (TypeOfWeapon == 1)
            {
                PDamage = 13;
                Dexterity = 7;
                Strenght = 7;
                Health = 5;
                Inteligence = 5;

            }
            else if (TypeOfWeapon == 2)
            {
                PDamage = 15;
                Dexterity = 10;
                Health = 10;
                Strenght = 10;
                Inteligence = 10;
                Armor = 5;
                Vitality = 5;
            }
        }

    }
}
