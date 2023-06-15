using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    [Serializable]
    internal class Flight {
        public Route route;
        private Plane plane;
        public string departureDate, arrivalDate, gateNumebr; // date format: DD/MM/YYY - Hr.Min.Sec
        public double duration;
        public Flight(Route route, Plane plane, string departureDate) {
            this.route = route;
            this.plane = plane;
            this.departureDate = departureDate;
            arrivalDate = calculateArrvialDate(departureDate, route.distance);
            gateNumebr = "A56";
            duration = calculateDuration(departureDate, arrivalDate);
        }
        public string calculateArrvialDate(string departureDateString, double distance) {
            DateTime departureDate = DateTime.ParseExact(departureDateString, "dd/MM/yyyy - H.mm.ss", null);
            double planeSpeed = plane.speed;
            double duration = distance / planeSpeed;
            //?????????????????
            DateTime arrivalDate = DateTime.ParseExact(departureDateString + duration, "dd/MM/yyyy - H.mm.ss", null);

            return arrivalDate.ToString();
        }
        public double calculateDuration(string departureDateString, string arrivalDateString) {
            DateTime departureDate = DateTime.ParseExact(departureDateString, "dd/MM/yyyy - H.mm.ss", null);
            DateTime arrivalDate = DateTime.ParseExact(arrivalDateString, "dd/MM/yyyy - H.mm.ss", null);

            TimeSpan duration = arrivalDate - departureDate;

            double totalMinutes = duration.TotalMinutes;
            return totalMinutes;
        }
        public string data { get { return $"{route.departureAirport} at {departureDate} to {route.arrivalAirport} at {arrivalDate} ({duration}) - {plane.number}"; } }
    }
}
