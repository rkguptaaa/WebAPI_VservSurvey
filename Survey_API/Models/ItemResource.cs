using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey_API.Models
{
    public class ItemResource
    {
        public string questionScript { get; set; }
        public DateTime date { get; set; }
        public int state { get; set; }
        public string status { get; set; }
        public string createdBy { get; set; }
    }
}