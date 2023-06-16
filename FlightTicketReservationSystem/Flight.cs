using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    //========================================================================================FLIGHT CLASS
    [Serializable]
    internal class Flight {
        public Route route;
        public Plane plane;
        public string departureDate, arrivalDate, gateNumebr; // date format: DD/MM/YYY - Hr.Min.Sec
        public double duration;
        public Flight(Route route, Plane plane, string departureDate) {
            this.route = route;
            this.plane = plane;
            this.departureDate = departureDate;
            arrivalDate = CalculateArrivalDate(departureDate, route.distance);
            gateNumebr = "A56";
            duration = CalculateDuration(departureDate, arrivalDate);
        }
        public string CalculateArrivalDate(string departureDateString, double distance) {
            try {
                DateTime departureDate = DateTime.ParseExact(departureDateString, "dd/MM/yyyy - H.mm.ss", null);

                if (plane != null) {
                    double planeSpeed = plane.speed;
                    double duration = distance / planeSpeed;

                    DateTime arrivalDate = departureDate.AddHours(duration);

                    return arrivalDate.ToString("dd/MM/yyyy - H.mm.ss");
                }
                else {
                    Console.WriteLine("An error occurred");
                    Console.ReadLine();
                }
            }
           
            catch (Exception ex) {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.ReadLine();
            }

            return string.Empty;
        }


        public double CalculateDuration(string departureDateString, string arrivalDateString) {
            try {
                DateTime departureDate = DateTime.ParseExact(departureDateString, "dd/MM/yyyy - H.mm.ss", null);
                DateTime arrivalDate = DateTime.ParseExact(arrivalDateString, "dd/MM/yyyy - H.mm.ss", null);

                TimeSpan duration = arrivalDate - departureDate;

                double totalMinutes = duration.TotalMinutes;
                return totalMinutes;
            }
            catch (FormatException) {
                Console.WriteLine("Unable to create flight");
                Console.ReadLine();
            }
            catch (Exception ex) {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.ReadLine();
            }

            return 0.0;
        }

        public string data { get { return $"{route.departureAirport.Code} at {departureDate} to {route.arrivalAirport.code} at {arrivalDate} ({duration}) - {plane.number}"; } }
    }
}
