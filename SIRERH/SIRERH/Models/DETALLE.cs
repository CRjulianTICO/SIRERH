//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIRERH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETALLE
    {
        public int ID_DETALLE { get; set; }
        public string EXPERIENCIA { get; set; }
        public string GRADO_ACADEMICO { get; set; }
        public Nullable<int> ID_TECNOLOGIA { get; set; }
    
        public virtual TECNOLOGIA TECNOLOGIA { get; set; }
    }
}
