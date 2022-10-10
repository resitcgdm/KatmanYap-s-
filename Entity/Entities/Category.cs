using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(50)]  //Attribute veriyoruz !
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
       
    }
}
