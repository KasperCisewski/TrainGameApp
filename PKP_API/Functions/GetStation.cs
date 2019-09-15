using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PKP_API
{
    public static class GetStation
    {
        [FunctionName("GetStation")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "station")] HttpRequest req,
            ILogger log)
        {
            string token = req.Query["token"];
            string ticketid = req.Query["ticketid"];
            string offset = req.Query["offset"];

            log.LogInformation($"Ticket ID: {ticketid}, Offset :{offset}");

            return new JsonResult(new JValue(1));
        }
    }
}
