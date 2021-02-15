using Avengers.Data.Interface;
using Avengers.Model;
using AvengersAPI.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvengersAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly IAvengersDbContext _avengersDbContext;

        public CustomerController(IAvengersDbContext avengersDbContext)
        {
            _avengersDbContext = avengersDbContext;
           
        }
        [HttpPost]
        public IActionResult Index(CustomerRequest request)
        {

            Customer obj = new Customer()
            {
                Age = request.Age,
                Name = request.Name
            };
            Subscription obj1 = new Subscription()
            {
                Name = request.Name
            };
            _avengersDbContext.Customer.Add(obj);
            _avengersDbContext.Subscription.Add(obj1);

            _avengersDbContext.SaveChanges();

            return View();
        }
        [HttpPost]
        [Route("SaveSubscription")]
        public IActionResult SaveSubscription(SubscriptionRequest request)
        {

            Subscription obj = new Subscription()
            {
                Name = request.Name
            };
            _avengersDbContext.Subscription.Add(obj);
            _avengersDbContext.SaveChanges();

            return View();
        }
    }
}
