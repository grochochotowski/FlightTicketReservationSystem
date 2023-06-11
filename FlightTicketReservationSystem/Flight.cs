using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    internal class Flight {
        private Route route;
        private Plane plane;
        private string departureDate, arrivalDate, gateNumebr; // date format: DD/MM/YYY - Hr.Min.Sec
        private double duration;
        public Flight(Route route, Plane plane, string departureDate, string arrivalDate, string gateNumber, double douration) {
            this.route = route;
            this.plane = plane;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
            this.gateNumebr = gateNumber;
            this.duration = calculateDuration(departureDate, arrivalDate);
        }
        public double calculateDuration(string departureDateString, string arrivalDateString) {
            DateTime arrivalDate = DateTime.ParseExact(arrivalDateString, "dd/MM/yyyy - H.mm.ss", null);
            DateTime departureDate = DateTime.ParseExact(departureDateString, "dd/MM/yyyy - H.mm.ss", null);

            TimeSpan duration = arrivalDate - departureDate;

            double totalMinutes = duration.TotalMinutes;
            return totalMinutes;
        }
    }
}
