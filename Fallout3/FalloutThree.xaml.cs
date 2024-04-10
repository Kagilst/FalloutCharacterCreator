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

namespace FallloutCharacterCreator
{
    /// <summary>
    /// Interaction logic for FalloutThree.xaml
    /// </summary>
    public partial class FalloutThree : Page, INotifyPropertyChanged
    {


        public Fallout3Character Character { get; set; }

        public string StrengthText =>      $"{Character.Strength}";
        public string PerceptionText =>    $"{Character.Perception}";
        public string EnduranceText =>     $"{Character.Endurance}";
        public string CharismaText =>      $"{Character.Charisma}";
        public string IntelligenceText =>  $"{Character.Intelligence}";
        public string AgilityText =>       $"{Character.Agility}";
        public string LuckText =>          $"{Character.Luck}";
        public string SpecialPointsText => $"{Character.SpecialPoints}";
        public string ActionPointsText => $"{Character.ActionPoints}";
        public string CarryWeightText => $"{Character.CarryWeight}";
        public string CriticalChanceText => $"{Character.CriticalChance}";
        public string DamageResistText => $"{Character.DamageResistance}";
        public string HealthText => $"{Character.Health}";
        public string UnarmedDamageText => $"{Character.UnarmedDamage}";
        public string TaggedSkillsText => $"{Character.TaggedSkills}";
        public string SkillPointsText => $"{Character.SkillPoints}";
        public string BarterText => $"{Character.Barter}";
        public string BigGunsText => $"{Character.BigGuns}";
        public string EnergyWeaponsText => $"{Character.EnergyWeapons}";
        public string ExplosivesText => $"{Character.Explosives}";
        public string LockpickText => $"{Character.Lockpick}";
        public string MedicineText => $"{Character.Medicine}";
        public string MeleeWeaponsText => $"{Character.MeleeWeapons}";
        public string RepairText => $"{Character.Repair}";
        public string ScienceText => $"{Character.Science}";
        public string SmallGunsText => $"{Character.SmallGuns}";
        public string SneakText => $"{Character.Sneak}";
        public string SpeechText => $"{Character.Speech}";
        public string UnarmedText => $"{Character.Unarmed}";
        public FalloutThree()
        {
            InitializeComponent();
            Character = new Fallout3Character(); // Create a new instance of Fallout3Character
            DataContext = this; // Set DataContext to this for binding to work
        }

        // Methods to handle strength value
        private void DecreaseStrength(object sender, RoutedEventArgs e)
        {
            if (Character.Strength != 1)
            {
                Character.SpecialPoints++;
                Character.Strength--;
                Character.CarryWeight -= 10;
                Character.UnarmedDamage -= .5;
            }
            OnPropertyChanged(nameof(StrengthText));
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(CarryWeightText));
            OnPropertyChanged(nameof(UnarmedDamageText));// Update the displayed text
        }
        private void IncreaseStrength(object sender, RoutedEventArgs e)
        {
            if (Character.Strength != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Strength++;
                Character.CarryWeight += 10;
                Character.UnarmedDamage += .5;
            }
            OnPropertyChanged(nameof(StrengthText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(CarryWeightText));
            OnPropertyChanged(nameof(UnarmedDamageText));
        }

        // Methods to handle perception value
        private void DecreasePerception(object sender, RoutedEventArgs e)
        {
            if (Character.Perception != 1)
            {
                Character.SpecialPoints++;
                Character.Perception--;
            }
            OnPropertyChanged(nameof(PerceptionText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
        }
        private void IncreasePerception(object sender, RoutedEventArgs e)
        {
            if (Character.Perception != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Perception++;
            }
            OnPropertyChanged(nameof(PerceptionText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
        }

        // Methods to handle endurance value
        private void DecreaseEndurance(object sender, RoutedEventArgs e)
        {
            if (Character.Endurance != 1)
            {
                Character.SpecialPoints++;
                Character.Endurance--;
                Character.Health -= 20;
            }
            OnPropertyChanged(nameof(EnduranceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(HealthText));
        }
        private void IncreaseEndurance(object sender, RoutedEventArgs e)
        {
            if (Character.Endurance != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Endurance++;
                Character.Health += 20;
            }
            OnPropertyChanged(nameof(EnduranceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(HealthText));
        }

        // Methods to handle Charisma value
        private void DecreaseCharisma(object sender, RoutedEventArgs e)
        {
            if (Character.Charisma != 1)
            {
                Character.SpecialPoints++;
                Character.Charisma--;
            }
            OnPropertyChanged(nameof(CharismaText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
        }
        private void IncreaseCharisma(object sender, RoutedEventArgs e)
        {
            if (Character.Charisma != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Charisma++;
            }
            OnPropertyChanged(nameof(CharismaText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
        }

        // Methods to handle Intelligence value
        private void DecreaseIntelligence(object sender, RoutedEventArgs e)
        {
            if (Character.Intelligence != 1)
            {
                Character.SpecialPoints++;
                Character.Intelligence--;
                Character.SkillPoints--;
            }
            OnPropertyChanged(nameof(IntelligenceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            //OnPropertyChanged(nameof(SkillPointsText));
        }
        private void IncreaseIntelligence(object sender, RoutedEventArgs e)
        {
            if (Character.Intelligence != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Intelligence++;
                Character.SkillPoints++;
            }
            OnPropertyChanged(nameof(IntelligenceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            //OnPropertyChanged(nameof(SkillPointsText));
        }

        // Methods to handle Agility value
        private void DecreaseAgility(object sender, RoutedEventArgs e)
        {
            if (Character.Agility != 1)
            {
                Character.SpecialPoints++;
                Character.Agility--;
                Character.ActionPoints -= 2;
            }
            OnPropertyChanged(nameof(AgilityText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(ActionPointsText));
        }
        private void IncreaseAgility(object sender, RoutedEventArgs e)
        {
            if (Character.Agility != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Agility++;
                Character.ActionPoints += 2;
            }
            OnPropertyChanged(nameof(AgilityText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(ActionPointsText));
        }

        // Methods to handle Luck value
        private void DecreaseLuck(object sender, RoutedEventArgs e)
        {
            if (Character.Luck != 1)
            {
                Character.SpecialPoints++;
                Character.Luck--;
                Character.CriticalChance--;
            }
            OnPropertyChanged(nameof(LuckText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(CriticalChanceText));
        }
        private void IncreaseLuck(object sender, RoutedEventArgs e)
        {
            if (Character.Luck != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Luck++;
                Character.CriticalChance++;
            }
            OnPropertyChanged(nameof(LuckText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(CriticalChanceText));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        // Method to notify property changed
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
