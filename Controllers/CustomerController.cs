using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DBContext;
using WebApplication1.Model.Ecommerce;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationContext _db;

        public CustomerController(ApplicationContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<CustomerModel> GetCustomers(int id)
        {
    
            var query = _db.Customers.AsQueryable();

            if (id > 0) query= query.Where(x => x.Id == id);


            return query.ToList();
        }

        [HttpGet]
         public List<CustomerModel> GetCustomersbyName(string? name, string? starts, string? ends)
        {
            var customers = _db.Customers.AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                customers=customers.Where(x => x.CustomerName.Contains(name));

            }


            if (!string.IsNullOrEmpty(starts))
            {
                customers= customers.Where(x => x.CustomerName.StartsWith(starts));

            }

            if (!string.IsNullOrEmpty(ends))
            {
                customers= customers.Where(x => x.CustomerName.EndsWith(ends));

            }


            return customers.ToList();


        }

        public int Add(CustomerModel customer)
        {


            _db.Customers.Add(customer);
            _db.SaveChanges();

            return customer.Id;
            
        }

    }
}
