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
    
    public partial class ROL
    {
        public int RolID { get; set; }
        public int FilmID { get; set; }
        public string RolNaam { get; set; }
        public int ActeurID { get; set; }
    
        public virtual ACTEUR ACTEUR { get; set; }
        public virtual FILM FILM { get; set; }
    }
}
