using System;
using System.Collections.Generic;
using System.Text;

namespace InviceGenaratorImpl
{
    public class CabRidesProperties
    {
        
        public CabRidesProperties(double kms,double timeInMinutes)
        {
            Kms = kms;
            TimeInMinutes = timeInMinutes;
        }

        public double Kms { get; }
        public double TimeInMinutes { get; }
    }
}
