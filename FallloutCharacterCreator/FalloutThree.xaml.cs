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

        public string StrengthText => $"Strength: {Character.Strength}";
        public string PerceptionText => $"Perception: {Character.Perception}";
        public string EnduranceText => $"Endurance: {Character.Endurance}";
        public string CharismaText => $"Charisma: {Character.Charisma}";
        public string IntelligenceText => $"Intelligence: {Character.Intelligence}";
        public string AgilityText => $"Agility: {Character.Agility}";
        public string LuckText => $"Luck: {Character.Luck}";
        public string SpecialPointsText => $"SPECIAL Points: {Character.SpecialPoints}";
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
            }
            OnPropertyChanged(nameof(StrengthText));
            OnPropertyChanged(nameof(SpecialPointsText)); // Update the displayed text
        }
        private void IncreaseStrength(object sender, RoutedEventArgs e)
        {
            if (Character.Strength != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Strength++;
            }
            OnPropertyChanged(nameof(StrengthText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
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
            }
            OnPropertyChanged(nameof(EnduranceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
        }
        private void IncreaseEndurance(object sender, RoutedEventArgs e)
        {
            if (Character.Endurance != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Endurance++;
            }
            OnPropertyChanged(nameof(EnduranceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
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
            }
            OnPropertyChanged(nameof(IntelligenceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
        }
        private void IncreaseIntelligence(object sender, RoutedEventArgs e)
        {
            if (Character.Intelligence != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Intelligence++;
            }
            OnPropertyChanged(nameof(IntelligenceText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
        }

        // Methods to handle Agility value
        private void DecreaseAgility(object sender, RoutedEventArgs e)
        {
            if (Character.Agility != 1)
            {
                Character.SpecialPoints++;
                Character.Agility--;
            }
            OnPropertyChanged(nameof(AgilityText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
        }
        private void IncreaseAgility(object sender, RoutedEventArgs e)
        {
            if (Character.Agility != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Agility++;
            }
            OnPropertyChanged(nameof(AgilityText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
        }

        // Methods to handle Luck value
        private void DecreaseLuck(object sender, RoutedEventArgs e)
        {
            if (Character.Luck != 1)
            {
                Character.SpecialPoints++;
                Character.Luck--;
            }
            OnPropertyChanged(nameof(LuckText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
        }
        private void IncreaseLuck(object sender, RoutedEventArgs e)
        {
            if (Character.Luck != 10 && Character.SpecialPoints != 0)
            {
                Character.SpecialPoints--;
                Character.Luck++;
            }
            OnPropertyChanged(nameof(LuckText)); // Update the displayed text
            OnPropertyChanged(nameof(SpecialPointsText));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        // Method to notify property changed
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
