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
    
    public partial class pt_scores
    {
        public int FKvisit_id { get; set; }
        public int Fkscore_id { get; set; }
        public string score_Res { get; set; }
    
        public virtual score score { get; set; }
        public virtual vist vist { get; set; }
    }
}
