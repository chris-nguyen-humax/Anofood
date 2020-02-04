namespace OrderFood.Data.Context.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class TypeOfCuisine
    {
        [Required]
        public long TypeCuisineId { get; set; }
        public string NameEs { get; set; }
        public string NameEn { get; set; }
    }
}
