
using PKP_API;

public class Ticket
    {
        public int Id { get; set; }

        public string TicketId { get; set; }

        public Route Route { get; set; }

        public Train Train { get; set; }
    }
