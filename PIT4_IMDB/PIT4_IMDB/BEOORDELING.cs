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
    
    public partial class BEOORDELING
    {
        public int GebruikerID { get; set; }
        public int FilmID { get; set; }
        public System.DateTime AangemaaktDatum { get; set; }
        public int Beoordeling { get; set; }
        public string Commentaar { get; set; }
    
        public virtual FILM FILM { get; set; }
        public virtual GEBRUIKER GEBRUIKER { get; set; }
    }
}
