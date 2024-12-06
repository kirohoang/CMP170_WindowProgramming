namespace solution5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            orders = new HashSet<order>();
        }

        [Key]
        public int customer_id { get; set; }

        [StringLength(50)]
        public string customer_name { get; set; }

        [StringLength(20)]
        public string username { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        public int? numberphone { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dob { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
    }
}
