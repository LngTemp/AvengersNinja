using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvengersAPI.Requests
{
    public class CustomerRequest
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class SubscriptionRequest
    {
        public string Name { get; set; }
    }
}
