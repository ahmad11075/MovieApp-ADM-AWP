using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Customer_Hobby
    {

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int HobbyId { get; set; }
        public Hobby Hobby { get; set; }

      
    }
}
