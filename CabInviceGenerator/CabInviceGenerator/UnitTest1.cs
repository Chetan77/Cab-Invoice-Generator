using InviceGenaratorImpl;
using NUnit.Framework;
using System;
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

        /// <summary>
        /// Givens the multiple data invice generator should return rides fare and avrage fare.
        /// </summary>
        [Test]
        public void GivenMultipleData_InviceGeneratorShouldReturnRidesFareAndAvrageFare()
        {
            List<CabRidesProperties> list1 = new List<CabRidesProperties>()
            {
               new CabRidesProperties(3,10),
               new CabRidesProperties(0.3,2),
               new CabRidesProperties(10,30),
               new CabRidesProperties(20,35)
            };
            List<CabRidesProperties> list2 = new List<CabRidesProperties>()
            {
               new CabRidesProperties(2,5),
               new CabRidesProperties(6,9),
               new CabRidesProperties(3,30),
               new CabRidesProperties(36,60),
               new CabRidesProperties(12,29)
            };
            List<CabRidesProperties> list3 = new List<CabRidesProperties>()
            {
               new CabRidesProperties(5,9),
               new CabRidesProperties(15,24),
               new CabRidesProperties(8,35)
            };
            Dictionary<int, List<CabRidesProperties>> keyValuePairs = new Dictionary<int, List<CabRidesProperties>>();
            keyValuePairs.Add(1, list1);
            keyValuePairs.Add(2, list2);
            keyValuePairs.Add(3, list3);
            List<EnhancedInvoiceProperties> values = InviceGenerator.CalculateTotalRides_TotalFare_AvgFare(keyValuePairs);
            foreach (var item in values)
            {
                Assert.NotZero(item.TotalNumberRides);
                Assert.NotZero(item.TotalFare);
                Assert.NotZero(item.AverageFarePerRide);
            }
        }

        /// <summary>
        /// Givens the user identifier invoice generator should return the ride history invoice.
        /// </summary>
        [Test]
        public void GivenTheUserId_InvoiceGeneratorShouldReturnTheRideHistoryInvoice()
        {
            List<CabRidesProperties> list1 = new List<CabRidesProperties>()
            {
               new CabRidesProperties(3,10),
               new CabRidesProperties(0.3,2),
               new CabRidesProperties(10,30),
               new CabRidesProperties(20,35)
            };
            List<CabRidesProperties> list2 = new List<CabRidesProperties>()
            {
               new CabRidesProperties(2,5),
               new CabRidesProperties(6,9),
               new CabRidesProperties(3,30),
               new CabRidesProperties(36,60),
               new CabRidesProperties(12,29)
            };
            List<CabRidesProperties> list3 = new List<CabRidesProperties>()
            {
               new CabRidesProperties(5,9),
               new CabRidesProperties(15,24),
               new CabRidesProperties(8,35)
            };
            Dictionary<int, List<CabRidesProperties>> keyValuePairs = new Dictionary<int, List<CabRidesProperties>>();
            keyValuePairs.Add(1, list1);
            keyValuePairs.Add(2, list2);
            keyValuePairs.Add(3, list3);
            List<CabRidesProperties> values = InviceGenerator.GetRideHistoryByUserID(keyValuePairs, 3);
            Assert.NotZero(values.Capacity);
        }

        /// <summary>
        /// Selects the category find the fare.
        /// </summary>
        [Test]
        public void SelectTheCategory_FindThe_Fare()
        {
            //1 for normal category
            //2 for premium category
            double fare=InviceGenerator.PremiumAndNormalRideFare(2, 4.2, 10);
            Assert.AreEqual(83, fare);
        }
    }
}