using System;
using System.Collections.Generic;
using System.Linq;
using TrainQuiz_BackEnd.ApiModel.Response;
using TrainQuiz_BackEnd.Extensions;
using TrainQuiz_BackEnd.Repository.Abstraction;
using TrainQuiz_BackEnd.Services.Abstraction;

namespace TrainQuiz_BackEnd.Services.Implementation
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerRepository _answerRepository;

        public QuestionService(
            IQuestionRepository questionRepository,
            IAnswerRepository answerRepository
            )
        {
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
        }

        public bool CheckIfQuestionAnswerIsCorrect(int questionId, int answerId)
        {
            var getCorrectAnswerId = _answerRepository.GetAll().FirstOrDefault(a => a.Question.Id == questionId).Id;

            return answerId == getCorrectAnswerId;
        }

        public QuestionWithAnsersApiResponseModel GetQuestionForPlace(int sectionId)
        {
            var questionsOrderByAscendingiIds = _questionRepository
                .GetAll()
                .Where(q => q.SectionId == sectionId)
                .Select(c => c.Id)
                .OrderBy(c => c)
                .ToList();

            var random = new Random();

            var getQuestionIndex = random.Next(questionsOrderByAscendingiIds.First(), questionsOrderByAscendingiIds.Last() - 1);

            var questionModel = _questionRepository
                .GetAll()
                .Where(q => q.Id == getQuestionIndex)
                  .Select(q => new QuestionWithAnsersApiResponseModel
                  {
                      QuestionId = q.Id,
                      QuestionText = q.QuestionValue,
                      Answers = q.AnswerList.Select(a => new AnswerApiResponseModel
                      {
                          AnswerId = a.Id,
                          AnswerText = a.AnswerValue
                      })
                      .ToList()
                  })
                  .FirstOrDefault();

            questionModel.Answers.Shuffle();

            return questionModel;
        }
    }
}
