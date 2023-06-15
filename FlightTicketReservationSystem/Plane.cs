using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    //========================================================================================PLANE CLASS
    [Serializable]
    abstract class Plane {
        public string number;
        protected double width, length, maxDistance;
        public double speed;
        protected int numberOfSeats;
        public Plane(string number, double width, double length, double maxDistance, double speed, int numberOfSeats) {
            this.number = number;
            this.width = width;
            this.length = length;
            this.maxDistance = maxDistance;
            this.speed = speed;
            this.numberOfSeats = numberOfSeats;
        }
        public abstract string data { get; }
    }
    //========================================================================================PLANE SUBCLASSES
    [Serializable]
    class LightJet: Plane {
        public LightJet(string number, double width, double length, double maxDistance, double speed, int numberOfSeats): base(number, width, length, maxDistance, speed, numberOfSeats) { }
        public override string data { get { return $"Light Jet - {number}"; } }
    }
    [Serializable]
    class MidSizeJet: Plane {
        public MidSizeJet(string number, double width, double length, double maxDistance, double speed, int numberOfSeats): base(number, width, length, maxDistance, speed, numberOfSeats) { }
        public override string data { get { return $"Light Jet - {number}"; } }
    }
    [Serializable]
    class JumboJet: Plane {
        public JumboJet(string number, double width, double length, double maxDistance, double speed, int numberOfSeats): base(number, width, length, maxDistance, speed, numberOfSeats) { }
        public override string data { get { return $"Jumbo Jet - {number}"; } }
    }
    [Serializable]
    class BussinessJet: Plane {
        public BussinessJet(string number, double width, double length, double maxDistance, double speed, int numberOfSeats): base(number, width, length, maxDistance, speed, numberOfSeats) { }
        public override string data { get { return $"Bussiness Jet - {number}"; } }
    }
}
