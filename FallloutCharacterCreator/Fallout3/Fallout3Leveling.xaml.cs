using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
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
        public Fallout3Character GetLatestCharacter()
        {
            return characterSnapshots[characterSnapshots.Count - 1];
        }

        

        public Fallout3SkillBooks BookValues { get; set; }

        private List<Fallout3Character> characterSnapshots;
        
        public Fallout3Character Character => GetLatestCharacter();
        public string CharacterNameText => $"{Character.CharacterName}";
        public string CharacterLevelText => $"{Character.Level}";
        public string StrengthText => $"{Character.Strength}";
        public string PerceptionText => $"{Character.Perception}";
        public string EnduranceText => $"{Character.Endurance}";
        public string CharismaText => $"{Character.Charisma}";
        public string IntelligenceText => $"{Character.Intelligence}";
        public string AgilityText => $"{Character.Agility}";
        public string LuckText => $"{Character.Luck}";
        public string SpecialPointsText => $"{Character.SpecialPoints}";
        public string ActionPointsText => $"{Character.ActionPoints}";
        public string CarryWeightText => $"{Character.CarryWeight}";
        public string CriticalChanceText => $"{Character.CriticalChance}";
        public string DamageResistText => $"{Character.DamageResistance}";
        public string HealthText => $"{Character.Health}";
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
            Fallout3Perks.InitializePerksList();
            Fallout3Bobbleheads.InitializeBobbleheadsList();
            ExtraFallout3Perks.InitializeExtraPerksList();
            characterSnapshots = snapshots;
            DataContext = this;
            BookValues = new Fallout3SkillBooks();
            DataContext = this;

        }

        private void PerksListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (PerksListView.SelectedItem != null)
            {
                // Cast the selected item to Fallout3Perks
                Fallout3Perks selectedPerk = (Fallout3Perks)PerksListView.SelectedItem;
                string requirementsText = "Requirements:\n";
                if (selectedPerk.RequiredLevel > 0)
                {
                    requirementsText += $"Required Level: {selectedPerk.RequiredLevel}\n";
                }
                if (selectedPerk.RequiredStrength > 0)
                {
                    requirementsText += $"Strength {selectedPerk.RequiredStrength}\n";
                }
                if (selectedPerk.RequiredPerception > 0)
                {
                    requirementsText += $"Perception: {selectedPerk.RequiredPerception}\n";
                }
                if (selectedPerk.RequiredEndurance > 0)
                {
                    requirementsText += $"Endurance: {selectedPerk.RequiredEndurance}\n";
                }
                if (selectedPerk.RequiredCharisma > 0)
                {
                    requirementsText += $"Charisma: {selectedPerk.RequiredCharisma}\n";
                }
                if (selectedPerk.RequiredIntelligence > 0)
                {
                    requirementsText += $"Intelligence: {selectedPerk.RequiredIntelligence}\n";
                }
                if (selectedPerk.RequiredAgility > 0)
                {
                    requirementsText += $"Agility: {selectedPerk.RequiredAgility}\n";
                }
                if (selectedPerk.RequiredLuck > 0)
                {
                    requirementsText += $"Luck: {selectedPerk.RequiredLuck}\n";
                }
                if (selectedPerk.RequiredScience > 0)
                {
                    requirementsText += $"Science: {selectedPerk.RequiredScience}\n";
                }
                if (selectedPerk.RequiredExplosives > 0)
                {
                    requirementsText += $"Explosives: {selectedPerk.RequiredExplosives}\n";
                }
                if (selectedPerk.RequiredSneak > 0)
                {
                    requirementsText += $"Sneak: {selectedPerk.RequiredSneak}\n";
                }
                if (selectedPerk.RequiredMedicine > 0)
                {
                    requirementsText += $"Medicine: {selectedPerk.RequiredMedicine}\n";
                }
                if (selectedPerk.RequiredLockpick > 0)
                {
                    requirementsText += $"Lockpick: {selectedPerk.RequiredLockpick}\n";
                }
                if (selectedPerk.RequiredSmallGuns > 0)
                {
                    requirementsText += $"Small Guns: {selectedPerk.RequiredSmallGuns}\n";
                }
                if (selectedPerk.RequiredEnergyWeapons > 0)
                {
                    requirementsText += $"Energy Weapons: {selectedPerk.RequiredEnergyWeapons}\n";
                }
                if (selectedPerk.RequiredBarter > 0)
                {
                    requirementsText += $"Barter: {selectedPerk.RequiredBarter}\n";
                }
                if (selectedPerk.RequiredUnarmed > 0)
                {
                    requirementsText += $"Unarmed: {selectedPerk.RequiredUnarmed}\n";
                }
                if (selectedPerk.RequiredMeleeWeapons > 0)
                {
                    requirementsText += $"Melee Weapons: {selectedPerk.RequiredMeleeWeapons}\n";
                }

                PerkReqTextBox.Text = requirementsText;


            }

            // Update the description TextBlock when a different perk is selected
            PerkDescriptionTextBlock.Text = (PerksListView.SelectedItem as Fallout3Perks)?.PerkDescription;
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
            LvlViewbox.Visibility = Visibility.Collapsed;
            ExtraPerksListView.ItemsSource = ExtraFallout3Perks.AllExtraPerksList;
            ExtraPerksViewbox.Visibility = Visibility.Visible;
        }

        private void BooksSave_Click(object sender, RoutedEventArgs e)
        {
            LvlViewbox.Visibility = Visibility.Visible;
            SkillBooksViewbox.Visibility = Visibility.Collapsed;
        }

        private void CancelPerkSelection_Click(object sender, RoutedEventArgs e)
        {
            LvlViewbox.Visibility = Visibility.Visible;
            PerksListViewbox.Visibility = Visibility.Collapsed;
        }

        List<Fallout3Perks> characterPerks = new List<Fallout3Perks>();

        bool hasEducatedPerk = false; 
        private void ConfirmPerkSelection_Click(object sender, RoutedEventArgs e)
        {
            Fallout3Perks selectedPerk = PerksListView.SelectedItem as Fallout3Perks;

            if (selectedPerk.AvaliableOrHave != 0)
            {
                if (selectedPerk.CurrentPerkRank == 0)
                {
                    characterPerks.Add(selectedPerk);
                }

                foreach (Fallout3Perks perk in Fallout3Perks.AllPerksList)
                {
                    if (perk.PerkName == selectedPerk.PerkName)
                    {
                        perk.CurrentPerkRank++;
                        break;
                    }
                }

                    if (selectedPerk.PerkName == "Daddy's Boy/Girl") {
                        if (Character.Science <= 95)
                        {
                            Character.Science += 5;
                        }
                        else {
                            Character.Science = 100;
                        }

                        if (Character.Medicine <= 95)
                        {
                            Character.Medicine += 5;
                        }
                        else
                        {
                            Character.Medicine = 100;
                        }
                    }

                    if (selectedPerk.PerkName == "Gun Nut")
                    {
                        if (Character.SmallGuns <= 95)
                        {
                            Character.SmallGuns += 5;
                        }
                        else
                        {
                            Character.SmallGuns = 100;
                        }

                        if (Character.Repair <= 95)
                        {
                            Character.Repair += 5;
                        }
                        else
                        {
                            Character.Repair = 100;
                        }
                    }

                    if (selectedPerk.PerkName == "Little Leaguer")
                    {
                        if (Character.MeleeWeapons <= 95)
                        {
                            Character.MeleeWeapons += 5;
                        }
                        else
                        {
                            Character.MeleeWeapons = 100;
                        }

                        if (Character.Explosives <= 95)
                        {
                            Character.Explosives += 5;
                        }
                        else
                        {
                            Character.Explosives = 100;
                        }
                    }

                    if (selectedPerk.PerkName == "Theif")
                    {
                        if (Character.Lockpick <= 95)
                        {
                            Character.Lockpick += 5;
                        }
                        else
                        {
                            Character.Lockpick = 100;
                        }

                        if (Character.Sneak <= 95)
                        {
                            Character.Sneak += 5;
                        }
                        else
                        {
                            Character.Sneak = 100;
                        }
                    }

                    if (selectedPerk.PerkName == "Intense Training")
                    {
                        //Still deciding how to implement
                    }

                    if (selectedPerk.PerkName == "Comprehension")
                    {

                        //Still need to implement
                    }

                    if (selectedPerk.PerkName == "Educated")
                    {
                        hasEducatedPerk = true;
                    }

                    if (selectedPerk.PerkName == "Scoundrel")
                    {
                        if (Character.Speech <= 95)
                        {
                            Character.Speech += 5;
                        }
                        else
                        {
                            Character.Speech = 100;
                        }

                        if (Character.Barter <= 95)
                        {
                            Character.Barter += 5;
                        }
                        else
                        {
                            Character.Barter = 100;
                        }
                    }

                    if (selectedPerk.PerkName == "Toughness")
                    {
                        if (Character.DamageResistance < 75) {
                            Character.DamageResistance = +10; }
                        else { 
                            Character.DamageResistance = 85;
                        }
                    }

                    if (selectedPerk.PerkName == "Size Matter")
                    {
                        if (Character.BigGuns < 85)
                        {
                            Character.BigGuns += 15;
                        }
                        else
                        {
                            Character.BigGuns = 100;
                        }
                    }

                    if (selectedPerk.PerkName == "Strong Back")
                    {
                            Character.CarryWeight += 50;
                    }

                    if (selectedPerk.PerkName == "Finesse")
                    {
                            Character.CriticalChance += 5;                       
                    }

                    if (selectedPerk.PerkName == "Life Giver")
                    {
                        Character.Health += 30;
                    }

                    if (selectedPerk.PerkName == "Silent Running")
                    {
                        if (Character.Sneak < 90)
                        {
                            Character.Sneak += 10;
                        }
                        else
                        {
                            Character.Sneak = 100;
                        }
                    }

                    if (selectedPerk.PerkName == "Cyborg")
                    {
                        if (Character.EnergyWeapons < 90)
                        {
                            Character.EnergyWeapons += 10;
                        }
                        else
                        {
                            Character.EnergyWeapons = 100;
                        }
                    }

                    if (selectedPerk.PerkName == "Tag")
                    {
                        //Need to implement
                    }

                    if (selectedPerk.PerkName == "Action Boy/Girl")
                    {
                        Character.ActionPoints += 25;
                    }

                    if (selectedPerk.PerkName == "No Weaknesses")
                    {
                        if (Character.Strength < 5) { Character.Strength = 5; }
                        if (Character.Perception < 5) { Character.Perception = 5; }
                        if (Character.Endurance < 5) { Character.Endurance = 5; }
                        if (Character.Charisma < 5) { Character.Charisma = 5; }
                        if (Character.Intelligence < 5) { Character.Intelligence = 5; }
                        if (Character.Agility < 5) { Character.Agility = 5; }
                        if (Character.Luck < 5) { Character.Luck = 5; }
                    }

                    if (selectedPerk.PerkName == "Almost Perfect")
                    {
                        if (Character.Strength < 9) { Character.Strength = 9; }
                        if (Character.Perception < 9) { Character.Perception = 9; }
                        if (Character.Endurance < 9) { Character.Endurance = 9; }
                        if (Character.Charisma < 9) { Character.Charisma = 9; }
                        if (Character.Intelligence < 9) { Character.Intelligence = 9; }
                        if (Character.Agility < 9) { Character.Agility = 9; }
                        if (Character.Luck < 9) { Character.Luck = 9; }
                    }



                


                {
                    Fallout3Character snapshot = new Fallout3Character();
                    snapshot.CharacterName = Character.CharacterName;
                    snapshot.Level = Character.Level + 1;
                    snapshot.SpecialPoints = Character.SpecialPoints;
                    snapshot.CarryWeight = Character.CarryWeight;
                    snapshot.ActionPoints = Character.ActionPoints;
                    snapshot.CriticalChance = Character.CriticalChance;
                    snapshot.DamageResistance = Character.DamageResistance;
                    if (hasEducatedPerk == false){
                        snapshot.SkillPoints = Character.Intelligence + 10;
                    }
                    else {
                        snapshot.SkillPoints = Character.Intelligence + 13;
                    }
                    snapshot.Health = Character.Health + 10;
                    snapshot.SpecialPoints = Character.SpecialPoints;
                    snapshot.Strength = Character.Strength;
                    snapshot.Perception = Character.Perception;
                    snapshot.Endurance = Character.Endurance;
                    snapshot.Charisma = Character.Charisma;
                    snapshot.Intelligence = Character.Intelligence;
                    snapshot.Agility = Character.Agility;
                    snapshot.Luck = Character.Luck;
                    snapshot.Barter = Character.Barter;
                    snapshot.BigGuns = Character.BigGuns;
                    snapshot.EnergyWeapons = Character.EnergyWeapons;
                    snapshot.Explosives = Character.Explosives;
                    snapshot.Lockpick = Character.Lockpick;
                    snapshot.Medicine = Character.Medicine;
                    snapshot.MeleeWeapons = Character.MeleeWeapons;
                    snapshot.Repair = Character.Repair;
                    snapshot.Science = Character.Science;
                    snapshot.SmallGuns = Character.SmallGuns;
                    snapshot.Sneak = Character.Sneak;
                    snapshot.Speech = Character.Speech;
                    snapshot.Unarmed = Character.Unarmed;
                    snapshot.TaggedSkills = Character.TaggedSkills;

                    characterSnapshots.Add(snapshot);

                    UpdateCharacterValues();

                    LvlViewbox.Visibility = Visibility.Visible;
                    PerksListViewbox.Visibility = Visibility.Collapsed;
                }
            }
            else {
                    MessageBox.Show("You do not have the requirement for this perk",
                        "Warning",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                
            }            
        }
        private void UpdateCharacterValues()
        {
            OnPropertyChanged(nameof(CharacterNameText));
            OnPropertyChanged(nameof(CharacterLevelText));
            OnPropertyChanged(nameof(StrengthText));
            OnPropertyChanged(nameof(PerceptionText));
            OnPropertyChanged(nameof(EnduranceText));
            OnPropertyChanged(nameof(CharismaText));
            OnPropertyChanged(nameof(IntelligenceText));
            OnPropertyChanged(nameof(AgilityText));
            OnPropertyChanged(nameof(LuckText));
            OnPropertyChanged(nameof(SpecialPointsText));
            OnPropertyChanged(nameof(ActionPointsText));
            OnPropertyChanged(nameof(CarryWeightText));
            OnPropertyChanged(nameof(CriticalChanceText));
            OnPropertyChanged(nameof(DamageResistText));
            OnPropertyChanged(nameof(HealthText));
            OnPropertyChanged(nameof(TaggedSkillsText));
            OnPropertyChanged(nameof(SkillPointsText));
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
            OnPropertyChanged(nameof(ScienceBookText));
            OnPropertyChanged(nameof(SneakBookText));
            OnPropertyChanged(nameof(MedicineBookText));
            OnPropertyChanged(nameof(RepairBookText));
            OnPropertyChanged(nameof(ExplosivesBookText));
            OnPropertyChanged(nameof(MeleeWeaponsBookText));
            OnPropertyChanged(nameof(SmallGunsBookText));
            OnPropertyChanged(nameof(SpeechBookText));
            OnPropertyChanged(nameof(EnergyWeaponsBookText));
            OnPropertyChanged(nameof(ParadiseLostText));
            OnPropertyChanged(nameof(UnarmedBookText));
            OnPropertyChanged(nameof(BarterBookText));
            OnPropertyChanged(nameof(LockpickBookText));
            OnPropertyChanged(nameof(BigGunsBookText));
        }


        private void LevelUp_Click(object sender, RoutedEventArgs e)
        {     

            if (Character.SkillPoints == 0 && Character.Level < 50) {

                foreach (Fallout3Perks perkcheck in Fallout3Perks.AllPerksList)
                {
                    if (Character.Level + 1 >= perkcheck.RequiredLevel &&
                        Character.Strength >= perkcheck.RequiredStrength &&
                        Character.Perception >= perkcheck.RequiredPerception &&
                        Character.Endurance >= perkcheck.RequiredEndurance &&
                        Character.Charisma >= perkcheck.RequiredCharisma &&
                        Character.Intelligence >= perkcheck.RequiredIntelligence &&
                        Character.Agility >= perkcheck.RequiredAgility &&
                        Character.Luck >= perkcheck.RequiredLuck &&
                        Character.Science >= perkcheck.RequiredScience &&
                        Character.Explosives >= perkcheck.RequiredExplosives &&
                        Character.Sneak >= perkcheck.RequiredSneak &&
                        Character.Medicine >= perkcheck.RequiredMedicine &&
                        Character.Lockpick >= perkcheck.RequiredLockpick &&
                        Character.SmallGuns >= perkcheck.RequiredSmallGuns &&
                        Character.EnergyWeapons >= perkcheck.RequiredEnergyWeapons &&
                        Character.Barter >= perkcheck.RequiredBarter &&
                        Character.Unarmed >= perkcheck.RequiredUnarmed &&
                        Character.MeleeWeapons >= perkcheck.RequiredMeleeWeapons &&
                        perkcheck.CurrentPerkRank < perkcheck.MaxPerkRank)
                    {

                        perkcheck.AvaliableOrHave = 1;

                    }
                    else if (Character.Level < perkcheck.RequiredLevel)
                    {
                        break;
                    }
                    else if (perkcheck.CurrentPerkRank == perkcheck.MaxPerkRank) { 
                        perkcheck.AvaliableOrHave = 2;
                    }

                    List<Fallout3Perks> availablePerks = Fallout3Perks.AllPerksList
        .Where(perk => perk.AvaliableOrHave == 1)
        .ToList();

                    List<Fallout3Perks> unavailablePerks = Fallout3Perks.AllPerksList
        .Where(perk => perk.AvaliableOrHave == 0)
        .ToList();
                    
                    List<Fallout3Perks> perkListDisplay = availablePerks.Concat(unavailablePerks).ToList();

                    LvlViewbox.Visibility = Visibility.Collapsed;
                    PerksListView.ItemsSource = perkListDisplay;
                    PerksListViewbox.Visibility = Visibility.Visible;
                }
                
            }
            else if(Character.SkillPoints != 0)
            {
                MessageBox.Show("Please make sure:\n" +
                    "- You use all avaliable skill point",
                    "Warning",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else if (Character.Level == 50)
            {
                MessageBox.Show("You are already max character level\n",
                    "Warning",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }


        
        private void Bobbleheads_Click(object sender, RoutedEventArgs e) //Todo: Still Working on functionality
        {
            BobbleheadsListView.ItemsSource = null;
            BobbleheadsListView.ItemsSource = Fallout3Bobbleheads.AllBobbleheadsList;
            LvlViewbox.Visibility = Visibility.Collapsed;
            BobbleheadsListViewbox.Visibility = Visibility.Visible;
        }

        private void CharacterPerks_Click(object sender, RoutedEventArgs e)
        {
            LvlViewbox.Visibility = Visibility.Collapsed;
            PerkRankInfoTextBlock.Text = string.Empty;
            CharPerksListView.ItemsSource = null;
            CharPerksListView.ItemsSource = characterPerks;
            CharPerksViewbox.Visibility = Visibility.Visible;
        }

        private void BobbleheadsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ConfirmBobbleheadSelection_Click(object sender, RoutedEventArgs e)
        {
            foreach (var selectedBobblehead in BobbleheadsListView.SelectedItems)
            {
                var bobblehead = selectedBobblehead as Fallout3Bobbleheads;

                if (bobblehead.BobbleheadGotorNot != true)
                {

                    //Update BobbleheadGotorNot value to true
                    bobblehead.BobbleheadGotorNot = true;

                    if (bobblehead.BobbleheadName == "Strength - Bobblehead" && Character.Strength < 10)
                    {
                        Character.Strength++;
                    }
                    if (bobblehead.BobbleheadName == "Perception - Bobblehead" && Character.Perception < 10)
                    {
                        Character.Perception++;
                    }
                    if (bobblehead.BobbleheadName == "Endurance - Bobblehead" && Character.Endurance < 10)
                    {
                        Character.Endurance++;
                    }
                    if (bobblehead.BobbleheadName == "Charisma - Bobblehead" && Character.Charisma < 10)
                    {
                        Character.Charisma++;
                    }
                    if (bobblehead.BobbleheadName == "Intelligence - Bobblehead" && Character.Intelligence < 10)
                    {
                        Character.Intelligence++;
                    }
                    if (bobblehead.BobbleheadName == "Agility - Bobblehead" && Character.Agility < 10)
                    {
                        Character.Agility++;
                    }
                    if (bobblehead.BobbleheadName == "Luck - Bobblehead" && Character.Luck < 10)
                    {
                        Character.Luck++;
                    }
                    if (bobblehead.BobbleheadName == "Barter - Bobblehead" && Character.Barter < 100)
                    {
                        if (Character.Barter < 90)
                        {
                            Character.Barter = +10;
                        }
                        else
                        {
                            Character.Barter = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Big Guns - Bobblehead" && Character.BigGuns < 100)
                    {
                        if (Character.BigGuns < 90)
                        {
                            Character.BigGuns = +10;
                        }
                        else
                        {
                            Character.BigGuns = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Energy Weapons - Bobblehead" && Character.EnergyWeapons < 100)
                    {
                        if (Character.EnergyWeapons < 90)
                        {
                            Character.EnergyWeapons = +10;
                        }
                        else
                        {
                            Character.EnergyWeapons = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Explosives - Bobblehead" && Character.Explosives < 100)
                    {
                        if (Character.Explosives < 90)
                        {
                            Character.Explosives = +10;
                        }
                        else
                        {
                            Character.Explosives = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Lockpick - Bobblehead" && Character.Lockpick < 100)
                    {
                        if (Character.Lockpick < 90)
                        {
                            Character.Lockpick = +10;
                        }
                        else
                        {
                            Character.Lockpick = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Medicine - Bobblehead" && Character.Medicine < 100)
                    {
                        if (Character.Medicine < 90)
                        {
                            Character.Medicine = +10;
                        }
                        else
                        {
                            Character.Medicine = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Melee Weapons - Bobblehead" && Character.MeleeWeapons < 100)
                    {
                        if (Character.MeleeWeapons < 90)
                        {
                            Character.MeleeWeapons = +10;
                        }
                        else
                        {
                            Character.MeleeWeapons = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Repair - Bobblehead" && Character.Repair < 100)
                    {
                        if (Character.Repair < 90)
                        {
                            Character.Repair = +10;
                        }
                        else
                        {
                            Character.Repair = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Science - Bobblehead" && Character.Science < 100)
                    {
                        if (Character.Science < 90)
                        {
                            Character.Science = +10;
                        }
                        else
                        {
                            Character.Science = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Small Guns - Bobblehead" && Character.SmallGuns < 100)
                    {
                        if (Character.SmallGuns < 90)
                        {
                            Character.SmallGuns = +10;
                        }
                        else
                        {
                            Character.SmallGuns = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Sneak - Bobblehead" && Character.Sneak < 100)
                    {
                        if (Character.Sneak < 90)
                        {
                            Character.Sneak = +10;
                        }
                        else
                        {
                            Character.Sneak = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Speech - Bobblehead" && Character.Speech < 100)
                    {
                        if (Character.Speech < 90)
                        {
                            Character.Speech = +10;
                        }
                        else
                        {
                            Character.Speech = 100;
                        }
                    }
                    if (bobblehead.BobbleheadName == "Unarmed - Bobblehead" && Character.Unarmed < 100)
                    {
                        if (Character.Unarmed < 90)
                        {
                            Character.Unarmed = +10;
                        }
                        else
                        {
                            Character.Unarmed = 100;
                        }
                    }
                }
                else {
                    continue;
                }
            }

            UpdateCharacterValues();

            LvlViewbox.Visibility = Visibility.Visible;
            BobbleheadsListViewbox.Visibility = Visibility.Collapsed;
        }

        private void CancelBobbleHeadSelection_Click(object sender, RoutedEventArgs e)
        {
            LvlViewbox.Visibility = Visibility.Visible;
            BobbleheadsListViewbox.Visibility = Visibility.Collapsed;
        }

        private void ExitCharPerks_Click(object sender, RoutedEventArgs e)
        {
            LvlViewbox.Visibility = Visibility.Visible;
            CharPerksViewbox.Visibility = Visibility.Collapsed;
        }

        private void CharPerksListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CharPerksListView.SelectedItem != null)
            {
                Fallout3Perks selectedCharPerk = (Fallout3Perks)CharPerksListView.SelectedItem;

                string PerkRankInfo = "Perk Rank: ";

                PerkRankInfo += $"{selectedCharPerk.CurrentPerkRank} / {selectedCharPerk.MaxPerkRank}\n \nPerk Description:";

                PerkRankInfoTextBlock.Text = PerkRankInfo;
            }
            PerkInfoTextBlock.Text = (CharPerksListView.SelectedItem as Fallout3Perks)?.PerkDescription;
        }

        private void ExtraPerkCancel_Click(object sender, RoutedEventArgs e)
        {
            LvlViewbox.Visibility = Visibility.Visible;
            ExtraPerksViewbox.Visibility = Visibility.Collapsed;
        }

        private void ExtraPerkListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ExtraPerksListView.SelectedItem != null)
            {
                ExtraFallout3Perks selectedExtraPerk = (ExtraFallout3Perks)ExtraPerksListView.SelectedItem;

                string ExtraPerkRequirementsString = "Requirement: \n";

                ExtraPerkRequirementsString += $"{selectedExtraPerk.ExtraPerkRequirements} \nPerk Description: \n";

                ExtraPerkReqTextBlock.Text = ExtraPerkRequirementsString;
            }
            ExtraPerkDescriptionTextBlock.Text = (ExtraPerksListView.SelectedItem as ExtraFallout3Perks)?.ExtraPerkDescription;
        }
    }
}
