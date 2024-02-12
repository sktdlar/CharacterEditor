using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    internal class Wand : IWeapon
    {
        public string Name { get; set; }
        public int TypeOfWeapon { get; set; }
        public int PDamage {  get; set; }
        public int MDamage { get; set; }
        public int Mana { get; set; }
        public int Inteligence { get; set; }
        public int CritChance { get; set; }
        public int CritDamage { get; set; }
        public int Armor { get; set; }
        public bool IsDouble { get; set; }
        public int Health { get; set; }
        public int Dexterity { get; set; }
        public bool IsMagicCrit { get; set; }
        public int Strenght { get; set;}
        public bool IsDual { get; set; }
        public int Vitality { get; set; }
        public bool IsShield { get; set; }

        public Wand(string name,  int type)
        {
            Name = name;
                IsMagicCrit = true;
            TypeOfWeapon = type;
            CritChance = 5;
            CritDamage = 300;
            IsDual = false;
            if(TypeOfWeapon == 0)
            {
                PDamage = 3;
                MDamage = 10;
                Inteligence = 10;
            }
            else if (TypeOfWeapon == 1)
            {
                PDamage = 5;
                MDamage = 12;
                Inteligence = 15;
                Health = 5;
                Dexterity = 5;
            }
            else if (TypeOfWeapon == 2)
            {
                PDamage = 7;
                MDamage = 15;
                Inteligence = 20;
                Health = 10;
                Dexterity = 10;
                Armor = 5;
                Strenght = 5;
            }
        }
    }
}
