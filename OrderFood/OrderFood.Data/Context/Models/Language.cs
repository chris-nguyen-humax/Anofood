namespace OrderFood.Data.Context.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Language
    {
        public long LanguageId { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
