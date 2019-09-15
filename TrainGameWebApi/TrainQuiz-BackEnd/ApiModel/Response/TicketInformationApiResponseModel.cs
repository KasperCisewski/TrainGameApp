using System.Collections.Generic;

namespace TrainQuiz_BackEnd.ApiModel.Response
{
    public class TicketInformationApiResponseModel
    {
        public string StartingStation { get; set; }
        public string EndingStation { get; set; }
        public int Distance { get; set; }
        public string TrainName { get; set; }
        public int QuantityOfCarriages { get; set; }
    }
}
