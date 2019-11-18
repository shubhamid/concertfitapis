using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace concertfitapis.Pages
{
    [Route("api/spotify")]
    public class SpotifyController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public SpotifyArtistsResponse.TopLevel[] Get()
        {
            using (StreamReader r = new StreamReader("spotifyartists.json"))
            {
                string json = r.ReadToEnd();
                SpotifyArtistsResponse.TopLevel[] spotifyResponseTopLevel = SpotifyArtistsResponse.TopLevel.FromJson(json);
                return spotifyResponseTopLevel;
            }
        }
    }
}
