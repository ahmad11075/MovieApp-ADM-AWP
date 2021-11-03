using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Customer_Criteria
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int CriteriaId { get; set; }
        public Criteria Criteria { get; set; }

       

    }
}
