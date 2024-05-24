using FallloutCharacterCreator.Fallout3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallloutCharacterCreator
{
    public class Fallout3Character
    {
        public string CharacterName { get; set; }
        public int Level { get; set; }
        public int CarryWeight { get; set; }
        public int ActionPoints { get; set; }
        public int CriticalChance { get; set; }
        public int DamageResistance { get; set; }
        public int SkillPoints { get; set; }
        public int Health { get; set; }
        public int SpecialPoints { get; set; }
        public int Strength { get; set; }
        public int Perception { get; set; }
        public int Endurance { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }
        public int Barter { get; set; }
        public int BigGuns { get; set; }
        public int EnergyWeapons { get; set; }
        public int Explosives { get; set; }
        public int Lockpick { get; set; }
        public int Medicine { get; set; }
        public int MeleeWeapons { get; set; }
        public int Repair { get; set; }
        public int Science { get; set; }
        public int SmallGuns { get; set; }
        public int Sneak { get; set; }
        public int Speech { get; set; }
        public int Unarmed { get; set; }
        public int TaggedSkills { get; set; }

        public Fallout3Character() {
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            CharacterName = "Enter Name";
            Level = 1;
            CarryWeight = 200;
            ActionPoints = 75;
            CriticalChance = 5;
            DamageResistance = 0;
            SkillPoints = 15;
            Health = 200;
            SpecialPoints = 5;
            Strength = 5;
            Perception = 5;
            Endurance = 5;
            Charisma = 5;
            Intelligence = 5;
            Agility = 5;
            Luck = 5;
            Barter = 15;
            BigGuns = 15;
            EnergyWeapons = 15;
            Explosives = 15;
            Lockpick = 15;
            Medicine = 15;
            MeleeWeapons = 15;
            Repair = 15;
            Science = 15;
            SmallGuns = 15;
            Sneak = 15;
            Speech = 15;
            Unarmed = 15;
            TaggedSkills = 0;
        }

        //public Fallout3Character Clone() {
        //    return new Fallout3Character
        //    {
        //        CharacterName = this.CharacterName,
        //        Level = this.Level,
        //        CarryWeight = this.CarryWeight,
        //        ActionPoints = this.ActionPoints,
        //        CriticalChance = this.CriticalChance,
        //        DamageResistance = this.DamageResistance,
        //        SkillPoints = this.SkillPoints,
        //        Health = this.Health,
        //        SpecialPoints = this.SpecialPoints,
        //        Strength = this.Strength,
        //        Perception = this.Perception,
        //        Endurance = this.Endurance,
        //        Charisma = this.Charisma,
        //        Intelligence = this.Intelligence,
        //        Agility = this.Agility,
        //        Luck = this.Luck,
        //        Barter = this.Barter,
        //        BigGuns = this.BigGuns,
        //        EnergyWeapons = this.EnergyWeapons,
        //        Explosives = this.Explosives,
        //        Lockpick = this.Lockpick,
        //        Medicine = this.Medicine,
        //        MeleeWeapons = this.MeleeWeapons,
        //        Repair = this.Repair,
        //        Science = this.Science,
        //        SmallGuns = this.SmallGuns,
        //        Sneak = this.Sneak,
        //        Speech = this.Speech,
        //        Unarmed = this.Unarmed,
        //        TaggedSkills = this.TaggedSkills
        //    };
        //}

    }

}
