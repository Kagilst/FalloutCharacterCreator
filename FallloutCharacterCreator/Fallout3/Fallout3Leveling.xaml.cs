using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FallloutCharacterCreator.Fallout3;

namespace FallloutCharacterCreator.Fallout3
{
    /// <summary>
    /// Interaction logic for Fallout3Leveling.xaml
    /// </summary>
    public partial class Fallout3Leveling : Page, INotifyPropertyChanged
    {
        public Fallout3SkillBooks BookValues { get; set; }

        private List<Fallout3Character> characterSnapshots;
        public Fallout3Character Character => characterSnapshots[1];
        public string CharacterNameText => $"{Character?.CharacterName}";
        public string CharacterLevelText => $"{Character?.Level}";
        public string StrengthText => $"{Character?.Strength}";
        public string PerceptionText => $"{Character?.Perception}";
        public string EnduranceText => $"{Character?.Endurance}";
        public string CharismaText => $"{Character?.Charisma}";
        public string IntelligenceText => $"{Character?.Intelligence}";
        public string AgilityText => $"{Character?.Agility}";
        public string LuckText => $"{Character?.Luck}";
        public string SpecialPointsText => $"{Character?.SpecialPoints}";
        public string ActionPointsText => $"{Character?.ActionPoints}";
        public string CarryWeightText => $"{Character?.CarryWeight}";
        public string CriticalChanceText => $"{Character?.CriticalChance}";
        public string DamageResistText => $"{Character?.DamageResistance}";
        public string HealthText => $"{Character?.Health}";
        public string UnarmedDamageText => $"{Character?.UnarmedDamage}";
        public string TaggedSkillsText => $"{Character?.TaggedSkills}/3";
        public string SkillPointsText => $"{Character?.SkillPoints}";
        public string BarterText => $"{Character?.Barter}";
        public string BigGunsText => $"{Character?.BigGuns}";
        public string EnergyWeaponsText => $"{Character?.EnergyWeapons}";
        public string ExplosivesText => $"{Character?.Explosives}";
        public string LockpickText => $"{Character?.Lockpick}";
        public string MedicineText => $"{Character?.Medicine}";
        public string MeleeWeaponsText => $"{Character?.MeleeWeapons}";
        public string RepairText => $"{Character?.Repair}";
        public string ScienceText => $"{Character?.Science}";
        public string SmallGunsText => $"{Character?.SmallGuns}";
        public string SneakText => $"{Character?.Sneak}";
        public string SpeechText => $"{Character?.Speech}";
        public string UnarmedText => $"{Character?.Unarmed}";
        public string ScienceBookText => $"{BookValues.ScienceBook}  /  \u221E";
        public string SneakBookText => $"{BookValues.SneakBook}  /  25";
        public string MedicineBookText => $"{BookValues.MedicineBook}  /  25";
        public string RepairBookText => $"{BookValues.RepairBook}  /  25";
        public string ExplosivesBookText => $"{BookValues.ExplosivesBook}  /  25";
        public string MeleeWeaponsBookText => $"{BookValues.MeleeWeaponsBook}  /  25";
        public string SmallGunsBookText => $"{BookValues.SmallGunsBook}  /  25";
        public string SpeechBookText => $"{BookValues.SpeechBook}  /  24";
        public string EnergyWeaponsBookText => $"{BookValues.EnergyWeaponsBook}  /  25";
        public string ParadiseLostText => $"{BookValues.ParadiseLost}  /  1";
        public string UnarmedBookText => $"{BookValues.UnarmedBook}  /  25";
        public string BarterBookText => $"{BookValues.BarterBook}  /  24";
        public string LockpickBookText => $"{BookValues.LockpickBook}  /  25";
        public string BigGunsBookText => $"{BookValues.BigGunsBook}  /  \u221E";


        public Fallout3Leveling(List<Fallout3Character> snapshots)
        {
            InitializeComponent();
            characterSnapshots = snapshots;
            DataContext = this;
            BookValues = new Fallout3SkillBooks();
            DataContext = this;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        // Method to notify property changed
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void DecreaseBarter(object sender, RoutedEventArgs e)
        {
            
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.Barter--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(BarterText));

        }

        private void IncreaseBarter(object sender, RoutedEventArgs e)
        {
            if (Character.Barter < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.Barter++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(BarterText));
        }

        private void DecreaseBigGuns(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.BigGuns--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(BigGunsText));
        }

        private void IncreaseBigGuns(object sender, RoutedEventArgs e)
        {
            if (Character.BigGuns < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.BigGuns++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(BigGunsText));
        }

        private void DecreaseEnergyWeapons(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.EnergyWeapons--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(EnergyWeaponsText));
        }

        private void IncreaseEnergyWeapons(object sender, RoutedEventArgs e)
        {
            if (Character.EnergyWeapons < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.EnergyWeapons++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(EnergyWeaponsText));
        }

        private void DecreaseExplosives(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.Explosives--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(ExplosivesText));
        }

        private void IncreaseExplosives(object sender, RoutedEventArgs e)
        {
            if (Character.Explosives < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.Explosives++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(ExplosivesText));
        }

        private void DecreaseLockpick(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.Lockpick--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(LockpickText));
        }

        private void IncreaseLockpick(object sender, RoutedEventArgs e)
        {
            if (Character.Lockpick < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.Lockpick++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(LockpickText));
        }

        private void DecreaseMedicine(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.Medicine--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(MedicineText));
        }

        private void IncreaseMedicine(object sender, RoutedEventArgs e)
        {
            if (Character.Medicine < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.Medicine++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(MedicineText));
        }

        private void DecreaseMeleeWeapons(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.MeleeWeapons--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(MeleeWeaponsText));
        }

        private void IncreaseMeleeWeapons(object sender, RoutedEventArgs e)
        {
            if (Character.MeleeWeapons < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.MeleeWeapons++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(MeleeWeaponsText));
        }

        private void DecreaseRepair(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.Repair--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(RepairText));
        }

        private void IncreaseRepair(object sender, RoutedEventArgs e)
        {
            if (Character.Repair < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.Repair++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(RepairText));
        }

        private void DecreaseScience(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.Science--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(ScienceText));
        }

        private void IncreaseScience(object sender, RoutedEventArgs e)
        {
            if (Character.Science < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.Science++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(ScienceText));
        }

        private void DecreaseSmallGuns(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.SmallGuns--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(SmallGunsText));
        }
        private void IncreaseSmallGuns(object sender, RoutedEventArgs e)
        {
            if (Character.SmallGuns < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.SmallGuns++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(SmallGunsText));
        }

        private void DecreaseSneak(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.Sneak--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(SneakText));
        }

        private void IncreaseSneak(object sender, RoutedEventArgs e)
        {
            if (Character.Sneak < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.Sneak++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(SneakText));
        }

        private void DecreaseSpeech(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.Speech--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(SpeechText));
        }

        private void IncreaseSpeech(object sender, RoutedEventArgs e)
        {
            if (Character.Speech < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.Speech++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(SpeechText));
        }

        private void DecreaseUnarmed(object sender, RoutedEventArgs e)
        {
            if (Character.SkillPoints < Character.Intelligence + 10)
            {
                Character.SkillPoints++;
                Character.Unarmed--;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(UnarmedText));
        }

        private void IncreaseUnarmed(object sender, RoutedEventArgs e)
        {
            if (Character.Unarmed < 100 && Character.SkillPoints > 0)
            {
                Character.SkillPoints--;
                Character.Unarmed++;
            }
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(UnarmedText));
        }

        private void SkillBooks_Click(object sender, RoutedEventArgs e)
        {
            LvlViewbox.Visibility = Visibility.Collapsed;
            SkillBooksViewbox.Visibility = Visibility.Visible;
        }

        private void ExtraPerks_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void BooksSave_Click(object sender, RoutedEventArgs e)
        {
            LvlViewbox.Visibility = Visibility.Visible;
            SkillBooksViewbox.Visibility = Visibility.Collapsed;
        }

        private void LevelUp_Click(object sender, RoutedEventArgs e)
        {
            /*  ALL PERK ATTRIBUTES IF NOT SET WHEN ADDED ARE DEFAULT  
                PerkName
                RequiredLevel
                RequiredStrength
                RequiredPerception
                RequiredEndurance
                RequiredCharisma
                RequiredIntelligence
                RequiredAgility
                RequiredLuck
                RequiredScience
                RequiredExplosives
                RequiredSneak
                RequiredMedicine
                RequiredLockpick
                RequiredSmallGuns
                RequiredEnergyWeapons
                RequiredUnarmed
                RequiredMeleeWeapons
                MaxPerkRank
                CurrentPerkRank
            */

            List<Fallout3Perks> allPerksList = new List<Fallout3Perks>();

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Black Widow/Lady Killer",
                RequiredLevel = 2,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Daddy's Boy/Daddy's Girl",
                RequiredLevel = 2,
                MaxPerkRank = 3,
                RequiredIntelligence = 4
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Gun Nut",
                RequiredLevel = 2,
                MaxPerkRank = 3,
                RequiredIntelligence = 4,
                RequiredAgility = 4
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Little Leaguer",
                RequiredLevel = 2,
                MaxPerkRank = 3,
                RequiredStrength = 4
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Theif",
                RequiredLevel = 2,
                MaxPerkRank = 3,
                RequiredPerception = 4,
                RequiredAgility = 4
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Swift Learner",
                RequiredLevel = 2,
                MaxPerkRank = 3,
                RequiredIntelligence = 4
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Intense Training",
                RequiredLevel = 2,
                MaxPerkRank = 10
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Child at Heart",
                RequiredLevel = 4,
                MaxPerkRank = 1,
                RequiredCharisma = 4
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Child at Heart",
                RequiredLevel = 4,
                MaxPerkRank = 1,
                RequiredCharisma = 4
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Comprehension",
                RequiredLevel = 4,
                MaxPerkRank = 1,
                RequiredIntelligence = 4
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Educated",
                RequiredLevel = 4,
                MaxPerkRank = 1,
                RequiredIntelligence = 4
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Entomologist",
                RequiredLevel = 4,
                MaxPerkRank = 1,
                RequiredIntelligence = 4,
                RequiredScience = 40
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Scoundrel",
                RequiredLevel = 4,
                MaxPerkRank = 3,
                RequiredCharisma = 4
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Iron Fist",
                RequiredLevel = 4,
                MaxPerkRank = 3,
                RequiredStrength = 4
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Bloody Mess",
                RequiredLevel = 6,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Lead Belly",
                RequiredLevel = 6,
                MaxPerkRank = 1,
                RequiredEndurance = 5
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Toughness",
                RequiredLevel = 6,
                MaxPerkRank = 1,
                RequiredEndurance = 5

            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Fortune Finder",
                RequiredLevel = 6,
                MaxPerkRank = 1,
                RequiredLuck = 5
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Gunslinger",
                RequiredLevel = 6,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Demolition Expert",
                RequiredLevel = 6,
                MaxPerkRank = 3,
                RequiredExplosives = 50
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Commando",
                RequiredLevel = 8,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Rad Resistance",
                RequiredLevel = 8,
                MaxPerkRank = 1,
                RequiredEndurance = 5
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Scrounger",
                RequiredLevel = 8,
                MaxPerkRank = 1,
                RequiredLuck = 5
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Size Matters",
                RequiredLevel = 8,
                MaxPerkRank = 3,
                RequiredEndurance = 5
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Strong Back",
                RequiredLevel = 8,
                MaxPerkRank = 1,
                RequiredStrength = 5,
                RequiredEndurance= 5
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Impartial Mediation",
                RequiredLevel = 8,
                MaxPerkRank = 1,
                RequiredCharisma = 5
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Animal Friend",
                RequiredLevel = 10,
                MaxPerkRank = 2,
                RequiredCharisma = 6
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Finesse",
                RequiredLevel = 10,
                MaxPerkRank = 1,
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Mister Sandman",
                RequiredLevel = 10,
                MaxPerkRank = 1,
                RequiredSneak = 60
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Mysterious Stranger",
                RequiredLevel = 10,
                MaxPerkRank = 1,
                RequiredLuck = 6
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Nerd Rage",
                RequiredLevel = 10,
                MaxPerkRank = 1,
                RequiredIntelligence = 5,
                RequiredScience = 50
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Night Person",
                RequiredLevel = 10,
                MaxPerkRank = 1,
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Here and Now",
                RequiredLevel = 10,
                MaxPerkRank = 1,
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Pyromaniac",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                RequiredExplosives = 60
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Cannibal",
                RequiredLevel = 12,
                MaxPerkRank = 1,
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Life Giver",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                RequiredEndurance = 6
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Robotics Expert",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                RequiredScience = 50
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Sniper",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                RequiredPerception = 6,
                RequiredAgility = 6
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Silent Running",
                RequiredLevel = 12,
                MaxPerkRank = 1,
                RequiredAgility = 6,
                RequiredSneak = 50
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Fast Metabolism",
                RequiredLevel = 12,
                MaxPerkRank = 1,
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Lawbringer",
                RequiredLevel = 14,
                MaxPerkRank = 1,
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Chemist",
                RequiredLevel = 14,
                MaxPerkRank = 1,
                RequiredMedicine = 60
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Contract Killer",
                RequiredLevel = 14,
                MaxPerkRank = 1,
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Cyborg",
                RequiredLevel = 14,
                MaxPerkRank = 1,
                RequiredMedicine = 60,
                RequiredScience = 60
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Light Step",
                RequiredLevel = 14,
                MaxPerkRank = 1,
                RequiredPerception = 6,
                RequiredAgility = 6
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Master Trader",
                RequiredLevel = 14,
                MaxPerkRank = 1,
                RequiredBarter = 60,
                RequiredCharisma = 6
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Admantium Skeleton",
                RequiredLevel = 14,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Tag!",
                RequiredLevel = 16,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Better Criticals",
                RequiredLevel = 16,
                MaxPerkRank = 1,
                RequiredPerception = 6,
                RequiredLuck = 6
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Action Boy/Girl",
                RequiredLevel = 16,
                MaxPerkRank = 1,
                RequiredAgility = 6
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Chem Resistant",
                RequiredLevel = 16,
                MaxPerkRank = 1,
                RequiredMedicine = 60
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Infiltrator",
                RequiredLevel = 18,
                MaxPerkRank = 1,
                RequiredPerception = 7,
                RequiredLockpick = 70
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Computer Whiz",
                RequiredLevel = 18,
                MaxPerkRank = 1,
                RequiredIntelligence = 7,
                RequiredScience = 70
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Concentrated Fire",
                RequiredLevel = 18,
                MaxPerkRank = 1,
                RequiredEnergyWeapons = 60,
                RequiredSmallGuns = 60
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Paralyzing Palm",
                RequiredLevel = 18,
                MaxPerkRank = 1,
                RequiredUnarmed = 70
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Solar Powered",
                RequiredLevel = 20,
                MaxPerkRank = 1,
                RequiredEndurance = 7
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Ninja",
                RequiredLevel = 20,
                MaxPerkRank = 1,
                RequiredMeleeWeapons = 80,
                RequiredSneak = 80
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Grim Reaper's Sprint",
                RequiredLevel = 20,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Explorer",
                RequiredLevel = 20,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Deep Sleep",
                RequiredLevel = 22,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Puppies",
                RequiredLevel = 22,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Quantum Chemist",
                RequiredLevel = 22,
                MaxPerkRank = 1,
                RequiredScience = 70
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Devil's Highway",
                RequiredLevel = 24,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Escalator to Heaven",
                RequiredLevel = 24,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Karamic Rebalance",
                RequiredLevel = 24,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "No Weaknesses",
                RequiredLevel = 24,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Rad Tolerance",
                RequiredLevel = 26,
                MaxPerkRank = 1,
                RequiredEndurance = 7
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Warmonger",
                RequiredLevel = 26,
                MaxPerkRank = 1,
                RequiredIntelligence = 7
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Nerves of Steel",
                RequiredLevel = 26,
                MaxPerkRank = 1,
                RequiredAgility = 7
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Party Boy/Girl",
                RequiredLevel = 228,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Rad Absorption",
                RequiredLevel = 28,
                MaxPerkRank = 1,
                RequiredEndurance= 7
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Nuclear Anomaly",
                RequiredLevel = 30,
                MaxPerkRank = 1
            });

            allPerksList.Add(new Fallout3Perks
            {
                PerkName = "Almost Perfect",
                RequiredLevel = 30,
                MaxPerkRank = 1
            });
        }
    }
}
