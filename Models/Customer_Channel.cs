using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Customer_Channel
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ChannelId { get; set; }
        public Channel Channel { get; set; }
    }
}
