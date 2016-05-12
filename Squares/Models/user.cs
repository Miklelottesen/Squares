//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Squares.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.creation = new HashSet<creation>();
            this.order = new HashSet<order>();
            this.squareSet = new HashSet<squareSet>();
            this.comment = new HashSet<comment>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public int roleID { get; set; }
        public string desc { get; set; }
        public string street { get; set; }
        public Nullable<int> zip { get; set; }
        public string city { get; set; }
        public string socialFB { get; set; }
        public string socialIG { get; set; }
        public string socialTW { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<creation> creation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<squareSet> squareSet { get; set; }
        public virtual userRole userRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comment { get; set; }
    }
}
