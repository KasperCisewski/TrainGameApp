using TrainQuiz_BackEnd.Data.Context;
using TrainQuiz_BackEnd.Data.Entities;
using TrainQuiz_BackEnd.Repository.Abstraction;

namespace TrainQuiz_BackEnd.Repository.Implementation
{
    public class AnswerRepository : Repository<Answer>, IAnswerRepository
    {
        public AnswerRepository(TrainsQuizContext context) : base(context)
        {
        }
    }
}
