using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallloutCharacterCreator.Fallout3
{
    class Fallout3Bobbleheads
    {
        public string BobbleheadName { get; set; }
        
        public Boolean BobbleheadGotorNot {  get; set; }

        public string BobbleheadDescription {  get; set; }

        public Fallout3Bobbleheads() {
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            // Set default values for the properties
            BobbleheadName = "";
            BobbleheadGotorNot = false;
            BobbleheadDescription = "";
        }

        public static List<Fallout3Bobbleheads> AllBobbleheadsList = new List<Fallout3Bobbleheads>();

        public static void InitializeBobbleheadsList()
        {
            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Strength - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+1 Strength"
        });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Perception - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+1 Perception"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Endurance - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+1 Endurance"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Charisma - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+1 Charisma"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Intelligence - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+1 Intelligence"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Agility - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+1 Agility"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Luck - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+1 Luck"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Barter - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Barter"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Big Guns - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Big Guns"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Energy Weapons - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Energy Weapons"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Explosives - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Explosives"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Lockpick - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Lockpick"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Medicine - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Medicine"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Melee Weapons - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Melee Weapons"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Repair - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Repair"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Science - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Science"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Small Guns - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Small Guns"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Sneak - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Sneak"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Speech - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Speech"
            });

            AllBobbleheadsList.Add(new Fallout3Bobbleheads
            {
                BobbleheadName = "Unarmed - Bobblehead",
                BobbleheadGotorNot = false,
                BobbleheadDescription = "+10 Unarmed"
            });
        }
    }
}
