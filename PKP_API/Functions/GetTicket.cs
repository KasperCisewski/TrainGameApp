
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;

namespace PKP_API
{
    public static class GetTicket
    {
        [FunctionName("GetTicket")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "ticket")] HttpRequest req,
            ILogger log)
        {
            dynamic result = new JObject();

            result.RequestestTicketId = req.Query["id"].ToString();
            result.Tickets = JToken.FromObject(DbHelper.GetTickets());
        
            return new JsonResult(result);
        }
    }
}
