using System.Collections.Generic;
using TrainQuiz_BackEnd.ApiModel.Response;

namespace TrainQuiz_BackEnd.Services.Abstraction
{
    public interface IQuestionService : IService
    {
        bool CheckIfQuestionAnswerIsCorrect(int questionId, int answerId);
        QuestionWithAnsersApiResponseModel GetQuestionForPlace(int stadionId);
    }
}
