using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHR.Models
{
    public class Position
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal? MaxSalary { get; set; }
        public decimal? MinSalary { get; set; }
    }
}
