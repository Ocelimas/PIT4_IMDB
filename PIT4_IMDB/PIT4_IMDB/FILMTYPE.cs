//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIT4_IMDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class FILMTYPE
    {
        public int FilmID { get; set; }
        public int TypeID { get; set; }
    
        public virtual FILM FILM { get; set; }
        public virtual TYPE TYPE { get; set; }
    }
}
