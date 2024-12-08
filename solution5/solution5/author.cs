namespace solution5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class author
    {
        [Key]
        public int author_id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(255)]
        public string bio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dob { get; set; }

        [StringLength(10)]
        public string nationality { get; set; }
    }
}
