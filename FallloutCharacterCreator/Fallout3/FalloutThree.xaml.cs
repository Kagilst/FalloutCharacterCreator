using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
        public string TaggedSkillsText => $"{Character.TaggedSkills}/3";
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
                Character.MeleeWeapons -= 2;
            }
            OnPropertyChanged(nameof(StrengthText));
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(CarryWeightText));
            OnPropertyChanged(nameof(UnarmedDamageText));// Update the displayed text
            OnPropertyChanged(nameof(MeleeWeaponsText));
        }
        private void IncreaseStrength(object sender, RoutedEventArgs e)
        {
            if (Character.Strength != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Strength++;
                Character.CarryWeight += 10;
                Character.UnarmedDamage += .5;
                Character.MeleeWeapons += 2;
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
                Character.EnergyWeapons -= 2;
                Character.Explosives -= 2;
                Character.Lockpick -= 2;
            }
            OnPropertyChanged(nameof(PerceptionText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(EnergyWeaponsText));
            OnPropertyChanged(nameof(ExplosivesText));
            OnPropertyChanged(nameof(LockpickText));
        }
        private void IncreasePerception(object sender, RoutedEventArgs e)
        {
            if (Character.Perception != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Perception++;
                Character.EnergyWeapons += 2;
                Character.Explosives += 2;
                Character.Lockpick += 2;
            }
            OnPropertyChanged(nameof(PerceptionText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(EnergyWeaponsText));
            OnPropertyChanged(nameof(ExplosivesText));
            OnPropertyChanged(nameof(LockpickText));
        }

        // Methods to handle endurance value
        private void DecreaseEndurance(object sender, RoutedEventArgs e)
        {
            if (Character.Endurance != 1)
            {
                Character.SpecialPoints++;
                Character.Endurance--;
                Character.Health -= 20;
                Character.BigGuns -= 2;
                Character.Unarmed -= 2;
            }
            OnPropertyChanged(nameof(EnduranceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(HealthText));
            OnPropertyChanged(nameof(BigGunsText));
            OnPropertyChanged(nameof(UnarmedText));
        }
        private void IncreaseEndurance(object sender, RoutedEventArgs e)
        {
            if (Character.Endurance != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Endurance++;
                Character.Health += 20;
                Character.BigGuns += 2;
                Character.Unarmed += 2;
            }
            OnPropertyChanged(nameof(EnduranceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(HealthText));
            OnPropertyChanged(nameof(BigGunsText));
            OnPropertyChanged(nameof(UnarmedText));
        }

        // Methods to handle Charisma value
        private void DecreaseCharisma(object sender, RoutedEventArgs e)
        {
            if (Character.Charisma != 1)
            {
                Character.SpecialPoints++;
                Character.Charisma--;
                Character.Barter -= 2;
                Character.Speech -= 2;
            }
            OnPropertyChanged(nameof(CharismaText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(BarterText));
            OnPropertyChanged(nameof(SpeechText));
        }
        private void IncreaseCharisma(object sender, RoutedEventArgs e)
        {
            if (Character.Charisma != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Charisma++;
                Character.Barter += 2;
                Character.Speech += 2;
            }
            OnPropertyChanged(nameof(CharismaText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(BarterText));
            OnPropertyChanged(nameof(SpeechText));
        }

        // Methods to handle Intelligence value
        private void DecreaseIntelligence(object sender, RoutedEventArgs e)
        {
            if (Character.Intelligence != 1)
            {
                Character.SpecialPoints++;
                Character.Intelligence--;
                Character.SkillPoints--;
                Character.Medicine -= 2;
                Character.Repair -= 2;
                Character.Science -= 2;
            }
            OnPropertyChanged(nameof(IntelligenceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(MedicineText));
            OnPropertyChanged(nameof(RepairText));
            OnPropertyChanged(nameof(ScienceText));
        }
        private void IncreaseIntelligence(object sender, RoutedEventArgs e)
        {
            if (Character.Intelligence != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Intelligence++;
                Character.SkillPoints++;
                Character.Medicine += 2;
                Character.Repair += 2;
                Character.Science += 2;
            }
            OnPropertyChanged(nameof(IntelligenceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(SkillPointsText));
            OnPropertyChanged(nameof(MedicineText));
            OnPropertyChanged(nameof(RepairText));
            OnPropertyChanged(nameof(ScienceText));
        }

        // Methods to handle Agility value
        private void DecreaseAgility(object sender, RoutedEventArgs e)
        {
            if (Character.Agility != 1)
            {
                Character.SpecialPoints++;
                Character.Agility--;
                Character.ActionPoints -= 2;
                Character.SmallGuns -= 2;
                Character.Sneak -= 2;
            }
            OnPropertyChanged(nameof(AgilityText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(ActionPointsText));
            OnPropertyChanged(nameof(SmallGunsText));
            OnPropertyChanged(nameof(SneakText));
        }
        private void IncreaseAgility(object sender, RoutedEventArgs e)
        {
            if (Character.Agility != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Agility++;
                Character.ActionPoints += 2;
                Character.SmallGuns += 2;
                Character.Sneak += 2;
            }
            OnPropertyChanged(nameof(AgilityText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(ActionPointsText));
            OnPropertyChanged(nameof(SmallGunsText));
            OnPropertyChanged(nameof(SneakText));
        }

        // Methods to handle Luck value
        //all stats increase on 3 5 7 9
        //all stats decrease on 2 4 6 8
        int count = 5;
        
        private void DecreaseLuck(object sender, RoutedEventArgs e)
        {
            if (Character.Luck != 1)
            {
                Character.SpecialPoints++;
                Character.Luck--;
                Character.CriticalChance--;
                count--;
            }

            if (count == 2 || count == 4 || count == 6 || count == 8)
            {
                Character.Barter--;
                Character.BigGuns--;
                Character.EnergyWeapons--;
                Character.Explosives--;
                Character.Lockpick--;
                Character.Medicine--;
                Character.MeleeWeapons--;
                Character.Repair--;
                Character.Science--;
                Character.SmallGuns--;
                Character.Sneak--;
                Character.Speech--;
                Character.Unarmed--;
            }

            OnPropertyChanged(nameof(LuckText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(CriticalChanceText));
            OnPropertyChanged(nameof(BarterText));
            OnPropertyChanged(nameof(BigGunsText));
            OnPropertyChanged(nameof(EnergyWeaponsText));
            OnPropertyChanged(nameof(ExplosivesText));
            OnPropertyChanged(nameof(LockpickText));
            OnPropertyChanged(nameof(MedicineText));
            OnPropertyChanged(nameof(MeleeWeaponsText));
            OnPropertyChanged(nameof(RepairText));
            OnPropertyChanged(nameof(ScienceText));
            OnPropertyChanged(nameof(SmallGunsText));
            OnPropertyChanged(nameof(SneakText));
            OnPropertyChanged(nameof(SpeechText));
            OnPropertyChanged(nameof(UnarmedText));
        }
        private void IncreaseLuck(object sender, RoutedEventArgs e)
        {
            
            if (Character.Luck != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Luck++;
                Character.CriticalChance++;
                count++;
            }

            if (count == 3 || count == 5 || count == 7 || count == 9)
            {
                Character.Barter++;
                Character.BigGuns++;
                Character.EnergyWeapons++;
                Character.Explosives++;
                Character.Lockpick++;
                Character.Medicine++;
                Character.MeleeWeapons++;
                Character.Repair++;
                Character.Science++;
                Character.SmallGuns++;
                Character.Sneak++;
                Character.Speech++;
                Character.Unarmed++;
            }
            OnPropertyChanged(nameof(LuckText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(CriticalChanceText));
            OnPropertyChanged(nameof(BarterText));
            OnPropertyChanged(nameof(BigGunsText));
            OnPropertyChanged(nameof(EnergyWeaponsText));
            OnPropertyChanged(nameof(ExplosivesText));
            OnPropertyChanged(nameof(LockpickText));
            OnPropertyChanged(nameof(MedicineText));
            OnPropertyChanged(nameof(MeleeWeaponsText));
            OnPropertyChanged(nameof(RepairText));
            OnPropertyChanged(nameof(ScienceText));
            OnPropertyChanged(nameof(SmallGunsText));
            OnPropertyChanged(nameof(SneakText));
            OnPropertyChanged(nameof(SpeechText));
            OnPropertyChanged(nameof(UnarmedText));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        // Method to notify property changed
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void BarterTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.Barter += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(BarterText));
            }
            else
            {
               
                (sender as CheckBox).IsChecked = false;
            }
        }

        private void BarterTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.Barter -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(BarterText));
        }

        private void BigGunsTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.BigGuns += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(BigGunsText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void BigGunsTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.BigGuns -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(BigGunsText));
        }

        private void EnergyWeaponsTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.EnergyWeapons += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(EnergyWeaponsText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void EnergyWeaponsTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.EnergyWeapons -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(EnergyWeaponsText));
        }

        private void ExplosivesTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.Explosives += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(ExplosivesText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void ExplosivesTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.Explosives -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(ExplosivesText));
        }

        private void LockpickTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.Lockpick += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(LockpickText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void LockpickTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.Lockpick -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(LockpickText));
        }

        private void MedicineTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.Medicine += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(MedicineText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void MedicineTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.Medicine -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(MedicineText));
        }

        private void MeleeWeaponsTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.MeleeWeapons += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(MeleeWeaponsText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void MeleeWeaponsTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.MeleeWeapons -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(MeleeWeaponsText));
        }

        private void RepairTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.Repair += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(RepairText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void RepairTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.Repair -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(RepairText));
        }

        private void ScienceTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.Science += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(ScienceText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void ScienceTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.Science -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(ScienceText));
        }

        private void SmallGunsTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.SmallGuns += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(SmallGunsText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void SmallGunsTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.SmallGuns -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(SmallGunsText));
        }

        private void SneakTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.Sneak += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(SneakText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void SneakTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.Sneak -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(SneakText));
        }

        private void SpeechTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.Speech += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(SpeechText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void SpeechTag_Unchecked(object sender, RoutedEventArgs e)
        {
            Character.TaggedSkills--;
            Character.Speech -= 15;
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(SpeechText));
        }

        private void UnarmedTag_Checked(object sender, RoutedEventArgs e)
        {
            if (Character.TaggedSkills < 3)
            {
                Character.TaggedSkills++;
                Character.Unarmed += 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(UnarmedText));
            }
            else
            {

                (sender as CheckBox).IsChecked = false;
            }
        }

        private void UnarmedTag_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.IsChecked == false)
            {
                Character.TaggedSkills--;
                Character.Unarmed -= 15;
                OnPropertyChanged(nameof(TaggedSkillsText));
                OnPropertyChanged(nameof(UnarmedText));
            }
        }
    }
}
