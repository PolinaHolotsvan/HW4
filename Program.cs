using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._2
{
    interface IGeoObject
    {
        double X { get; set; }
        double Y { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        public void getInfo();
    }
    class River : IGeoObject
    {
        public double Speed { get; set; }
        public double TotalLength { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public River(double xTemp, double yTemp, string descriptionTemp, string nameTemp, double speedTemp, double totalLengthTemp)
        {
            X = xTemp;
            Y = yTemp;
            Description = descriptionTemp;
            Name = nameTemp;
            Speed = speedTemp;
            TotalLength = totalLengthTemp;
        }
        public void getInfo()
        {
            Console.WriteLine($"Info about {Name}{Environment.NewLine}x={X}; y={Y}; description={Description}; name={Name}; total length={TotalLength} km; speed={Speed} km/s");
        }
    }

    class Mountain : IGeoObject
    {
        public string HighestPeak { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Mountain(double xTemp, double yTemp, string descriptionTemp, string nameTemp, string highestPeakTemp)
        {
            X = xTemp;
            Y = yTemp;
            Description = descriptionTemp;
            Name = nameTemp;
            HighestPeak = highestPeakTemp;
        }
        public void getInfo()
        {
            Console.WriteLine($"Info about {Name}{Environment.NewLine}x={X}; y={Y}; description={Description}; name={Name}; highest peak={HighestPeak}");
        }
    }
    class Program

    {
        static void Main(string[] args)
        {
            Mountain mountain = new Mountain(35.880981, 76.508102, "It's very beautiful!", "K2", "Dhaulagiri I");
            River river = new River(48.450001, 34.983334, "It`s beautiful!", "Dnipro", 2, 2.201);
            river.getInfo();
            mountain.getInfo();


        }

    }
}
