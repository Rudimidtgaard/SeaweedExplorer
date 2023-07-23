using System.ComponentModel.DataAnnotations;

namespace SeaweedExplorer.Data.Models
{
    public class Seeweed
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
        public int? SeeweedClassId { get; set; }
        public SeeweedClass? SeeweedClass { get; set; }
        [Timestamp]
        public byte[]? Timestamp { get; set; }
    }
}
