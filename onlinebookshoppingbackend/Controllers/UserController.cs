using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace onlinebookshoppingbackend.Controllers
{
    public class UserController : ApiController
    {
        //signup
        public HttpResponseMessage Post([FromBody] UserTb user)
        {
            try
            {
                using (onlinebookshoppingEntities e1 = new onlinebookshoppingEntities())
                {
                    e1.UserTbs.Add(user);
                    e1.SaveChanges();

                    var msg = Request.CreateResponse(HttpStatusCode.Created, user);
                    return msg;
                }
            }

            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ex);
            }

            }
            
    }
}
