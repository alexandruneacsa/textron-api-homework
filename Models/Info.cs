using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TextronApp.Models
{
    public class Info
    {
        public int Id { get; set; }
        public string GPSlocation { get; set; }
        public int Acceleration { get; set; }
        public int Speed { get; set; }
        public DateTime Date { get; set; }
    }
}
