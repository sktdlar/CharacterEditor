using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    internal class Wizard : Unit
    {
        private double strenght;
        private double dexterity;
        private double inteligence;
        private double vitality;
        public Wizard(string name)
        {
            Name = name;
            Character = "Wizard";
            EXP = 0;
            Level = 1;
            Strength = 15;
            MStrength = 45;
            Dexterity = 20;
            MDexterity = 80;
            Inteligence = 25;
            MInteligence = 270;
            Vitality = 15;
            MVitality = 70;
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
                PDamage = 0.5 * value;
                MHealth = Vitality * 1.4 + value * 0.2;
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
                MMana = 1.5 * value;
                MDefence = value;
                MDamage = value;
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
                MHealth = value * 1.4 + Strength * 0.2;
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
