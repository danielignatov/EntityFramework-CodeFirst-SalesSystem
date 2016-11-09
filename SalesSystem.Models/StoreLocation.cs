namespace SalesSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class StoreLocation
    {
        // Fields
        private ICollection<Sale> salesInStore;

        // Constructor
        public StoreLocation()
        {
            this.salesInStore = new HashSet<Sale>();
        }

        // Properties
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string LocationName { get; set; }

        public virtual ICollection<Sale> SalesInStore
        {
            get
            {
                return this.salesInStore;
            }
            set
            {
                this.salesInStore = value;
            }
        }
    }
}