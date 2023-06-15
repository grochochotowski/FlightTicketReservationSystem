using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FlightTicketReservationSystem {

    public class Serializer {
        public void SaveState(object obj, string fileRoute) {
            using (FileStream file = new FileStream(fileRoute, FileMode.Create)) {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(file, obj);
            }
        }

        public Tstate ReadState<Tstate>(string fileRoute) {
            using (FileStream file = new FileStream(fileRoute, FileMode.Open)) {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Tstate)formatter.Deserialize(file);
            }
        }
    }

    [Serializable]
    internal class System {
        private List<Client> clients = new List<Client>();
        private List<Route> routes = new List<Route>();
        private List<Airport> airports = new List<Airport>();
        private List<Plane> planes = new List<Plane>();
        private List<Flight> flights = new List<Flight>();



        public void addClient(Client client) { clients.Add(client); }
        public void removeClient(Client client) { clients.Remove(client); }
        public List<Client> getClients() { return clients; }



        public void addRoute(Route route) { routes.Add(route); }
        public void removeRoute(Route route) { routes.Remove(route); }
        public List<Route> getRoutes() { return routes; }



        public void addAirport(Airport airport) { airports.Add(airport); }
        public void removeAirport(Airport airport) { airports.Remove(airport); }
        public List<Airport> getAirports() { return airports; }



        public void addPlane(Plane plane) { planes.Add(plane); }
        public void removePlane(Plane plane) { planes.Remove(plane); }
        public List<Plane> getPlanes() { return planes; }



        public void addFlight(Flight flight) { flights.Add(flight); }
        public void removeFlight(Flight flight) { flights.Remove(flight); }
        public List<Flight> getFlights() { return flights; }



        public void SaveState(string fileRoute) {
            Serializer serializer = new Serializer();
            serializer.SaveState(this, fileRoute);
        }

        public static System ReadState(string fileRoute) {
            Serializer serializer = new Serializer();
            return serializer.ReadState<System>(fileRoute);
        }

    }
}
