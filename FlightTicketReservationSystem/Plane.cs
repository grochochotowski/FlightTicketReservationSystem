using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    abstract class Plane {
        protected string number;
        protected double width, length, maxDistance, speed;
        protected int numberOfSeats;
        public Plane(string number, double width, double length, double maxDistance, double speed, int numberOfSeats) {
            this.number = number;
            this.width = width;
            this.length = length;
            this.maxDistance = maxDistance;
            this.speed = speed;
            this.numberOfSeats = numberOfSeats;
        }
    }
    class LightJet: Plane {
        public LightJet(string number, double width, double length, double maxDistance, double speed, int numberOfSeats): base(number, width, length, maxDistance, speed, numberOfSeats) { }
    }
    class MidSizeJet: Plane {
        public MidSizeJet(string number, double width, double length, double maxDistance, double speed, int numberOfSeats): base(number, width, length, maxDistance, speed, numberOfSeats) { }
    }
    class JumboJet: Plane {
        public JumboJet(string number, double width, double length, double maxDistance, double speed, int numberOfSeats): base(number, width, length, maxDistance, speed, numberOfSeats) { }
    }
    class BussinessJet: Plane {
        public BussinessJet(string number, double width, double length, double maxDistance, double speed, int numberOfSeats): base(number, width, length, maxDistance, speed, numberOfSeats) { }
    }
}
