using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    public class Triangulo
    {
        public double l1;
        public double l2; 
        public double l3;

        public double Area(){

            double p = ( l1 + l2 + l3) / 2.0;
            return (Math.Sqrt(p * (p - l1)*(p -l2)*(p-l3)));
            
        }
    }
} 