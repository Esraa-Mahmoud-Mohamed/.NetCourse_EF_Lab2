using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab2.Models
{
    public class Catalog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual List<News> news { get; set; } = new List<News>();

    }
}
