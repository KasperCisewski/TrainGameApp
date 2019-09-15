using Microsoft.AspNetCore.Mvc;
using TrainQuiz_BackEnd.ApiModel.Request;
using TrainQuiz_BackEnd.ApiModel.Response;
using TrainQuiz_BackEnd.Services.Abstraction;

namespace TrainQuiz_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpPost]
        [Route("getTicketInformation")]
        public TicketInformationApiResponseModel GetTicketInformation([FromBody]TicketBasicInformationApiRequestModel ticketBasicInformationApiRequestModel)
        {
            return _ticketService.GetTicketInformation(ticketBasicInformationApiRequestModel);
        }
    }
}