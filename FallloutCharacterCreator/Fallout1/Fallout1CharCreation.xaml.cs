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
        public string TaggedSkillsText => $"{Character.TaggedSkills}/3";
        public Fallout1Character Character { get; set; }
        public List<Fallout1Character> characterSnapshots = new List<Fallout1Character>();
        public Fallout1CharCreation()
        {
            InitializeComponent();
            Character = new Fallout1Character();
            DataContext = this;
        }
    }
}
