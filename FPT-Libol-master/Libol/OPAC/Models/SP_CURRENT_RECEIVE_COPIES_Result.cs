//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OPAC.Models
{
    using System;
    
    public partial class SP_CURRENT_RECEIVE_COPIES_Result
    {
        public bool Available { get; set; }
        public bool Binded { get; set; }
        public string Note { get; set; }
        public int ID { get; set; }
        public int LocationID { get; set; }
        public Nullable<int> CopyNumberID { get; set; }
        public System.DateTime ReceivedDate { get; set; }
        public int IssueID { get; set; }
        public string VolumeByLibrary { get; set; }
    }
}
