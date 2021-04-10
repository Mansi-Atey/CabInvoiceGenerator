﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UC5_PremiumRides
{
   public class InvoiceSummary
    {
        private int numberOfRides;
        private double totalFare;
        private double averageFare;
        private string userId;
        /// <summary>
        /// Parameterized Constructor For Setting Data
        /// </summary>
        /// <param name="numberOfRides">numberOfRides</param>
        /// <param name="totalFare">totalFare</param>
        public InvoiceSummary(int numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOfRides;
        }

        public InvoiceSummary(int numberOfRides, double totalFare, double averageFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOfRides;
        }

        public InvoiceSummary(int numberOfRides, double totalFare, string useId)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            //this.userId = userId;
            this.averageFare = this.totalFare / this.numberOfRides;
        }
        /// <summary>
        /// Override Equls Method
        /// </summary>
        /// <param name="obj">obj</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;

            InvoiceSummary inputedObject = (InvoiceSummary)obj;
            return this.numberOfRides == inputedObject.numberOfRides && this.totalFare == inputedObject.totalFare && this.averageFare == inputedObject.averageFare;
        }

        /// <summary>
        /// Metho To Get Hash Code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode();
        }
    }
}
