using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session
{
    internal class Car
    {
  
        #region property
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        #endregion
        #region constructor
        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }
        //constructor chain
        public Car(int id,string model):this(id,model,190) 
        {
        }
        public Car (int id) : this(id, "audi", 190) { }
        #endregion


        public override string ToString()
        {
            return $"carid:{Id}\nModel:{Model}\nspeed{Speed}";
        }
    }
}
