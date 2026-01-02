using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AikaSeggs.Database.Models
{
    public class QuestDB
    {
        [JsonIgnore]
        public virtual AccountDB Account { get; set; } = null!;

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        public int QuestId { get; set; }

        public int StageId { get; set; }

        public int ClearCount { get; set; }

        public int IsUnlock { get; set; }
    }
}

