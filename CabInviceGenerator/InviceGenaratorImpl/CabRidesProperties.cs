using System;
using System.Collections.Generic;
using System.Text;

namespace InviceGenaratorImpl
{
    public class CabRidesProperties
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CabRidesProperties"/> class.
        /// </summary>
        /// <param name="kms">The KMS.</param>
        /// <param name="timeInMinutes">The time in minutes.</param>
        public CabRidesProperties(double kms,double timeInMinutes)
        {
            Kms = kms;
            TimeInMinutes = timeInMinutes;
        }

        /// <summary>
        /// Gets the KMS.
        /// </summary>
        /// <value>
        /// The KMS.
        /// </value>
        public double Kms { get; }

        /// <summary>
        /// Gets the time in minutes.
        /// </summary>
        /// <value>
        /// The time in minutes.
        /// </value>
        public double TimeInMinutes { get; }
    }

    public class EnhancedInvoiceProperties
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancedInvoiceProperties"/> class.
        /// </summary>
        /// <param name="totalNumberRides">The total number rides.</param>
        /// <param name="totalFare">The total fare.</param>
        /// <param name="averageFarePerRide">The average fare per ride.</param>
        public EnhancedInvoiceProperties(int totalNumberRides,double totalFare,double averageFarePerRide)
        {
            TotalNumberRides = totalNumberRides;
            TotalFare = totalFare;
            AverageFarePerRide = averageFarePerRide;
        }

        /// <summary>
        /// Gets the total number rides.
        /// </summary>
        /// <value>
        /// The total number rides.
        /// </value>
        public int TotalNumberRides { get; }

        /// <summary>
        /// Gets the total fare.
        /// </summary>
        /// <value>
        /// The total fare.
        /// </value>
        public double TotalFare { get; }

        /// <summary>
        /// Gets the average fare per ride.
        /// </summary>
        /// <value>
        /// The average fare per ride.
        /// </value>
        public double AverageFarePerRide { get; }
    }
}

