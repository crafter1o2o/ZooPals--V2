using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPals.Animal
{
    internal class Bird : Animal
    {
        bool canFly;
        double wingSpan;
        public int EggsPerYear;
        public Bird(String name, int age, double weight, bool healthy, String habitat, bool canFly, double wingSpan, int EggsPerYear)
        : base(name, age, weight, healthy, habitat)
        {
            this.canFly = canFly;
            this.wingSpan = wingSpan;
            this.EggsPerYear = EggsPerYear;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chirp!");
            return;
        }

        override public void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Can Fly: {canFly}, Wing Span: {wingSpan}, Eggs Per Year: {EggsPerYear}");

        }
    }
}
