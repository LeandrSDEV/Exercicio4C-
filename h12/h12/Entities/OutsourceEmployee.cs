using System;
using System.Collections.Generic;

namespace h12.Entities
{
    internal class OutsourceEmployee : Employee
    {
        public double additionalCharge { get; set; }

        public OutsourceEmployee() { }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) :base(name, hours, valuePerHour)
        {
            this.additionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * additionalCharge;
        }
    }
}
