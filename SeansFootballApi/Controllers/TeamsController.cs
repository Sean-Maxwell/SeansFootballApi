using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SeansFootballApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TeamsController : ControllerBase
    {
        //Field
        private IHttpClientFactory httpClient;

        public TeamsController(IHttpClientFactory httpClient)
        {
            this.httpClient = httpClient;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<string> Get()
        {
            // newsapi.org API KEY - 9c5119fef0294cab86be895047a58f00
            //Insert API into ""
            HttpRequestMessage newsRequestMessage = new HttpRequestMessage(HttpMethod.Get,
                "https://my-json-server.typicode.com/Sean-Maxwell/json-data/teams");

            //Creating an empty http client
            HttpClient playerHttpClient = httpClient.CreateClient();

            var response = await playerHttpClient.SendAsync(newsRequestMessage);
            var resp = await response.Content.ReadAsStringAsync();

            return resp;
        }


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
