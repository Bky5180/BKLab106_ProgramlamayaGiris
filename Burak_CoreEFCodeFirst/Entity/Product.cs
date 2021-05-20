using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak_CoreEntityCodeFirst.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        
        [StringLength(50)]
        public string ProductName { get; set; }

        public decimal? Price { get; set; }

        public int? UnitsInStock { get; set; }

        public bool IsActive { get; set; }

        // Navigation Property
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"{ProductName} - {Price} - {UnitsInStock} - {IsActive}";
        }
    }

    // !!! CALISMIYOR !!!
    // https://www.learnentityframeworkcore.com/configuration/fluent-api/hasdiscriminator-method
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasDiscriminator<bool>("IsActive").HasValue(true);
            builder.Ignore(p => p.IsActive);
        }
    }
}
