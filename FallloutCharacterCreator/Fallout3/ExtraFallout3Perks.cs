using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallloutCharacterCreator.Fallout3
{
    internal class ExtraFallout3Perks
    {
        public string ExtraPerkName { get; set; }

        public string ExtraPerkRequirements { get; set; }
        public bool ExtraPerkHave { get; set; }
        public string ExtraPerkDescription { get; set; }


        public ExtraFallout3Perks()
        {
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            // Set default values for the properties
            ExtraPerkName = "";
            ExtraPerkHave = false;
            ExtraPerkDescription = "";
        }

        public static List<ExtraFallout3Perks> AllExtraPerksList = new List<ExtraFallout3Perks>();

        public static void InitializeExtraPerksList()
        {
            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Dream Crusher",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Talk Moira Brown out of writing the Wasteland Survivor Guide.",
                ExtraPerkDescription = "Reduces an enemy's chance to critically hit you by 50%, 30% discount at Craterside Supply, and +30 points to Moira's Repair skill."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Hematophage",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Talk to Vance about learning the ways of the vampire.",
                ExtraPerkDescription = "Blood packs heal 20 Hit Points instead of 1 point."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Power Armor Training",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Learned from Paladin Gunny in the Citadel or by completing Operation: Anchorage.",
                ExtraPerkDescription = "You're now able to wear any form of power armor."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Ant Might",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Complete Those! without eliminating the fire ant queen OR eliminating the queen and convincing Doctor Lesko it was better for mankind.",
                ExtraPerkDescription = "+1 Strength and +25% Fire Resistance."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Ant Sight",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Complete Those! without eliminating the fire ant queen OR eliminating the queen and convincing Doctor Lesko it was better for mankind.",
                ExtraPerkDescription = "+1 Perception and +25% Fire Resistance."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Barkskin",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Destroy Harolds heart.",
                ExtraPerkDescription = "+5 DR permanently."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Rad Regeneration",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Help Moira Brown with the Wasteland Survival Guide by gaining 600 rads when she asks.",
                ExtraPerkDescription = "With the Rad Regeneration perk, any crippled limbs will regenerate themselves when you have Advanced Rad Poisoning."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Survival Junior/Expert/Guru",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Help Moira Brown finish the Wasteland Survival Guide by completing the final chapter.",
                ExtraPerkDescription = "Get an increase to both Poison and Radiation Resistance depending on Perk Tier, also depending on Quest Dialog Choices get increased Health, Damage Resistance, Critical Chance, or skill increases (Medicine/Science or Sneak/Speech)."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Wired Reflexes",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Side with Dr. Zimmer during The Replicated Man quest.",
                ExtraPerkDescription = "+10% accuracy in V.A.T.S."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Covert Ops",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Gather all Intel suitcases during Operation: Anchorage.",
                ExtraPerkDescription = "+3 skill points to Science, Small Guns, and Lockpick"
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Auto Axpert",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Collect 10 steel ingots in The Pitt",
                ExtraPerkDescription = "+25% more damage with the auto axe."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Ghoul Ecology",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Read Plik's Journal",
                ExtraPerkDescription = "All weapons do 5 additional damage to ghouls (Actually applies +5 damage to all enemies due to a bug)."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Xenotech Expert",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Kill or have 10 enemies die at the shooting range on Mothership Zeta",
                ExtraPerkDescription = "+20% damage with alien weapons"
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Booster Shot",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Copmlete Free Labor",
                ExtraPerkDescription = "+10% Radiation Resistance"
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Pitt Fighter",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Complete Hole Battles",
                ExtraPerkDescription = "+3% Radiation and Damage Resistance."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Punga Power",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Complete Walking with Spirits",
                ExtraPerkDescription = "-10 Rads from wild punga fruit and -15 frome refined punga fruit."
            });

            AllExtraPerksList.Add(new ExtraFallout3Perks
            {
                ExtraPerkName = "Superior Defender",
                ExtraPerkHave = false,
                ExtraPerkRequirements = "Complete The Local Flavor",
                ExtraPerkDescription = "+5 points of damage and damage resistance when standing still."
            });
        }
    }
}
