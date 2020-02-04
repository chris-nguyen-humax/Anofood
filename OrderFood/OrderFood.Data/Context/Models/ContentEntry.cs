using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Data.Context.Models
{
    public class ContentEntry
    {
        public long Id { get; set; }
        public long ContentDefinitionId { get; set; }
        public string Value { get; set; }
        public long LanguageId { get; set; }

        public virtual ContentDefinition ContentDefinition { get; set; }
        public virtual Language Language { get; set; }
    }
}
