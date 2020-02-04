namespace OrderFood.Data.Context.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public partial class Tax
    {
        [Required]
        public long Id { set; get; }
        public string Value { set; get; }
        public string Name { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
    }
}
