﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    internal class System {
        private List<Client> clients = new List<Client>();
        private List<Route> routes = new List<Route>();
        private List<Airport> airports = new List<Airport>();
        private List<Plane> planes = new List<Plane>();

        public void addClient(Client client) { clients.Add(client); }

        public void removeClient(Client client) { clients.Remove(client); }

        public List<Client> getClient() { return clients; }



        public void addRoute(Route route) { routes.Add(route); }

        public void removeRoute(Route route) { routes.Remove(route); }

        public List<Route> getRoutes() { return routes; }



        public void addAirport(Airport airport) { airports.Add(airport); }

        public void removeAirport(Airport airport) { airports.Remove(airport); }

        public List<Airport> getAirports() { return airports; }



        public void addPlane(Plane plane) { planes.Add(plane); }

        public void removePlane(Plane plane) { planes.Remove(plane); }

        public List<Plane> getPlanes() { return planes; }

    }
}
