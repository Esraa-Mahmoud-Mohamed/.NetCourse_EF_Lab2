using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab2.Models
{
    public class News
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string? Title { get; set; }
        [StringLength(200)]
        public string? Brief { get; set; }
        [StringLength(150)]
        public string? Description { get; set; }
        public DateTime? NewDateTime { get; set; }
        [ForeignKey("catalog")]
        public int cat_id { get; set; }
        public virtual Catalog catalog { get; set; }
        [ForeignKey("author")]
        public int auth_id { get; set; }
        public virtual Author author { get; set; }  


    }
}
