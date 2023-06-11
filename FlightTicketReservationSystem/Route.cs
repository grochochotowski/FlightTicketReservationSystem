using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    class Route {
        private Airport departureAirport;
        private Airport arrivalAirport;
        private double distance;
        private Runway departureRunway;
        private Runway arrivalRunway;

        public Route(Airport departureAirport, Airport arrivalAirport, double distance, Runway departureRunway, Runway arrivalRunway)
        {
            this.departureAirport = departureAirport;
            this.arrivalAirport = arrivalAirport;
            this.distance = calculateDistance(departureAirport, arrivalAirport);
            this.departureRunway = departureRunway;
            this.arrivalRunway = arrivalRunway;
        }   

        public double calculateDistance(Airport departureAirport, Airport arrivalAirport) {
            int x1 = departureAirport.Cordinates.X;
            int y1 = departureAirport.Cordinates.Y;
            int x2 = arrivalAirport.Cordinates.X;
            int y2 = arrivalAirport.Cordinates.Y;

            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            return distance;
        }
    }
}
