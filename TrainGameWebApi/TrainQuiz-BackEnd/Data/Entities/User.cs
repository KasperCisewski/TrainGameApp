using TrainQuiz_BackEnd.Data.Entities.Base;

namespace TrainQuiz_BackEnd.Data.Entities
{
    public class User : Entity<int>
    {
        public string NickName { get; set; }  
        //history, ratings etc
    }
}
