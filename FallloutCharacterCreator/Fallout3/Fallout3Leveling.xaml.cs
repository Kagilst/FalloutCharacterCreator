using System;
using System.Collections.Generic;
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
    public partial class Fallout3Leveling : Page
    {
        public Fallout3Character Character { get; set; }
        public string CharacterNameText => $"{Character.CharacterName}";
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

        public Fallout3Leveling()
        {
            InitializeComponent();
            
        }
    }
}
