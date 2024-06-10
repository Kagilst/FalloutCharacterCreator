using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallloutCharacterCreator.Fallout1
{
    public class Fallout1Character
    {
        public string CharacterName { get; set; }
        public int CharacterAge { get; set; }
        public string CharacterSex { get; set; }
        public int HitPoints { get; set; }
        public int Level { get; set; }
        public int ArmorClass { get; set; }
        public int ActionPoints { get; set; }
        public int CarryWeight { get; set; }
        public int MeleeDamage { get; set; }
        public int DamageRes { get; set; }
        public int PoisonRes { get; set; }
        public int RadiationRes { get; set; }
        public int Sequence {  get; set; }
        public int HealingRate { get; set; }
        public int CriticalChance { get; set; }
        public int TaggedTraits { get; set; }//Maybe change
        public int SpecialPoints { get; set; }
        public int Strength { get; set; }
        public int Perception { get; set; }
        public int Endurance { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Luck { get; set; }
        public int SkillPoints { get; set; }
        public int SmallGuns { get; set; }
        public int BigGuns { get; set; }
        public int EnergyWeapons { get; set; }
        public int Unarmed { get; set; }
        public int MeleeWeapons { get; set; }
        public int Throwing { get; set; }
        public int FirstAid { get; set; }
        public int Doctor { get; set; }
        public int Sneak { get; set; }
        public int Lockpick { get; set; }
        public int Steal { get; set; }
        public int Traps { get; set; }
        public int Science { get; set; }
        public int Repair { get; set; }
        public int Speech { get; set; }
        public int Barter { get; set; }
        public int Gambling { get; set; }
        public int Outdoorsman { get; set; }
        public int TaggedSkills { get; set; }

        public Fallout1Character()
        {
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            CharacterName = "EnterName";
            CharacterAge =  16;
            CharacterSex = "Male";
            HitPoints = 30;
            Level = 1;
            ArmorClass = 5;
            ActionPoints = 7;
            CarryWeight = 150;
            MeleeDamage = 1;
            DamageRes = 0;
            PoisonRes = 25;
            RadiationRes = 10;
            Sequence = 10;
            HealingRate = 1;
            CriticalChance = 5;
            TaggedTraits = 0;
            SpecialPoints = 5;
            Strength = 5;
            Perception = 5;
            Endurance = 5;
            Charisma = 5;
            Intelligence = 5;
            Agility = 5;
            Luck = 5;
            SkillPoints = 0;
            SmallGuns = 40;
            BigGuns = 15;
            EnergyWeapons = 15;
            Unarmed = 70;
            MeleeWeapons = 60;
            Throwing = 45;
            FirstAid = 35;
            Doctor = 20;
            Sneak = 30;
            Lockpick = 25;
            Steal = 25;
            Traps = 25;
            Science = 35;
            Repair = 25;
            Speech = 35;
            Barter = 30;
            Gambling = 35;
            Outdoorsman = 10;
            TaggedSkills = 0;
        }

        public Fallout1Character Clone()
        {
            return new Fallout1Character
            {
                CharacterName = this.CharacterName,
                CharacterAge = this.CharacterAge,
                CharacterSex = this.CharacterSex,
                HitPoints = this.HitPoints,
                Level = this.Level,
                ArmorClass = this.ArmorClass,
                ActionPoints = this.ActionPoints,
                CarryWeight = this.CarryWeight,
                MeleeDamage = this.MeleeDamage,
                DamageRes = this.DamageRes,
                PoisonRes = this.PoisonRes,
                RadiationRes = this.RadiationRes,
                Sequence = this.Sequence,
                HealingRate = this.HealingRate,
                CriticalChance = this.CriticalChance,
                TaggedTraits = this.TaggedTraits,
                SpecialPoints = this.SpecialPoints,
                Strength = this.Strength,
                Perception = this.Perception,
                Endurance = this.Endurance,
                Charisma = this.Charisma,
                Intelligence = this.Intelligence,
                Agility = this.Agility,
                Luck = this.Luck,
                SkillPoints = this.SkillPoints,
                SmallGuns = this.SmallGuns,
                BigGuns = this.BigGuns,
                EnergyWeapons = this.EnergyWeapons,
                Unarmed = this.Unarmed,
                MeleeWeapons = this.MeleeWeapons,
                Throwing = this.Throwing,
                FirstAid = this.FirstAid,
                Doctor = this.Doctor,
                Sneak = this.Sneak,
                Lockpick = this.Lockpick,
                Steal = this.Steal,
                Traps = this.Traps,
                Science = this.Science,
                Repair = this.Repair,
                Speech = this.Speech,
                Barter = this.Barter,
                Gambling = this.Gambling,
                Outdoorsman = this.Outdoorsman,
                TaggedSkills = this.TaggedSkills
            };
        }
    }



}
