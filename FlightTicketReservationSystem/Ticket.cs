using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    internal class Ticket {
        protected string ticketId;
        protected double price;
        protected string seatNumber;
        protected Flight flight;
        protected int meals;
        protected bool Return;
        protected int commutationTicket;

       
        public Ticket(string tickedId, double price, string seatNumber, Flight flight, int measl, bool Return, int commutationTicket)
        {
            this.ticketId = tickedId;
            this.price = price;
            this.seatNumber = seatNumber;
            this.flight = flight;
            this.meals = measl;
            this.Return = Return;
            this.commutationTicket = commutationTicket;
        }


    }

    class Buissnes : Ticket
    {
        public Buissnes(string tickedId, double price, string seatNumber, Flight flight, int measl, bool Return, int commutationTicket) : base(tickedId, price, seatNumber, flight, measl, Return, commutationTicket)
        {
        }
    }

    class Economy : Ticket
    {
        public Economy(string tickedId, double price, string seatNumber, Flight flight, int measl, bool Return, int commutationTicket) : base(tickedId, price, seatNumber, flight, measl, Return, commutationTicket)
        {
        }
    }

    class First : Ticket
    {
        public First(string tickedId, double price, string seatNumber, Flight flight, int measl, bool Return, int commutationTicket) : base(tickedId, price, seatNumber, flight, measl, Return, commutationTicket)
        {
        }
    }
}
