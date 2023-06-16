using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    //========================================================================================TICKET CLASS
    [Serializable]
    internal abstract class Ticket {
        protected double price;
        protected int seatNumber;
        protected Flight flight;
        protected int commutationTicket;


        public Ticket(Flight flight, int commutationTicket) {
            price = CalculatePrice(flight, commutationTicket);
            seatNumber = SetSeatNumber(flight);
            this.flight = flight;
            this.commutationTicket = commutationTicket;
        }
        public double CalculatePrice(Flight flight, int commucation) {
            double price;
            if (commucation == 0) {
                price = flight.route.distance * 0.01;
            }
            else {
                price = commucation * 50;
            }
        return price;
        }
        public int SetSeatNumber(Flight flight) {
            int seatNumber;
            if (flight == null) {
                seatNumber = 0;
            }
            else {
                int maxSeats = flight.plane.numberOfSeats;
                Random random = new Random();
                seatNumber = random.Next(1, maxSeats + 1);
            }

            return seatNumber;
        }

        public abstract string ticketData { get; }
    }
    //========================================================================================TICKET SUBCLASSES
    [Serializable]
    class Bussines : Ticket {
        public Bussines(Flight flight, int commutationTicket) : base(flight, commutationTicket) { }
        public override string ticketData {
            get {
                if (commutationTicket > 0) {
                    return $"Bussines commucation ticket for: {commutationTicket}";
                }
                else {
                    return $"Bussines ticket from {flight.route.departureAirport.Code} to {flight.route.arrivalAirport.Code}";
                }
            }
        }
    }
    [Serializable]
    class Economy : Ticket {
        public Economy(Flight flight, int commutationTicket) : base(flight, commutationTicket) { }
        public override string ticketData {
            get {
                if (commutationTicket > 0) {
                    return $"Economy commucation ticket for: {commutationTicket}";
                }
                else {
                    return $"Economy ticket from {flight.route.departureAirport.Code} to {flight.route.arrivalAirport.Code}";
                }
            }
        }
    }
    [Serializable]
    class First : Ticket {
        public First(Flight flight, int commutationTicket) : base(flight, commutationTicket) { }
        public override string ticketData {
            get {
                if (commutationTicket > 0) {
                    return $"First class commucation ticket for: {commutationTicket}";
                }
                else {
                    return $"First class ticket from {flight.route.departureAirport.Code} to {flight.route.arrivalAirport.Code}";
                }
            }
        }
    }
}
