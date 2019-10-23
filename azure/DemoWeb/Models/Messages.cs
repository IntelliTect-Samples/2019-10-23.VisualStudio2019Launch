using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DemoWeb.Models
{
    public class Messages
    {
        public int ID { get; set; }
        public string Topic { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime MessageDate { get; set; }
        public string MessageText { get; set; }

    }
}
