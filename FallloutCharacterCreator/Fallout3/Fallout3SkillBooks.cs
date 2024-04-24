using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallloutCharacterCreator.Fallout3
{
    public class Fallout3SkillBooks
    {
        public int ScienceBook {  get; set; }
        public int SneakBook { get; set; }
        public int MedicineBook { get; set; }
        public int RepairBook { get; set; }
        public int ExplosivesBook { get; set; }
        public int MeleeWeaponsBook { get; set; }
        public int SmallGunsBook { get; set; }
        public int SpeechBook { get; set; }
        public int EnergyWeaponsBook { get; set; }
        public int ParadiseLost { get; set; }
        public int UnarmedBook { get; set; }
        public int BarterBook { get; set; }
        public int LockpickBook { get; set; }
        public int BigGunsBook { get; set; }
        public Fallout3SkillBooks()
        {
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            ScienceBook = 0;
            SneakBook = 0;
            MedicineBook = 0;
            RepairBook = 0;
            ExplosivesBook = 0;
            MeleeWeaponsBook = 0;
            SmallGunsBook = 0;
            SpeechBook = 0;
            EnergyWeaponsBook = 0;
            ParadiseLost = 0;
            UnarmedBook = 0;
            BarterBook = 0;
            LockpickBook = 0;
            BigGunsBook = 0;
        }
    }
}
