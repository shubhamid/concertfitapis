using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace concertfitapis.Pages
{
    [Route("api/ticketmaster")]
    public class TicketmasterController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public TicketMasterResponse.TopLevel Get()
        {
            using (StreamReader r = new StreamReader("ticketmaster.json"))
            {
                string json = r.ReadToEnd();
                TicketMasterResponse.TopLevel ticketMasterResponseTopLevel = TicketMasterResponse.TopLevel.FromJson(json);
                return ticketMasterResponseTopLevel;
            }
        }
    }
}
