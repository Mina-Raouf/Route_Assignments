using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public double Speed { get; set; } 

        //parameterles consturctor will be generated auto if there is no user defined costructor
        // if you define one no parameterless exist
        public Car(int id, string model, double speed)
        {
            Id = id;    
            Model = model;
            Speed = speed;
        }
        public Car(int id,string model):this(id,model,100) // Consturtor Chainning
        {
            // chainning executed first
        }
    }
}
