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
        public static double GenerateFare(double kms, double timeInMinutes)
        {
            double totalCost = kms * 10 + timeInMinutes;
            if (totalCost > 5)
            {
                return totalCost;
            }
            else
            {
                return 5.0;
            }
        }

        /// <summary>
        /// Generates the fare for premium.
        /// </summary>
        /// <param name="kms">The KMS.</param>
        /// <param name="timeInMinutes">The time in minutes.</param>
        /// <returns></returns>
        public static double GenerateFareForPremium(double kms, double timeInMinutes)
        {
            double totalCost = kms * 15 + timeInMinutes*2;
            if (totalCost > 20)
            {
                return totalCost;
            }
            else
            {
                return 20.0;
            }
        }
        /// <summary>
        /// Generates the monthly fare.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static double GenerateMonthlyFare(List<CabRidesProperties> data)
        {
            double totalCost = 0;
            foreach (var item in data)
            {
                totalCost = totalCost + GenerateFare(item.Kms, item.TimeInMinutes);
            }
            return totalCost;
        }

        /// <summary>
        /// Calculates the total rides total fare average fare.
        /// </summary>
        /// <param name="totalData">The total data.</param>
        /// <returns></returns>
        public static List<EnhancedInvoiceProperties> CalculateTotalRides_TotalFare_AvgFare
            (Dictionary<int, List<CabRidesProperties>> totalData)
        {
            List<EnhancedInvoiceProperties> li = new List<EnhancedInvoiceProperties>();
            foreach (var item in totalData)
            {
                int count = 0;
                double totalCost = 0;
                foreach (var item1 in item.Value)
                {
                    totalCost = totalCost + GenerateFare(item1.Kms, item1.TimeInMinutes);
                    count++;
                }
                li.Add(new EnhancedInvoiceProperties(count, totalCost, (totalCost / count)));
            }
            return li;
        }

        /// <summary>
        /// Gets the ride history by user identifier.
        /// </summary>
        /// <param name="totalData">The total data.</param>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public static List<CabRidesProperties> GetRideHistoryByUserID
            (Dictionary<int, List<CabRidesProperties>> totalData, int id)
        {
            List<CabRidesProperties> li = new List<CabRidesProperties>();
            foreach (var item in totalData)
            {
                int count = 0;
                double totalCost = 0;
                if (item.Key == id)
                {
                    foreach (var item1 in item.Value)
                    {
                        //totalCost = totalCost + GenerateFare(item1.Kms, item1.TimeInMinutes);
                        li.Add(new CabRidesProperties(item1.Kms,item1.TimeInMinutes));
                        count++;
                    }
                }
            }
            return li;
        }

        /// <summary>
        /// Premiums the and normal ride fare.
        /// </summary>
        /// <param name="category">The category.</param>
        /// <param name="kms">The KMS.</param>
        /// <param name="timeInMinute">The time in minute.</param>
        /// <returns></returns>
        public static double PremiumAndNormalRideFare(int category,double kms,double timeInMinute)
        {
            double cost = 0;
            switch (category)
            {
                case 1:
                     cost= InviceGenerator.GenerateFare(kms, timeInMinute);
                    break;
                case 2:
                    cost = InviceGenerator.GenerateFareForPremium(kms, timeInMinute);
                    break;
                default:
                    break;
            }
            return cost;
        }
    }
}
