using System.ComponentModel.DataAnnotations;

namespace SeaweedExplorer.Data.Models
{
    public class Seaweed
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string? NameCommon { get; set; }
        [Required]
        [StringLength(200)]
        public string? NameLatin { get; set; }
        public bool Native { get; set; }
        [Required]
        public int? SeaweedClassId { get; set; }
        public SeaweedClass? SeaweedClass { get; set; }
        [Timestamp]
        public byte[]? Timestamp { get; set; }
    }
}
