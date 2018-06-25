using Survey_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Survey_API.BAL;

namespace Survey_API.Controllers
{
    public class SurveyController : Controller
    {
        [System.Web.Http.HttpPost]
        public HttpResponseMessage PostItem([FromBody] ItemResource candidate)
        {
            SurveyBAL s = new SurveyBAL();
            s.PostItemResource(candidate);
            return new HttpResponseMessage();
        }
    }
}
