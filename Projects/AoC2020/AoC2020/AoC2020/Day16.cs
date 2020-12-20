using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day16
    {
        public static List<string> rawList = new List<string>();
        public static List<Ticket> tickets = new List<Ticket>();
        public static List<Ticket> invalidTickets = new List<Ticket>();
        public static List<string> requirements = new List<string>();
        public static List<List<int>> requirementsInt = new List<List<int>>();
        public static List<List<int>> fieldGroups = new List<List<int>>();
        public static List<int> fieldIndexes = new List<int>();
        public static List<int> positionsToIgnore = new List<int>();
        public static List<int> fieldsToIgnore = new List<int>();
        public static Ticket myTicket = new Ticket(
            new List<int>{ 61, 151, 137, 191, 59, 163, 89, 83, 71, 179, 67, 149, 197, 167, 181, 173, 53, 139, 193, 157 });

        public static void Execute()
        {
            rawList = FileParser.ParseFileString(16);
            requirements = FileParser.ParseFileString(160);
            tickets = GenerateTickets();
            PopulateRequirements();

            long answer = PartTwo();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static int PartOne()
        {
            int invalid = 0;

            foreach (Ticket ticket in tickets)
            {
                foreach (int field in ticket.Fields)
                {
                    if (!IsValidField(field))
                    {
                        invalid += field;
                        invalidTickets.Add(ticket);
                        break;
                    }
                }
            }

            foreach (Ticket invalidTicket in invalidTickets) tickets.Remove(invalidTicket);

            return invalid;
        }

        public static long PartTwo()
        {
            int invalid = PartOne();
            GroupFields();

            while (positionsToIgnore.Count < 20)
            {
                AssociateGroups(positionsToIgnore, fieldsToIgnore);
            }

            return (long)myTicket.Fields[positionsToIgnore[fieldsToIgnore.IndexOf(0)]] 
                * (long)myTicket.Fields[positionsToIgnore[fieldsToIgnore.IndexOf(1)]] 
                * (long)myTicket.Fields[positionsToIgnore[fieldsToIgnore.IndexOf(2)]] 
                * (long)myTicket.Fields[positionsToIgnore[fieldsToIgnore.IndexOf(3)]]
                * (long)myTicket.Fields[positionsToIgnore[fieldsToIgnore.IndexOf(4)]] 
                * (long)myTicket.Fields[positionsToIgnore[fieldsToIgnore.IndexOf(5)]];
        }

        public static void GroupFields()
        {
            for (int i = 0; i < tickets[0].Fields.Count; i++)
            {
                fieldGroups.Add(new List<int>());
                foreach (Ticket ticket in tickets) fieldGroups[i].Add(ticket.Fields[i]);
            }
        }

        public static void AssociateGroups(List<int> posToIgnore, List<int> fldToIgnore)
        {
            int posIndex = 0;
            foreach (var position in fieldGroups)
            {
                if (posToIgnore.Contains(posIndex))
                {
                    posIndex++;
                    continue;
                }
                
                List<int> validFields = new List<int>();

                for (int i = 0; i<requirementsInt.Count; i++)
                {
                    if (fldToIgnore.Contains(i)) continue;
                    bool isValid = true;

                    foreach (int value in position)
                    {
                        if (value<requirementsInt[i][0] 
                            || (value > requirementsInt[i][1] && value<requirementsInt[i][2])
                            || value> requirementsInt[i][3])
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        validFields.Add(i);
                    }
                }

                if (validFields.Count == 1)
                {
                    positionsToIgnore.Add(posIndex);
                    fieldsToIgnore.Add(validFields[0]);
                    break;
                }

                posIndex++;
            }
        }

        public static List<Ticket> GenerateTickets()
        {
            List<Ticket> ticketsList = new List<Ticket>();

            foreach (string data in rawList)
            {
                Ticket curTicket = new Ticket(new List<int>());
                var values = data.Split(',').ToList();
                foreach (string val in values) curTicket.Fields.Add(int.Parse(val));

                ticketsList.Add(curTicket);
            }

            return ticketsList;
        }

        public static bool IsValidField(int field)
        {
            foreach (var reqs in requirementsInt)
            {
                if (field >= reqs[0] && field <= reqs[1] 
                    || field >= reqs[2] && field <= reqs[3])
                        return true;
            }

            return false;
        }

        public static void PopulateRequirements()
        {
            foreach (string req in requirements)
            {
                int cropPlace = req.LastIndexOf(' ');
                string numbers = req.Substring(cropPlace);
                var reqs = numbers.Split('-').ToList();
                var reqsInt = new List<int>();
                foreach (var r in reqs)reqsInt.Add(int.Parse(r));

                requirementsInt.Add(reqsInt);
            }
        }
    }

    public struct Ticket
    {
        public List<int> Fields { get; set; }

        public Ticket(List<int> fields)
        {
            Fields = fields;
        }
    }
}
