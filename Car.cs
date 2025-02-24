//Written by Coltan Paul
//2/24/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace HomeWork_5
{
    internal class Car: Vehicle
    {
        //SubClass Variables
        public int NumberOfDoors { get; set; }
        //Constructors
        public Car()
        {

        }
        public Car(string aMake, string aModel, int aYear, int aNumberOfDoors):base(aMake,aModel,aYear)
        {
            this.NumberOfDoors = aNumberOfDoors;
        }
        //Methods
        public override string ToString()
        {
            return $"YearL {Year}\nMake: {Make}\nModel: {Model}\n with {NumberOfDoors} doors.";
        }

    }
}
