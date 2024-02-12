using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    [BsonKnownTypes(typeof(Warrior), typeof(Wizard), typeof(Rogue))]
    public abstract class Unit
    {
        public ObjectId _id;
        public abstract string Name { get; set; }
        public abstract string Character { get; set; }
        public abstract double Level { get; set; }
        public abstract double EXP { get; set; }
        public abstract double Strength {get; set; }  
        public abstract double MStrength { get; set; }
        public abstract double Dexterity { get; set; }
        public abstract double MDexterity { get; set; }
        public abstract double Inteligence {  get; set; }
        public abstract double MInteligence { get; set; }
        public abstract double Vitality { get; set; }
        public abstract double MVitality { get; set; }
        public abstract double Health { get; set; }
        public abstract double MHealth { get; set; }
        public abstract double Mana { get; set; }
        public abstract double MMana { get; set; }
        public abstract double PDamage { get; set; }
        public abstract double Armor { get; set; }
        public abstract double MDamage { get; set; }
        public abstract double MDefence { get; set; }
        public abstract double CritChance { get; set; }
        public abstract double CritDamage { get; set; }
        public abstract List<IWeapon> Weapons { get; set; }
        public abstract IWeapon ActiveWeapon {  get; set; }

    }
}
