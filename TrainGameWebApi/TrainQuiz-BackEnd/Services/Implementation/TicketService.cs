using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TrainQuiz_BackEnd.ApiModel.Request;
using TrainQuiz_BackEnd.ApiModel.Response;
using TrainQuiz_BackEnd.Services.Abstraction;

namespace TrainQuiz_BackEnd.Services.Implementation
{
    public class TicketService : ITicketService
    {
        private static string _url = "https://pkpapi.azurewebsites.net/api";
        public TicketInformationApiResponseModel GetTicketInformation(TicketBasicInformationApiRequestModel ticketBasicInformationApiRequestModel)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(_url + "/ticket?id=1")
            };

            var response = client.GetAsync(client.BaseAddress).GetAwaiter().GetResult().Content.ReadAsStringAsync().Result;

            var ticket = JsonConvert.DeserializeObject<dynamic>(response);

            var ticketInformationModel = new TicketInformationApiResponseModel
            {
                StartingStation = ticket.Tickets[0].Route.StacjaPoczatkowa.Nazwa,
                EndingStation = ticket.Tickets[0].Route.StacjaKoncowa.Nazwa,
                //IntermediateStations = ticket.Route.StacjePosrednie.ToList(),
                Distance = ticket.Tickets[0].Route.Dlugosc,
                TrainName = ticket.Tickets[0].Train.NazwaPociagu,
                QuantityOfCarriages = ticket.Tickets[0].Train.Wagony
            };

            return ticketInformationModel;
        }
    }
}
