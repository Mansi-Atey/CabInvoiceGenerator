//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UC4_InvoiceService;

namespace InvoiceServiceTest
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

        /// <summary>
        /// Test Case For checking Fare function for multiple rides  summary.
        /// </summary>
        [Test]
        public void GivenMultipleRides_WhenUsingInvoiceSummaryClass_ShouldReturnInvoiceSummary()
        {
            //Creating Instance of InviceGenerator For Normal Ride.
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            //Generating Summary For Rides
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);

            //Asserting Values
            Assert.AreEqual(expectedSummary, summary);
        }

        /// <summary>
        /// Test Case to for enhanced Invoice
        /// </summary>
        [Test]
        public void GivenInvoiceGenerator_WhenUsingInvoiceSummary_ShouldReturnInvoiceSummaryWithAvgRides()
        {
            //Creating Instance of InviceGenerator For Normal Ride.
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            //Generating Summary For Rides
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0, 3);

            //Asserting Values
            Assert.AreEqual(expectedSummary, summary);
        }

        /// <summary>
        /// Test Case to for Invoice Service
        /// </summary>
        [Test]
        public void GivenUserId_WhenInvoivceService_ShouldReturnInvoice()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            invoiceGenerator.AddRides("1", rides);
            InvoiceSummary summary = invoiceGenerator.GetInvoiceSummary("1");
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0, "1");
            Assert.AreEqual(expectedSummary, summary);
        }
    }
}
