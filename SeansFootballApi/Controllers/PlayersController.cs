using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SeansFootballApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        //Field
        private IHttpClientFactory httpClient;

        //Ctor (Constructor)
        public PlayersController(IHttpClientFactory httpClient)
        {
            this.httpClient = httpClient;
        }

        // GET: api/<PlayersController>
        [HttpGet]
        public async Task<HttpResponseMessage> Get()
        {
            // Create a http GET request to our football API endpoint
            // api-football-v1.p.rapidapi.com
            
            HttpRequestMessage playerRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://api-football-v1.p.rapidapi.com/v2/leagues/type/league");
            playerRequestMessage.Headers.Add("X-RapidAPI-Key", "d991d39e8184b5d34b914766562d8187");

            // Adding the API key on the header to the request message
            //test85g57


            //Create an empty HTTP client object
            HttpClient playerHttpClient = httpClient.CreateClient();
            //Asynchronously sends the player request message and get the response.
            var response = await playerHttpClient.SendAsync(playerRequestMessage);
            var resp = await response.Content.ReadAsStringAsync();


            return response;
        }

        // GET api/<PlayersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlayersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PlayersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlayersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
