using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterEditor
{
    public interface IWeapon
    {
        string Name { get; set; }
        int TypeOfWeapon {  get; set; }
        int PDamage { get; set; }
        int MDamage { get; set; }
        int Mana {  get; set; }
        int Inteligence { get; set; }
        bool IsMagicCrit { get; set; }
        int CritChance { get; set; }
        int CritDamage {  get; set; }
        int Armor {  get; set; }
        bool IsDouble {  get; set; }
        int Health { get; set; }
        int Dexterity { get; set; }
        int Strenght { get; set; }
        bool IsDual { get; set; }
        bool IsShield { get; set; }
        int Vitality { get; set; }

    }
}
