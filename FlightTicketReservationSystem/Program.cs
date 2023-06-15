using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    internal class Program {
        static void Main(string[] args) {

            System system;
            //Ticket reservation
            switch(choice) {
                case 1:

                    List<Airport> airports = system.getAirports();
                    //choosing departure airport
                    Airport departureAirport;
                    Console.WriteLine("Choose a departure Airport:");
                    int count = 1;
                    foreach (Airport airport in airports) {
                        Console.WriteLine($"{count}: {airport.Type} - {airport.Code}");
                        count++;
                    }
                    int departureChoice = Convert.ToInt32(Console.ReadLine());
                    departureAirport = airports[departureChoice];
                    Console.Clear();
                    //choosing arrival airport
                    Airport arrivalAirport;
                    Console.WriteLine("Choose a departure Airport:");
                    count = 1;
                    foreach (Airport airport in airports) {
                        Console.WriteLine($"{count}: {airport.Type} - {airport.Code}");
                        count++;
                    }
                    int arrivalChoice = Convert.ToInt32(Console.ReadLine());
                    arrivalAirport = airports[arrivalChoice];
                    Console.Clear();

                    //searching for route

                    Route selectedRoute;
                    List<Route> routes = system.getRoutes();
                    Route matchingRoute = routes.Find(route =>
                        route.departureAirport == departureAirport && route.arrivalAirport == arrivalAirport);
                    if (matchingRoute != null) {
                        selectedRoute = matchingRoute;
                    }
                    else {
                        system.addRoute(Airport departureAirport, Airport arrivalAirport);
                        selectedRoute = routes.Find(route =>
                            route.departureAirport == departureAirport && route.arrivalAirport == arrivalAirport);
                    }

                    //searching for flights
                    Console.WriteLine($"Flights from {departureChoice} to {arrivalChoice}\n=================================================");
                    Flight selectedFLight;
                    List<Flight> flights = system.getFlights();
                    List<Flight> foundFlights = flights.Find(flight =>
                        flight.route.departureAirport == departureChoice && flight.route.arrivalAirport == arrivalAirport);
                    if (foundFlights != null) {
                        Console.WriteLine($"Avaliable flights from {departureAirport} to {arrivalAirport}:\n=================================================");
                        int count = 1;
                        foreach (flight in foundFlights) {
                            Console.WriteLine($"{count}: {flight.departureDate} - {flight.arrivalDate} | {flight.duration}");
                            count++;
                        }
                    }
                    else {
                        Console.WriteLine($"We are sorry, there are not any flights from {departureChoice} to {arrivalChoice} at the moment.\n" +
                            $"  Would you like to sumbit, a flight request? [write \"yes\" to submit]");
                        string answer = Console.ReadLine();
                        if (answer != "yes") Console.WriteLine("Your request has been submited.");
                    }


                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
}
