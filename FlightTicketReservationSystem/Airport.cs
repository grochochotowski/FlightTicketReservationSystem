using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    [Serializable]
    class Coordinates {
        int x;
        int y;

        public Coordinates(int x, int y) {
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
        protected Coordinates coordinates;

        public Coordinates Coordinates {
            get { return coordinates; }
        }

        public Airport(string code, Coordinates coordinates) {
            this.code = code;
            this.coordinates = coordinates;
        }

        public abstract string Type { get; }
        public string Code { get { return code; } }
    }
    [Serializable]
    class Local : Airport {
        public Local(string code, Coordinates coordinates) : base(code, coordinates) { }
        public override string Type { get { return "Local"; } }
    }
    [Serializable]
    class International : Airport {
        public International(string code, Coordinates coordinates) : base(code, coordinates) { }
        public override string Type { get { return "International"; } }
    }
}
