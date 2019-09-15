using System.Collections.Generic;
using TrainQuiz_BackEnd.Data.Entities.Base;

namespace TrainQuiz_BackEnd.Data.Entities
{
    public class Section : Entity<int>
    {
        public string SectionCityA { get; set; }

        public string SectionCityB { get; set; }

        public int SectionDistance { get; set; }

        public ICollection<SectionRoute> SectionRoutes { get; set; }
    }
}