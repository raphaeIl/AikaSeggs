using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AikaSeggs.Database.Models
{
    public class CharacterDB
    {
        [JsonIgnore]
        public virtual AccountDB Account { get; set; } = null!;

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserCd { get; set; } = string.Empty;

        public string CharacterCd { get; set; } = string.Empty;

        public int CharacterId { get; set; }

        public string RegisterDate { get; set; } = string.Empty;
    }
}

