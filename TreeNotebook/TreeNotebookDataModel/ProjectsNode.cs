//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TreeNotebookDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectsNode
    {
        public int ProjectId { get; set; }
        public int NodeId { get; set; }
        public int ProjectNodeId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual Node Node { get; set; }
        public virtual Project Project { get; set; }
    }
}