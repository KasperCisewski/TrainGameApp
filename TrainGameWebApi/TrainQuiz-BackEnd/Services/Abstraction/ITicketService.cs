using TrainQuiz_BackEnd.ApiModel.Request;
using TrainQuiz_BackEnd.ApiModel.Response;

namespace TrainQuiz_BackEnd.Services.Abstraction
{
    public interface ITicketService : IService
    {
        TicketInformationApiResponseModel GetTicketInformation(TicketBasicInformationApiRequestModel ticketBasicInformationApiRequestModel);
    }
}
