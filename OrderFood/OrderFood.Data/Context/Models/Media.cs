using System;
using System.ComponentModel.DataAnnotations;

namespace OrderFood.Data.Context.Models
{
    public class Media
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        public float FileSize { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        [Required]
        [StringLength(255)]
        public string Owned { get; set; }
        [Required]
        public Guid MasterId { get; set; }
    }
}
