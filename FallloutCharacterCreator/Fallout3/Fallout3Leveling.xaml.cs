using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
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
using FallloutCharacterCreator.Fallout3;

namespace FallloutCharacterCreator.Fallout3
{
    /// <summary>
    /// Interaction logic for Fallout3Leveling.xaml
    /// </summary>
    /// 
    //Todo: Add revert level button
    //Todo: Add clothing and armor(include button to show stats with and without armor? Make it so stats with armor can not be editted?)
    public partial class Fallout3Leveling : Page, INotifyPropertyChanged
    {
        public Fallout3Character GetLatestCharacter()
        {
            return characterSnapshots[characterSnapshots.Count - 1];
        }      

        public Fallout3SkillBooks BookValues { get; set; }

        private List<Fallout3Character> characterSnapshots;
        
        public Fallout3Character Character => GetLatestCharacter();
        public string CharacterNameText => $"{Character.CharacterName}'s Stat Sheet";
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

        public event PropertyChangedEventHandler PropertyChanged;

        // Method to notify property changed
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Skill value change functions
        private void DecreaseSkill_Click(object sender, RoutedEventArgs e) {

            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                // Get the skill name from the Tag property
                string skillName = clickedButton.Tag.ToString();
                int tempIntel;
                var lastSnapshot = characterSnapshots.Count - 2;
                if (hasEducatedPerk == true)
                {
                    tempIntel = Character.Intelligence + 3;
                }
                else {
                    tempIntel = Character.Intelligence;
                }

                    //Switch for decrease the skill
                    switch (skillName)
                    {
                        case "Barter":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].Barter < Character.Barter)
                            {
                                Character.SkillPoints++;
                                Character.Barter--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(BarterText));
                            break;
                        case "BigGuns":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].BigGuns < Character.BigGuns)
                            {
                                Character.SkillPoints++;
                                Character.BigGuns--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(BigGunsText));
                            break;
                        case "EnergyWeapons":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].EnergyWeapons < Character.EnergyWeapons)
                            {
                                Character.SkillPoints++;
                                Character.EnergyWeapons--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(EnergyWeaponsText));
                            break;
                        case "Explosives":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].Explosives < Character.Explosives)
                            {
                                Character.SkillPoints++;
                                Character.Explosives--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(ExplosivesText));
                            break;
                        case "Lockpick":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].Lockpick < Character.Lockpick)
                            {
                                Character.SkillPoints++;
                                Character.Lockpick--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(LockpickText));
                            break;
                        case "Medicine":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].Medicine < Character.Medicine)
                            {
                                Character.SkillPoints++;
                                Character.Medicine--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(MedicineText));
                            break;
                        case "MeleeWeapons":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].MeleeWeapons < Character.MeleeWeapons)
                            {
                                Character.SkillPoints++;
                                Character.MeleeWeapons--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(MeleeWeaponsText));
                            break;
                        case "Repair":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].Repair < Character.Repair)
                            {
                                Character.SkillPoints++;
                                Character.Repair--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(RepairText));
                            break;
                        case "Science":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].Science < Character.Science)
                            {
                                Character.SkillPoints++;
                                Character.Science--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(ScienceText));
                            break;
                        case "SmallGuns":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].SmallGuns < Character.SmallGuns)
                            {
                                Character.SkillPoints++;
                                Character.SmallGuns--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(SmallGunsText));
                            break;
                        case "Sneak":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].Sneak < Character.Sneak)
                            {
                                Character.SkillPoints++;
                                Character.Sneak--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(SneakText));
                            break;
                        case "Speech":
                        if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].Speech < Character.Speech)
                            {
                                Character.SkillPoints++;
                                Character.Speech--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(SpeechText));
                            break;
                        case "Unarmed":
                            if (Character.SkillPoints < tempIntel + 10 && characterSnapshots[lastSnapshot].Unarmed < Character.Unarmed)
                            {
                                Character.SkillPoints++;
                                Character.Unarmed--;
                            }
                            OnPropertyChanged(nameof(SkillPointsText));
                            OnPropertyChanged(nameof(UnarmedText));
                            break;

                }

            }
        }

        private void IncreaseSkill_Click(object sender, RoutedEventArgs e) {
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                // Get the skill name from the Tag property
                string skillName = clickedButton.Tag.ToString();
                var lastSnapshot = characterSnapshots.Count - 2;

                //Switch for increase skill
                switch (skillName)
                {
                    case "Barter":
                        if (Character.Barter < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.Barter++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(BarterText));
                        break;
                    case "BigGuns":
                        if (Character.BigGuns < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.BigGuns++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(BigGunsText));
                        break;
                    case "EnergyWeapons":
                        if (Character.EnergyWeapons < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.EnergyWeapons++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(EnergyWeaponsText));
                        break;
                    case "Explosives":
                        if (Character.Explosives < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.Explosives++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(ExplosivesText));
                        break;
                    case "Lockpick":
                        if (Character.Lockpick < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.Lockpick++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(LockpickText));
                        break;
                    case "Medicine":
                        if (Character.Medicine < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.Medicine++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(MedicineText));
                        break;
                    case "MeleeWeapons":
                        if (Character.MeleeWeapons < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.MeleeWeapons++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(MeleeWeaponsText));
                        break;
                    case "Repair":
                        if (Character.Repair < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.Repair++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(RepairText));
                        break;
                    case "Science":
                        if (Character.Science < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.Science++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(ScienceText));
                        break;
                    case "SmallGuns":
                        if (Character.SmallGuns < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.SmallGuns++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(SmallGunsText));
                        break;
                    case "Sneak":
                        if (Character.Sneak < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.Sneak++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(SneakText));
                        break;
                    case "Speech":
                        if (Character.Speech < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.Speech++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(SpeechText));
                        break;
                    case "Unarmed":
                        if (Character.Unarmed < 100 && Character.SkillPoints > 0)
                        {
                            Character.SkillPoints--;
                            Character.Unarmed++;
                        }
                        OnPropertyChanged(nameof(SkillPointsText));
                        OnPropertyChanged(nameof(UnarmedText));
                        break;

                }

            }

        }

        //Skillbook functionality
        private void SkillBooks_Click(object sender, RoutedEventArgs e)
        {
            LvlViewbox.Visibility = Visibility.Collapsed;
            SkillBooksViewbox.Visibility = Visibility.Visible;
        }

        private void BooksSave_Click(object sender, RoutedEventArgs e)
        {
            LvlViewbox.Visibility = Visibility.Visible;
            SkillBooksViewbox.Visibility = Visibility.Collapsed;
        } //Todo: Implement save functionality
        
        //LevelUp and Levelup perk selection functionality
        private void PerksListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (PerksListView.SelectedItem != null)
            {
                // Cast the selected item to Fallout3Perks
                Fallout3Perks selectedPerk = (Fallout3Perks)PerksListView.SelectedItem;
                if (selectedPerk.PerkName == "Intense Training")
                {
                    if (Character.Strength == 10) {
                        IntenseStrength.Foreground = Brushes.Gray;
                    }
                    if (Character.Perception == 10)
                    {
                        IntensePerception.Foreground = Brushes.Gray;
                    }
                    if (Character.Endurance == 10)
                    {
                        IntenseEndurance.Foreground = Brushes.Gray;
                    }
                    if (Character.Charisma == 10)
                    {
                        IntenseCharisma.Foreground = Brushes.Gray;
                    }
                    if (Character.Agility == 10)
                    {
                        IntenseAgility.Foreground = Brushes.Gray;
                    }
                    if (Character.Intelligence == 10)
                    {
                        IntenseIntelligence.Foreground = Brushes.Gray;
                    }
                    if (Character.Luck == 10)
                    {
                        IntenseLuck.Foreground = Brushes.Gray;
                    }
                    IntenseTrainingPerkGrid.Visibility = Visibility.Visible;
                }
                else {
                    IntenseTrainingPerkGrid.Visibility = Visibility.Collapsed;
                }
                if (selectedPerk.PerkName == "Tag!")
                {
                    if (Character.Barter == 100)
                    {
                        TagBarter.Foreground = Brushes.Gray;
                    }
                    if (Character.BigGuns == 100)
                    {
                        TagBigGuns.Foreground = Brushes.Gray;
                    }
                    if (Character.EnergyWeapons == 100)
                    {
                        TagEnergyWeapons.Foreground = Brushes.Gray;
                    }
                    if (Character.Explosives == 100)
                    {
                        TagExplosives.Foreground = Brushes.Gray;
                    }
                    if (Character.Lockpick == 100)
                    {
                        TagLockpick.Foreground = Brushes.Gray;
                    }
                    if (Character.Medicine == 100)
                    {
                        TagMedicine.Foreground = Brushes.Gray;
                    }
                    if (Character.MeleeWeapons == 100)
                    {
                        TagMeleeWeapons.Foreground = Brushes.Gray;
                    }
                    if (Character.Repair == 100)
                    {
                        TagRepair.Foreground = Brushes.Gray;
                    }
                    if (Character.Science == 100)
                    {
                        TagScience.Foreground = Brushes.Gray;
                    }
                    if (Character.SmallGuns == 100)
                    {
                        TagSmallGuns.Foreground = Brushes.Gray;
                    }
                    if (Character.Sneak == 100)
                    {
                        TagSneak.Foreground = Brushes.Gray;
                    }
                    if (Character.Speech == 100)
                    {
                        TagSpeech.Foreground = Brushes.Gray;
                    }
                    if (Character.Unarmed == 100)
                    {
                        TagUnarmed.Foreground = Brushes.Gray;
                    }
                    TagPerkGrid.Visibility = Visibility.Visible;
                }
                else
                {
                    TagPerkGrid.Visibility = Visibility.Collapsed;
                }

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
        private void CancelPerkSelection_Click(object sender, RoutedEventArgs e)
        {
            LvlViewbox.Visibility = Visibility.Visible;
            PerksListViewbox.Visibility = Visibility.Collapsed;
        }

        List<Fallout3Perks> characterPerks = new List<Fallout3Perks>();

        public bool hasEducatedPerk = false; 
        public bool hasComprehensionPerk = false;
        private void ConfirmPerkSelection_Click(object sender, RoutedEventArgs e)
        {
            Fallout3Perks selectedPerk = PerksListView.SelectedItem as Fallout3Perks;
            int perkIndex = 0;

            if (selectedPerk.AvaliableOrHave != 0)
            {

                for (int i = 0; i < Fallout3Perks.AllPerksList.Count; i++)
                {
                    if (Fallout3Perks.AllPerksList[i].PerkName == selectedPerk.PerkName)
                    {
                        perkIndex = i;
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
                    if (_selectedTextBlock == null) return;

                    switch (_selectedTextBlock.Text)
                    {
                        case "Strength":
                            if (Character.Strength < 10)
                            {
                                Character.Strength++;
                                break;
                            }
                            else {
                                
                                MessageBox.Show($"{_selectedTextBlock.Text} already max!");
                                return;
                            }
                        case "Perception":
                            if (Character.Perception < 10)
                            {
                                Character.Perception++;
                                break;
                            }
                            else {
                                
                                MessageBox.Show($"{_selectedTextBlock.Text} already max!");
                                return;
                            }
                        case "Endurance":
                            if (Character.Endurance < 10)
                            {
                                Character.Endurance++;
                                break;
                            }
                            else {
                                
                                MessageBox.Show($"{_selectedTextBlock.Text} already max!");
                                return;
                            }
                        case "Charisma":
                            if (Character.Charisma < 10)
                            {
                                Character.Charisma++;
                                break;
                            }
                            else {
                               
                                MessageBox.Show($"{_selectedTextBlock.Text} already max!");
                                return;
                            }
                            
                        case "Agility":
                            if (Character.Agility < 10)
                            {
                                Character.Agility++;
                                break;
                            }
                            else
                            {
                                
                                MessageBox.Show($"{_selectedTextBlock.Text} already max!");
                                return;
                            }
                        case "Intelligence":
                            if (Character.Intelligence < 10)
                            {
                                Character.Intelligence++;
                                break;
                            }
                            else {
                                
                                MessageBox.Show($"{_selectedTextBlock.Text} already max!");
                                return;
                            }
                        case "Luck":
                            if (Character.Luck < 10)
                            {
                                Character.Luck++;
                                break;
                            }
                            else {
                                
                                MessageBox.Show($"{_selectedTextBlock.Text} already max!");
                                return;
                            }
                        default:
                            break;
                    }
                }

                    if (selectedPerk.PerkName == "Comprehension")
                    {
                        hasComprehensionPerk = true;
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

                    if (selectedPerk.PerkName == "Tag") //Todo: Finish all cases
                    {
                    if (_tagSelectedTextBlock == null) return;

                    switch (_tagSelectedTextBlock.Text)
                    {
                        case "Barter":
                            if (Character.Barter < 100)
                            {
                                if (Character.Barter >= 85)
                                {
                                    Character.Barter = 100;
                                }
                                else
                                {
                                    Character.Barter += 15;
                                }
                                break;
                            }
                            else
                            {
                                MessageBox.Show($"{_selectedTextBlock.Text} already max!");
                                return;
                            }
                        
                        default:
                            break;
                    }
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

                if (selectedPerk.CurrentPerkRank == 0)
                {
                    characterPerks.Add(selectedPerk);
                }

                    Fallout3Perks.AllPerksList[perkIndex].CurrentPerkRank++;


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

            if (Character.SkillPoints == 0 && Character.Level < 30) {

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


        //Bobblehead Functionality
        private void Bobbleheads_Click(object sender, RoutedEventArgs e) //Todo: Still Working on functionality
        {
            BobbleheadsListView.ItemsSource = null;
            BobbleheadsListView.ItemsSource = Fallout3Bobbleheads.AllBobbleheadsList;
            LvlViewbox.Visibility = Visibility.Collapsed;
            BobbleheadsListViewbox.Visibility = Visibility.Visible;
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
                else
                {
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

        //Character Perks Functionality
        List<CombinedPerk3> combinedPerks = new List<CombinedPerk3>();
        private void CharacterPerks_Click(object sender, RoutedEventArgs e)
        {
            combinedPerks.Clear();//Todo: maybe update to make more effecient using hashset or another way
            foreach (var perk in characterPerks)
            {
                combinedPerks.Add(new CombinedPerk3
                {
                    PerkName = perk.PerkName,
                    PerkDescription = perk.PerkDescription,
                    Rank = perk.CurrentPerkRank,
                    MaxRank = perk.MaxPerkRank
                });
            }

            foreach (var extraPerk in extraCharacterPerks)
            {
                combinedPerks.Add(new CombinedPerk3
                {
                    PerkName = extraPerk.ExtraPerkName,
                    PerkDescription = extraPerk.ExtraPerkDescription,
                    Rank = 1,
                    MaxRank = 1
                });
            }

            LvlViewbox.Visibility = Visibility.Collapsed;
            PerkRankInfoTextBlock.Text = string.Empty;
            CharPerksListView.ItemsSource = null;
            CharPerksListView.ItemsSource = combinedPerks;
            CharPerksViewbox.Visibility = Visibility.Visible;
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
                CombinedPerk3 selectedCharPerk = (CombinedPerk3)CharPerksListView.SelectedItem;

                string PerkRankInfo = "Perk Rank: ";

                PerkRankInfo += $"{selectedCharPerk.Rank} / {selectedCharPerk.MaxRank}\n \nPerk Description:";

                PerkRankInfoTextBlock.Text = PerkRankInfo;
            }
            PerkInfoTextBlock.Text = (CharPerksListView.SelectedItem as CombinedPerk3)?.PerkDescription;
        }

        //Extra Perks functionality
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

                string ExtraPerkRequirementsString = "Requirement:\n";

                ExtraPerkRequirementsString += $"{selectedExtraPerk.ExtraPerkRequirements}\n\nPerk Description:";

                ExtraPerkReqTextBlock.Text = ExtraPerkRequirementsString;
            }
            ExtraPerkDescriptionTextBlock.Text = (ExtraPerksListView.SelectedItem as ExtraFallout3Perks)?.ExtraPerkDescription;
        }

        List<ExtraFallout3Perks> extraCharacterPerks = new List<ExtraFallout3Perks>();
        private void ExtraPerkConfirm_Click(object sender, RoutedEventArgs e)
        {
            ExtraFallout3Perks selectedPerk = ExtraPerksListView.SelectedItem as ExtraFallout3Perks;

            if (selectedPerk.ExtraPerkHave != true)
            {
                extraCharacterPerks.Add(selectedPerk);
                selectedPerk.ExtraPerkHave = true;
                if (selectedPerk.ExtraPerkName == "Dream Crusher") {
                    ExtraFallout3Perks.AllExtraPerksList[7].ExtraPerkHave = true;
                }
                if (selectedPerk.ExtraPerkName == "Ant Might")
                {
                    Character.Strength++;
                }
                if (selectedPerk.ExtraPerkName == "Ant Sight")
                {
                    Character.Perception++;
                }
                if (selectedPerk.ExtraPerkName == "Barkskin")
                {
                    Character.DamageResistance += 5;
                }
                if (selectedPerk.ExtraPerkName == "Survival Junior/Expert/Guru")
                {
                    //Todo: add new frame which allows user to choose rank and type
                }
                if (selectedPerk.ExtraPerkName == "Covert Ops")
                {
                    Character.Science += 3;
                    Character.SmallGuns += 3;
                    Character.Lockpick += 3;
                }
                if (selectedPerk.ExtraPerkName == "Booster Shot")
                {
                    //Todo: add new feature that shows radiation resistance
                }
                if (selectedPerk.ExtraPerkName == "Pitt Fighter")
                {
                    Character.DamageResistance += 3;
                    //Todo: add radiation resistance increase
                }
                if (selectedPerk.ExtraPerkName == "Superior Defender")
                {
                    //Todo: decide whether or not to add increase to DR even tho it only applies when Standing Still(maybe have frame that tells the user it doesnt apply changes to DR since it only applies when standing still)
                }
                LvlViewbox.Visibility = Visibility.Visible;
                ExtraPerksViewbox.Visibility = Visibility.Collapsed;
            }
            else {
                MessageBox.Show("The Perk you choose you either already have or cannot obtain.\n",
                    "Warning",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
        private void ExtraPerks_Click(object sender, RoutedEventArgs e)
        {
            ExtraPerksListView.ItemsSource = null;
            ExtraPerkReqTextBlock.Text = string.Empty;
            LvlViewbox.Visibility = Visibility.Collapsed;
            ExtraPerksListView.ItemsSource = ExtraFallout3Perks.AllExtraPerksList;
            ExtraPerksViewbox.Visibility = Visibility.Visible;
        }

        private TextBlock _selectedTextBlock;
        private void IntenseListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IntenseListView.SelectedItem is ListViewItem selectedItem)
            {
                var stackPanel = selectedItem.Content as StackPanel;
                if (stackPanel != null)
                {
                    _selectedTextBlock = stackPanel.Children[0] as TextBlock;
                }
            }
        }
        private TextBlock _tagSelectedTextBlock;
        private void TagListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TagListView.SelectedItem is ListViewItem selectedItem)
            {
                var stackPanel = selectedItem.Content as StackPanel;
                if (stackPanel != null)
                {
                    _tagSelectedTextBlock = stackPanel.Children[0] as TextBlock;
                }

            }
        }
}
