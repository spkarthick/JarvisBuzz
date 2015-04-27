using JarvisBuzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JarvisBuzz.Controllers
{
    public class AccountController : ApiController
    {
        JarvisBuzzContext JarvisBuzzDB = new JarvisBuzzContext();
        // GET api/values
        public IEnumerable<LoginModel> Get()
        {
           return JarvisBuzzDB.Login.AsEnumerable();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}