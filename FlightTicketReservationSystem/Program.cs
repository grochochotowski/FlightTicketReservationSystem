using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketReservationSystem {
    internal class Program {
        public void WeAreSorry(string departureChoice, string arrivalChoice) {
            Console.WriteLine($"We are sorry, there are not any flights from {departureChoice} to {arrivalChoice}" +
                $"at the moment.\nWould you like to submit a flight request? [write \"yes\" to submit]");
            string answer = Console.ReadLine();
            if (answer == "yes") Console.WriteLine("Your request has been submitted.");
        }
        static void Main(string[] args) {
            System system = new System();
            List<Airport> airports = system.getAirports();
            List<Plane> planes = system.getPlanes();
            List<Route> routes = system.getRoutes();
            List<Flight> flights = system.getFlights();


            Console.WriteLine("Choose who you are:");
            Console.WriteLine("1) Admin");
            Console.WriteLine("2) Client");
            int accountType = Convert.ToInt32(Console.ReadLine());

            switch (accountType) {
                case 1:
                    Console.Clear();
                    Console.WriteLine("==================================ADMIN MENU==================================");
                    Console.WriteLine("1) Airports");
                    Console.WriteLine("2) Airplanes");
                    Console.WriteLine("3) Routes");
                    Console.WriteLine("4) Flights");

                    int adminOption = Convert.ToInt32(Console.ReadLine());

                    switch (adminOption) {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Airports");
                            Console.WriteLine("1 - go back");
                            Console.WriteLine("2 - add new airport");
                            Console.WriteLine("============================To delete a airport input its number============================");
                            int count = 3;
                            foreach (Airport airport in airports) {
                                Console.WriteLine($"{count}: {airport.Code} {airport.Type}");
                                count++;
                            }
                            int airportOption = Convert.ToInt32(Console.ReadLine());
                            switch (airportOption) {
                                case 1:
                                    //go back
                                    break;
                                case 2:
                                    Console.Clear();
                                    Airport newAirport = null;

                                    Console.WriteLine("Airport code:");
                                    string newAirportCode = Console.ReadLine();
                                    Console.WriteLine("Airport X coordinates:");
                                    int newAirportCordX = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Airport Y coordinates:");
                                    int newAirportCordY = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Type [1 - international / 2 - local]:");
                                    int newAirportType = Convert.ToInt32(Console.ReadLine());
                                    Cordinates cords = new Cordinates(newAirportCordX, newAirportCordY);
                                    if (newAirportType == 1) {
                                        newAirport = new International(newAirportCode, cords);
                                    }
                                    else if (newAirportType == 2) {
                                        newAirport = new Local(newAirportCode, cords);
                                    }
                                    system.addAirport(newAirport);
                                    break;
                                default:
                                    Airport airportToRemove = airports[airportOption - 1];
                                    system.removeAirport(airportToRemove);
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Planes");
                                    Console.WriteLine("1 - go back");
                                    Console.WriteLine("2 - add new plane");
                                    Console.WriteLine("============================To delete a plane input its number============================");
                                    count = 3;
                                    foreach (Plane plane in planes) {
                                        Console.WriteLine($"{count}: {plane.data}");
                                        count++;
                                    }
                                    int planeOption = Convert.ToInt32(Console.ReadLine());
                                    switch (planeOption) {
                                        case 1:
                                            //go back
                                            break;
                                        case 2:
                                            Console.Clear();
                                            Plane newPlane = null;

                                            Console.WriteLine("Plane number:");
                                            string newPlaneNumber = Console.ReadLine();
                                            Console.WriteLine("Plane width:");
                                            double newPlaneWidth = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Plane length:");
                                            double newPlaneLength = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Plane maximum travel distance:");
                                            double newPlaneMaxDistance = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Plane average speed:");
                                            double newPlaneSpeed = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Plane number of sitting places:");
                                            int newPlaneNumberOfSeats = Convert.ToInt32(Console.ReadLine());

                                            Console.WriteLine("Type [1 - Light Jet / 2 - Medium Size Jet / 3 - Jumbo Jet / 4 - Bussiness Jet]:");
                                            int newPlaneType = Convert.ToInt32(Console.ReadLine());
                                            if (newPlaneType == 1) {
                                                newPlane = new LightJet(newPlaneNumber, newPlaneWidth, newPlaneLength, newPlaneMaxDistance, newPlaneSpeed, newPlaneNumberOfSeats);
                                            }
                                            else if (newPlaneType == 2) {
                                                newPlane = new MidSizeJet(newPlaneNumber, newPlaneWidth, newPlaneLength, newPlaneMaxDistance, newPlaneSpeed, newPlaneNumberOfSeats);
                                            }
                                            else if (newPlaneType == 3) {
                                                newPlane = new JumboJet(newPlaneNumber, newPlaneWidth, newPlaneLength, newPlaneMaxDistance, newPlaneSpeed, newPlaneNumberOfSeats);
                                            }
                                            else if (newPlaneType == 4) {
                                                newPlane = new BussinessJet(newPlaneNumber, newPlaneWidth, newPlaneLength, newPlaneMaxDistance, newPlaneSpeed, newPlaneNumberOfSeats);
                                            }
                                            system.addPlane(newPlane);
                                            break;
                                        default:
                                            Plane planeToRemove = planes[planeOption - 1];
                                            system.removePlane(planeToRemove);
                                            break;
                                            break;

                                        case 3:
                                            Console.Clear();
                                            Console.WriteLine("Routes");
                                            Console.WriteLine("1 - go back");
                                            Console.WriteLine("2 - create new route");
                                            Console.WriteLine("============================To delete a route input its number============================");
                                            count = 3;
                                            foreach (Route route in routes) {
                                                Console.WriteLine($"{count}: {route.data}");
                                                count++;
                                            }

                                            int routeOption = Convert.ToInt32(Console.ReadLine());
                                            switch (routeOption) {
                                                case 1:
                                                    //go back
                                                    break;
                                                case 2:
                                                    Route newRoute = null;

                                                    Console.WriteLine("Departure airport:");
                                                    string newDepartureAirportString = Console.ReadLine();
                                                    Airport newDepartureAirport = airports.Find(airport => airport.Code == newDepartureAirportString);
                                                    Console.WriteLine("Arrival airport:");
                                                    string newArrivalAirportString = Console.ReadLine();
                                                    Airport newArrivalAirport = airports.Find(airport => airport.Code == newArrivalAirportString);

                                                    newRoute = new Route(newDepartureAirport, newArrivalAirport);
                                                    system.addRoute(newRoute);
                                                    break;
                                                default:
                                                    Route routeToRemove = routes[routeOption - 1];
                                                    system.removeRoute(routeToRemove);
                                                    break;
                                            }
                                            break;

                                        case 4:
                                            Console.Clear();
                                            Console.WriteLine("Flights");
                                            Console.WriteLine("1 - go back");
                                            Console.WriteLine("2 - add new flight");
                                            Console.WriteLine("============================To delete a flight input its number============================");
                                            count = 3;
                                            foreach (Flight flight in flights) {
                                                Console.WriteLine($"{count}: {flight.data}");
                                                count++;
                                            }

                                            int flightOption = Convert.ToInt32(Console.ReadLine());
                                            switch (flightOption) {
                                                case 1:
                                                    //go back
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    Flight newFlight = null;

                                                    Console.WriteLine("Route:");
                                                    count = 1;
                                                    foreach (Route route in routes) {
                                                        Console.WriteLine($"{count}: {route.data}");
                                                        count++;
                                                    }
                                                    int chosenRouteId = Convert.ToInt32(Console.ReadLine());
                                                    Route newFlightRoute = routes[chosenRouteId - 1];
                                                    Console.Clear();

                                                    Console.WriteLine("Plane:");
                                                    count = 1;
                                                    foreach (Plane plane in planes) {
                                                        Console.WriteLine($"{count}: {plane.data}");
                                                        count++;
                                                    }
                                                    int chosenPlaneId = Convert.ToInt32(Console.ReadLine());
                                                    Plane newFlightPlane = planes[chosenPlaneId - 1];
                                                    Console.Clear();

                                                    Console.WriteLine("Departure date [DD/MM/YYYY - Hrs:Min:Sec]:");
                                                    string newFlightDepartureDate = Console.ReadLine();

                                                    newFlight = new Flight(newFlightRoute, newFlightPlane, newFlightDepartureDate);
                                                    system.addFlight(newFlight);
                                                    break;
                                                default:
                                                    Flight flightToRemove = flights[flightOption - 1];
                                                    system.removeFlight(flightToRemove);
                                                    break;
                                                    break;

                                                case 2:
                                                    Client loggedInAccount;

                                                    List<Client> clients = system.getClients();
                                                    List<Client> people = clients.FindAll(client => client is Person);
                                                    List<Client> companies = clients.FindAll(client => client is Company);

                                                    Console.WriteLine("==================================CLIENT MENU==================================");
                                                    Console.WriteLine("1) Create a person account");
                                                    Console.WriteLine("2) Create a company account");
                                                    Console.WriteLine("3) Login as person:");
                                                    //Console.WriteLine("4) Login as company");
                                                    int clientOption = Convert.ToInt32(Console.ReadLine());
                                                    int maxClientListId = clients.Count;
                                                    switch (clientOption) {
                                                        case 1:
                                                            Console.Clear();
                                                            int newPersonId = clients[maxClientListId - 1].clientId + 1;
                                                            Console.WriteLine("First name: ");
                                                            string newPersonFirstName = Console.ReadLine();
                                                            Console.WriteLine("Second name: ");
                                                            string newPersonSecondName = Console.ReadLine();
                                                            Console.WriteLine("Last name: ");
                                                            string newPersonLastName = Console.ReadLine();
                                                            Console.WriteLine("Age: ");
                                                            int newPersonAge = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine("E-mail: ");
                                                            string newPersonEmail = Console.ReadLine();
                                                            Console.WriteLine("Phone number: ");
                                                            string newPersonPhoneNumber = Console.ReadLine();
                                                            List<Ticket> newPersonTickets = null;

                                                            Person newPerson = new Person(newPersonId, newPersonEmail, newPersonPhoneNumber, newPersonFirstName, newPersonSecondName, newPersonLastName, newPersonAge, newPersonTickets);
                                                            loggedInAccount = newPerson;
                                                            break;
                                                        case 2:
                                                            int newCompanyId = clients[maxClientListId - 1].clientId + 1;
                                                            Console.WriteLine("Company name: ");
                                                            string name = Console.ReadLine();
                                                            Console.WriteLine("KRS number: ");
                                                            string krs = Console.ReadLine();
                                                            Console.WriteLine("E-mail: ");
                                                            string email = Console.ReadLine();
                                                            Console.WriteLine("Phone number: ");
                                                            string phoneNumber = Console.ReadLine();
                                                            List<Ticket> newCompanyTickets = null;

                                                            Company company1 = new Company(newCompanyId, phoneNumber, email, name, krs, newCompanyTickets);
                                                            break;

                                                        case 3:
                                                            Console.Clear();
                                                            Console.WriteLine("============================Choose an account to log in============================");
                                                            count = 1;
                                                            foreach (Person client in clients) {
                                                                Console.WriteLine($"{count}: {client.clientData}");
                                                            }
                                                            int chosenAccount = Convert.ToInt32(Console.ReadLine());
                                                            loggedInAccount = clients[chosenAccount - 1];
                                                            if (loggedInAccount == null) {
                                                                Console.WriteLine($"Client with ID {chosenAccount} not found.");
                                                            }

                                                            //Ticket reservation
                                                            List<Ticket> userTickets = loggedInAccount.getTickets();
                                                            int userOption = Convert.ToInt32(Console.ReadLine());
                                                            switch (userOption) {
                                                                case 1:
                                                                    //choosing departure airport
                                                                    Airport departureAirport;
                                                                    Console.WriteLine("Choose a departure Airport:");
                                                                    count = 1;
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
                                                                    Route matchingRoute = routes.Find(route =>
                                                                        route.departureAirport == departureAirport && route.arrivalAirport == arrivalAirport);
                                                                    if (matchingRoute != null) {
                                                                        selectedRoute = matchingRoute;
                                                                    }
                                                                    else {
                                                                        WeAreSorry(departureAirport.Code, arrivalAirport.Code);
                                                                    }

                                                                    //searching for flights
                                                                    Console.WriteLine($"Flights from {departureAirport} to {arrivalAirport}\n=================================================");
                                                                    Flight selectedFLight;
                                                                    List<Flight> foundFlights = flights.FindAll(flight =>
                                                                        flight.route.departureAirport == departureAirport && flight.route.arrivalAirport == arrivalAirport);
                                                                    if (foundFlights != null) {
                                                                        Console.WriteLine($"Avaliable flights from {departureAirport} to {arrivalAirport}:\n=================================================");
                                                                        count = 1;
                                                                        foreach (Flight flight in foundFlights) {
                                                                            Console.WriteLine($"{count}: {flight.departureDate} - {flight.arrivalDate} | {flight.duration}");
                                                                            count++;
                                                                        }
                                                                    }
                                                                    else {
                                                                        WeAreSorry(departureAirport.Code, arrivalAirport.Code);
                                                                    }


                                                                    break;
                                                                case 2:
                                                                    Console.Clear();
                                                                    Console.WriteLine("Your Tickets");
                                                                    Console.WriteLine("1 - go back");
                                                                    Console.WriteLine("============================To delete a ticket input its number============================");
                                                                    count = 2;
                                                                    foreach (Ticket ticket in userTickets) {
                                                                        Console.WriteLine($"{count}: {ticket.ticketData}");
                                                                        count++;
                                                                    }

                                                                    int ticketOption = Convert.ToInt32(Console.ReadLine());
                                                                    switch (ticketOption) {
                                                                        case 1:
                                                                            //go back
                                                                            break;
                                                                        default:
                                                                            Ticket ticketToRemove = userTickets[ticketOption - 1];
                                                                            loggedInAccount.removeTicket(ticketToRemove);
                                                                            break;
                                                                    }
                                                                    break;
                                                                case 3:
                                                                    Console.WriteLine("Are you sure you want to delete your account? You will loose all your tickets!\nWrite \"yes\" to confirm.");
                                                                    string answer = Console.ReadLine();
                                                                    if (answer == "yes" || answer == "YES") system.removeClient(loggedInAccount);
                                                                    break;
                                                            }
                                                            break;

                                                    }
                                            }
                                            break;
                                    }
                            }
                    }
            }
        }
    }
}
                    
