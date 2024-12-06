namespace solution5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class order
    {
        [Key]
        public int order_id { get; set; }

        public bool? ispayment { get; set; }

        public bool? isship { get; set; }

        [Column(TypeName = "date")]
        public DateTime? order_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? delivery_date { get; set; }

        public int? customer_id { get; set; }

        public virtual customer customer { get; set; }

        public virtual order_details order_details { get; set; }
    }
}
