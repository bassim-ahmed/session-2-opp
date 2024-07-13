using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session.Inhertance
{
    internal class Child : Parent
    {
        public int Z { get; set; }
        public Child( int x,int y, int z):base(x,y)  
            { 
            Z = z;
       
           }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }
        public new int product()//new version product method
        { return base.product()*Z; }

    }
}
