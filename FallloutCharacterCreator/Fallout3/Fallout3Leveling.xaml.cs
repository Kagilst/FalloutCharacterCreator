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
        public string CharacterNameText => $"Name: {Character?.CharacterName}";
        public string CharacterLevelText => $"Level: {Character?.Level}";
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
    }
}
