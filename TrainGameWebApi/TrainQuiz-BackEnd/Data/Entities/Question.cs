using System.Collections.Generic;
using TrainQuiz_BackEnd.Data.Entities.Base;

namespace TrainQuiz_BackEnd.Data.Entities
{
    public class Question :Entity<int>
    {
        public List<Answer> AnswerList { get; set; }
        public string QuestionValue { get; set; }
        public int SectionId { get; set; }

        public Section Section { get; set; }
    }
}
