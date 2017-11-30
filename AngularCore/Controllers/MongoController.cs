using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularCore.Controllers
{
    public class MongoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<MongoRow> GetFixedMongoRows()
        {
            MongoRow r = new MongoRow();

            List<MongoRow> list = new List<MongoRow>();

            r.ID = 1;
            r.Value = "{ \"Data\": \"Sample Data\"}";

            list.Add(r);

            r = new MongoRow();

            r.ID = 2;
            r.Value = "{ \"Data\": \"Sample Data 2\"}";

            list.Add(r);

            r = new MongoRow();

            r.ID = 3;
            r.Value = "{ \"Data\": \"Sample Data 3\"}";

            list.Add(r);

            return list;
        }

        public class MongoRow
        {
            public int ID { get; set; }
            public string Value { get; set; }
        }
    }
}