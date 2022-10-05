using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    interface IGeoObject
    {
        double x { get; set; }
        double y { get; set; }
        string name { get; set; }
        string description { get; set; }
        public void getInfo();
    }
    class River : IGeoObject
    {
        protected double speed { get; set; }
        protected double totalLength { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public void getInfo()
        {
            Console.WriteLine($"Speed = "+this.speed+"; lenght="+this.totalLength);
        }
    }

    class Mountain : IGeoObject
    {
        string highestPoint;
        public double x { get; set; }
        public double y { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public void getInfo()
        {
            Console.WriteLine("Highest point:"+this.highestPoint);
        }
    }
}
