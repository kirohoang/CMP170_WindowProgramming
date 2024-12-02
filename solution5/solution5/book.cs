namespace solution5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class book
    {
        [Key]
        public int book_id { get; set; }

        [StringLength(100)]
        public string book_name { get; set; }

        public decimal? price { get; set; }

        public int? quantity_stock { get; set; }

        [StringLength(100)]
        public string image { get; set; }

        public int? publisher_id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? update_date { get; set; }

        public virtual publisher publisher { get; set; }
    }
}
