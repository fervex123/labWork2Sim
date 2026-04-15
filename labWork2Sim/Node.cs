using System;
using System.Collections.Generic;
using System.Text;

namespace labWork2Sim
{
    public class Node
    {
        private string destination;
        private string flightNumber;
        private string passengerName;
        private DateTime departureDate;
        private Node link;

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        public string PassengerName
        {
            get { return passengerName; }
            set { passengerName = value; }
        }

        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }

        public Node Link
        {
            get { return link; }
            set { link = value; }
        }


        public Node()
        {
            link = null;
        }

        public Node(string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            this.destination = destination;
            this.flightNumber = flightNumber;
            this.passengerName = passengerName;
            this.departureDate = departureDate;
            this.link = null;
        }

        public Node(string destination, string flightNumber, string passengerName, DateTime departureDate, Node link)
        {
            this.destination = destination;
            this.flightNumber = flightNumber;
            this.passengerName = passengerName;
            this.departureDate = departureDate;
            this.link = link;
        }

    }
}
