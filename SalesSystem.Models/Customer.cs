namespace SalesSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customer
    {
        // Fields
        private ICollection<Sale> salesForCustomer;

        // Constructor
        public Customer()
        {
            this.salesForCustomer = new HashSet<Sale>();
        }

        // Properties
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(200)]
        [RegularExpression(@"^ ([\w\.\-] +)@([\w\-] +)((\.(\w){2, 3})+)$")]
        public string Email { get; set; }

        [MaxLength(200)]
        public string CreditCardNumber { get; set; }

        public virtual ICollection<Sale> SalesForCustomer
        {
            get
            {
                return this.salesForCustomer;
            }
            set
            {
                this.salesForCustomer = value;
            }
        }
    }
}