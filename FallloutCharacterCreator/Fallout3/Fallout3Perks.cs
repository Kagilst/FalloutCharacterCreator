using FallloutCharacterCreator.Fallout3;
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
        public int AvaliableOrHave {  get; set; }// if = 0 not avaliable if = 1 avaliable if = 2 already have

        public string PerkDescription { get; set; }

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
            AvaliableOrHave = 0;
            PerkDescription = "";
        }

        public string RequirementsText
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Level: {RequiredLevel}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Strength {RequiredStrength}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Perception: {RequiredPerception}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Endurance: {RequiredEndurance}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Charisma: {RequiredCharisma}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Intelligence: {RequiredIntelligence}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Agility: {RequiredAgility}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Luck: {RequiredLuck}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Science: {RequiredScience}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Explosives: {RequiredExplosives}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Sneak: {RequiredSneak}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Medicine: {RequiredMedicine}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Lockpick: {RequiredLockpick}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Small Guns: {RequiredSmallGuns}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Energy Weapons: {RequiredEnergyWeapons}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Barter: {RequiredBarter}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Unarmed: {RequiredUnarmed}");
                }
                if (RequiredLevel > 0)
                {
                    sb.AppendLine($"Melee Weapons: {RequiredMeleeWeapons}");
                }

                return sb.ToString().TrimEnd();
            }

        }

        public static List<Fallout3Perks> AllPerksList = new List<Fallout3Perks>();


        public static void InitializePerksList()
        {
            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Black Widow/Lady Killer",
                RequiredLevel = 2,
                MaxPerkRank = 1,
                PerkDescription = "+10% damage to the opposite sex, and unique dialogue options with certain characters"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Daddy's Boy/Girl",
                RequiredLevel = 2,
                MaxPerkRank = 3,
                RequiredIntelligence = 4,
                PerkDescription = "+5 Science, +5 Medicine"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Gun Nut",
                RequiredLevel = 2,
                MaxPerkRank = 3,
                RequiredIntelligence = 4,
                RequiredAgility = 4,
                PerkDescription = "+5 Small Guns, +5 Repair"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Little Leaguer",
                RequiredLevel = 2,
                MaxPerkRank = 3,
                RequiredStrength = 4,
                PerkDescription = "+5 Melee Weapons, +5 Explosives"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Theif",
                RequiredLevel = 2,
                MaxPerkRank = 3,
                RequiredPerception = 4,
                RequiredAgility = 4,
                PerkDescription = "+5 Lockpick, +5 Sneak"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Swift Learner",
                RequiredLevel = 2,
                MaxPerkRank = 3,
                RequiredIntelligence = 4,
                PerkDescription = "+10% XP whenever XP is earned"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Intense Training",
                RequiredLevel = 2,
                MaxPerkRank = 10,
                PerkDescription = "+1 to any SPECIAL stat"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Child at Heart",
                RequiredLevel = 4,
                MaxPerkRank = 1,
                RequiredCharisma = 4,
                PerkDescription = "Unlocks many unique dialogue options with children"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Comprehension",
                RequiredLevel = 4,
                MaxPerkRank = 1,
                RequiredIntelligence = 4,
                PerkDescription = "+1 additional skill point whenever a skill book is read"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Educated",
                RequiredLevel = 4,
                MaxPerkRank = 1,
                RequiredIntelligence = 4,
                PerkDescription = "+3 skill points per level"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Entomologist",
                RequiredLevel = 4,
                MaxPerkRank = 1,
                RequiredIntelligence = 4,
                RequiredScience = 40,
                PerkDescription = "+50% damage to insects"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Scoundrel",
                RequiredLevel = 4,
                MaxPerkRank = 3,
                RequiredCharisma = 4,
                PerkDescription = "+5 Speech, +5 Barter"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Iron Fist",
                RequiredLevel = 4,
                MaxPerkRank = 3,
                RequiredStrength = 4,
                PerkDescription = "+5 points of Unarmed Damage"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Bloody Mess",
                RequiredLevel = 6,
                MaxPerkRank = 1,
                PerkDescription = "+5% overall damage, more violent death animations"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Lead Belly",
                RequiredLevel = 6,
                MaxPerkRank = 1,
                RequiredEndurance = 5,
                PerkDescription = "-50% radiation taken whenever drinking from a water source"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Toughness",
                RequiredLevel = 6,
                MaxPerkRank = 1,
                RequiredEndurance = 5,
                PerkDescription = "+10% DR permanently"

            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Fortune Finder",
                RequiredLevel = 6,
                MaxPerkRank = 1,
                RequiredLuck = 5,
                PerkDescription = "Considerably more bottle caps will be found in containers"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Gunslinger",
                RequiredLevel = 6,
                MaxPerkRank = 1,
                PerkDescription = "+25% accuracy in V.A.T.S. with one-handed weapons"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Demolition Expert",
                RequiredLevel = 6,
                MaxPerkRank = 3,
                RequiredExplosives = 50,
                PerkDescription = "+20% damage with explosives"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Commando",
                RequiredLevel = 8,
                MaxPerkRank = 1,
                PerkDescription = "+25% accuracy in V.A.T.S. with two-handed weapons"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Rad Resistance",
                RequiredLevel = 8,
                MaxPerkRank = 1,
                RequiredEndurance = 5,
                PerkDescription = "+25% Radiation Resistance permanently"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Scrounger",
                RequiredLevel = 8,
                MaxPerkRank = 1,
                RequiredLuck = 5,
                PerkDescription = "Considerably more ammunition in containers"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Size Matters",
                RequiredLevel = 8,
                MaxPerkRank = 3,
                RequiredEndurance = 5,
                PerkDescription = "+15 Big Guns"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Strong Back",
                RequiredLevel = 8,
                MaxPerkRank = 1,
                RequiredStrength = 5,
                RequiredEndurance = 5,
                PerkDescription = "+50 Carry Weight"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Impartial Mediation",
                RequiredLevel = 8,
                MaxPerkRank = 1,
                RequiredCharisma = 5,
                PerkDescription = "+30 Speech when you have neutral Karma"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Animal Friend",
                RequiredLevel = 10,
                MaxPerkRank = 2,
                RequiredCharisma = 6,
                PerkDescription = "Hostile animals become friendly (one rank), and come to your aid except against other animals (two ranks)."
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Finesse",
                RequiredLevel = 10,
                MaxPerkRank = 1,
                PerkDescription = "+5% Critical Chance"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Mister Sandman",
                RequiredLevel = 10,
                MaxPerkRank = 1,
                RequiredSneak = 60,
                PerkDescription = "Can instantly kill a sleeping non-player character and earns bonus XP"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Mysterious Stranger",
                RequiredLevel = 10,
                MaxPerkRank = 1,
                RequiredLuck = 6,
                PerkDescription = "Chance that the Stranger will finish off a target in V.A.T.S."
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Nerd Rage",
                RequiredLevel = 10,
                MaxPerkRank = 1,
                RequiredIntelligence = 5,
                RequiredScience = 50,
                PerkDescription = "+50% DR and Strength increased to 10 whenever health is 20% or lower"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Night Person",
                RequiredLevel = 10,
                MaxPerkRank = 1,
                PerkDescription = "+2 Intelligence and +2 Perception between 6:00 p.m. and 6:00 a.m."
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Here and Now",
                RequiredLevel = 10,
                MaxPerkRank = 1,
                PerkDescription = "You instantly level up again"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Pyromaniac",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                RequiredExplosives = 60,
                PerkDescription = "+50% damage with fire-based weapons"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Cannibal",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                PerkDescription = "Can eat corpses to restore 25 points of health and lose 1 Karma"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Life Giver",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                RequiredEndurance = 6,
                PerkDescription = "+30 Hit Points"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Robotics Expert",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                RequiredScience = 50,
                PerkDescription = "+25% damage to robots, can shut down robots by sneaking up on them"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Sniper",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                RequiredPerception = 6,
                RequiredAgility = 6,
                PerkDescription = "+25% to hit the target's head in V.A.T.S."
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Silent Running",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                RequiredAgility = 6,
                RequiredSneak = 50,
                PerkDescription = "+10 Sneak, foot speed and armor weight no longer affect sneaking"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Fast Metabolism",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                PerkDescription = "+20% Hit Points restored with stimpaks"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Lawbringer",
                RequiredLevel = 14,
                MaxPerkRank = 1,
                PerkDescription = "Can sell fingers to Sonora Cruz"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Chemist",
                RequiredLevel = 14,
                MaxPerkRank = 1,
                RequiredMedicine = 60,
                PerkDescription = "Chems last twice as long"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Contract Killer",
                RequiredLevel = 14,
                MaxPerkRank = 1,
                PerkDescription = "Can sell ears to Daniel Littlehorn"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Cyborg",
                RequiredLevel = 14,
                MaxPerkRank = 1,
                RequiredMedicine = 60,
                RequiredScience = 60,
                PerkDescription = "+10 Energy Weapons, +10% to Radiation Resistance, Poison Resistance and Damage Resistance"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Light Step",
                RequiredLevel = 14,
                MaxPerkRank = 1,
                RequiredPerception = 6,
                RequiredAgility = 6,
                PerkDescription = "Floor traps or mines will not be set off"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Master Trader",
                RequiredLevel = 14,
                MaxPerkRank = 1,
                RequiredBarter = 60,
                RequiredCharisma = 6,
                PerkDescription = "All items cost 25% less "
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Admantium Skeleton",
                RequiredLevel = 14,
                MaxPerkRank = 1,
                PerkDescription = "Damage taken by limbs reduced by 50%"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Tag!",
                RequiredLevel = 16,
                MaxPerkRank = 1,
                PerkDescription = "Fourth \"tag\" skill: +15 points to that skill"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Better Criticals",
                RequiredLevel = 16,
                MaxPerkRank = 1,
                RequiredPerception = 6,
                RequiredLuck = 6,
                PerkDescription = "+50% damage with critical hits"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Action Boy/Girl",
                RequiredLevel = 16,
                MaxPerkRank = 1,
                RequiredAgility = 6,
                PerkDescription = "+25 Action Points"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Chem Resistant",
                RequiredLevel = 16,
                MaxPerkRank = 1,
                RequiredMedicine = 60,
                PerkDescription = "Half as likely to get addicted"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Infiltrator",
                RequiredLevel = 18,
                MaxPerkRank = 1,
                RequiredPerception = 7,
                RequiredLockpick = 70,
                PerkDescription = "Can pick a broken lock with one more bobby pin"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Computer Whiz",
                RequiredLevel = 18,
                MaxPerkRank = 1,
                RequiredIntelligence = 7,
                RequiredScience = 70,
                PerkDescription = "Can hack a locked down terminal with four more chances"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Concentrated Fire",
                RequiredLevel = 18,
                MaxPerkRank = 1,
                RequiredEnergyWeapons = 60,
                RequiredSmallGuns = 60,
                PerkDescription = "+5% accuracy in V.A.T.S. with every attack queued"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Paralyzing Palm",
                RequiredLevel = 18,
                MaxPerkRank = 1,
                RequiredUnarmed = 70,
                PerkDescription = "30% to paralyze an enemy for 30 seconds with an unarmed attack in V.A.T.S."
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Solar Powered",
                RequiredLevel = 20,
                MaxPerkRank = 1,
                RequiredEndurance = 7,
                PerkDescription = "+2 Strength and +1 HP every 10 seconds while outside, from 6:00 a.m. to 6:00 p.m."
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Ninja",
                RequiredLevel = 20,
                MaxPerkRank = 1,
                RequiredMeleeWeapons = 80,
                RequiredSneak = 80,
                PerkDescription = "+15% critical chance with melee and unarmed weapons, +25% damage with sneak attack criticals"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Grim Reaper's Sprint",
                RequiredLevel = 20,
                MaxPerkRank = 1,
                PerkDescription = "A kill in V.A.T.S. restores all your AP immediately"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Explorer",
                RequiredLevel = 20,
                MaxPerkRank = 1,
                PerkDescription = "All locations are marked on your map"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Deep Sleep",
                RequiredLevel = 22,
                MaxPerkRank = 1,
                PerkDescription = "Sleeping in any bed gives the Well Rested effect, which increases your XP by 10%, for 8 hours."
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Puppies",
                RequiredLevel = 22,
                MaxPerkRank = 1,
                PerkDescription = "If Dogmeat dies, a puppy will spawn outside of Vault 101"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Quantum Chemist",
                RequiredLevel = 22,
                MaxPerkRank = 1,
                RequiredScience = 70,
                PerkDescription = "Every 10 Nuka-Colas you acquire are automatically converted into a Nuka-Cola Quantum"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Devil's Highway",
                RequiredLevel = 24,
                MaxPerkRank = 1,
                PerkDescription = "Karma is instantly set to Very Evil"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Escalator to Heaven",
                RequiredLevel = 24,
                MaxPerkRank = 1,
                PerkDescription = "Karma is instantly set to Very Good"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Karamic Rebalance",
                RequiredLevel = 24,
                MaxPerkRank = 1,
                PerkDescription = "Karma is instantly set to Neutral"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "No Weaknesses",
                RequiredLevel = 24,
                MaxPerkRank = 1,
                PerkDescription = "All SPECIAL stats lower than 5 become 5"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Rad Tolerance",
                RequiredLevel = 26,
                MaxPerkRank = 1,
                RequiredEndurance = 7,
                PerkDescription = "No effects from minor radiation poisoning (still gives alert)"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Warmonger",
                RequiredLevel = 26,
                MaxPerkRank = 1,
                RequiredIntelligence = 7,
                PerkDescription = "All schematics are added at V3"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Nerves of Steel",
                RequiredLevel = 26,
                MaxPerkRank = 1,
                RequiredAgility = 7,
                PerkDescription = "+1 AP every 10 seconds"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Party Boy/Girl",
                RequiredLevel = 228,
                MaxPerkRank = 1,
                PerkDescription = "No chance for alcohol addiction"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Rad Absorption",
                RequiredLevel = 28,
                MaxPerkRank = 1,
                RequiredEndurance = 7,
                PerkDescription = "-1 Rad every 20 seconds"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Nuclear Anomaly",
                RequiredLevel = 30,
                MaxPerkRank = 1,
                PerkDescription = "Whenever your health is reduced to 20 or less, you will erupt into a devastating nuclear explosion"
            });

            AllPerksList.Add(new Fallout3Perks
            {
                PerkName = "Almost Perfect",
                RequiredLevel = 30,
                MaxPerkRank = 1,
                PerkDescription = "All SPECIAL stats are raised to 9"
            });
        }
        
    }
}
