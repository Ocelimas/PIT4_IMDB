//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBModel.bu
{
    using System;
    using System.Collections.Generic;
    
    public partial class REGISSEUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REGISSEUR()
        {
            this.FILMREGISSEURs = new HashSet<FILMREGISSEUR>();
        }
    
        public int RegiID { get; set; }
        public string RegiNaam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILMREGISSEUR> FILMREGISSEURs { get; set; }
    }
}
