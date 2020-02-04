using System.Collections.Generic;
namespace OrderFood.Data.Context.Models
{
    public partial class ContentDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContentDefinition()
        {
            ContentEntries = new HashSet<ContentEntry>();
        }
        public long ContentDefinitionId { get; set; }
        public string Name { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentEntry> ContentEntries { get; set; }
    }
}
