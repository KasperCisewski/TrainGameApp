using TrainQuiz_BackEnd.Data.Entities.Base;

namespace TrainQuiz_BackEnd.Data.Entities
{
    public class Train : Entity<int>
    {
        public string RouteId { get; set; }
        public Route Route { get; set; }
        public string TrainName { get; set; }

        public int QuantityOfCarriages { get; set; }
    }
}
