using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Customer_Technology
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }


    }
}
