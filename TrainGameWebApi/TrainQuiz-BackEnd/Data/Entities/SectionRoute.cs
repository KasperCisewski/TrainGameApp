namespace TrainQuiz_BackEnd.Data.Entities
{
    public class SectionRoute
    {
        public int SectionId { get; set; }
        public int RouteId { get; set; }
        public Section Section { get; set; }

        public Route Route { get; set; }
    }
}
