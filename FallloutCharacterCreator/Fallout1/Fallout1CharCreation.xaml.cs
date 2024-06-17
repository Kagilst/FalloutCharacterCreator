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

namespace FallloutCharacterCreator.Fallout1
{
    /// <summary>
    /// Interaction logic for Fallout1CharCreation.xaml
    /// </summary>
    public partial class Fallout1CharCreation : Page//, INotifyPropertyChanged
    {
        
        public Fallout1Character Character { get; set; }
        public List<Fallout1Character> characterSnapshots = new List<Fallout1Character>();
        
        //Bound Strings for SPECIAL Values
        public string StrengthText => $"{Character.Strength}";
        public string PerceptionText => $"{Character.Perception}";
        public string EnduranceText => $"{Character.Endurance}";
        public string CharismaText => $"{Character.Charisma}";
        public string IntelligenceText => $"{Character.Intelligence}";
        public string AgilityText => $"{Character.Agility}";
        public string LuckText => $"{Character.Luck}";
        public string SpecialPointsText => $"{Character.SpecialPoints}";

        //Bound Strings for Skill values
        public string SmallGunsText => $"{Character.SmallGuns}%";
        public string BigGunsText => $"{Character.BigGuns}%";
        public string EnergyWeaponsText => $"{Character.EnergyWeapons}%";
        public string UnarmedText => $"{Character.Unarmed}%";
        public string MeleeWeaponsText => $"{Character.MeleeWeapons}%";
        public string ThrowingText => $"{Character.Throwing}%";
        public string FirstAidText => $"{Character.FirstAid}%";
        public string DoctorText => $"{Character.Doctor}%";
        public string SneakText => $"{Character.Sneak}%";
        public string LockpickText => $"{Character.Lockpick}%";
        public string StealText => $"{Character.Steal}%";
        public string TrapsText => $"{Character.Traps}%";
        public string ScienceText => $"{Character.Science}%";
        public string RepairText => $"{Character.Repair}%";
        public string SpeechText => $"{Character.Speech}%";
        public string BarterText => $"{Character.Barter}%";
        public string GamblingText => $"{Character.Gambling}%";
        public string OutdoorsmanText => $"{Character.Outdoorsman}%";
        public string TaggedSkillsText => $"{Character.TaggedSkills}/3";


        //HitPoints = this.HitPoints,
        //Level = this.Level,
        //ArmorClass = this.ArmorClass,
        //ActionPoints = this.ActionPoints,
        //CarryWeight = this.CarryWeight,
        //MeleeDamage = this.MeleeDamage,
        //DamageRes = this.DamageRes,
        //PoisonRes = this.PoisonRes,
        //RadiationRes = this.RadiationRes,
        //Sequence = this.Sequence,
        //HealingRate = this.HealingRate,
        //CriticalChance = this.CriticalChance,
        //SkillPoints = this.SkillPoints,

        public Fallout1CharCreation()
        {
            InitializeComponent();
            Character = new Fallout1Character();
            DataContext = this;
        }
    }
}
