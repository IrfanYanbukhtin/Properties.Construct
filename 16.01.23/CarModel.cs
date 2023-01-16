using System;
using System.Collections.Generic;
using System.Text;

namespace _16._01._23
{
    internal class Car
    {
       
        public string Name { get; set; }
        
        public int MaxSpeed { get; set; }

        public int Year { get; set; }


        /////// <summary>
       public Car(string name, string model, int maxSpeed, int year)
        {
            Name = name;
            _model = model;
            MaxSpeed = maxSpeed;
            Year = year;
        }

        //////
        private string _model;

        public string Model
        {
            get => _model;
            set
            {
                Console.WriteLine("You assigned this model :" + value);
                _model = value;
            }
        }

        internal void Print()
        {
            Console.WriteLine($"{Name} {Year} {Model} {MaxSpeed}");
        }
    } 
       
}
