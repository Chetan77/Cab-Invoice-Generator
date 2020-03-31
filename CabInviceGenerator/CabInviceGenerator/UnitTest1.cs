using InviceGenaratorImpl;
using NUnit.Framework;
using System.Collections.Generic;

namespace CabInviceGenerator
{
    public class Tests
    {

        /// <summary>
        /// Given the distance and time invice generator should return total fare of journey.
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_InviceGenerator_ShouldReturnTotalFareOfJourney()
        {
            double cost = InviceGenerator.GenerateFare(1.8, 5);
            Assert.AreEqual(23, cost);
        }
        /// <summary>
        /// Givens the multiple data invice generator should return total cost.
        /// </summary>
        [Test]
        public void GivenMultipleData_inviceGeneratorShouldReturnTotalCost()
        {
            List<CabRidesProperties> list = new List<CabRidesProperties>()
           {
               new CabRidesProperties(2.3,8),
               new CabRidesProperties(0.3,2),
               new CabRidesProperties(8,21),
               new CabRidesProperties(20,35)
           };
            double cost = InviceGenerator.GenerateMonthlyFare(list);
            Assert.AreEqual(372, cost);
        }
    }
}