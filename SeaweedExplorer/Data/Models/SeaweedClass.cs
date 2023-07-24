using System.ComponentModel.DataAnnotations;

namespace SeaweedExplorer.Data.Models
{
    public class SeaweedClass
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string? NameCommon { get; set; }
        [Required]
        [StringLength(200)]
        public string? NameLatin { get; set; }

        public List<Seaweed> Seaweeds { get; set; } = new();

    }
}
