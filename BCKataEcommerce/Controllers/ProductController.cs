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

        public Product LoadJsonByName(string name)
        {
            var item = LoadJson().FirstOrDefault(t => t.Name == name);
            return item;
        }

        public List<Product> LoadJsonByTags(string tags)
        {
            var filterTags = tags.Split("," , StringSplitOptions.TrimEntries);
            var items = LoadJson().Where(t => !filterTags.Except(t.Tags).Any()).ToList();

            return items;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(LoadJson());
        }

        [Route("{name}")]
        [HttpGet]
        public IActionResult GetByName(string name)
        {
            return Ok(LoadJsonByName(name));
        }

        [HttpGet("{tags}")]
        public IActionResult GetByTags(string tags)
        {
            return Ok(LoadJsonByTags(tags));
        }
    }

}