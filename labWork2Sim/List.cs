using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace labWork2Sim
{

    public class SingleLinkedList
    {
        private Node first;
        public SingleLinkedList()
        {
            first = null;
        }
        public void DisplayAll(DataGridView dgv)
        {
            dgv.Rows.Clear();

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("ColNum", "№");
                dgv.Columns.Add("ColPassenger", "Пассажир");
                dgv.Columns.Add("ColFlight", "Рейс");
                dgv.Columns.Add("ColDest", "Назначение");
                dgv.Columns.Add("ColDate", "Дата вылета");

                dgv.Columns["ColNum"].Width = 50;
                dgv.Columns["ColPassenger"].Width = 150;
                dgv.Columns["ColFlight"].Width = 100;
                dgv.Columns["ColDest"].Width = 120;
                dgv.Columns["ColDate"].Width = 120;
            }

            Node current = first;
            int index = 1;

            if (current == null)
            {
                dgv.Rows.Add("", "Список пуст", "", "", "");
                return;
            }

            while (current != null)
            {
                dgv.Rows.Add(
                    index.ToString(),
                    current.PassengerName,
                    current.FlightNumber,
                    current.Destination,
                    current.DepartureDate.ToString("dd.MM.yyyy")
                );
                current = current.Link;
                index++;
            }
        }
        public void DisplayByFlightAndDate(DataGridView dgv, string flightNumber, DateTime date)
        {
            dgv.Rows.Clear();

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("ColPassenger", "Пассажир");
                dgv.Columns.Add("ColFlight", "Рейс");
                dgv.Columns.Add("ColDest", "Назначение");
                dgv.Columns.Add("ColDate", "Дата вылета");
            }

            Node current = first;
            bool found = false;

            while (current != null)
            {
                if (current.FlightNumber == flightNumber &&
                    current.DepartureDate.Date == date.Date)
                {
                    dgv.Rows.Add(
                        current.PassengerName,
                        current.FlightNumber,
                        current.Destination,
                        current.DepartureDate.ToString("dd.MM.yyyy")
                    );
                    found = true;
                }
                current = current.Link;
            }

            if (!found)
            {
                dgv.Rows.Add("Заявки не найдены", "", "", "");
            }
        }
        public bool DisplayByPassenger(DataGridView dgv, string passengerName)
        {
            dgv.Rows.Clear();

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("ColPassenger", "Пассажир");
                dgv.Columns.Add("ColFlight", "Рейс");
                dgv.Columns.Add("ColDest", "Назначение");
                dgv.Columns.Add("ColDate", "Дата вылета");
            }

            Node current = first;

            while (current != null)
            {
                if (current.PassengerName.Equals(passengerName, StringComparison.OrdinalIgnoreCase))
                {
                    dgv.Rows.Add(
                        current.PassengerName,
                        current.FlightNumber,
                        current.Destination,
                        current.DepartureDate.ToString("dd.MM.yyyy")
                    );
                    return true;
                }
                current = current.Link;
            }

            dgv.Rows.Add("Пассажир не найден", "", "", "");
            return false;
        }
        public void AddToBeginning(string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            Node newNode = new Node(destination, flightNumber, passengerName, departureDate);
            newNode.Link = first;
            first = newNode;
        }
        public void AddToEnd(string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            Node newNode = new Node(destination, flightNumber, passengerName, departureDate);
            if (first == null)
            {
                first = newNode;
            }
            else
            {
                Node current = first;
                while (current.Link != null)
                    current = current.Link;
                current.Link = newNode;
            }
        }
        public bool AddAtPosition(int position, string destination, string flightNumber, string passengerName, DateTime departureDate)
        {
            bool flag = false;
            if (position < 1) flag = false;

            if (position == 1)
            {
                AddToBeginning(destination, flightNumber, passengerName, departureDate);
                flag = true;
            }
            Node current = first;
            for (int i = 1; current != null && i < position - 1; i++)
            {
                current = current.Link;
            }
            if (current == null) flag = false;
            else
            {
                Node newNode = new Node(destination, flightNumber, passengerName, departureDate);
                newNode.Link = current.Link;
                current.Link = newNode;
            }
            return flag;
        }
        public void Destroy()
        {
            first = null;
        }

    }



}

