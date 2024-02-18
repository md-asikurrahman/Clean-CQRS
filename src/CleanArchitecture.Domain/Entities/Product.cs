using CleanArchitecture.Domain.CommonEntity;


namespace CleanArchitecture.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double? BuyingPrice { get; set; }
        public DateTime ExpiringDate { get; set; }
        public DateTime ManufacturegDate { get; set;}
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
