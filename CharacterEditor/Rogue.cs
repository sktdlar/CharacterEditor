using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    internal class Rogue : Unit
    {
        private double strenght;
        private double dexterity;
        private double inteligence;
        private double vitality;
        public Rogue(string name)
        {
            Name = name;
            Character = "Rogue";
            EXP = 0;
            Level = 1;
            Strength = 20;
            MStrength = 65;
            Dexterity = 30;
            MDexterity = 250;
            Inteligence = 15;
            MInteligence = 70;
            Vitality = 20;
            MVitality = 80;
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
                PDamage = 0.5 * value + 0.5 * Dexterity;
                MHealth = Vitality * 1.5 + value * 0.5;
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
                PDamage = 0.5 * value + 0.5 * Strength;
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
                MMana = value * 1.2;
                MDefence = value * 0.5;
                MDamage = value * 0.2;
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
                MHealth = Vitality * 1.5 + Strength * 0.5;
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
