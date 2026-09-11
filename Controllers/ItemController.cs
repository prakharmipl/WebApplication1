using Microsoft.AspNetCore.Mvc;
using WebApplication1.DBContext;
using WebApplication1.Model.Ecommerce;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ApplicationContext _db;

        public ItemController(ApplicationContext db) { 
            _db = db;
        }





        // GET: api/<ItemController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ItemController>/5
        [HttpGet("{id?}")]
        public List<ItemModel> Get(int? id)
        {
            if (id > 0) return _db.Items.Where(x=>x.Id==id).ToList();

            return _db.Items.ToList();
        }

        // POST api/<ItemController>
        [HttpPost]
        public int Add([FromBody] ItemModel value)
        {
            _db.Items.Add(value);
            _db.SaveChanges();

            return value.Id?? 0;
        }

        // PUT api/<ItemController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ItemModel value)
        {


            if (id < 0) return NotFound("Please provide valid Id");

            ItemModel item = _db.Items.FirstOrDefault(x => x.Id == id);

            if (item == null) return NotFound("No item found for this Id");

            item.Name = value.Name;
            item.Quantity = value.Quantity;

            _db.SaveChanges();

            return Ok(item);

        }

        // DELETE api/<ItemController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <=0)
            return NotFound();

            var item = _db.Items.FirstOrDefault(x => x.Id == id);

            if (item == null) return NotFound();

            _db.Items.Remove(item);

            _db.SaveChanges();

            return Ok("Success");

        }
    }
}
