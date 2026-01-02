using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AikaSeggs.Database.Models
{
    public class ItemDB
    {
        [JsonIgnore]
        public virtual AccountDB Account { get; set; } = null!;

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        public int ItemId { get; set; }

        public int Count { get; set; }
    }
}

