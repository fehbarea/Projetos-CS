using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercícioAula140.entities
{
    public class OutSourcedEmployee : Employee
    {
        public double AddicionalCharge{get; set;}

        public OutSourcedEmployee(){

        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double addicionalCharge)
            : base(name, hours, valuePerHour)
        {
            AddicionalCharge = addicionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddicionalCharge;
        }
    }
}