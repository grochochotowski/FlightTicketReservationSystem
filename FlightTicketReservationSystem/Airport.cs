using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    [Serializable]
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
    [Serializable]
    abstract class Airport {

        protected string code;
        protected Cordinates cordinates;

        public Cordinates Cordinates {
            get { return cordinates; }
        }

        public Airport(string code, Cordinates cordinates) {
            this.code = code;
            this.cordinates = cordinates;
        }

        public abstract string Type { get; }
        public string Code { get { return code; } }
    }
    [Serializable]
    class Local : Airport {
        public Local(string code, Cordinates cordinates) : base(code, cordinates) { }
        public override string Type { get { return "Local"; } }
    }
    [Serializable]
    class International : Airport {
        public International(string code, Cordinates cordinates) : base(code, cordinates) { }
        public override string Type { get { return "International"; } }
    }
}
