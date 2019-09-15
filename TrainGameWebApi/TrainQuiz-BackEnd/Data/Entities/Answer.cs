using TrainQuiz_BackEnd.Data.Entities.Base;

namespace TrainQuiz_BackEnd.Data.Entities
{
    public class Answer : Entity<int>
    {
        public string AnswerValue { get; set; }
        public bool IsCorrect { get; set; }
        public Question Question { get; set; }
    }
}
