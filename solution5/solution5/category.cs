namespace solution5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class category
    {
        [Key]
        public int category_id { get; set; }

        [StringLength(50)]
        public string category_name { get; set; }

        [StringLength(255)]
        public string description { get; set; }
    }
}
