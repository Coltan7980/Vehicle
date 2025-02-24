//Written by Coltan Paul
//2/24/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    internal class Vehicle
    {
        //Class Variables
        private string make = "n/a";
        private string model = "n/a";
        private int year = -1;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        //Constructors
        public Vehicle():this("n/a","n/a",-1)
        {

        }
        public Vehicle(string aMake, string aModel, int aYear)
        {
            this.Make = aMake;
            this.model = aModel;
            this.year = aYear;
        }
        //Methods
        public override string ToString()
        {
            string msg = $"Make: {Make} \nModel: {Model}\nYear: {Year}";
            return msg;
        }
    }
}
