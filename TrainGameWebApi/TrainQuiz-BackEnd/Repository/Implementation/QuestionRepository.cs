using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainQuiz_BackEnd.Data.Context;
using TrainQuiz_BackEnd.Data.Entities;
using TrainQuiz_BackEnd.Repository.Abstraction;

namespace TrainQuiz_BackEnd.Repository.Implementation
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(TrainsQuizContext context) : base(context)
        {
        }
    }
}
