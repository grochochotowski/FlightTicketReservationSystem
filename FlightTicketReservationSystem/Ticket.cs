using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    //========================================================================================TICKET CLASS
    [Serializable]
    internal abstract class Ticket {
        protected string ticketId;
        protected double price;
        protected string seatNumber;
        protected Flight flight;
        protected int meals;
        protected bool Return;
        protected int commutationTicket;


        public Ticket(string tickedId, double price, string seatNumber, Flight flight, int measl, bool Return, int commutationTicket) {
            this.ticketId = tickedId;
            this.price = price;
            this.seatNumber = seatNumber;
            this.flight = flight;
            this.meals = measl;
            this.Return = Return;
            this.commutationTicket = commutationTicket;
        }

        public abstract string ticketData { get; }
    }
    //========================================================================================TICKET SUBCLASSES
    [Serializable]
    class Buissnes : Ticket {
        public Buissnes(string ticketId, double price, string seatNumber, Flight flight, int meals, bool Return, int commutationTicket) : base(ticketId, price, seatNumber, flight, meals, Return, commutationTicket) { }
        public override string ticketData { get { return $"Bussines ticket {ticketId} - from {flight.route.departureAirport.Code} to {flight.route.arrivalAirport.Code}"; } }
    }
    [Serializable]
    class Economy : Ticket {
        public Economy(string ticketId, double price, string seatNumber, Flight flight, int meals, bool Return, int commutationTicket) : base(ticketId, price, seatNumber, flight, meals, Return, commutationTicket) { }
        public override string ticketData { get { return $"Economy ticket {ticketId} - from {flight.route.departureAirport.Code} to {flight.route.arrivalAirport.Code}"; } }
    }
    [Serializable]
    class First : Ticket {
        public First(string ticketId, double price, string seatNumber, Flight flight, int meals, bool Return, int commutationTicket) : base(ticketId, price, seatNumber, flight, meals, Return, commutationTicket) { }
        public override string ticketData { get { return $"First class ticket {ticketId} - from {flight.route.departureAirport.Code} to {flight.route.arrivalAirport.Code}"; } }
    }
}
