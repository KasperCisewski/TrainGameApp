using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainQuiz_BackEnd.ApiModel.Response;
using TrainQuiz_BackEnd.Services.Abstraction;

namespace TrainQuiz_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        [Route("getQuestionWithAnswers")]
        public QuestionWithAnsersApiResponseModel GetQuestionWithAnsers(string token)
        {
            return _questionService.GetQuestionForPlace(1);
        }
    }
}
