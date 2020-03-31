using InviceGenaratorImpl;
using NUnit.Framework;

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
    }
}