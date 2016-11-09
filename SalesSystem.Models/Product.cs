namespace SalesSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        // Fields
        private ICollection<Sale> salesOfproduct;

        // Constructor
        public Product()
        {
            this.salesOfproduct = new HashSet<Sale>();
        }

        // Properties
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }
        
        [Required]
        public double Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<Sale> SalesOfProduct
        {
            get
            {
                return this.salesOfproduct;
            }
            set
            {
                this.salesOfproduct = value;
            }
        }
    }
}