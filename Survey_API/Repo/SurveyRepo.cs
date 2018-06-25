using Survey_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Survey_API.BAL;
using Survey_API.EFModel;

namespace Survey_API.Repo
{
    public class SurveyRepo
    {
        public void PostItemResource(ItemResource item)
        {
            using (var context = new SurveyEntities())
            {
                tbl_Questions que = new tbl_Questions
                {
                    itemScript = item.questionScript,
                    createdBy = "Ravi",
                    createdDate = System.DateTime.Now,
                    state= 1,
                    status = "live"
                };
                context.tbl_Questions.Add(que);
                context.SaveChanges();
            }
        }
    }
}