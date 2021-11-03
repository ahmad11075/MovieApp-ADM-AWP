using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Technology
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //Relationships

        public List<Customer_Technology> Customers_Technologies { get; set; }
    }
}
