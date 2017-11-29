using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowers2911
{
    enum sunlight_tol { light_loving, neutral, shade_loving };
    class flower
    {
        
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }//endof prop
        private sunlight_tol tol;
        public sunlight_tol Tol
        {
            get { return tol; }
            set { tol = value; }
        }
        private int waterNeed;
        public int WaterNeed
        {
            get { return waterNeed; }
            set { waterNeed = value; }
        }
        private int monthLastWatering;
        public int MonthLastWatering {
            get { return monthLastWatering; }
            set { monthLastWatering = value; }
        }
        private int dayLastWatering;
        public int DayLastWatering
        {
            get { return dayLastWatering; }
            set { dayLastWatering = value; }
        }
        private bool stinging;
        public bool Stinging
        {
            get { return stinging; }
            set { stinging = value; }
        }
        public flower (string type, int tolerance, int waterNeed, int monthLastWatering, int dayLastWateting, string sting)
        {
            this.type = type;
            switch (switch_on)
            {
                case 0:
            }
        }
        public string print()
        {
            return "Name of the flower : " + type + "\nSunlight tolerance : " + tol + "\nWater need : " + waterNeed + "\nMonth of last watering : " + monthLastWatering + "\nDay of last waterig : " + dayLastWatering + "\nDoes it sting ? " + stinging;
        }// end print
    }//endof class

}
