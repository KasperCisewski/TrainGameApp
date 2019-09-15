using TrainQuiz_BackEnd.Data.Entities.Base;

namespace TrainQuiz_BackEnd.Data.Entities
{
    public class Point : Entity<int>
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }

        public int NumberOfPoints { get; set; }
    }
}
