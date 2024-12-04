using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab2.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Brief { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateOnly JoinDate { get; set; }
        public virtual List<News> news { get; set; } = new List<News>();


    }
}
