//Written by Coltan Paul
//2/24/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    internal class Motorcycle : Vehicle
    {
        //SubClass Variables
        public bool HasSideCar { get; set; }
        //Constructors
        public Motorcycle()
        {

        }
        public Motorcycle(string aMake, string aModel, int aYear, bool aSideCar) : base(aMake, aModel, aYear)
        {
            this.HasSideCar = aSideCar;
        }
        //Methods
        public override string ToString()
        {
            return $"YearL {Year}\nMake: {Make}\nModel: {Model}\nHas Sidecar: {HasSideCar}";
        }

    }
}
