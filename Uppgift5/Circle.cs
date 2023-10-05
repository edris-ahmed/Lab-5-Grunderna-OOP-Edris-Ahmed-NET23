using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5
{
    public class Circle
    {
        public int radius {  get; set; }

        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
           
    }
}
