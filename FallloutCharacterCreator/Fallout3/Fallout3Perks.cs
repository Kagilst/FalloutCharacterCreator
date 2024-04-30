using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallloutCharacterCreator.Fallout3
{
    // LEVEL, ST, PE, EN, CH, IN, AG, LU, Science, Explosives, Sneak, Medicine, Lockpick, Small Guns, Energy Weapons, Unarmed, Melee Weapons, Rank
    public class Fallout3Perks
    {
        public string PerkName { get; set; }   
        public int RequiredLevel { get; set; }
        public int RequiredStrength { get; set; }
        public int RequiredPerception { get; set; }
        public int RequiredEndurance { get; set; }
        public int RequiredCharisma { get; set; }
        public int RequiredIntelligence { get; set; }
        public int RequiredAgility { get; set; }
        public int RequiredLuck { get; set; }
        public int RequiredScience { get; set; }
        public int RequiredExplosives { get; set; }
        public int RequiredSneak { get; set; }
        public int RequiredMedicine { get; set; }
        public int RequiredLockpick { get; set; }
        public int RequiredSmallGuns { get; set; }
        public int RequiredEnergyWeapons { get; set; }
        public int RequiredUnarmed { get; set; }
        public int RequiredMeleeWeapons { get; set; }
        public int RequiredBarter { get; set; }
        public int MaxPerkRank { get; set; }
        public int CurrentPerkRank { get; set; }

        public Fallout3Perks() { 
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            // Set default values for the properties
            PerkName = "";
            RequiredLevel = 0;
            RequiredStrength = 0;
            RequiredPerception = 0;
            RequiredEndurance = 0;
            RequiredCharisma = 0;
            RequiredIntelligence = 0;
            RequiredAgility = 0;
            RequiredLuck = 0;
            RequiredScience = 0;
            RequiredExplosives = 0;
            RequiredSneak = 0;
            RequiredMedicine = 0;
            RequiredLockpick = 0;
            RequiredSmallGuns = 0;
            RequiredEnergyWeapons = 0;
            RequiredBarter = 0;
            RequiredUnarmed = 0;
            RequiredMeleeWeapons = 0;
            MaxPerkRank = 0;
            CurrentPerkRank = 0;
        }

    }
}
