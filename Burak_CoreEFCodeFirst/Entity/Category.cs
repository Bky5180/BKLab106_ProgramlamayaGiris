using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak_CoreEntityCodeFirst.Entity
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        
        [StringLength(50)]
        public string CategoryName { get; set; }
        
        [StringLength(200)]
        public string Description { get; set; }


        public List<Product> Products { get; set; }
    }
}
