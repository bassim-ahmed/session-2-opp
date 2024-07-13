using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session.Inhertance
{
    internal class Parent
    {
    
        public int X { get; set; }
        public int Y { get; set; }
        public Parent(int x, int y)
        {
                X = x;
            Y = y;
        }
        //object member method [Non static Method]
        public int product()
        {
            return X*Y;
        }
        public virtual string ToString()
        {
            return $"({X},{Y})";
        }
        public Parent()
        {
            
        }


    }
}
