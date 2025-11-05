using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPal.Animals;

namespace ZooPals.Animals
{
    internal class Bird : Animal{
        bool canFly;
        double wingSpan;
        public Bird(String name, int age, double weight, bool healthy, String habitat, bool canFly, double wingSpan) : base(name, age, weight, healthy, habitat)
    {
        public int EggsPerYear;
        public bool canFly;
        public double wingSpan;
}
