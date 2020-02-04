using System;
namespace OrderFood.Data.Context.Abstract
{
    public interface IAuditTable
    {
        DateTime CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime ModifiedDate { set; get; }
        string ModifiedBy { set; get; }
    }
}
