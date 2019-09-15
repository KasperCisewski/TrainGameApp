using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainQuiz_BackEnd.ApiModel.Response
{
    public class QuestionWithAnsersApiResponseModel
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public List<AnswerApiResponseModel> Answers { get; set; }
        public bool IsLastAnswerWasCorrect { get; set; }
    }

    public class AnswerApiResponseModel
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
    }
}
