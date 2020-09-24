using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assigment1_5101B_WafaMustafa_N01450753.Controllers
{
    public class GreetingController : ApiController
    {
        // GET: api/Greeting/id
        public string Get(int id)
        {
            return "Greetings to " + id + " people";
        }


        /// <summary>
        /// this method returns one string when recieving a post request
        /// </summary>
        /// <returns>["Hello World!"]</returns>
        // POST: api/Greeting
        public string Post()
        {
            return "Hello World!";
        }


    }
}
