using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdoMvcRam.Models
{
    public class CustomerList
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
    }
}
