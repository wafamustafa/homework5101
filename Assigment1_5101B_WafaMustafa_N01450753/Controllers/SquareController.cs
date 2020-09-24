using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assigment1_5101B_WafaMustafa_N01450753.Controllers
{
    public class SquareController : ApiController
    {
        // GET api/Square/{id}
        public IEnumerable<int> Get(int id)
        {
            return new int [] { (id*id) };
        }


    }
}