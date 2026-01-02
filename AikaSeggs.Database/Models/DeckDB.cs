using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AikaSeggs.Database.Models
{
    public class DeckDB
    {
        [JsonIgnore]
        public virtual AccountDB Account { get; set; } = null!;

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        public int DeckId { get; set; }

        public string CharacterCds { get; set; } = string.Empty; // JSON array stored as string

        public string MemorialCd { get; set; } = string.Empty;

        public string DeckName { get; set; } = string.Empty;
    }
}

