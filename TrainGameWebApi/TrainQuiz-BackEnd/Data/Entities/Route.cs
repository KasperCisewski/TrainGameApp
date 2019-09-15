using System.Collections.Generic;
using TrainQuiz_BackEnd.Data.Entities.Base;

namespace TrainQuiz_BackEnd.Data.Entities
{
    public class Route : Entity<int>
    {
        public int RouteStartSectionId { get; set; }

        public int TrainId { get; set; }
        public Train Train { get; set; }
        public ICollection<SectionRoute> SectionRoutes { get; set; }
    }
}
