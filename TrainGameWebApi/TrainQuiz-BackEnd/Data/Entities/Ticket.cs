using TrainQuiz_BackEnd.Data.Entities.Base;

namespace TrainQuiz_BackEnd.Data.Entities
{
    public class Ticket : Entity<int>
    {
        public int TicketStartSection { get; set; }

        public int TicketEndSection { get; set; }
        public int TrainId { get; set; }

        public Train Train { get; set; }
        public int UserId { get; set; }
    }
}
