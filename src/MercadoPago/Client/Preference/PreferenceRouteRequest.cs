﻿namespace MercadoPago.Client.Preference
{
    using System;

    /// <summary>
    /// Flight information.
    /// </summary>
    public class PreferenceRouteRequest
    {
        /// <summary>
        /// Derpature.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Destination.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Departure date.
        /// </summary>
        public DateTime? DepartureDateTime { get; set; }

        /// <summary>
        /// Arrival date.
        /// </summary>
        public DateTime? ArrivalDateTime { get; set; }

        /// <summary>
        /// Company. 
        /// </summary>
        public string Company { get; set; }
    }
}
