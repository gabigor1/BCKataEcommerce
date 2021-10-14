using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace BCKataEcommerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public List<Product> LoadJson()
        {
            using (StreamReader r = new StreamReader("./items.json"))
            {
                string json = r.ReadToEnd();
                var products = JsonConvert.DeserializeObject<Item>(json);
                List<Product> itemList = products.Items;
                return itemList;
            }
        }

        public IActionResult LoadJsonByName(string name)
        {
            using (StreamReader r = new StreamReader("./items.json"))
            {
                string json = r.ReadToEnd();
                var products = JsonConvert.DeserializeObject<Item>(json);
                List<Product> itemList = products.Items;

                var item = itemList.FirstOrDefault(t => t.name == name);
                if (item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return LoadJson();
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            return LoadJsonByName(name);
        }
    }

}