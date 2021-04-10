//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UC1_CalculateFare;

namespace CalculateFareTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class UnitTest1
    {
        //InvoiceGenerator Reference
        InvoiceGenerator invoiceGenerator = null;

        [Test]
        public void GivenDistanceAndTime_WhenCalculate_ShouldReturnTotalFare()
        {
            //Creating Instance of InvoiceGenerator for Normal Ride
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            //Calculate Fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            //Asserting Values
            Assert.AreEqual(expected, fare);
        }
    }
}
