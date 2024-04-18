using System;
using System.Collections.Generic;
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
        public double UnarmedDamage { get; set; }
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
            UnarmedDamage = 2.5;
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

        public void UpdateAllValues(string name, int level, int carryWeight, int actionPoints, int criticalChance, int damageResistance, double unarmedDamage, int skillPoints, 
            int health, int specialPoints, int strength, int perception, int endurance, int charisma, int intelligence, int agility, int luck, int barter, int bigGuns, int energyWeapons,
            int explosives, int lockpick, int medicine, int meleeWeapons, int repair, int science, int smallGuns, int sneak, int speech, int unarmed, int taggedSkills  ) {
            
            CharacterName = name;
            Level = level;
            CarryWeight = carryWeight;
            ActionPoints = actionPoints;
            CriticalChance = criticalChance;
            DamageResistance = damageResistance;
            UnarmedDamage = unarmedDamage;
            SkillPoints = skillPoints;
            Health = health;
            SpecialPoints = specialPoints;
            Strength = strength;
            Perception = perception;
            Endurance = endurance;
            Charisma = charisma;
            Intelligence = intelligence;
            Agility = agility;
            Luck = luck;
            Barter = barter;
            BigGuns = bigGuns;
            EnergyWeapons = energyWeapons;
            Explosives = explosives;
            Lockpick = lockpick;
            Medicine = medicine;
            MeleeWeapons = meleeWeapons;
            Repair = repair;
            Science = science;
            SmallGuns = smallGuns;
            Sneak = sneak;
            Speech = speech;
            Unarmed = unarmed;
            TaggedSkills = taggedSkills;

        }

    }

}
