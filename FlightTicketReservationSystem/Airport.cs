using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {

    class Cordinates {
        int x;
        int y;

        public Cordinates(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public int X {
            get { return x; }
        }

        public int Y {
            get { return y; }
        }
    }
    abstract class Airport {

        protected string code;
        protected Cordinates cordinates;
        protected int NumberOfGates;
        protected List<Runway> runways;

        public Cordinates Cordinates {
            get { return cordinates; }
        }

        public void addRunway(Runway runway) {
            runways.Add(runway);
        }

        public void removeRunway(Runway runway) {
            runways.Remove(runway);
        }

        public List<Runway> GetRunways() {
            return runways;
        }

        public Airport(string code, Cordinates cordinates, int NumberOfGates, List<Runway> runways) {
            this.code = code;
            this.cordinates = cordinates;
            this.NumberOfGates = NumberOfGates;
            this.runways = runways;
        }
    }

    class Local : Airport {
        public Local(string code, Cordinates cordinates, int NumberOfGates, List<Runway> runways) : base(code, cordinates, NumberOfGates, runways) { }
    }

    class International : Airport {
        public International(string code, Cordinates cordinates, int NumberOfGates, List<Runway> runways) : base(code, cordinates, NumberOfGates, runways) { }
    }
}
