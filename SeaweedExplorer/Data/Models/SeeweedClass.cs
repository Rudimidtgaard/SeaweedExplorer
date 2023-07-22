using System.ComponentModel.DataAnnotations;

namespace SeaweedExplorer.Data.Models
{
    public class SeeweedClass
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string? NameCommon { get; set; }
        [Required]
        [StringLength(200)]
        public string? NameLatin { get; set; }

        public List<Seeweed> Seeweeds { get; set; } = new();

    }
}
