using CleanArchitecture.Domain.CommonEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string BrandName { get; set; }
        public string Branddescription { get; set; }
        public List<Product> Products { get; set; }   
    }
}
