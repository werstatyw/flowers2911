using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace flowers2911
{
    class flower_care
    {
        private string fileName { get; }
        private int monthOfToday { get; }
        private int dayOfToday { get; }
        private int numberFlowerts { get; }
        private flower[] f;
        public flower[] F
        {
            get { return f; }
        }

        public flower_care(string fileName, int monthOfToday, int dayOfToday)
        {
            this.fileName = fileName;
            this.monthOfToday = monthOfToday;
            this.dayOfToday = dayOfToday;

            StreamReader sr0 = new StreamReader(fileName);
            int lineCounter = 0;
            while (!sr0.EndOfStream)
            {
                lineCounter++;
            }
            sr0.Close();
            flower[] f = new flower[lineCounter];


            StreamReader sr = new StreamReader(fileName);

            int i = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] Line = line.Split(',');
                string type = Line[0];
                int tol = int.Parse(Line[1]);
                int waterNeed = int.Parse(Line[2]);
                int month = int.Parse(Line[3]);
                int day = int.Parse(Line[4]);
                string sting = Line[5];
                flower flower = new flower(type, tol, waterNeed, month, day, sting);
                f[i] = flower;
                i++;
            }
            sr.Close();
        }//flower_care end

        public string print(int num)
        {
            flower chosenFlower = f[num];
            return chosenFlower.print();
        }

        public void addNewFlower()
        {
            Array.Resize(ref f, f.Length + 1);
            Console.WriteLine("Type in the properties of the new flower");
            Console.Write("Name of the flower ?");
            string type = Console.ReadLine();
            Console.WriteLine("Sunlight tolerance : (0 - light loving, 1 - neutral ,2 - shade loving) ");
            int tol = int.Parse(Console.ReadLine());
            Console.WriteLine("Water need : ");
            int waterNeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Month of last watering : ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Day of last watering : ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Does the flower sting ? (Yes - 1, NO - 0)");
            string sting = Console.ReadLine();

            f[f.Length - 1] = new flower(type, tol, waterNeed, month, day, sting);

        }//ens of add new flower

        public void editFlower()
        {
            Console.WriteLine("Which flower do you want to edit ? ");
            string type = Console.ReadLine();
            bool sureEdit = false;
            int i;
            for (i = 0; i < f.Length; i++)
            {
                if (type == f[i].Type)
                {
                    f[i].print();
                    Console.WriteLine("Are you sure you want to edit the item ? (Y/N) ");
                    string userChoice = Console.ReadLine().ToLower();
                    if (userChoice == "y")
                    {
                        sureEdit = true;
                    }
                }
                else
                {
                    Console.WriteLine("There is no such flower ");
                }
            }

            while (sureEdit)
            {
                Console.WriteLine("Type in the properties of the new flower");
                Console.Write("Name of the flower ?");
                f[i].Type = Console.ReadLine();
                Console.WriteLine("Sunlight tolerance : (0 - light loving, 1 - neutral ,2 - shade loving) ");
                int anwser = int.Parse(Console.ReadLine());
                switch (anwser)
                {
                    case 0:
                        f[i].Tol = sunlight_tol.ligh_loving;
                        break;
                    case 1:
                        f[i].Tol = sunlight_tol.neutral;
                        break;
                    case 2:
                        f[i].Tol = sunlight_tol.shade_loving;
                        break;
                    default:
                        break;
                }//end switch                
                Console.WriteLine("Water need : ");
                f[i].WaterNeed = int.Parse(Console.ReadLine());
                Console.WriteLine("Month of last watering : ");
                f[i].MonthLastWatering = int.Parse(Console.ReadLine());
                Console.WriteLine("Day of last watering : ");
                f[i].DayLastWatering = int.Parse(Console.ReadLine());
                Console.WriteLine("Does the flower sting ? (Yes - 1, NO - 0)");
                int anw = int.Parse(Console.ReadLine());
                if (anw == 1)
                {
                    f[i].Stinging = true;
                }
                else
                {
                    f[i].Stinging = false;
                }
            }
        }//ens of editflower

        public void removeFlower()
        {
            Console.WriteLine("Which flower do you want to remove ? (number of the flower starting with 0) ");
            int anwser = int.Parse(Console.ReadLine());


        }

    }
}
