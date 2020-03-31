using System;
using System.Collections.Generic;
using System.Text;

namespace InviceGenaratorImpl
{

    public class InviceGenerator
    {

        /// <summary>
        /// Generates the fare.
        /// </summary>
        /// <param name="kms">The KMS.</param>
        /// <param name="timeInMinutes">The time in minutes.</param>
        /// <returns></returns>
        public static double GenerateFare(double kms,double timeInMinutes)
        {
            double totalCost = kms * 10 + timeInMinutes;
            if (totalCost>5)
            {
                return totalCost;
            }
            else
            {
                return 5.0;
            }
        }
        public static double GenerateMonthlyFare(List<CabRidesProperties> data)
        {
            double totalCost = 0;
            foreach (var item in data)
            {
                totalCost = totalCost + GenerateFare(item.Kms, item.TimeInMinutes);
            }
            return totalCost;
        }
    }
}
