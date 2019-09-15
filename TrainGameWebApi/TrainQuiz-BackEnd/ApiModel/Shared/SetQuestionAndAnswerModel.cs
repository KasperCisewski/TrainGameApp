namespace TrainQuiz_BackEnd.ApiModel.Shared
{
    public class SetQuestionAndAnswerModel
    {
        public string Token { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public bool IsAnswerCorrect { get; set; }
    }
}
