//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sliding_menue
{
    using System;
    using System.Collections.Generic;
    
    public partial class vist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vist()
        {
            this.patient_lab = new HashSet<patient_lab>();
            this.patient_radiology = new HashSet<patient_radiology>();
            this.pt_scores = new HashSet<pt_scores>();
            this.hoos = new HashSet<hoo>();
        }
    
        public int visit_id { get; set; }
        public int FKpt_id { get; set; }
        public string StaffName { get; set; }
        public System.DateTime visitDate { get; set; }
        public string complaint { get; set; }
        public string provisional_diag { get; set; }
        public string fina_diag { get; set; }
        public Nullable<System.DateTime> followUpDate { get; set; }
        public string lab_req { get; set; }
        public string radio_req { get; set; }
        public string lifeStyle { get; set; }
        public string notes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<patient_lab> patient_lab { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<patient_radiology> patient_radiology { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pt_scores> pt_scores { get; set; }
        public virtual examination examination { get; set; }
        public virtual family_history family_history { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoo> hoos { get; set; }
        public virtual management_plan management_plan { get; set; }
        public virtual past_med_history past_med_history { get; set; }
        public virtual social_history social_history { get; set; }
        public virtual socialWomanHistoryy socialWomanHistoryy { get; set; }
        public virtual patient patient { get; set; }
    }
}
