using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    internal class Warrior : Unit
    {

        private double strenght;
        private double dexterity;
        private double inteligence;
        private double vitality;

        public Warrior(string name) 
        {
            Name = name;
            Character = "Warrior";
            EXP = 0;
            Level = 1;
            Strength = 30;
            MStrength = 250;
            Dexterity = 15;
            MDexterity = 80;
            Inteligence = 10;
            MInteligence = 50;
            Vitality = 25;
            MVitality = 100;
            Health = MHealth;
            Mana = MMana;
            Weapons = new List<IWeapon>();

        }

        public override List<IWeapon> Weapons { get; set; }
        public override IWeapon ActiveWeapon { get; set; }
        public override string Name { get; set; }
        public override string Character { get; set; }
        public override double Level { get; set; }
        public override double EXP { get; set; }
        public override double Strength
        {
            get
            {
                return strenght;
            }

            set
            {
                strenght = value;
                PDamage = value;
                MHealth = Vitality * 2 + value;
            }
        }
        public override double MStrength { get; set; }
        public override double Dexterity
        {
            get { return dexterity; }
            set
            {
                dexterity = value;
                Armor = value;
                CritChance = 0.2 * value;
                CritDamage = 0.1 * value;
            }
        }
        public override double MDexterity { get; set; }
        public override double Inteligence
        {
            get
            {
                return inteligence;
            }
            set
            {
                inteligence = value;
                MDamage = value * 0.2;
                MMana = value;
                MDefence = value * 0.5;
            }
        }
        public override double MInteligence { get; set; }
        public override double Vitality
        {
            get
            {
                return vitality;
            }
            set
            {
                vitality = value;
                MHealth = value * 2 + Strength;
            }
        }
        public override double MVitality { get; set; }
        public override double Health { get; set; }
        public override double MHealth { get; set; }
        public override double Mana { get; set; }
        public override double MMana { get; set; }
        public override double PDamage { get; set; }
        public override double Armor { get; set; }
        public override double MDamage { get; set; }
        public override double MDefence { get; set; }
        public override double CritChance { get; set; }
        public override double CritDamage { get; set; }


    }
}
