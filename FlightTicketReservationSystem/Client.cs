using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FlightTicketReservationSystem {
    [Serializable]
    internal abstract class Client {
        public int clientId;
        protected string phoneNumber;
        protected string email;
        protected List<Ticket> tickets = new List<Ticket>();

        public Client(int clientId, string phoneNumber, string email, List<Ticket> tickets)
        {
            this.clientId = clientId;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public void addTicket(Ticket ticket)
        {
            tickets.Add(ticket);

        }
        public void removeTicket(Ticket ticket)
        {
            tickets.Remove(ticket);
        }
        public List<Ticket> getTickets()
        {
            return tickets;
        }

        public abstract string clientData { get; }
    }
    [Serializable]
    class Person : Client {
        public string firstName;
        private string secondName;
        private string lastName;
        private int age;

        public Person(int clientId, string phoneNumber, string email, string firstName, string secondName, string lastName, int age, List<Ticket> tickets) : base(clientId, phoneNumber, email, tickets) {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string clientData { get { return $"[{clientId}] {firstName} {secondName}"; } }
    }

    [Serializable]
    class Company : Client
    {
        public string name;
        private string krs;

        public Company(int clientId, string phoneNumber, string email, string name, string krs, List<Ticket> tickets) : base(clientId, phoneNumber, email, tickets)
        {
            this.name = name;
            this.krs = krs;
        }

        public override string clientData { get { return $"[{clientId}] {name} - {krs}"; } }
    }
}
