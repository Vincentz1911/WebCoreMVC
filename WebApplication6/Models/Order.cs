using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }



    }
}
