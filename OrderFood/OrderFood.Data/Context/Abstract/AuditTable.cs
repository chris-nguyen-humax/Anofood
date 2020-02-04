using System;

namespace OrderFood.Data.Context.Abstract
{
    public class AuditTable : IAuditTable
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
