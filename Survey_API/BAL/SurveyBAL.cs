using Survey_API.Models;
using Survey_API.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey_API.BAL
{
    public class SurveyBAL
    {
        public void PostItemResource(ItemResource Item)
        {
            SurveyRepo sr = new SurveyRepo();
            sr.PostItemResource(Item);
        }

    }
}